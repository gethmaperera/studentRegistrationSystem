using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsApplication1
{
    public partial class Form11 : Form
    {
        
        SqlConnection con;
        public Form11()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Dell\Documents\Visual Studio 2005\Projects\GCP_pro1274\GCP_pro1274\Database1.mdf;Integrated Security=True;User Instance=True");
        }

      

      

        private void Form11_Load_1(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'database1DataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.database1DataSet.Student);

        }

        

        

       
    }
}