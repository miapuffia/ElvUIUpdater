using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElvUIUpdater.Schema {
	public class GitHubRateLimit {
		public GitHubResources resources;
		public GitHubRate rate;
	}

	public class GitHubResources {
		public GitHubRate core;
		public GitHubRate graphql;
		public GitHubRate integration_manifest;
		public GitHubRate search;
	}

	public class GitHubRate {
		public int limit;
		public int remaining;
		public long reset;
		public int used;
		public string resource;
	}
}
