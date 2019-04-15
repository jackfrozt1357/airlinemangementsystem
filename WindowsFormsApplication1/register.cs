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
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            string uusername = this.uusername.Text;
            string upassword = this.upassword.Text;

            if (uusername == "" || upassword == "")
            {
                MessageBox.Show("fill all"); return;
            }
            else
            {
                string connectionstring = "data source = 127.0.0.1;port=3306;username=root;database=airline;";
                string query = "INSERT into create_account (`username`,`password`) values('" + uusername + "','" + upassword + "')";

                using (MySqlConnection con = new MySqlConnection(connectionstring))
                {
                    con.Open();
                    using (MySqlCommand con_command = new MySqlCommand(query, con))
                    {
                        try
                        {
                            con_command.ExecuteNonQuery();
                            con_command.CommandTimeout = 60;
                            con.Close();
                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }

                    }

                    MessageBox.Show("created successfully");


                }
            }
        }
        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            string ausername = this.ausername.Text;
            string apassword = this.apassword.Text;

            if (ausername == "" || apassword == "")
            {
                MessageBox.Show("fill all"); return;
            }
            else
            {
                string connectionstring = "data source = 127.0.0.1;port=3306;username=root;database=airline;";
                string query = "INSERT into manager_account (`username`,`Password`) values('" + ausername + "','" + apassword + "')";

                using (MySqlConnection con = new MySqlConnection(connectionstring))
                {
                    con.Open();
                    using (MySqlCommand con_command = new MySqlCommand(query, con))
                    {
                        try
                        {
                            con_command.ExecuteNonQuery();
                            con_command.CommandTimeout = 60;
                            con.Close();
                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }

                    }

                    MessageBox.Show("created successfully");


                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Form1 op = new Form1();
            op.Show();
            this.Hide();
        }
    }
}
