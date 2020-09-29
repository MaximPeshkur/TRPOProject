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
            labelExit.BackColor = Color.Red;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            labelExit.BackColor = Color.FromArgb(34, 36, 49);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBoxUsername.Clear();
            pictureBoxUsername.Image = Properties.Resources.user_blue;
            panelUsername.BackColor = Color.FromArgb(78, 184, 206);
            textBoxUsername.ForeColor = Color.FromArgb(78, 184, 206);

            pictureBoxPassword.Image = Properties.Resources.lock_white;
            panelPassword.BackColor = Color.White;
            textBoxPassword.ForeColor = Color.White;

            panelSurname.BackColor = Color.White;
            textBoxSurname.ForeColor = Color.White;

            panelName.BackColor = Color.White;
            textBoxName.ForeColor = Color.White;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBoxPassword.Text = "";
            pictureBoxPassword.Image = Properties.Resources.lock_blue;
            panelPassword.BackColor = Color.FromArgb(78, 184, 206);
            textBoxPassword.ForeColor = Color.FromArgb(78, 184, 206);

            pictureBoxUsername.Image = Properties.Resources.user_white;
            panelUsername.BackColor = Color.White;
            textBoxUsername.ForeColor = Color.White;

            panelSurname.BackColor = Color.White;
            textBoxSurname.ForeColor = Color.White;

            panelName.BackColor = Color.White;
            textBoxName.ForeColor = Color.White;
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBoxHiddenSurname.Visible = true;
            textBoxSurname.Text = "";
            panelSurname.BackColor = Color.FromArgb(78, 184, 206);
            textBoxSurname.ForeColor = Color.FromArgb(78, 184, 206);

            pictureBoxUsername.Image = Properties.Resources.user_white;
            panelUsername.BackColor = Color.White;
            textBoxUsername.ForeColor = Color.White;

            pictureBoxPassword.Image = Properties.Resources.lock_white;
            panelPassword.BackColor = Color.White;
            textBoxPassword.ForeColor = Color.White;

            panelName.BackColor = Color.White;
            textBoxName.ForeColor = Color.White;
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBoxHiddenName.Visible = true;
            textBoxName.Text = "";
            panelName.BackColor = Color.FromArgb(78, 184, 206);
            textBoxName.ForeColor = Color.FromArgb(78, 184, 206);

            pictureBoxUsername.Image = Properties.Resources.user_white;
            panelUsername.BackColor = Color.White;
            textBoxUsername.ForeColor = Color.White;

            pictureBoxPassword.Image = Properties.Resources.lock_white;
            panelPassword.BackColor = Color.White;
            textBoxPassword.ForeColor = Color.White;

            panelSurname.BackColor = Color.White;
            textBoxSurname.ForeColor = Color.White;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            pictureBoxUsername.Image = Properties.Resources.user_blue;
            panelUsername.BackColor = Color.FromArgb(78, 184, 206);
            textBoxUsername.ForeColor = Color.FromArgb(78, 184, 206);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "" || textBoxUsername.Text == "Username")
            {
                MessageBox.Show("Введите логин");
                return;
            }
            if (textBoxPassword.Text == "" || textBoxPassword.Text == "Password")
            {
                MessageBox.Show("Введите пароль");
                return;
            }
            if (textBoxName.Text == "" || textBoxName.Text == "Name")
            {
                MessageBox.Show("Введите имя");
                return;
            }
            if (textBoxSurname.Text == "" || textBoxSurname.Text == "Surname")
            {
                MessageBox.Show("Введите фамилию");
                return;
            }
            if (isUserExists())
                return;
            DB = new SQLiteConnection("Data Source = DataBase.db; Version = 3");
            DB.Open();
            SQLiteCommand CMD = DB.CreateCommand();
            CMD.CommandText = "insert into Users(Login, Password, Name, Surname) values ( @login, @password, @name, @surname )";
            CMD.Parameters.Add("@login", System.Data.DbType.String).Value = textBoxUsername.Text;
            CMD.Parameters.Add("@password", System.Data.DbType.String).Value = textBoxPassword.Text;
            CMD.Parameters.Add("@name", System.Data.DbType.String).Value = textBoxName.Text;
            CMD.Parameters.Add("@surname", System.Data.DbType.String).Value = textBoxSurname.Text;
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

        public bool isUserExists()
        {
            DB = new SQLiteConnection("Data Source = DataBase.db; Version = 3");
            DB.Open();
            SQLiteCommand CMD = DB.CreateCommand();
            CMD.CommandText = "select * from Users where Login = @login";
            CMD.Parameters.Add("@login", System.Data.DbType.String).Value = textBoxUsername.Text;
            SQLiteDataReader SQL = CMD.ExecuteReader();

            if (SQL.HasRows)
            {
                MessageBox.Show("Логин занят. Пожалуйста, введите другой");
                DB.Close();
                return true;
            }
            else
            {
                DB.Close();
                return false;
            }
        }

        private void pictureBoxVisible_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.UseSystemPasswordChar)
            {
                pictureBoxVisible.Image = Properties.Resources.visible_blue;
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                pictureBoxVisible.Image = Properties.Resources.visible_white;
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
