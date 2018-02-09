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
    public partial class Stafflogin : Form
    {
        public static string settext = "";
        public Stafflogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Server=DESKTOP-R7V17QH\\PAAVAISQLEXPRESS; Database=SMASCSE; Integrated Security=SSPI");

            conn.Open();
            String newcom = "SELECT username, password " + "FROM csestaff " + "WHERE username = '" + Textbox1.Text + "' AND password = '" + Textbox2.Text + "'";

            SqlDataAdapter adp = new SqlDataAdapter(newcom, conn);

            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count >= 1)
            {
                settext = Textbox1.Text;
                Staffdashboard wc = new Staffdashboard();
                wc.Show();
                this.Hide();
            }

            else
            {
                label4.Text = "Invalid login";
            }
        }
    }
}
