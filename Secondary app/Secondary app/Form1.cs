using System.Security.Cryptography.Pkcs;
using System.Security.Cryptography.X509Certificates;

namespace Secondary_app
{
    public partial class Form1 : Form
    {
        private string username;
        private string password;
        bool username_check = false;
        bool password_check = false;

        public Form1()
        {
            InitializeComponent();
            username = "da";
            password = "123";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            label4.Visible = false;

            if (textBox1.Text == username)
            {
                username_check = true;
            }

            if (textBox1.Text != username)
            {
                label3.Visible = true;
            }

            if (textBox2.Text == password)
            {
                password_check = true;
            }

            if (textBox2.Text != password)
            {
                label4.Visible = true;
            }

            if (username_check == true && password_check == true)
            {
                Main_menu_screen main_menu_screen = new Main_menu_screen();

                main_menu_screen.Show();
            }

        }

        



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public string pomString_username
        {
            get { return username; }
            set
            {
                username = value;
                textBox1.Text = username;
            }
        }

        public string pomString_password
        {
            get { return password; }
            set
            {
                password = value;
                textBox2.Text = password;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                Register_interface register = new Register_interface(this);

                register.Show();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       



    }

}