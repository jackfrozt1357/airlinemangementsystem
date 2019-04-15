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
//using System.Data;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {   
        
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = this.username1.Text;
            string password = this.password1.Text;


            //opening connection string for database
            string connectionString = "data source =127.0.0.1; port = 3306; " +
                "username = root; database = airline;";

            //assign each value to each row in the engineer table
            string query = "select username, Password from create_account where username = @username " +
                "and Password = @password ";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                using (MySqlCommand commandDatabase = new MySqlCommand(query, conn))
                {

                    commandDatabase.Parameters.AddWithValue("@username", username);
                    commandDatabase.Parameters.AddWithValue("@password", password);

                    //establish connection with database and update
                    try
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter(commandDatabase);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            userdata reg = new userdata();
                            reg.Show();

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

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuMetroTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            string username = this.username.Text;
            string password = this.password.Text;


            //opening connection string for database
            string connectionString = "data source =127.0.0.1; port = 3306; " +
                "username = root; database = airline;";

            //assign each value to each row in the engineer table
            string query = "select username, Password from create_account where username = @username " +
                "and Password = @password ";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                using (MySqlCommand commandDatabase = new MySqlCommand(query, conn))
                {

                    commandDatabase.Parameters.AddWithValue("@username", username);
                    commandDatabase.Parameters.AddWithValue("@password", password);

                    //establish connection with database and update
                    try
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter(commandDatabase);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            userdata reg = new userdata();
                            reg.Show();

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {   
            if(this.password.isPassword == false)
            this.password.isPassword = true;
            else
                this.password.isPassword = false;
        }
    }
}
