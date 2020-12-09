using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace DoxTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://textnow.com");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("https://whatismyipaddress.com/ip-lookup");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("https://raidforums.com/Thread-Leak-DOX-via-ISP-DOB-SSN-Address");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.whitepages.com");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.spydialer.com");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.whois.com/whois/");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.spokeo.com");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.infosniper.net/");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            Browser BuiltInBrowser = new Browser();
            BuiltInBrowser.ShowDialog();
        }
    }
}
