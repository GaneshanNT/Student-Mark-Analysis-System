﻿using System;
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
    public partial class selectstudent : Form
    {
        public selectstudent()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                if (comboBox2.SelectedIndex == 0)
                {

                }
                if (comboBox2.SelectedIndex == 1)
                {

                }
                if (comboBox2.SelectedIndex == 2)
                {

                }
                if (comboBox2.SelectedIndex == 3)
                {

                }
            }
        }
    }
}
