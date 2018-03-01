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
    public partial class csestaff : Form
    {
        SqlConnection conn = new SqlConnection("Server=DESKTOP-R7V17QH\\PAAVAISQLEXPRESS; Database=SMASCSE; Integrated Security=SSPI");

        public csestaff()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Server=DESKTOP-R7V17QH\\PAAVAISQLEXPRESS; Database=SMASCSE; Integrated Security=SSPI");

            conn.Open();
            String newcom = "insert into csestaff([first name],[last name],department,[email id],username,password,[phone no],designation,subject1,subject2,subject3,tutor) VALUES('" + Textbox1.Text + "','" + Textbox2.Text + "','" + Textbox3.Text + "','" + Textbox4.Text + "','" + Textbox5.Text + "','" + Textbox6.Text + "','" + Textbox7.Text + "','" + Textbox8.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + Textbox9.Text + "')";

            SqlCommand cmd = new SqlCommand(newcom, conn);

            cmd.ExecuteNonQuery();

            label6.Text = "Registered";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            {

                comboBox1.Items.Add("Theory of Computation");
                comboBox1.Items.Add("Database Management Systems");
                comboBox1.Items.Add("Computer Networks");
                comboBox1.Items.Add("Operating Systems");
                comboBox1.Items.Add("Web designing");
                
             

            }
        }
        public void display()
        {
            conn.Open();
            SqlCommand newcom = conn.CreateCommand();
            newcom.CommandType = CommandType.Text;
            newcom.CommandText = "select * from csestaff";
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
            newcom.CommandText = "delete from csestaff where [first name] = '" + Textbox1.Text + "'";
            newcom.ExecuteNonQuery();
            conn.Close();
            display();
            MessageBox.Show("Data deleted successfully");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Add("Theory of Computation");
            comboBox2.Items.Add("Database Management Systems");
            comboBox2.Items.Add("Computer Networks");
            comboBox2.Items.Add("Operating Systems");
            comboBox2.Items.Add("Web designing");
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Add("Theory of Computation");
            comboBox3.Items.Add("Database Management Systems");
            comboBox3.Items.Add("Computer Networks");
            comboBox3.Items.Add("Operating Systems");
            comboBox3.Items.Add("Web designing");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Adminpanel r = new Adminpanel();
            r.Show();
            this.Hide();
        }
    }
}
