using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using Microsoft.Win32;
namespace Filernet_LITE
{

    public partial class Form1 : Form
    {
        int icon = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private static bool IsDarkModeEnabled()
        {
            using var key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize");
            var value = key?.GetValue("AppsUseLightTheme");
            if (value is int i)
            {
                return i == 0;
            }
            else if (value is string s)
            {
                return s == "0";
            }
            else
            {
                return false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(IsDarkModeEnabled().ToString());
        }

        private void madeWitthCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I made FilerNET with .NET obviously, but it didn't have a proper installer, so FilerLITE is a C# winforms app without the need of the full framework.");
        }

        private void licenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("cmd", $"/c start {"https://github.com/Sweeistaken/FilerLITE/blob/master/LICENSE.txt"}") { CreateNoWindow = true });
        }

        private void filerLITEBySweeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If you want to visit my site, click \"Developer's site\" in the about menu.");
        }

        private void developersWebsiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("cmd", $"/c start {"https://swee.pythonanywhere.com/"}") { CreateNoWindow = true });
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void otherDriveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void rootDriveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripTextBox1.Text = "C:\\";
        }

        private void userFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripTextBox1.Text = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            MessageBox.Show("You can click the folder icon to go to the user folder now.", "Tip");
        }

        private void toolStripSplitButton2_ButtonClick(object sender, EventArgs e)
        {
            toolStripTextBox1.Text = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var Mes = MessageBox.Show("Are you sure you want to delete this file?","Delete file",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
        }
    }
}