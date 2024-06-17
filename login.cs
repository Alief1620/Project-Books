using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Proby
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void close_MouseEnter(object sender, EventArgs e)
        {
            close.ForeColor= Color.Red;
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.ForeColor = Color.Black;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (loginField.Text == "")
            {
                MessageBox.Show("Write login,please");
                return;
            }
            if (passField.Text == "")
            {
                MessageBox.Show("Write password,please");
                return;
            }
            String loginUser = loginField.Text;
            String passUser = passField.Text;

            data db = new data();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND pass = @uP",db.getConnection());
            
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;
            
            adapter.SelectCommand = command;
            adapter.Fill(table);



            if (table.Rows.Count > 0)
            {
                this.Hide();
                MainPage mainPage = new MainPage();
                mainPage.Show();
            }
            else
                MessageBox.Show("User not found");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            register register = new register();
            register.Show();
        }
    }
}
