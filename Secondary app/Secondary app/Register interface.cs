using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secondary_app
{
    public partial class Register_interface : Form
    {

        private Form1 firstform;

        public Register_interface(Form1 form)
        {
            InitializeComponent();
            firstform = form;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Visible = false;

            firstform.pomString_username = textBox1.Text;
            firstform.pomString_password = textBox2.Text;
           

            if (textBox2.Text != textBox3.Text)
            {
                label4.Visible = true;
            }

            else
            {
                this.Close();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
