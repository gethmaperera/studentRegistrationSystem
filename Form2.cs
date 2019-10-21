using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Uname = textBox1.Text;
            String Pname = textBox2.Text;
            if ((Uname == "Admin" && Pname == "Admin")||(Uname == "Staff" && Pname == "Staff"))
            {
                Form3 fm3 = new Form3();
                fm3.Show();
                this.Hide();

            }
                   else
            
            {
                MessageBox.Show("Incorrect Username or Password","Error",MessageBoxButtons.OKCancel);
                textBox2.Clear();
                textBox2.Focus();

            }
        }

       
    }
}