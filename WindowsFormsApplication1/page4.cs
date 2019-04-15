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
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class page4 : Form
    {
        public page4()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 page = new Form1();
            page.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 page = new Form2();
            page.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "data source =127.0.0.1; port = 3306; " +
              "username = root; database = airline;";

            //assign each value to each row in the engineer table
            string query = "DELETE FROM `bookings` WHERE `First Name` = '" + userdata.f_n + "'";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                using (MySqlCommand commandDatabase = new MySqlCommand(query, conn))
                {


                    try
                    {
                        commandDatabase.ExecuteNonQuery();
                        commandDatabase.CommandTimeout = 60;
                        MessageBox.Show("cancel");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*String filename = @"C:\Users\adetu\Documents\Visual Studio 2012\Projects\WindowsFormsApplication1\printout.txt";

            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            else
            {
                using (StreamWriter filestr = File.CreateText(filename))
                {
                    filestr.WriteLine("------------------TICKET INFO---------------\n");
                    filestr.WriteLine("First Name : " +  + "\t\t");
                    filestr.WriteLine("Last Name : " + meh.d + "\t\t");
                    filestr.WriteLine("Airline : " + meh.b + "\t\t");
                    filestr.WriteLine("Source : " + meh.e + "\t\t");
                    filestr.WriteLine("Departure Time : " + meh.f + "\t\t");
                    filestr.WriteLine("Destination : " + meh.g + "\t\t");
                    filestr.WriteLine("Arrival Time : " + meh.h + "\t\t");
                    filestr.WriteLine("Seat Class : " + meh.a + "\t\t");
                    filestr.WriteLine("No Of Tickets : " + meh.i + "\t\t");
                    Random gen = new Random();
                    int gr = gen.Next(1, 10);
                }
            }*/
        }
    }
}
