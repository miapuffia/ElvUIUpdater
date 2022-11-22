using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ElvUIUpdater.VersionCache {
	public class Cache {
		private string[] responses = new string[4];
		private int index;

		public Cache() {
			responses[0] = ReadResource("cache1.txt");
			responses[1] = ReadResource("cache2.txt");
			responses[2] = ReadResource("cache3.txt");
			responses[3] = ReadResource("cache4.txt");

			index = 0;
		}

		public string NextResponse() {
			return responses[index++];
		}

		private string ReadResource(string name) {
			// Determine path
			var assembly = Assembly.GetExecutingAssembly();
			string resourcePath = name;
			// Format: "{Namespace}.{Folder}.{filename}.{Extension}"
			resourcePath = assembly.GetManifestResourceNames().Single(str => str.EndsWith(name));

			using(Stream stream = assembly.GetManifestResourceStream(resourcePath)) {
				using(StreamReader reader = new StreamReader(stream)) {
					return reader.ReadToEnd();
				}
			}
		}
	}
}
