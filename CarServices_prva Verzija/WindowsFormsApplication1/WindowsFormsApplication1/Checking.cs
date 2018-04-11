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
    public partial class Checking : Form
    {
        public Checking()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string constring = "Data Source=DEMIR-PC\\SQLEXPRESS;Initial Catalog=CarServices;Integrated Security=True";
            string Query = "select * from parts where car='" + this.txt_car.Text + "' and model='" + this.txt_model.Text + "'";

            SqlConnection conDataBase = new SqlConnection(constring);
            SqlCommand cmd = new SqlCommand(Query, conDataBase);
            conDataBase.Open();
            this.txt_message.Text = "You should change:";
            using (SqlDataReader reader = cmd.ExecuteReader()) {
            while (reader.Read()) {
                int change = reader.GetInt32(7);
                if (Convert.ToInt32(this.txt_kilometres.Text) > change)
                    {
                    this.txt_message.Text = reader.GetString(1) + ", ";

                    }
      
                }
            }
            if (this.txt_message.Text == "You should change:")
                this.txt_message.Text += " nothing";
        }

private void Parts(string p1,string p2)
{
 	throw new NotImplementedException();
}

private void button2_Click(object sender, EventArgs e)
{
    string constring = "Data Source=DEMIR-PC\\SQLEXPRESS;Initial Catalog=CarServices;Integrated Security=True";
            SqlConnection conDataBase = new SqlConnection(constring);
            SqlCommand cmdDataBase = new SqlCommand("Select * from Parts;", conDataBase);

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
}


}



