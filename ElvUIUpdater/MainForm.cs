using ElvUIUpdater.Schema;
using ElvUIUpdater.VersionCache;
using ElvUIUpdater.Configuration;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Windows.Forms;
using System.ComponentModel;
using Semver;

namespace ElvUIUpdater {
	public partial class MainForm : Form {
		private string applicationVersion = "v1.0.0";
		private const string userAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/42.0.2311.135 Safari/537.36 Edge/12.246";
		private const int estimatedAPICalls = 3;
		private bool useLiveAPI = true;

		private string gameLocation = "";
		private string elvuiVersion = "";
		private List<GitHubTag> gitHubTags;
		Config Config { get; } = new Config();

		public MainForm() {
			InitializeComponent();

			Start();
		}

		public async void Start() {
			checkForUpdatesOnProgramStartToolStripMenuItem.Checked = Config.CheckForUpdateOnLaunch;
			installLatestVersionOnProgramStartToolStripMenuItem.Checked = Config.InstallOnLaunch;
			checkForNewElvUIUpdaterOnProgramStartToolStripMenuItem.Checked = Config.CheckForNewElvUIUpdaterOnLaunch;

			if(Config.CustomGameLocation != "") {
				gameLocation = Config.CustomGameLocation;

				SetGameLocationText(true);
			} else {
				FindGameLocation();

				SetGameLocationText(false);
			}

			GetElvUIVersion();

			await GetRateLimit();

			if(Config.CheckForUpdateOnLaunch)
				await GetVersions();

			if(Config.InstallOnLaunch)
				await InstallVersion();

			if(Config.CheckForNewElvUIUpdaterOnLaunch)
				await CheckForApplicationUpdate();
		}

		private void SetGameLocationText(bool wasManuallySet) {
			if(gameLocation != "") {
				gameLocationTextBox.Text = gameLocation;

				gameLocationLabel.Text = wasManuallySet ? "WoW addon directory set" : "WoW addon directory found";
				gameLocationLabel.ForeColor = Color.ForestGreen;
			}
		}

		private void FindGameLocation() {
			if(FindGameLocation2()) {
				AddLogItem("Found WoW addon directory: " + gameLocation);
			} else {
				AddLogItem("WoW addon directory not found");
			}
		}

		private bool FindGameLocation2() {
			AddLogItem("Looking for WoW addon directory");

			if(Directory.Exists(@"C:\Program Files (x86)\World of Warcraft\_retail_\Interface\AddOns")) {
				gameLocation = @"C:\Program Files (x86)\World of Warcraft\_retail_\Interface\AddOns";

				return true;
			}

			if(Directory.Exists(@"C:\Program Files\World of Warcraft\_retail_\Interface\AddOns")) {
				gameLocation = @"C:\Program Files\World of Warcraft\_retail_\Interface\AddOns";

				return true;
			}

			foreach(DriveInfo driveInfo in DriveInfo.GetDrives()) {
				if(Directory.Exists(driveInfo.Name + @"World of Warcraft\_retail_\Interface\AddOns")) {
					gameLocation = driveInfo.Name + @"World of Warcraft\_retail_\Interface\AddOns";

					return true;
				}
			}

			return false;
		}

		private bool GetElvUIVersion() {
			if(gameLocation != "") {
				AddLogItem("Looking for currently installed ElvUI version");

				if(File.Exists(gameLocation + @"\ElvUI\ElvUI_Mainline.toc")) {
					string elvuiTOC = File.ReadAllText(gameLocation + @"\ElvUI\ElvUI_Mainline.toc");

					int startIndex = elvuiTOC.IndexOf("Version: ") + "Version: ".Length;
					int endIndex = elvuiTOC.IndexOf('\n', startIndex);

					elvuiVersion = elvuiTOC.Substring(startIndex, endIndex - startIndex);

					elvuiVersionLabel.Text = "Installed ElvUI version: v" + elvuiVersion;

					AddLogItem("Currently installed ElvUI version: v" + elvuiVersion);

					return true;
				}

				elvuiVersionLabel.Text = "ElvUI not found in addon directory";

				AddLogItem("Currently installed ElvUI version not found");
			}

			return false;
		}

