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

namespace p2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int mode = 0;

        void SetProcessStartInfo(Process p, int mode, string filename = "", string newFileName = "", string orderType = "a")
        {
            p.StartInfo.FileName = @".\p1.exe";
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;

            if (mode == 1)
                p.StartInfo.Arguments = $"-g {filename}";
            else if (mode == 2)
                p.StartInfo.Arguments = $"-s {filename} {newFileName} {orderType}";
            else if (mode == 3)
                p.StartInfo.Arguments = $"-v {filename}";
            else if (mode == 4)
                p.StartInfo.Arguments = $"-d {filename}";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            mode = 0;
            statusLabel.Text = "";
            filenameBox.Text = "";
            newFilenameBox.Text = "";
            label1.Hide();
            filenameBox.Hide();
            label2.Hide();
            newFilenameBox.Hide();
            buttonConfirm.Hide();
            buttonCancel.Hide();
            statusLabel.Hide();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            statusLabel.Show();
            string filename = filenameBox.Text;
            
            using (Process myProcess = new Process())
            {
                SetProcessStartInfo(myProcess, mode, filename);
                try
                {
                    myProcess.Start();

                    myProcess.StandardInput.WriteLine("y");
                    myProcess.StandardInput.Close();
                    string outputData = myProcess.StandardOutput.ReadLine();
                    int index = outputData.IndexOf("[Y/n]: ") + 7;
                    outputData = outputData.Remove(0, index);
                    statusLabel.Text = outputData;
                }
                catch (Win32Exception) { statusLabel.Text = "Error: p1.exe is not in the current folder"; }
            }
        }

        private void Common_MouseClick(object sender, EventArgs e)
        {
            label1.Show();
            filenameBox.Show();
            buttonConfirm.Show();
            buttonCancel.Show();
            label2.Hide();
            newFilenameBox.Hide();
            statusLabel.Hide();
        }

        private void buttonCreate_Click(object sender, EventArgs e) {
            mode = 1;
            label1.Text = "New file name";
        }

        private void buttonDelete_Click(object sender, EventArgs e) {
            mode = 4;
            label1.Text = "File to delete";
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            label1.Show();
            filenameBox.Show();
            buttonConfirm.Show();
            buttonCancel.Show();
            label2.Show();
            newFilenameBox.Show();
            statusLabel.Hide();
            mode = 2;
            label1.Text = "File name";
        }

        private void buttonView_Click(object sender, EventArgs e) {
            mode = 3;
            label1.Text = "File to view";
        }
        
    }
}
