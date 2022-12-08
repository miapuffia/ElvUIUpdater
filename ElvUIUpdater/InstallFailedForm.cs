using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElvUIUpdater {
	public partial class InstallFailedForm : Form {
		public InstallFailedForm() {
			InitializeComponent();
		}

		private void okButton_Click(object sender, EventArgs e) {
			this.Close();
		}
	}
}
