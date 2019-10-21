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
    public partial class Form5 : Form
    {
        SqlConnection con;
        public Form5()
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
            cmd.CommandText = "select Stno from Student";
            cmd.CommandType = CommandType.Text;
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                ID = rd["Stno"].ToString();

            }
                oldID = int.Parse(ID) + 1;
                textBox1.Text = oldID.ToString();
                rd.Close();
                con.Close();
           
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            showdata();

          
        }
        void adddata (int sn,string fname,string lname,string id)
        {
            con.Open();
            SqlTransaction trans=con.BeginTransaction();
            SqlCommand cmd=new SqlCommand();
            cmd.Connection=con;
            cmd.Transaction=trans;

            cmd.CommandText ="Insert into [Student](Stno,Fname,Lname,Course )values('"+sn+"','"+fname+"','"+lname+"','"+id+"')";
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
        adddata(int.Parse (textBox1.Text),textBox2.Text,textBox3.Text,comboBox1.Text);
        Clear();
            showdata();
        }
        void Clear()
        {
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void Form5_Load_1(object sender, EventArgs e)
        {

        }

        
       
    }

       

    }
