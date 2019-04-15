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
    public partial class userdata : Form
    {
        public static string f_n = "";
        
        public userdata()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstname = this.firstname1.Text;
            string lastname = this.lastname1.Text;
            string destination = this.destination.SelectedText;
            string fclass = this.flightclass.SelectedText;
            string departtime = this.departtime.SelectedText;
            string airline = this.airline.SelectedText;
            string noofticket = this.numticket.SelectedText;
            string origin = this.origin.SelectedText;

            string arrivaltime = this.arrivaltime.Text;

            f_n = firstname;
            if (firstname == "")
            {
                MessageBox.Show("fill all"); return;
            }
            else
            {
                string connectionstring = "data source = 127.0.0.1;port=3306;username=root;database=airline;";
                string query = "INSERT into bookings (`First Name`,`Last Name`,`Departing From`,`Departing At`,`Arrival time`,`Arriving in`,`Seat Class`,`Airline`) values('" + firstname + "','" + lastname + "','" + origin + "','" + departtime + "','" + arrivaltime + "','" + destination + "','" + fclass + "','" + airline + "')";

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




                }
                page4 age = new page4();
                age.Show();
                this.Hide();

            }
        }

        private void firstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void userdata_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
