using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElvUIUpdater {
	public partial class NewVersionForm : Form {
		string latestVersionURL;

		public NewVersionForm(string currentVersion, string latestVersion, string latestVersionURL) {
			InitializeComponent();

			currentVersionLabel.Text = currentVersion;
			latestVersionLabel.Text = latestVersion;
			this.latestVersionURL = latestVersionURL;
		}

		private void latestVersionLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			Process.Start(new ProcessStartInfo(latestVersionURL) { UseShellExecute = true });
		}
	}
}
