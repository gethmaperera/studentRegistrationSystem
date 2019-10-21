using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 fm5 = new Form5();
            fm5.MdiParent = this;
            fm5.Show();            

        }

        private void courseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 fm6 = new Form6();
            fm6.MdiParent = this;
            fm6.Show();

        }

        private void batchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 fm7 = new Form7();
            fm7.MdiParent = this;
            fm7.Show();

        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 fm8 = new Form8();
            fm8.MdiParent = this;
            fm8.Show();

        }

        private void batchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form10 fm10 = new Form10();
            fm10.MdiParent = this;
            fm10.Show();


        }

        private void courseToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Form9 fm9 = new Form9();
            fm9.MdiParent = this;
            fm9.Show();

        }

        private void studentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form11 fm11 = new Form11();
            fm11.MdiParent = this;
            fm11.Show();
        }

        private void courseToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form12 fm12 = new Form12();
            fm12.MdiParent = this;
            fm12.Show();
        }

        private void batchToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form13 fm13 = new Form13();
            fm13.MdiParent = this;
            fm13.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            fm2.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

     

       



    }
}
