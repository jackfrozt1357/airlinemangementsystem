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

namespace WindowsFormsApplication1
{
    public partial class adminlogin : Form
    {
        public adminlogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = this.username1.Text;
            string password = this.password1.Text;


            //opening connection string for database
            string connectionString = "data source =127.0.0.1; port = 3306; " +
                "username = root; database = airline;";

            string query = "select username, Password from manager_account where username = @username " +
                "and Password = @password ";

             using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open(); using (MySqlCommand commandDatabase = new MySqlCommand(query, conn))
                {

                    commandDatabase.Parameters.AddWithValue("@username", username);
                    commandDatabase.Parameters.AddWithValue("@password", password);  try
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter(commandDatabase);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {

                            ManagerPage page = new ManagerPage();
                            page.Show();

                            commandDatabase.ExecuteNonQuery();
                            commandDatabase.CommandTimeout = 60;

                            this.Hide();
                        }else
                        {
                            MessageBox.Show("Invalid Login. Please check username and password");
                        }


                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                }
            }
        }

        private void adminlogin_Load(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox1_TextChange(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            string username = this.username1.Text;
            string password = this.password1.Text;


            //opening connection string for database
            string connectionString = "data source =127.0.0.1; port = 3306; " +
                "username = root; database = airline;";

            string query = "select username, Password from manager_account where username = @username " +
                "and Password = @password ";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open(); using (MySqlCommand commandDatabase = new MySqlCommand(query, conn))
                {

                    commandDatabase.Parameters.AddWithValue("@username", username);
                    commandDatabase.Parameters.AddWithValue("@password", password); try
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter(commandDatabase);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {

                            ManagerPage page = new ManagerPage();
                            page.Show();

                            commandDatabase.ExecuteNonQuery();
                            commandDatabase.CommandTimeout = 60;

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Login. Please check username and password");
                        }


                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                }
            }
        }
    }
}
