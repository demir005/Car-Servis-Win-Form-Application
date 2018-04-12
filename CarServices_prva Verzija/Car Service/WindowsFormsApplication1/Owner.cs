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
    public partial class Owner : Form
    {
        public Owner()
        {
            InitializeComponent();

        }


        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string constring = "Data Source=DEMIR-PC\\SQLEXPRESS;Initial Catalog=CarServices;Integrated Security=True";
            string Query = "Insert into Owner(OwnerID,FirstName,LastName,Address,PhoneNumber,PostCode,Country,City,JMBG,Birthday,email) values ('"+this.txt_ownerID.Text+"','" + this.txt_first.Text + "','" + this.txt_last.Text + "','" + this.txt_address.Text + "','" + this.txt_phone.Text + "','" + this.txt_postCode.Text + "','" + this.txt_country.Text + "','" + this.txt_city.Text + "','" + this.txt_jmbg.Text + "','" + this.txt_birthday.Text + "','"+this.txt_email+"');";
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
            txt_first.Text = string.Empty;
            txt_last.Text = string.Empty;
            txt_address.Text = string.Empty;
            txt_birthday.Text = string.Empty;
            txt_city.Text = string.Empty;
            txt_jmbg.Text = string.Empty;
            txt_postCode.Text = string.Empty;
            txt_phone.Text = string.Empty;
            txt_country.Text = string.Empty;
            txt_ownerID.Text = string.Empty;
            txt_email.Text = string.Empty;


        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string constring = "Data Source=DEMIR-PC\\SQLEXPRESS;Initial Catalog=CarServices;Integrated Security=True";
            string Query = "Update Owner set OwnerID = '"+this.txt_ownerID.Text+"', FirstName = '" + this.txt_first.Text + "',LastName ='" + this.txt_last.Text + "',Address = '" + this.txt_address.Text + "',PhoneNumber = '" + this.txt_phone.Text + "',PostCode ='" + this.txt_postCode.Text + "',Country ='" + this.txt_country.Text + "',City ='" + this.txt_city.Text + "',JMBG ='" + this.txt_jmbg.Text + "',Birthday ='" + this.txt_birthday.Text + "',email ='" + this.txt_email.Text + "' where OwnerID ='" + this.txt_ownerID.Text + "';";
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
            txt_first.Text = string.Empty;
            txt_last.Text = string.Empty;
            txt_address.Text = string.Empty;
            txt_birthday.Text = string.Empty;
            txt_country.Text = string.Empty;
            txt_jmbg.Text = string.Empty;
            txt_phone.Text = string.Empty;
            txt_postCode.Text = string.Empty;
            txt_city.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            {
                string constring = "Data Source=DEMIR-PC\\SQLEXPRESS;Initial Catalog=CarServices;Integrated Security=True";
                string Query = "Delete from Owner where OwnerID ='" + this.txt_ownerID.Text + "' ;";
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
                txt_jmbg.Text = string.Empty;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {



        }

        private void Owner_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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
            SqlCommand cmdDataBase = new SqlCommand("Select * from Owner;",conDataBase);

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) {

                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                txt_first.Text = row.Cells["FirstName"].Value.ToString();
                txt_last.Text = row.Cells["LastName"].Value.ToString();
                txt_address.Text = row.Cells["Address"].Value.ToString();
                txt_phone.Text = row.Cells["PhoneNumber"].Value.ToString();
                txt_postCode.Text = row.Cells["PostCode"].Value.ToString();
                txt_country.Text = row.Cells["Country"].Value.ToString();
                txt_city.Text = row.Cells["City"].Value.ToString();
                txt_birthday.Text = row.Cells["Birthday"].Value.ToString();
                txt_jmbg.Text = row.Cells["JMBG"].Value.ToString();


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

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txt_jmbg_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        }
    }

 

       