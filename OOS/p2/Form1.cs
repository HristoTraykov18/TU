using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
        DirectoryInfo currentDir = new DirectoryInfo(@".\.");

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
            orderTypeLabel.Hide();
            orderTypeBox.Hide();
            buttonConfirm.Hide();
            buttonCancel.Hide();
            statusLabel.Hide();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            statusLabel.Show();
            string filename = filenameBox.Text;
            string newFilename = newFilenameBox.Text;
            string orderType = orderTypeBox.SelectedIndex < 1 ? "a" : "d";
            
            using (Process myProcess = new Process())
            {
                SetProcessStartInfo(myProcess, mode, filename, newFilename, orderType);
                try
                {
                    myProcess.Start();
                    if (mode == 1)
                        myProcess.StandardInput.WriteLine("y");
                    else
                        myProcess.StandardInput.WriteLine("n");
                    myProcess.StandardInput.Close();
                    string outputData = myProcess.StandardOutput.ReadLine();
                    int index = outputData.IndexOf("[Y/n]: ") + 7;
                    if (index != 0 && outputData.Contains("[Y/n]: "))
                        outputData = outputData.Remove(0, index);
                    else if (outputData.Contains("information"))
                        outputData = "No such file";
                    if (mode == 3)
                        outputData += "\n" + myProcess.StandardOutput.ReadToEnd();
                    statusLabel.Text = outputData;
                }
                catch (Win32Exception) { statusLabel.Text = "Error: p1.exe is not in the current folder"; }
                catch (NullReferenceException) { statusLabel.Text = "Error: d1.dll is not in the current folder"; }
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            label1.Show();
            filenameBox.Show();
            buttonConfirm.Show();
            buttonCancel.Show();
            label2.Hide();
            newFilenameBox.Hide();
            orderTypeLabel.Hide();
            orderTypeBox.Hide();
            statusLabel.Hide();
            mode = 1;
            label1.Text = "New file name";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            label1.Show();
            filenameBox.Show();
            buttonConfirm.Show();
            buttonCancel.Show();
            label2.Hide();
            newFilenameBox.Hide();
            orderTypeLabel.Hide();
            orderTypeBox.Hide();
            statusLabel.Hide();
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
            orderTypeLabel.Show();
            orderTypeBox.Show();
            statusLabel.Hide();
            mode = 2;
            label1.Text = "File name";
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            label1.Show();
            filenameBox.Show();
            buttonConfirm.Show();
            buttonCancel.Show();
            label2.Hide();
            newFilenameBox.Hide();
            orderTypeLabel.Hide();
            orderTypeBox.Hide();
            statusLabel.Hide();
            mode = 3;
            label1.Text = "File to view";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Tab)
            {
                int i = 0;
                TextBox tb = new TextBox();
                bool textBoxFocused = false;
                if (filenameBox.Focused)
                {
                    tb = filenameBox;
                    textBoxFocused = true;
                }
                else if (newFilenameBox.Focused)
                {
                    tb = newFilenameBox;
                    textBoxFocused = true;
                }
                tb.TabStop = true;
                if (textBoxFocused)
                {
                    FileInfo[] Files = currentDir.GetFiles("*.txt").Where(f => f.Name.Contains(tb.Text)).ToArray();
                    tb.Text = Files[i].ToString();
                    i++;
                }
                else
                    tb.TabStop = true;
            }
        }

        private void SetProcessStartInfo(Process p, int mode, string filename, string newFileName, string orderType)
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
            else
                statusLabel.Text = "Invalid input";
        }
    }
}
