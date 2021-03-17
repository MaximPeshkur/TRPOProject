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
using System.Data.SqlClient;

namespace TRPOProject
{
    public partial class RegistredForm : Form
    {
        private SqlConnection db;

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
            textBoxPassword.PasswordChar = '•';
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
            if (comboBoxPosition.SelectedIndex != 0 && comboBoxPosition.SelectedIndex !=1)
            {
                MessageBox.Show("Выберите должность");
                return;
            }
            if (comboBoxPosition.SelectedIndex == 0 && textBoxKeyWrite.Text != "Admin")
            {
                MessageBox.Show("Неверный ключ администратора");
                return;
            }
            
            if (isUserExists())
                return;
            
            db = new SqlConnection(LoginForm.get_cs());
            db.Open();
            SqlCommand cmd = db.CreateCommand();
            cmd.CommandText = "insert into worker(worker_login, worker_password, worker_name, worker_surname, worker_position_id) values ( @login, @password, @name, @surname, @position )";
            cmd.Parameters.Add("@login", System.Data.DbType.String).Value = textBoxUsername.Text;
            cmd.Parameters.Add("@password", System.Data.DbType.String).Value = textBoxPassword.Text;
            cmd.Parameters.Add("@name", System.Data.DbType.String).Value = textBoxName.Text;
            cmd.Parameters.Add("@surname", System.Data.DbType.String).Value = textBoxSurname.Text;
            cmd.Parameters.Add("@position", System.Data.DbType.Int32).Value = (comboBoxPosition.SelectedIndex + 1);           
            if (cmd.ExecuteNonQuery()==1)
            {
                MessageBox.Show("Регистрация прошла успешно");
            }
            else
            {
                MessageBox.Show("Ошибка при регистрации");
            }
            db.Close();
        }

        public bool isUserExists()
        {
            db = new SqlConnection(LoginForm.get_cs());
            db.Open(); 
            SqlCommand CMD = db.CreateCommand();
            CMD.CommandText = "select * from worker where worker_login = @login";
            CMD.Parameters.Add("@login", System.Data.DbType.String).Value = textBoxUsername.Text;
            SqlDataReader SQL = CMD.ExecuteReader();

            if (SQL.HasRows)
            {
                MessageBox.Show("Логин занят. Пожалуйста, введите другой");
                db.Close();
                return true;
            }
            else
            {
                db.Close();
                return false;
            }
        }

        private void pictureBoxVisible_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.PasswordChar == '•')
            {
                pictureBoxVisible.Image = Properties.Resources.visible_blue;
                textBoxPassword.PasswordChar = '\0';
            }
            else
            {
                pictureBoxVisible.Image = Properties.Resources.visible_white;
                textBoxPassword.PasswordChar = '•';
            }
        }

        private void comboBoxPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPosition.SelectedIndex == 0)
            {
                textBoxKey.Visible = true;
                panelKey.Visible = true;
                textBoxKeyWrite.Visible = true;
            }
            else
            {
                textBoxKey.Visible = false;
                panelKey.Visible = false;
                textBoxKeyWrite.Visible = false;
            }
             
            
        }

        private void textBoxKeyWrite_Click(object sender, EventArgs e)
        {
            textBoxKeyWrite.Text = "";
            panelKey.BackColor = Color.FromArgb(78, 184, 206);
            textBoxKeyWrite.ForeColor = Color.FromArgb(78, 184, 206);

            panelSurname.BackColor = Color.White;
            textBoxSurname.ForeColor = Color.White;

            pictureBoxUsername.Image = Properties.Resources.user_white;
            panelUsername.BackColor = Color.White;
            textBoxUsername.ForeColor = Color.White;

            pictureBoxPassword.Image = Properties.Resources.lock_white;
            panelPassword.BackColor = Color.White;
            textBoxPassword.ForeColor = Color.White;

            panelName.BackColor = Color.White;
            textBoxName.ForeColor = Color.White;
        }
    }
}
