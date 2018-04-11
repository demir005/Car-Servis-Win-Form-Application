using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Switch : Form
    {
        public Switch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InfoOfCar f1 = new InfoOfCar();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Owner f1 = new Owner();
            f1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mehanic f1 = new Mehanic();
            f1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Services f1 = new Services();
            f1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Checking f1 = new Checking();
            f1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Parts f1 = new Parts();
            f1.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Register f1 = new Register();
            f1.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Login f1 = new Login();
            f1.Show();
        }
    }
}
