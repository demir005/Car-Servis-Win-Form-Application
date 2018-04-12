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
    public partial class Services : Form
    {
        public Services()
        {
            InitializeComponent();
        }

        private void bt_insert_Click(object sender, EventArgs e)
        {
            string constring = "Data Source=DEMIR-PC\\SQLEXPRESS;Initial Catalog=CarServices;Integrated Security=True";
            string Query = "Insert into Services(ServicesID,Mehanic,EngineeID,Date,Price) values ('" + this.txt_servicesID.Text + "','" + this.txt_mehanic.Text + "','" + this.txt_engineeID.Text + "','" + this.dt_picker.Text + "','" + this.txt_price.Text + "');";
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
            txt_servicesID.Text = string.Empty;
            txt_engineeID.Text = string.Empty;
           
            txt_mehanic.Text = string.Empty;
            txt_price.Text = string.Empty;


        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            string constring = "Data Source=DEMIR-PC\\SQLEXPRESS;Initial Catalog=CarServices;Integrated Security=True";
            string Query = "Update Services set ServicesID = '" + this.txt_servicesID.Text + "',Mehanic ='" + this.txt_mehanic.Text + "',EngineeID = '" + this.txt_engineeID.Text + "',Date = '" + this.dt_picker.Text + "',TotalPrice ='" + this.txt_price.Text + "'where ServicesID= '" + this.txt_servicesID.Text + "' ;";
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
            txt_servicesID.Text = string.Empty;
            txt_engineeID.Text = string.Empty;
           
            txt_mehanic.Text = string.Empty;
            txt_price.Text = string.Empty;
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            string constring = "Data Source=DEMIR-PC\\SQLEXPRESS;Initial Catalog=CarServices;Integrated Security=True";
            string Query = "Delete from Services where ServicesID ='" + this.txt_servicesID.Text + "' ;";
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
            txt_servicesID.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string constring = "Data Source=DEMIR-PC\\SQLEXPRESS;Initial Catalog=CarServices;Integrated Security=True";
            SqlConnection conDataBase = new SqlConnection(constring);
            SqlCommand cmdDataBase = new SqlCommand("Select * from Services;", conDataBase);

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

        private void button1_Click(object sender, EventArgs e)
        {
            Mehanic f1 = new Mehanic();
            f1.Show();
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




