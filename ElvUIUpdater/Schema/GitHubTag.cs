using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElvUIUpdater.Schema {
	public class GitHubTag {
		public string name;
		public string zipball_url;
		public string tarball_url;
		public GitHubTagChecksum commit;
		public string node_id;
	}

	public class GitHubTagChecksum {
		public string sha;
		public string url;
	}
}
