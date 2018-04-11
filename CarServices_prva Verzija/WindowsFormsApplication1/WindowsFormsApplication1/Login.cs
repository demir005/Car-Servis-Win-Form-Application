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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DEMIR-PC\SQLEXPRESS;Initial Catalog=CarServices;Integrated Security=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Login where username = '" + txtUsername.Text + "' and password = '" + txtPassword.Text + "'", cn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Successful connected in database");
                Switch f2 = new Switch();
                f2.Show();
            }
            else
            {

                MessageBox.Show("Username or password doesn't exist in database");


               switch (MessageBox.Show("Do you want to create account?",
              "to allow connection in database",
              MessageBoxButtons.YesNoCancel,
              MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        Register f1 = new Register();
                        f1.Show();
                        break;
                       
                       

                    case DialogResult.No:
                       Login f2 = new Login();
                       f2.Show();
                       this.Hide();
                        break;

                    case DialogResult.Cancel:
                        this.Hide();
                        break;

                }
              


                txtPassword.Clear();
                txtUsername.Clear();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        }
    }

