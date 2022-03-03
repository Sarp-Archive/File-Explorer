using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Folder
{
    public partial class exploreForm : Form
    {
        #region Rounded Rectangle
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        #endregion

        public string location = Environment.GetEnvironmentVariable("USERPROFILE");
        private int lastSel;

        public exploreForm()
        {
            InitializeComponent();
            locationBox.Region = Region.FromHrgn(CreateRoundRectRgn(3, 6, locationBox.Size.Width - 6, locationBox.Size.Height - 3, 7, 7));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            exploreDir();
        }

        public void exploreDir()
        {
            try
            {
                Directory.GetDirectories(location);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Access denied.");
                if (Directory.GetParent(location) != null)
                {
                    location = Directory.GetParent(location).FullName;
                }
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                if (Directory.GetParent(location) != null)
                {
                    location = Directory.GetParent(location).FullName;
                }
            }

            filesList.Items.Clear();

            if (Path.GetPathRoot(location) == location) 
            {
                upButton.Enabled = false;
                //filesList.Items.Add("\ue110 Go upper directory");
            }
            else
            {
                upButton.Enabled = true;
            }

            var dirs = Directory.GetDirectories(location);           
            foreach (var dir in dirs)
            {
                if (Directory.Exists(dir))
                {
                    var name = "\ue8b7 " + Path.GetFileName(dir);
                    filesList.Items.Add(name);
                }
            }

            var files = Directory.GetFiles(location);
            foreach (var file in files)
            {
                if (File.Exists(file))
                {
                    var name = "\uf56e " + Path.GetFileName(file);
                    filesList.Items.Add(name);
                }
            }

            Text = location + " - Explorer";
            locationTxt.Text = location;
        }

        private void filesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filesList.SelectedItem != null)
            {
                if (lastSel != filesList.SelectedIndex)
                {
                    lastSel = filesList.SelectedIndex;
                }
                else
                {
                    lastSel = -1;
                    var txt = filesList.SelectedItem.ToString();
                    var type = txt.First(); //Substring(0,1);
                    var path = txt.Substring(2, txt.Length - 2);
                    var name = Path.GetFileName(path);

                    switch (type)
                    {
                        case '\ue8b7': // Folder
                            location = Path.Combine(location, name);
                            exploreDir();
                            break;

                        case '\uf56e': // File
                            var filepath = Path.Combine(location, path);
                            try
                            {
                                Process.Start(filepath);
                            }
                            catch (Win32Exception)
                            {
                                MessageBox.Show("File is protected or type is not supported.", "Unable to open file.");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("An error occured. Please report this to developer. Error: \n" + ex.ToString());
                            }
                            filesList.SelectedItem = null;
                            break;

                        default:
                            break;
                    }
                }
            }            
        }

        private void locationTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var input = locationTxt.Text;
                if (Directory.Exists(input))
                {
                    location = input;
                    exploreDir();
                }
                else
                {
                    var list = new List<string>();
                    foreach (var item in filesList.Items)
                    {
                        if (item.ToString().Contains(input))
                        {
                            list.Add(item.ToString());
                        }
                    }
                    if (list.Count > 0)
                    {
                        filesList.Items.Clear();
                        foreach (var item in list)
                        {
                            filesList.Items.Add(item);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No results found.");
                        locationTxt.Text = location;
                    }
                }
            }
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            if (Directory.GetParent(location) != null)
            {
                location = Directory.GetParent(location).FullName;
                exploreDir();
            }
            else
            {
                MessageBox.Show("Current directory is drive root.");
            }
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            exploreDir();
        }

        private void openTerminalHereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.WorkingDirectory = location;
            psi.FileName = "cmd.exe";
            Process.Start(psi);
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exploreDir();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filesList.SelectedItem != null)
            {
                lastSel = -1;
                var txt = filesList.SelectedItem.ToString();
                var type = txt.First(); //Substring(0,1);
                var path = txt.Substring(2, txt.Length - 2);
                var name = Path.GetFileName(path);
                var filepath = location = Path.Combine(location, name);

                switch (type)
                {
                    case '\ue8b7': // Folder
                        Directory.Delete(filepath, true);
                        exploreDir();
                        filesList.SelectedItem = null;
                        break;

                    case '\uf56e': // File
                        File.Delete(filepath);
                        exploreDir();
                        filesList.SelectedItem = null;
                        break;

                    default:
                        break;
                }
            }
        }

        private void folderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new newFolderForm(this).ShowDialog();
            //exploreDir();
        }

        private void openInWindowsExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.WorkingDirectory = location;
            psi.FileName = "explorer.exe";
            psi.Arguments = location;
            Process.Start(psi);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filesList.SelectedItem != null)
            {
                lastSel = -1;
                var txt = filesList.SelectedItem.ToString();
                var type = txt.First(); //Substring(0,1);
                var path = txt.Substring(2, txt.Length - 2);
                var name = Path.GetFileName(path);

                switch (type)
                {
                    case '\ue8b7': // Folder
                        location = Path.Combine(location, name);
                        exploreDir();
                        break;

                    case '\uf56e': // File
                        var filepath = Path.Combine(location, path);
                        try
                        {
                            Process.Start(filepath);
                        }
                        catch (Win32Exception)
                        {
                            MessageBox.Show("File is protected or type is not supported.", "Unable to open file.");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occured. Error: \n" + ex.ToString());
                        }
                        filesList.SelectedItem = null;
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
