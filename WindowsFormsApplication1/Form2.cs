using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MySql.Data.MySqlClient;
//using System.Data;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {   
        //MySqlConnection connection = new MySqlConnection(@"Data source=localhost;port=3306;Initial catalog= airline ;username=root;password=o3Ful8zIBzNt");
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //connection.Open();
            userdata Check = new userdata();
            Check.Show();
            Hide();
           // MySqlCommand command = connection.CreateCommand();



            //connection.Close();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
