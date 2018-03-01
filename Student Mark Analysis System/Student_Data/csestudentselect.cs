using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Mark_Analysis_System
{
    public partial class csestudentselect : Form
    {
        public csestudentselect()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            csestudent s = new csestudent();
            s.Show();
            this.Hide();
        }
    }
}
