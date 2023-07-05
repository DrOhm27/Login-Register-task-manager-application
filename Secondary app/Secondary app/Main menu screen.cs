using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secondary_app
{
    public partial class Main_menu_screen : Form
    {
        public Main_menu_screen()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Create_a_task_screen create_a_task_screen = new Create_a_task_screen();

            create_a_task_screen.Show();
        }
    }
}
