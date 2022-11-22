using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElvUIUpdater.Configuration {
    /// <summary>
    /// Exposes configuration properties that will be automatically saved to and retrieved from the registry
    /// </summary>
    class Config {
        private RegistryEditor Registry { get; }
        public Config() {
            Registry = new RegistryEditor(@"SOFTWARE\ElvUIUpdater"); //open the registry in this location

            if (bool.TryParse((string) Registry.GetKeyValue(nameof(CheckForUpdateOnLaunch)), out bool checkForUpdateOnLaunch))
				_checkForUpdateOnLaunch = checkForUpdateOnLaunch;

            if (bool.TryParse((string) Registry.GetKeyValue(nameof(InstallOnLaunch)), out bool installOnLaunch))
				_installOnLaunch = installOnLaunch;

			if(bool.TryParse((string) Registry.GetKeyValue(nameof(CheckForNewElvUIUpdaterOnLaunch)), out bool checkForNewElvUIUpdaterOnLaunch))
				_checkForNewElvUIUpdaterOnLaunch = checkForNewElvUIUpdaterOnLaunch;
			else
				_checkForNewElvUIUpdaterOnLaunch = true;

			_customGameLocation = "" + (string) Registry.GetKeyValue(nameof(CustomGameLocation));
		}

        public bool CheckForUpdateOnLaunch
        {
            get => _checkForUpdateOnLaunch;
            set
            {
				_checkForUpdateOnLaunch = value;
                Registry.SetKeyValue(nameof(CheckForUpdateOnLaunch), value);
            }
        }
        private bool _checkForUpdateOnLaunch;

        public bool InstallOnLaunch
        {
            get => _installOnLaunch;
            set
            {
				_installOnLaunch = value;
                Registry.SetKeyValue(nameof(InstallOnLaunch), value);
            }
        }
        private bool _installOnLaunch;

		public bool CheckForNewElvUIUpdaterOnLaunch {
			get => _checkForNewElvUIUpdaterOnLaunch;
			set {
				_checkForNewElvUIUpdaterOnLaunch = value;
				Registry.SetKeyValue(nameof(CheckForNewElvUIUpdaterOnLaunch), value);
			}
		}
		private bool _checkForNewElvUIUpdaterOnLaunch;

		public string CustomGameLocation {
			get => _customGameLocation;
			set {
				_customGameLocation = value;
				Registry.SetKeyValue(nameof(CustomGameLocation), value);
			}
		}
		private string _customGameLocation;
	}
}