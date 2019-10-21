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
    public partial class Form13 : Form
    {
        SqlConnection con;
        public Form13()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Dell\Documents\Visual Studio 2005\Projects\GCP_pro1274\GCP_pro1274\Database1.mdf;Integrated Security=True;User Instance=True");
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Batch' table. You can move, or remove it, as needed.
            this.batchTableAdapter.Fill(this.database1DataSet.Batch);

        }
    }
}