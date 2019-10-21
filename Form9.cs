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
    public partial class Form9 : Form
    { 
        SqlConnection con;
        public Form9()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Dell\Documents\Visual Studio 2005\Projects\GCP_pro1274\GCP_pro1274\Database1.mdf;Integrated Security=True;User Instance=True");
        }
        public void getcourseid()
        {
            try
            {
                con.Open();
                SqlCommand cmd =new SqlCommand("SELECT Courseid FROM [Course]",con);
                SqlDataReader reader; 
                reader =cmd.ExecuteReader();
                //Array Courseid =new Array();
                while(reader.Read())
                {
                   // Courseid.Add(reader[0].ToString());
                }
                comboBox2.Items.Clear();
               // comboBox2 .Items.AddRange(Courseid.ToArray());
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
                String Name = textBox2.Text;
                String Duration = textBox3.Text;
                String Lecturer = comboBox1.Text;
                SqlCommand cmd = new SqlCommand("UPDATE Course set Name'" + Name + "',Duration='" + Duration + "',Lecturer='" + Lecturer + "'WHERE Courseid='" + int.Parse(comboBox2.Text) + "", con);
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

        private void Form9_Load(object sender, EventArgs e)
        {
            getcourseid();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd=new SqlCommand("SELECT Name,Duration, Lecturer FROM [Course] WHERE Courseid="+int.Parse(comboBox2.Text)+"",con);
                SqlDataReader reader ;
                reader =cmd .ExecuteReader();
               String Name ="";
               // Array Lecturer=new Array();

                String Duration ="";
                while(reader.Read())
                {
                    Name=reader[0].ToString();
                    Duration=reader[1].ToString();
                 //   Lecturer.Add(reader[2].ToString());
                }
                textBox2.Text=Name.ToString();
                textBox3.Text = Duration.ToString();
                comboBox1.Items.Clear();
              // comboBox1.Items.AddRange(Lecturer.toArray());
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
