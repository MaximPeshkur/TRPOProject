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

    
    public partial class LoginForm : Form
    {
        private SqlConnection db;
        public static bool isAdmin = false;
        public LoginForm()
        {
            InitializeComponent();
        }
        public static string get_cs()
        {
            return "Data Source =DESKTOP-6T61F9U\\SQLEXPRESS; Initial Catalog = PIMShop; User ID = sa; Password = 123456789";
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
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistredForm frm2 = new RegistredForm();
            frm2.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastPoint;
        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            labelExit.BackColor = Color.Red;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            labelExit.BackColor = Color.FromArgb(34, 36, 49);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            pictureBoxUsername.Image = Properties.Resources.user_blue;
            panelUsername.BackColor = Color.FromArgb(78, 184, 206);
            textBoxUsername.ForeColor = Color.FromArgb(78, 184, 206);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            db = new SqlConnection(get_cs());
            db.Open();
            SqlCommand cmd = db.CreateCommand();
            cmd.CommandText = "select * from worker where worker_login = @login and worker_password = @password";
            cmd.Parameters.Add("@login", System.Data.DbType.String).Value = textBoxUsername.Text;
            cmd.Parameters.Add("@password", System.Data.DbType.String).Value = textBoxPassword.Text;
            SqlDataReader SQL = cmd.ExecuteReader();
            if (SQL.HasRows)
            {
                
                while (SQL.Read())
                {
                    isAdmin = Convert.ToInt32(SQL.GetValue(4)) == 1;
                }
                MainForm mainFrm = new MainForm();
                this.Hide();
                mainFrm.Show();
                SQL.Close();
                using (SqlCommand seccommand = new SqlCommand($"select worker_id from worker where (worker_login='{textBoxUsername.Text}' and worker_password='{textBoxPassword.Text}')", db))
                {
                    SqlDataReader secreader = seccommand.ExecuteReader();
                    while (secreader.Read())
                    {
                        Global.GlobalVar = int.Parse(secreader["worker_id"].ToString());
                    }

                }
                
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
            
            db.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
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




        private void textBoxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2_Click(sender, e);
                textBoxPassword.Focus();
                textBoxPassword.SelectionStart = textBoxPassword.Text.Length;
            }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e); 
            }
        }
    }
}
