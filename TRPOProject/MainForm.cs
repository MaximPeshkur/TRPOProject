using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRPOProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelExit_MouseLeave(object sender, EventArgs e)
        {
            labelExit.BackColor = Color.FromArgb(34, 36, 49);
        }

        private void labelExit_MouseMove(object sender, MouseEventArgs e)
        {
            labelExit.BackColor = Color.Red;

        }

        private void AddRecbutton_MouseMove(object sender, MouseEventArgs e)
        {
            AddRecbutton.BackColor = Color.FromArgb(78, 184, 206);
            AddRecbutton.ForeColor = Color.FromArgb(34, 36, 49);
            AddRecbutton.Font = new Font("Arial", 14);
        }

        private void AddRecbutton_MouseLeave(object sender, EventArgs e)
        {
            AddRecbutton.BackColor = Color.FromArgb(34, 36, 49);
            AddRecbutton.ForeColor = Color.White;
            AddRecbutton.Font = new Font("Arial", 11);

        }

        private void DeleteRecbutton_MouseLeave(object sender, EventArgs e)
        {
            DeleteRecbutton.BackColor = Color.FromArgb(34, 36, 49);
            DeleteRecbutton.ForeColor = Color.White;
            DeleteRecbutton.Font = new Font("Arial", 11);

        }

        private void DeleteRecbutton_MouseMove(object sender, MouseEventArgs e)
        {
            
            DeleteRecbutton.BackColor = Color.FromArgb(78, 184, 206);
            DeleteRecbutton.ForeColor = Color.FromArgb(34, 36, 49);
            DeleteRecbutton.Font = new Font("Arial", 14);

        }

        private void Statisticsbutton_MouseLeave(object sender, EventArgs e)
        {
            Statisticsbutton.BackColor = Color.FromArgb(34, 36, 49);
            Statisticsbutton.ForeColor = Color.White;
            Statisticsbutton.Font = new Font("Arial", 11);

        }

        private void Statisticsbutton_MouseMove(object sender, MouseEventArgs e)
        {
            Statisticsbutton.BackColor = Color.FromArgb(78, 184, 206);
            Statisticsbutton.ForeColor = Color.FromArgb(34, 36, 49);
            Statisticsbutton.Font = new Font("Arial", 14);

        }

        private void GetInfobutton_MouseLeave(object sender, EventArgs e)
        {
            GetInfobutton.BackColor = Color.FromArgb(34, 36, 49);
            GetInfobutton.ForeColor = Color.White;
            GetInfobutton.Font = new Font("Arial", 11);

        }

        private void GetInfobutton_MouseMove(object sender, MouseEventArgs e)
        {
            GetInfobutton.BackColor = Color.FromArgb(78, 184, 206);
            GetInfobutton.ForeColor = Color.FromArgb(34, 36, 49);
            GetInfobutton.Font = new Font("Arial", 14);

        }

        private void GetInfobutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            GetInfoForm getInfoForm = new GetInfoForm();
            getInfoForm.Show();
        }


        private void AddRecbutton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AddOrderForm addOrderform = new AddOrderForm();
            addOrderform.Show();
        }

        private void DeleteRecbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteOrderForm del = new DeleteOrderForm();
            del.Show();
        }
    }
}
