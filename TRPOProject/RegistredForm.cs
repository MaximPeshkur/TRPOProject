using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace TRPOProject
{
    public partial class RegistredForm : Form
    {
        private SQLiteConnection DB;
        public RegistredForm()
        {
            InitializeComponent();
        }

        
        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm frm1 = new LoginForm();
            frm1.Show();
        }

        Point lastPoint;
        private void RegistredForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void RegistredForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            label3.BackColor = Color.Red;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.BackColor = Color.FromArgb(34, 36, 49);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            pictureBox1.Image = Properties.Resources.user_blue;
            panel1.BackColor = Color.FromArgb(78, 184, 206);
            textBox1.ForeColor = Color.FromArgb(78, 184, 206);

            pictureBox2.Image = Properties.Resources.lock_white;
            panel2.BackColor = Color.White;
            textBox2.ForeColor = Color.White;

            panel3.BackColor = Color.White;
            textBox3.ForeColor = Color.White;

            panel4.BackColor = Color.White;
            textBox4.ForeColor = Color.White;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            pictureBox2.Image = Properties.Resources.lock_blue;
            panel2.BackColor = Color.FromArgb(78, 184, 206);
            textBox2.ForeColor = Color.FromArgb(78, 184, 206);

            pictureBox1.Image = Properties.Resources.user_white;
            panel1.BackColor = Color.White;
            textBox1.ForeColor = Color.White;

            panel3.BackColor = Color.White;
            textBox3.ForeColor = Color.White;

            panel4.BackColor = Color.White;
            textBox4.ForeColor = Color.White;
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox5.Visible = true;
            textBox3.Text = "";
            panel3.BackColor = Color.FromArgb(78, 184, 206);
            textBox3.ForeColor = Color.FromArgb(78, 184, 206);

            pictureBox1.Image = Properties.Resources.user_white;
            panel1.BackColor = Color.White;
            textBox1.ForeColor = Color.White;

            pictureBox2.Image = Properties.Resources.lock_white;
            panel2.BackColor = Color.White;
            textBox2.ForeColor = Color.White;

            panel4.BackColor = Color.White;
            textBox4.ForeColor = Color.White;
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox6.Visible = true;
            textBox4.Text = "";
            panel4.BackColor = Color.FromArgb(78, 184, 206);
            textBox4.ForeColor = Color.FromArgb(78, 184, 206);

            pictureBox1.Image = Properties.Resources.user_white;
            panel1.BackColor = Color.White;
            textBox1.ForeColor = Color.White;

            pictureBox2.Image = Properties.Resources.lock_white;
            panel2.BackColor = Color.White;
            textBox2.ForeColor = Color.White;

            panel3.BackColor = Color.White;
            textBox3.ForeColor = Color.White;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '•';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.user_blue;
            panel1.BackColor = Color.FromArgb(78, 184, 206);
            textBox1.ForeColor = Color.FromArgb(78, 184, 206);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB = new SQLiteConnection("Data Source = DataBase.db; Version = 3");
            DB.Open();
            SQLiteCommand CMD = DB.CreateCommand();
            CMD.CommandText = "insert into Users(Login, Password) values ( @login, @password )";
            CMD.Parameters.Add("@login", System.Data.DbType.String).Value = textBox1.Text;
            CMD.Parameters.Add("@password", System.Data.DbType.String).Value = textBox2.Text;
            if (CMD.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Регистрация прошла успешно");
            }
            else
            {
                MessageBox.Show("Ошибка при регистрации");
            }

            DB.Close();

        }

    }
}
