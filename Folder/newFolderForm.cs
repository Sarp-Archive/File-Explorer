using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Folder
{
    public partial class newFolderForm : Form
    {
        exploreForm parent;
        public newFolderForm(exploreForm _p)
        {
            parent = _p;
            InitializeComponent();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(Path.Combine(parent.location, inputBox.Text));
            parent.exploreDir();
            this.Close();
        }

        private void inputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                createBtn.PerformClick();
            }
        }
    }
}
