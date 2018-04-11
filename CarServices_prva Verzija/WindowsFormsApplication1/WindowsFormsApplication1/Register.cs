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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            txtPassword.MaxLength = 20;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = "Data Source=DEMIR-PC\\SQLEXPRESS;Initial Catalog=CarServices;Integrated Security=True";
            string Query = "Insert into Login(Username,Password) values ('" + this.txtUsername.Text + "','" + this.txtUsername.Text + "');";
            SqlConnection conDataBase = new SqlConnection(constring);
            SqlCommand cmd = new SqlCommand(Query, conDataBase);
            SqlDataReader dr;
            try
            {
                conDataBase.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("Successfuly Register New User");
                while (dr.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtPassword.Text = string.Empty;
            txtUsername.Text = string.Empty;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string constring = "Data Source=DEMIR-PC\\SQLEXPRESS;Initial Catalog=CarServices;Integrated Security=True";
            string Query = "Delete from Login where Username ='" + this.txtUsername.Text + "' ;";
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
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string constring = "Data Source=DEMIR-PC\\SQLEXPRESS;Initial Catalog=CarServices;Integrated Security=True";
            string Query = "Update Login set Username = '" + this.txtUsername.Text + "',Password ='" + this.txtPassword.Text + "'where Username = '" + this.txtUsername.Text + "' ;";
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
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }
    }
}