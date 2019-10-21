using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form4 fm4 = new Form4();
            fm4.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 5;
            }
            else
            {
                progressBar1.Value = 0;
            }
        }


    }
}
    