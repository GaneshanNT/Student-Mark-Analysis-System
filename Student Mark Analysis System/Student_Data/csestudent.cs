using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Mark_Analysis_System
{
    public partial class csestudent : Form
    {
        SqlConnection conn = new SqlConnection("Server=DESKTOP-R7V17QH\\PAAVAISQLEXPRESS; Database=SMASCSE; Integrated Security=SSPI");

        public csestudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Server=DESKTOP-R7V17QH\\PAAVAISQLEXPRESS; Database=SMASCSE; Integrated Security=SSPI");

            conn.Open();
            String newcom = "insert into finalyear([register number ],[student name],department,year,section,[phone number],[email id]) VALUES('" + Textbox1.Text + "','" + Textbox2.Text + "','" + comboBox1 + "','" + comboBox2 + "','" + comboBox3 + "','" + Textbox3.Text + "','" + Textbox4.Text + "')";
            SqlCommand cmd = new SqlCommand(newcom, conn);

            cmd.ExecuteNonQuery();
            label8.Text = "Registered";
        }
        public void display()
        {
            conn.Open();
            SqlCommand newcom = conn.CreateCommand();
            newcom.CommandType = CommandType.Text;
            newcom.CommandText = "select * from finalyear";
            newcom.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(newcom);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            display();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand newcom = conn.CreateCommand();
            newcom.CommandType = CommandType.Text;
            newcom.CommandText = "delete from finalyear where [register number ] = '" + Textbox1.Text + "'";
            newcom.ExecuteNonQuery();
            conn.Close();
            display();
            MessageBox.Show("Data deleted successfully");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Adminpanel r = new Adminpanel();
            r.Show();
            this.Hide();
        }
    }
}
