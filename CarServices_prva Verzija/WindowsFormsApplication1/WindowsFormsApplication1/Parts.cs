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
    public partial class Parts : Form
    {
        public Parts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string constring = "Data Source=DEMIR-PC\\SQLEXPRESS;Initial Catalog=CarServices;Integrated Security=True";
            string Query = "Insert into Parts(PartsID,Name,Car,Model,Warranty,Price,Manufacturer,Change) values ('" + this.txt_partID.Text + "','" + this.cb_name.Text + "','" + this.txt_car.Text + "','" + this.txt_model.Text + "','"+txt_warranty.Text+"','"+this.txt_price.Text+"','"+this.cb_name.Text+"','"+this.txt_change.Text+"');";
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
            txt_partID.Text = string.Empty;
            txt_model.Text = string.Empty;
            txt_car.Text = string.Empty;
            cb_name.Items.Clear();
            txt_warranty.Text = string.Empty;
            txt_price.Text = string.Empty;
            cb_manufacturer.Items.Clear();
            txt_change.Text = string.Empty;

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string constring = "Data Source=DEMIR-PC\\SQLEXPRESS;Initial Catalog=CarServices;Integrated Security=True";
            string Query = "Update Parts set PartsID = '" + this.txt_partID.Text + "',Name ='" + this.cb_name.Text + "',Car = '" + this.txt_car.Text + "',Model = '" + this.txt_model.Text + "',Warranty = '" + this.txt_warranty.Text + "',Manufacturer = '" + this.cb_manufacturer.Text + "' where PartsID= '" + this.txt_partID.Text + "' ;";
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
            txt_partID.Text = string.Empty;
            txt_model.Text = string.Empty;
            txt_car.Text = string.Empty;


              }

        private void button3_Click(object sender, EventArgs e)
        {
            string constring = "Data Source=DEMIR-PC\\SQLEXPRESS;Initial Catalog=CarServices;Integrated Security=True";
            string Query = "Delete from Parts where PartsID ='" + this.txt_partID.Text + "' ;";
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
            txt_partID.Text= string.Empty;

             }

        private void button4_Click(object sender, EventArgs e)
        {
            string constring = "Data Source=DEMIR-PC\\SQLEXPRESS;Initial Catalog=CarServices;Integrated Security=True";
            SqlConnection conDataBase = new SqlConnection(constring);
            SqlCommand cmdDataBase = new SqlCommand("Select * from Parts;",conDataBase);

            try { 
                SqlDataAdapter sda = new SqlDataAdapter ();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();
                 bSource.DataSource = dbdataset;
                dataGridView1.DataSource=bSource;
                sda.Update(dbdataset);

            }
          catch (Exception ex) {
              MessageBox.Show(ex.Message);
          }
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

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        }

        }
                    

                      