		private async Task GetRateLimit() {
			AddLogItem("Getting number of GitHub API calls used/remaining");

			using(HttpClient client = new HttpClient()) {

				client.DefaultRequestHeaders.Add("User-Agent", userAgent);

				string jsonRateLimit = await client.GetStringAsync("https://api.github.com/rate_limit");

				GitHubRateLimit? rateLimit = JsonConvert.DeserializeObject<GitHubRateLimit>(jsonRateLimit);

				if(rateLimit == null) {
					AddLogItem("Error: Failed to parse GitHub API rate limit response");
					return;
				}

				updatesLeftLabel.Text = (rateLimit.rate.remaining / estimatedAPICalls) + "";
				updatesLeftTooltip.SetToolTip(label1, rateLimit.rate.remaining + " left of " + rateLimit.rate.limit);
				updatesLeftTooltip.SetToolTip(updatesLeftLabel, rateLimit.rate.remaining + " left of " + rateLimit.rate.limit);
				updatesResetLabel.Text = DateTimeOffset.FromUnixTimeSeconds(rateLimit.rate.reset).DateTime.ToString();

				AddLogItem("This IP has " + rateLimit.rate.remaining + " of " + rateLimit.rate.limit + " GitHub API calls left");
			}
		}

		private async Task GetVersions() {
			AddLogItem("Getting ElvUI versions from GitHub API");

			Cache cache = new Cache();

			using(HttpClient client = new HttpClient()) {

				client.DefaultRequestHeaders.Add("User-Agent", userAgent);

				gitHubTags = new List<GitHubTag>();

				string pageJsonTags;
				GitHubTag[]? pageGitHubTags;
				int page = 1;

				do {
					try {
						if(useLiveAPI)
							pageJsonTags = await client.GetStringAsync("https://api.github.com/repos/tukui-org/ElvUI/tags?page=" + page + "&per_page=100");
						else
							pageJsonTags = cache.NextResponse();

						pageGitHubTags = JsonConvert.DeserializeObject<GitHubTag[]>(pageJsonTags);

						if(pageGitHubTags == null) {
							AddLogItem("Error: Failed to parse GitHub API ElvUI tags response");
							return;
						}

						gitHubTags.AddRange(pageGitHubTags);

						page++;
					} catch(HttpRequestException hre) {
						AddLogItem("Error: " + hre.Message);

						break;
					}
				} while(pageGitHubTags.Length == 100);
			}

			foreach(GitHubTag gitHubTag in gitHubTags) {
				versionsListView.Items.Add(gitHubTag.name);
			}

			AddLogItem(gitHubTags.Count + " ElvUI versions returned");
		}

