using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRPOProject
{
    public partial class GetInfoForm : Form
    {
        public GetInfoForm()
        {
            InitializeComponent();
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void labelExit_MouseLeave(object sender, EventArgs e)
        {
            labelExit.BackColor = Color.FromArgb(34, 36, 49);
        }

        private void labelExit_MouseMove(object sender, MouseEventArgs e)
        {
            labelExit.BackColor = Color.Red;
        }

        private void textBoxNumber_TextChanged(object sender, EventArgs e)
        {
            panelNumber.BackColor = Color.FromArgb(78, 184, 206);
            textBoxNumber.ForeColor = Color.FromArgb(78, 184, 206);
        }

        private void textBoxNumber_Click(object sender, EventArgs e)
        {
            textBoxNumber.Clear();
            panelNumber.BackColor = Color.FromArgb(78, 184, 206);
            textBoxNumber.ForeColor = Color.FromArgb(78, 184, 206);
        }
    }
}
