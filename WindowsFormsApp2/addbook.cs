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
            // Update Code Here


            try
            {

                string MyConnection = "server=localhost; userId=root; password=; database=librarysystem";

                string query = "UPDATE `book` SET `id` = '" + this.txt_id.Text + "', `name` = '" + this.txt_name.Text + "', `title` ='" + this.txt_title.Text + "', `category`= '" + this.txt_category.Text + "', `author`= '" + this.txt_author.Text + "' WHERE `id`= '" + this.txt_id.Text + "'";
                MySqlConnection Myconn = new MySqlConnection(MyConnection);
                MySqlCommand Mycommand = new MySqlCommand(query, Myconn);
                MySqlDataReader MyReader;
                Myconn.Open();
                MyReader = Mycommand.ExecuteReader();
                MessageBox.Show("Book Successfully Updated!");
                while (MyReader.Read())

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

        private void button4_Click(object sender, EventArgs e)
        {
            // Delete Code 

            try
            {

                string MyConnection = "server=localhost; userId=root; password=; database=librarysystem";
                string query = "DELETE FROM `book` WHERE id = '" + this.txt_id.Text + "'";

                MySqlConnection Myconn = new MySqlConnection(MyConnection);
                MySqlCommand Mycommand = new MySqlCommand(query, Myconn);
                MySqlDataReader MyReader;
                Myconn.Open();
                MyReader = Mycommand.ExecuteReader();
                MessageBox.Show("Book Successfully Deleted!");

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

            string query = "INSERT INTO `book` (`id`, `name`, `title`, `category`, `author`) VALUES ('"+this.txt_id.Text + "', '" + this.txt_name.Text + "', '" + this.txt_title.Text + "', '" + this.txt_category.Text + "', '" + this.txt_author.Text + "');";
            MySqlConnection Myconn = new MySqlConnection(MyConnection);
            MySqlCommand Mycommand = new MySqlCommand(query, Myconn);
            MySqlDataReader MyReader;
            Myconn.Open();
            MyReader = Mycommand.ExecuteReader();
            MessageBox.Show("Book Added Successful!");

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

        private void button2_Click(object sender, EventArgs e)
        {

            // View Code Here

            try
            {

                if (txt_id.Text != "")
                {

                    string MyConnection = "server=localhost; userId=root; password=; database=librarysystem";
                    string query = "SELECT * FROM `book` WHERE id= '"+txt_id.Text + "'";
                    MySqlConnection Myconn = new MySqlConnection(MyConnection);
                    MySqlCommand Mycommand = new MySqlCommand(query, Myconn);
                    MySqlDataReader MyReader;
                    Myconn.Open();
                    MyReader = Mycommand.ExecuteReader();
                    Myconn.Close();
                    MySqlDataAdapter adp = new MySqlDataAdapter(Mycommand);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);

                    txt_name.Text = dt.Rows[0][1].ToString();
                    txt_title.Text = dt.Rows[0][2].ToString();
                    txt_category.Text = dt.Rows[0][3].ToString();
                    txt_author.Text = dt.Rows[0][4].ToString();
                }
                else
                {
                    MessageBox.Show("Enter Value for ID");
                }

            }
            catch
            {

                MessageBox.Show("Error");
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            menu open_menu = new menu();
            open_menu.Show();
            this.Hide();
        }
    }
}
