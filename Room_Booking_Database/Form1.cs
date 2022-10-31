using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Room_Booking_Database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            string room = roomno.Text;
            string no_of_room = noofroom.Text;

            string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\University Work\Visual Porgramming\Lab Tasks\PRACTICE\Room_Booking_Database\Room_Booking_Database\Database1.mdf"";Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            string query = "INSERT into Room(Roomno, NoofRooms) VALUES('" + room + "','" + no_of_room + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Data Inserted");
            }


            



        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\University Work\Visual Porgramming\Lab Tasks\PRACTICE\Room_Booking_Database\Room_Booking_Database\Database1.mdf"";Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from Room", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name_of_person = name.Text;
            string address_of_person = address.Text;
            string mobile_no = mobile.Text;


            string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\University Work\Visual Porgramming\Lab Tasks\PRACTICE\Room_Booking_Database\Room_Booking_Database\Database1.mdf"";Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            string query = "INSERT into Customers(Name, Address,Mobile_No) VALUES('" + name_of_person + "','" + address_of_person + "','" + mobile_no + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Data Inserted");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {    
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\University Work\Visual Porgramming\Lab Tasks\PRACTICE\Room_Booking_Database\Room_Booking_Database\Database1.mdf"";Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from Customers", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);          
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            dataGridView2.DataSource = dt;
        }
    }
}
