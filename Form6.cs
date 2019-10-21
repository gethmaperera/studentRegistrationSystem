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
    public partial class Form6 : Form
    {

        SqlConnection con;

        public Form6()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Dell\Documents\Visual Studio 2005\Projects\GCP_pro1274\GCP_pro1274\Database1.mdf;Integrated Security=True;User Instance=True");
        }
                void showdata()
        {

            string ID = "";
            int oldID;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select Courseid from Course";
            cmd.CommandType = CommandType.Text;
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                ID = rd["Courseid"].ToString();

            }
            oldID = int.Parse(ID) + 1;
            textBox1.Text = oldID.ToString();
            rd.Close();
            con.Close();

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            showdata();

        }
        void adddata(int cid, string name, string Due, string lec)
        {
            con.Open();
            SqlTransaction trans=con.BeginTransaction();
            SqlCommand cmd=new SqlCommand();
            cmd.Connection=con;
            cmd.Transaction=trans;

            cmd.CommandText ="Insert into [Course](Courseid,Name,Duration,Lecturer)values('"+cid+"','"+name+"','"+Due+"','"+lec+"')";
            cmd.CommandType=CommandType.Text ;
            try
            {
                int count =cmd.ExecuteNonQuery();
                if( count>0)
                {
                    DialogResult r=MessageBox.Show(this,"Do You Want To Continue?",
                        "info",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
                    if (r==DialogResult.OK)
                    {
                        trans.Commit();
                    }
                    else
                    {
                        trans.Rollback();
                    }
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(this,ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            con.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            adddata(int.Parse(textBox1.Text),textBox2.Text, textBox3.Text, comboBox1.Text);
            Clear();
            showdata();
        }
        void Clear()
        {
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void Form6_Load_1(object sender, EventArgs e)
        {

        }

       

      
    }
}
