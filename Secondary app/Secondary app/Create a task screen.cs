using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

struct TaskItem
{
    string name;
    DateTime deadline;
    string priority;
    string description;
}

namespace Secondary_app
{

    public partial class Create_a_task_screen : Form
    {

        TaskItem[] tasks;

        public Create_a_task_screen()
        {
            InitializeComponent();
            tasks = new TaskItem[25];

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
