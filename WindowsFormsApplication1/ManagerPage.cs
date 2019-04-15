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
    public partial class ManagerPage : Form
    {
        public ManagerPage()
        {
            InitializeComponent();
            string connection = "data source =127.0.0.1; port= 3306;" + "username = root;database=airline;";
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("select * from bookings", conn))
                {
                    DataSet ds = new DataSet();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(ds);
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = ds.Tables[0].ToString();
                    cmd.ExecuteNonQuery();
                    cmd.CommandTimeout = 60;
                    conn.Close();
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Form1 jj = new Form1();
            jj.Show();
            this.Hide();
        }
    }
}
