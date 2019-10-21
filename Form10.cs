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
    public partial class Form10 : Form
    {
        SqlConnection con;
        public Form10()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Dell\Documents\Visual Studio 2005\Projects\GCP_pro1274\GCP_pro1274\Database1.mdf;Integrated Security=True;User Instance=True");
        }

        public void getBatchid()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Batchid FROM [Batch]", con);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
               // Array Batchid = new Array();
                while (reader.Read())
                {
                    //Batchid.Add(reader[0].ToString());
                }
                comboBox2.Items.Clear();
                //comboBox2.Items.AddRange(Batchid.ToArray());
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
                String StartingDate = textBox3.Text;
                String EndingDate = textBox4.Text;
                String Lecturer = comboBox1.Text;
                SqlCommand cmd = new SqlCommand("UPDATE Batch set Name'" + Name + "',StartingDate='" + StartingDate + "',EndingDate='"+EndingDate+"',Lecturer='" + Lecturer + "'WHERE Batchid='" + int.Parse(comboBox2.Text) + "", con);
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

        private void Form10_Load(object sender, EventArgs e)
        {
            getBatchid();
        }


        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
 try
            {
                con.Open();
                SqlCommand cmd   = new SqlCommand("SELECT Name,StartingDate,EndingDate, Lecturer FROM [Batch] WHERE Batchid=" + int.Parse(comboBox2.Text) + "", con);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                  String Name = "";
               // Array Lecturer = new Array();
                String EndingDate = "";
                String StartingDate = "";
                while (reader.Read())
                {
                    Name = reader[0].ToString();
                   StartingDate = reader[1].ToString();
                    EndingDate=reader[1].ToString();

                    //Lecturer.Add(reader[2].ToString());
                }
                textBox3.Text = StartingDate.ToString();
                 textBox4.Text = EndingDate.ToString();
                comboBox1.Items.Clear();
                //comboBox1.Items.AddRange(Lecturer.toArray());
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        }

    }