		private async Task InstallVersion() {
			AddLogItem("Looking for currently installed ElvUI folders");

			bool foundElvUIFolders = false;

			if(Directory.Exists(gameLocation + @"\ElvUI")) {
				AddLogItem("Found \"ElvUI\" folder");

				foundElvUIFolders = true;

				Directory.Delete(gameLocation + @"\ElvUI", true);

				AddLogItem("Deleted \"ElvUI\" folder");
			}

			if(Directory.Exists(gameLocation + @"\ElvUI_Libraries")) {
				AddLogItem("Found \"ElvUI_Libraries\" folder");

				foundElvUIFolders = true;

				Directory.Delete(gameLocation + @"\ElvUI_Libraries", true);

				AddLogItem("Deleted \"ElvUI_Libraries\" folder");
			}

			if(Directory.Exists(gameLocation + @"\ElvUI_Options")) {
				AddLogItem("Found \"ElvUI_Options\" folder");

				foundElvUIFolders = true;

				Directory.Delete(gameLocation + @"\ElvUI_Options", true);

				AddLogItem("Deleted \"ElvUI_Options\" folder");
			}

			if(Directory.Exists(gameLocation + @"\ElvUI_OptionsUI")) {
				AddLogItem("Found \"ElvUI_OptionsUI\" folder");

				foundElvUIFolders = true;

				Directory.Delete(gameLocation + @"\ElvUI_OptionsUI", true);

				AddLogItem("Deleted \"ElvUI_OptionsUI\" folder");
			}

			if(Directory.Exists(gameLocation + @"\ElvUI_Config")) {
				AddLogItem("Found \"ElvUI_Config\" folder");

				foundElvUIFolders = true;

				Directory.Delete(gameLocation + @"\ElvUI_Config", true);

				AddLogItem("Deleted \"ElvUI_Config\" folder");
			}

			if(!foundElvUIFolders) {
				AddLogItem("No currently installed ElvUI folders found");
			}

			GitHubTag selectedGitHubTag = gitHubTags[versionsListView.SelectedIndices[0]];

			string fileName = selectedGitHubTag.name;
			/*int fileNameCounter = 0;

			while(File.Exists(Path.GetTempPath() + fileName)) {
				fileNameCounter++;

				//fileName has already been appended to
				if(fileNameCounter > 1) {
					fileName = fileName[..^3];
				}

				fileName += "(" + fileNameCounter + ")";
			}*/

			AddLogItem("Downloading ElvUI (" + selectedGitHubTag.name + ") to temp folder (" + Path.GetTempPath() + ")");

			using(HttpClient client = new HttpClient()) {
				client.DefaultRequestHeaders.Add("User-Agent", userAgent);

				using(Stream stream = await client.GetStreamAsync(selectedGitHubTag.zipball_url)) {
					using(var fileStream = new FileStream(Path.GetTempPath() + fileName + ".zip", FileMode.Create, FileAccess.Write)) {
						stream.CopyTo(fileStream);
					}
				}
			}

			AddLogItem("Downloaded to " + Path.GetTempPath() + fileName + ".zip");
			AddLogItem("Extracting to " + Path.GetTempPath() + fileName);

			if(Directory.Exists(Path.GetTempPath() + fileName)) {
				Directory.Delete(Path.GetTempPath() + fileName, true);
			}

			ZipFile.ExtractToDirectory(Path.GetTempPath() + fileName + ".zip", Path.GetTempPath() + fileName);

			AddLogItem("Extracted to " + Path.GetTempPath() + fileName);
			AddLogItem("Moving contents to addon folder");

			string innerFolder = Directory.GetDirectories(Path.GetTempPath() + fileName)[0];

			foreach(string elvuiFolder in Directory.GetDirectories(innerFolder)) {
				try {
					Move(elvuiFolder, gameLocation + @"\" + Path.GetFileName(elvuiFolder));
				} catch(Exception e) {
					AddLogItem("Error: " + e.Message);
					return;
				}

				AddLogItem("Moved " + elvuiFolder + " to " + gameLocation + @"\" + Path.GetFileName(elvuiFolder));
			}

			AddLogItem("Cleaning up installation files");

			if(File.Exists(Path.GetTempPath() + fileName + ".zip")) {
				File.Delete(Path.GetTempPath() + fileName + ".zip");
			}

			if(Directory.Exists(Path.GetTempPath() + fileName)) {
				Directory.Delete(Path.GetTempPath() + fileName, true);
			}

			AddLogItem("Done installing ElvUI (" + selectedGitHubTag.name + ")");

			GetElvUIVersion();

			await GetRateLimit();
		}

		private async Task CheckForApplicationUpdate() {
			AddLogItem("Getting latest ElvUI Updater version");

			using(HttpClient client = new HttpClient()) {
				client.DefaultRequestHeaders.Add("User-Agent", userAgent);

				try {
					string jsonRelease = await client.GetStringAsync("https://api.github.com/repos/miapuffia/ElvUIUpdater/releases/latest");

					GitHubRelease? release = JsonConvert.DeserializeObject<GitHubRelease>(jsonRelease);

					if(release == null) {
						AddLogItem("Error: Failed to parse GitHub API ElvUI Updater latest release response");
						return;
					}

					SemVersion releaseVersion = SemVersion.Parse(release.tag_name, SemVersionStyles.Any);
					SemVersion currentVersion = SemVersion.Parse(applicationVersion, SemVersionStyles.Any);

					if(releaseVersion.CompareSortOrderTo(currentVersion) == 1) {
						AddLogItem("Newer ElvUI Updater version found");

						Debug.WriteLine(release.zipball_url);

						NewVersionForm newVersionForm = new NewVersionForm("v" + currentVersion, "v" + releaseVersion, release.zipball_url);
						newVersionForm.StartPosition = FormStartPosition.CenterParent;
						newVersionForm.ShowDialog(this);
					} else {
						AddLogItem("ElvUI Updater is up to date");
					}
				} catch(HttpRequestException hre) {
					AddLogItem("Error: " + hre.Message);
				}
			}
		}

		public static void Move(string source, string target) {
			if(!Directory.Exists(source)) {
				throw new DirectoryNotFoundException("Source directory couldn't be found.");
			}

			if(Directory.Exists(target)) {
				throw new IOException("Target directory already exists.");
			}

			DirectoryInfo sourceInfo = Directory.CreateDirectory(source);
			DirectoryInfo targetInfo = Directory.CreateDirectory(target);

			if(sourceInfo.FullName == targetInfo.FullName) {
				throw new IOException("Source and target directories are the same.");
			}

			Stack<DirectoryInfo> sourceDirectories = new Stack<DirectoryInfo>();
			sourceDirectories.Push(sourceInfo);

			Stack<DirectoryInfo> targetDirectories = new Stack<DirectoryInfo>();
			targetDirectories.Push(targetInfo);

			while(sourceDirectories.Count > 0) {
				DirectoryInfo sourceDirectory = sourceDirectories.Pop();
				DirectoryInfo targetDirectory = targetDirectories.Pop();

				foreach(FileInfo file in sourceDirectory.GetFiles()) {
					file.CopyTo(Path.Combine(targetDirectory.FullName, file.Name), overwrite: true);
				}

				foreach(DirectoryInfo subDirectory in sourceDirectory.GetDirectories()) {
					sourceDirectories.Push(subDirectory);
					targetDirectories.Push(targetDirectory.CreateSubdirectory(subDirectory.Name));
				}
			}

			sourceInfo.Delete(true);
		}

		private void gameLocationButton_Click(object sender, EventArgs e) {
			DialogResult dialogResult = gameFolderBrowserDialog.ShowDialog();

			if(dialogResult == DialogResult.OK) {
				gameLocation = gameFolderBrowserDialog.SelectedPath;

				gameLocationTextBox.Text = gameLocation;

				gameLocationLabel.Text = "Game directory found";
				gameLocationLabel.ForeColor = Color.ForestGreen;

				AddLogItem("WoW addon directory manually set");

				SetGameLocationText(true);

				Config.CustomGameLocation = gameLocation;

				GetElvUIVersion();
			}
		}

		private void versionsListView_SelectedIndexChanged(object sender, EventArgs e) {
			installButton.Enabled = true;
		}

		private async void checkForUpdatesButton_Click(object sender, EventArgs e) {
			await GetVersions();
		}

		private async void installButton_Click(object sender, EventArgs e) {
			await InstallVersion();
		}

		private void logListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e) {
			if(e.IsSelected) {
				e.Item.Selected = false;
				e.Item.Focused = false;
			}
		}

		private void checkForUpdatesOnProgramStartToolStripMenuItem_CheckedChanged(object sender, EventArgs e) {
			bool checkForUpdatesChecked = ((ToolStripMenuItem) sender).Checked;

			Config.CheckForUpdateOnLaunch = checkForUpdatesChecked;

			installLatestVersionOnProgramStartToolStripMenuItem.Enabled = checkForUpdatesChecked;
			installLatestVersionOnProgramStartToolStripMenuItem.Checked = installLatestVersionOnProgramStartToolStripMenuItem.Checked && checkForUpdatesChecked;
		}

		private void installLatestVersionOnProgramStartToolStripMenuItem_CheckedChanged(object sender, EventArgs e) {
			Config.InstallOnLaunch = ((ToolStripMenuItem) sender).Checked;
		}

		private void checkForNewElvUIUpdaterOnProgramStartToolStripMenuItem_CheckedChanged(object sender, EventArgs e) {
			Config.CheckForNewElvUIUpdaterOnLaunch = ((ToolStripMenuItem) sender).Checked;
		}

		private async void checkForNewElvUIUpdaterVersionToolStripMenuItem_Click(object sender, EventArgs e) {
			await CheckForApplicationUpdate();
		}

		private void AddLogItem(string logText) {
			logListView.Items.Add(logText);
			logListView.Items[^1].EnsureVisible();
			logListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
		}
	}
}