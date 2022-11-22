using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElvUIUpdater.Schema {
	public class GitHubRelease {
		public string url;
		public string assets_url;
		public string upload_url;
		public string html_url;
		public int id;
		public GitHubReleaseAuthor author;
		public string node_id;
		public string tag_name;
		public string target_commitish;
		public string name;
		public bool draft;
		public bool prerelease;
		public string created_at;
		public string published_at;
		public GitHubReleaseAsset[] assets;
		public string tarball_url;
		public string zipball_url;
		public string body;
	}

	public class GitHubReleaseAuthor {
		public string login;
		public int id;
		public string node_id;
		public string avatar_url;
		public string gravatar_id;
		public string url;
		public string html_url;
		public string followers_url;
		public string following_url;
		public string gists_url;
		public string starred_url;
		public string subscriptions_url;
		public string organizations_url;
		public string repos_url;
		public string events_url;
		public string received_events_url;
		public string type;
		public bool site_admin;
	}

	public class GitHubReleaseAsset {
		public string url;
		public string browser_download_url;
		public int id;
		public string node_id;
		public string name;
		public string label;
		public string state;
		public string content_type;
		public int size;
		public int download_count;
		public string created_at;
		public string updated_at;
		public GitHubReleaseAssetUploader uploader;
	}

	public class GitHubReleaseAssetUploader {
		public string name;
		public string email;
		public string login;
		public int id;
		public string node_id;
		public string avatar_url;
		public string gravatar_id;
		public string url;
		public string html_url;
		public string followers_url;
		public string following_url;
		public string gists_url;
		public string starred_url;
		public string subscriptions_url;
		public string organizations_url;
		public string repos_url;
		public string events_url;
		public string received_events_url;
		public string type;
		public bool site_admin;
		public string starred_at;
	}
}
