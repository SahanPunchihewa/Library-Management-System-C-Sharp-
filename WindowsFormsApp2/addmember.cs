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
    public partial class addmember : Form
    {
        public addmember()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                string MyConnection = "server=localhost; userId=root; password=; database=librarysystem";

                string query = "INSERT INTO `member` (`mid`, `mname`, `mage`, `maddress`) VALUES ('" + this.txt_mid.Text + "', '" + this.txt_mname.Text + "', '" + this.txt_mage.Text + "', '" + this.txt_maddress.Text + "');";
                MySqlConnection Myconn = new MySqlConnection(MyConnection);
                MySqlCommand Mycommand = new MySqlCommand(query, Myconn);
                MySqlDataReader MyReader;
                Myconn.Open();
                MyReader = Mycommand.ExecuteReader();
                MessageBox.Show("Registration Sucessful", "Registration", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                txt_mid.Text = "";
                txt_mname.Text = "";
                txt_mage.Text = "";
                txt_maddress.Text = "";
               

                Myconn.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }




        }

        private void button6_Click(object sender, EventArgs e)
        {
            menu open_menu = new menu();
            open_menu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                if (txt_mid.Text != "")
                {

                    string MyConnection = "server=localhost; userId=root; password=; database=librarysystem";
                    string query = "SELECT * FROM `member` WHERE mid= '" + txt_mid.Text + "'";
                    MySqlConnection Myconn = new MySqlConnection(MyConnection);
                    MySqlCommand Mycommand = new MySqlCommand(query, Myconn);
                    MySqlDataReader MyReader;
                    Myconn.Open();
                    MyReader = Mycommand.ExecuteReader();
                    Myconn.Close();
                    MySqlDataAdapter adp = new MySqlDataAdapter(Mycommand);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);

                    txt_mname.Text = dt.Rows[0][1].ToString();
                    txt_mage.Text = dt.Rows[0][2].ToString();
                    txt_maddress.Text = dt.Rows[0][3].ToString();
                    
                }
                else
                {
                    MessageBox.Show("Enter Member ID");
                }

            }
            catch
            {

                MessageBox.Show("Error");
            }

        }
    }
}
