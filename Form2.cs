using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CAESAR_lisflood_1._0
{
    public partial class Form2 : System.Windows.Forms.Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form2_Leave(object sender, EventArgs e)
        {
            caesar1.Form1.checkBox2.Checked = false;
        }

        private void Form2_Leave(object sender, FormClosedEventArgs e)
        {

        }


    }
}
