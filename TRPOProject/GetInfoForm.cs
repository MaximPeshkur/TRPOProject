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

        private void buttonRegisration_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string sql = $"select  order_date, product_name, ordered_product_count, product_price, order_cost from [order] inner join ordered_product on order_id = ordered_product_order_id inner join product on product_id = ordered_product_product_id where(order_id= {Convert.ToInt32(textBoxNumber.Text)})";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
            SqlConnection connection = new SqlConnection(LoginForm.get_cs());
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            int count = 0;
            while (reader.Read())
            {
                data.Add(new string[5]);
                if (count==0)
                {
                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();

                }
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                count++;

            }
            reader.Close();
            connection.Close();
            foreach (var s in data)
            {
                dataGridView1.Rows.Add(s);
            }



        }

        private void textBoxNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonRegisration_Click(sender, e);
            }
        }
    }
}
