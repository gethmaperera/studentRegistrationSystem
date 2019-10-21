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
    public partial class Form8 : Form
    {
        SqlConnection con;
     

        public Form8()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Dell\Documents\Visual Studio 2005\Projects\GCP_pro1274\GCP_pro1274\Database1.mdf;Integrated Security=True;User Instance=True");
        }

        public void getStno()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Stno FROM [Student]", con);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
               // Array Stno = new Array();
                while (reader.Read())
                {
                   // Stno.Add(reader[0].ToString());
                }
                comboBox2.Items.Clear();
               // comboBox2.Items.AddRange(Stno.ToArray());
            }
            catch
            {
                MessageBox.Show("failed");
            }
            finally
            {
                con.Close();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String Fname = textBox2.Text;
                String Lname = textBox3.Text;
                String Course = comboBox1.Text;
                SqlCommand cmd = new SqlCommand("UPDATE Student set Fname'" + Fname + "',Lname='" + Lname + "',Course='" + Course + "'WHERE Stno='" + int.Parse(comboBox2.Text) + "", con);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                con.Close();
            }



        }

        

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form8_Load_1(object sender, EventArgs e)
        {
            getStno();
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Fname,Lname, Course FROM [Student] WHERE Stno=" + int.Parse(comboBox2.Text) + "", con);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                String Fname = "";
               // Array Course = new Array();
                String Lname = "";
                while (reader.Read())
                {
                    Fname = reader[0].ToString();
                    //Lname = reader[1].ToString();
                   // Course.Add(reader[2].ToString());
                }
                textBox2.Text = Fname.ToString();
               // textBox3.Text = Lname.ToString();
                comboBox1.Items.Clear();
                //comboBox1.Items.AddRange(Course.toArray());
            }
            catch
            {
                MessageBox.Show("error");
            }
            finally
            {
                con.Close();
            }
        }
      
   

    }
}