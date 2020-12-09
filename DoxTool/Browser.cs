using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoxTool
{
    public partial class Browser : Form
    {
        public Browser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string Search = textBox1.Text.Trim();
            webBrowser1.Navigate(Search);
        }

        private void Browser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string Search1 = textBox1.Text.Trim();
                webBrowser1.Navigate(Search1);
            }    
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 MainForm = new Form1();
            MainForm.ShowDialog();
        }
    }
}
