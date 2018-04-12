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
    public partial class InfoOfCar : Form
    {
       

        public InfoOfCar()
        {
            InitializeComponent();
        }

        private void InfoOfCar_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string constring = "Data Source=DEMIR-PC\\SQLEXPRESS;Initial Catalog=CarServices;Integrated Security=True";
            string Query = "Insert into InfoOfCar(CarID,Car,Model,Year,EngineeID,Kilometres) values ('"+this.txt_carID.Text+"','" + this.txt_car.Text + "','" + this.txt_model.Text + "','" + this.txt_year.Text + "','" + this.txt_engineeid.Text + "','" + this.txt_kilometres.Text + "');";
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
            txt_car.Text = string.Empty;
            txt_model.Text = string.Empty;
            txt_year.Text = string.Empty;
            txt_engineeid.Text = string.Empty;
            txt_kilometres.Text = string.Empty;
            txt_carID.Text = string.Empty;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = "Data Source=DEMIR-PC\\SQLEXPRESS;Initial Catalog=CarServices;Integrated Security=True";
            string Query = "Update InfoOfCar set CarID = '"+this.txt_carID.Text+"',Car = '" + this.txt_car.Text + "',Model ='" + this.txt_model.Text + "',Year = '" + this.txt_year.Text + "',EngineeID = '" + this.txt_engineeid.Text + "',Kilometres ='" + this.txt_kilometres.Text + "'where CarID= '" + this.txt_carID.Text + "' ;";
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
            string constring = "Data Source=DEMIR-PC\\SQLEXPRESS;Initial Catalog=CarServices;Integrated Security=True";
            string Query = "Delete from InfoOfCar where CarID ='" + this.txt_carID.Text + "' ;";
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
            txt_engineeid.Text = string.Empty;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string constring = "Data Source=DEMIR-PC\\SQLEXPRESS;Initial Catalog=CarServices;Integrated Security=True";
            SqlConnection conDataBase = new SqlConnection(constring);
            SqlCommand cmdDataBase = new SqlCommand("Select * from InfoOfCar;", conDataBase);

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

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
           
            }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
           
             }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            
             }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_model_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {

        }

                }

            }
   


 
         

