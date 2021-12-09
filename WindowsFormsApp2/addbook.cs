using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    public partial class addbook : Form
    {
        public addbook()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Book Insert Code

            try { 

            string MyConnection = "server=localhost; userId=root; password=; database=librarysystem";

            string query = "INSERT INTO `book` (`id`, `name`, `title`, `category`, `author`) VALUES ('" + this.txt_id.Text + "', '" + this.txt_name.Text + "', '" + this.txt_title.Text + "', '" + this.txt_category.Text + "', '" + this.txt_author.Text + "');";
            MySqlConnection Myconn = new MySqlConnection(MyConnection);
            MySqlCommand Mycommand = new MySqlCommand(query, Myconn);
            MySqlDataReader MyReader;
            Myconn.Open();
            MyReader = Mycommand.ExecuteReader();
            MessageBox.Show("Registration Sucessful", "Registration", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            txt_id.Text = "";
            txt_name.Text = "";
            txt_title.Text = "";
            txt_category.Text = "";
            txt_author.Text = "";
            
             Myconn.Close();

        }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }





}
    }
}
