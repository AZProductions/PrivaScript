using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrivaScript
{

    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            //here paste notepad
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
         
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
              
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Navigate();
        }

        private void Navigate()
        {
            toolStripStatusLabel1.Text = "Navigation has started";
            webBrowser1.Navigate(textBox1.Text);
            textBox1.Enabled = false;
            button1.Enabled = false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Return))
            {
                //Navigate() 
                button1_Click(null, null);
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            button1.Enabled = true;
            textBox1.Enabled = true;
            toolStripStatusLabel1.Text = "Navigation Complete";


        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            if (e.CurrentProgress > 0 && e.MaximumProgress > 0)
            {
                toolStripProgressBar1.ProgressBar.Value = (int)(e.CurrentProgress * 100 / e.MaximumProgress); 
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If you are not familiar with this program close it (this is at your own risk!)");
            System.Diagnostics.Process.Start("CMD.exe");

        }

        private void startPowerShellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If you are not familiar with this program close it (this is at your own risk!)");
            System.Diagnostics.Process.Start("PowerShell.exe");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void startCMDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If you are not familiar with this program close it (this is at your own risk!)");
            System.Diagnostics.Process.Start("CMD.exe");
        }

        private void startPowerShellToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If you are not familiar with this program close it (this is at your own risk!)");
            System.Diagnostics.Process.Start("PowerShell.exe");
        }

        private void clearHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string strCmdText;
            //For Testing
            strCmdText = "/K RunDll32.exe InetCpl.cpl,ClearMyTracksByProcess 1";

            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
            System.Diagnostics.Process.Start("CMD.exe", "/c taskkill /IM CMD.exe");
        }

        private void tESTToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void clearCouToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string strCmdText2;
            //For Testing
            strCmdText2 = "/K RunDll32.exe InetCpl.cpl,ClearMyTracksByProcess 2";

            System.Diagnostics.Process.Start("CMD.exe", strCmdText2);
            System.Diagnostics.Process.Start("CMD.exe", "/c taskkill /IM CMD.exe");


        }

        private void testToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            string strCmdText3;
            //For Testing
            strCmdText3 = "/K RunDll32.exe InetCpl.cpl,ClearMyTracksByProcess 8";

            System.Diagnostics.Process.Start("CMD.exe", strCmdText3);
            System.Diagnostics.Process.Start("CMD.exe", "/c taskkill /IM CMD.exe");
        }

        private void propetiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }

        private void startWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("word.exe");
        }


        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("PrivaScript Ver. 1.2.5  AZ Productions ---> WWW.AZPRODUCTIONS.ML", "About - PrivaScript - Search - AZ  Productions");
        }
    }
}
