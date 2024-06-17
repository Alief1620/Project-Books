using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Proby
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();

        }

        private void MainPage_Load(object sender, EventArgs e)
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenBookDetail("Название книги 1", "Автор 1", "Описание книги 1");


        }

        private void OpenBookDetail(string title, string author, string description)
        {
            this.Hide();
            BookDetailForm bookDetailForm = new BookDetailForm(title, author, description);
            bookDetailForm.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenBookDetail2("Название книги 2", "Автор 2", "Описание книги 2");

        }


        private void OpenBookDetail2(string name, string author, string description)
        {
            this.Hide();
            text bookDetailForm2 = new text(name, author, description);
            bookDetailForm2.Show();
        }


        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_2(object sender, EventArgs e)
        {

        }
    }
}
