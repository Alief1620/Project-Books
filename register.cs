using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Proby
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void close_MouseEnter(object sender, EventArgs e)
        {
            close.ForeColor = Color.Red;
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.ForeColor = Color.Black;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (regName.Text=="")
            {
                MessageBox.Show("Write name,please");
                return;
            }
            if (regSurname.Text == "")
            {
                MessageBox.Show("Write surname,please");
                return;
            }
            if (regLogin.Text == "")
            {
                MessageBox.Show("Write login,please");
                return;
            }
            if (regPass.Text == "")
            {
                MessageBox.Show("Write password,please");
                return;
            }

            if (isUserExists())
            {
                return;
                
            }

            data db = new data();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `pass`, `name`, `surname`) VALUES (@login,@pass,@name,@surname);",db.getConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = regLogin.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = regPass.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = regName.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = regPass.Text;

            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Account has been created");
                
            else
                MessageBox.Show("Account has not been created");
            db.closeConnection();

        }

        public Boolean isUserExists()
        {
            data db = new data();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.getConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = regLogin.Text;
            

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("This user is already registered");
                return true;
            }
                
            else
                return false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void regSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void regPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void regLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void regName_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
