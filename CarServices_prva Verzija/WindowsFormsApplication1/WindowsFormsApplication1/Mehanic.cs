using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace WindowsFormsApplication1
{
    public partial class Mehanic : Form
    {
        public Mehanic()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = "Data Source=DEMIR-PC\\SQLEXPRESS;Initial Catalog=CarServices;Integrated Security=True";
            string Query = "Insert into Mehanic(MehanicID,Name,Surname,Birthday,email,Address,YearOfExperience) values ('" + this.txt_mehanicID.Text + "','" + this.txt_name.Text + "','" + this.txt_surname.Text + "','" + this.txt_birthday.Text + "','" + this.txt_email.Text + "','" + this.txt_address.Text + "','" + this.txt_experience.Text + "');";
            SqlConnection conDataBase = new SqlConnection(constring);
            SqlCommand cmd = new SqlCommand(Query, conDataBase);
            SqlDataReader dr;
            try
            {
                conDataBase.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("Saved");
                while (dr.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txt_mehanicID.Text = string.Empty;
            txt_name.Text = string.Empty;
            txt_surname.Text = string.Empty;
            txt_birthday.Text = string.Empty;
            txt_email.Text = string.Empty;
            txt_address.Text = string.Empty;
            txt_experience.Text = string.Empty;
           
            
             }

        private void Mehanic_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string constring = "Data Source=DEMIR-PC\\SQLEXPRESS;Initial Catalog=CarServices;Integrated Security=True";
            SqlConnection conDataBase = new SqlConnection(constring);
            SqlCommand cmdDataBase = new SqlCommand("Select * from Mehanic;", conDataBase);

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                       }
                 }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
             
                }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string constring = "Data Source=DEMIR-PC\\SQLEXPRESS;Initial Catalog=CarServices;Integrated Security=True";
            string Query = "Update Mehanic set MehanicID = '" + this.txt_mehanicID.Text + "',Name ='" + this.txt_name.Text + "',Surname = '" + this.txt_surname.Text + "',Birthday = '" + this.txt_birthday.Text + "',email ='" + this.txt_email.Text + "',Address ='" + this.txt_address.Text + "',YearOfExperience ='" + this.txt_experience.Text + "'where MehanicID= '" + this.txt_mehanicID.Text + "' ;";
            SqlConnection conDataBase = new SqlConnection(constring);
            SqlCommand cmd = new SqlCommand(Query, conDataBase);
            SqlDataReader dr;
            try
            {
                conDataBase.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("Updated");
                while (dr.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                string constring = "Data Source=DEMIR-PC\\SQLEXPRESS;Initial Catalog=CarServices;Integrated Security=True";
                string Query = "Delete from Mehanic where MehanicID ='" + this.txt_mehanicID.Text + "' ;";
                SqlConnection conDataBase = new SqlConnection(constring);
                SqlCommand cmd = new SqlCommand(Query, conDataBase);
                SqlDataReader dr;
                try
                {
                    conDataBase.Open();
                    dr = cmd.ExecuteReader();
                    MessageBox.Show("Deleted");
                    while (dr.Read())
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                txt_mehanicID.Text = string.Empty;
            }
        }
                       
    }
                  }



