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
    public partial class staffpwdrest : Form
    {
        SqlConnection conn = new SqlConnection("Server=DESKTOP-R7V17QH\\PAAVAISQLEXPRESS; Database=SMASCSE; Integrated Security=SSPI");

        public staffpwdrest()
        {
            InitializeComponent();
        }

        private void staffpwdrest_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand newcom = conn.CreateCommand();
            newcom.CommandType = CommandType.Text;
            newcom.CommandText = "update csestaff set password = '" + Textbox2.Text + "' where password = '" + Textbox1.Text + "'";
            newcom.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Password reseted successfully");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stafflogin r = new Stafflogin();
            r.Show();
            this.Hide();
        }
    }
}
