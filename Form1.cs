using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clicker
{
    public partial class Form1 : Form
    {
        int clicks = 0;
        int up = 0;
        int dops = 20;
        int boost = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clicks = clicks + boost;
            label2.Text = "Clicks: " + clicks;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (clicks/dops >= 1)
            {
                clicks = clicks - dops;
                up++;
                dops += 100;
                label3.Text = "Upgrade: " + up;
                boost*=2;
                label4.Text = "Cost of upgrade: " + dops; 
            }
            else
            {
                MessageBox.Show("No money","Error");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
     
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
