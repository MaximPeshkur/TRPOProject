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
    public partial class AddOrderForm : Form
    {
        public AddOrderForm()
        {
            InitializeComponent();
            string sql = $"select product_name from product";
            SqlConnection db = new SqlConnection(LoginForm.get_cs());
            db.Open();
            SqlCommand command = new SqlCommand(sql, db);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader[0].ToString());
            }
            reader.Close();
            db.Close();
        }
        


        private void buttonRegisration_Click(object sender, EventArgs e)
        {
            SqlConnection db;
            db = new SqlConnection(LoginForm.get_cs());
            db.Open();
            SqlCommand cmd = db.CreateCommand();
            cmd.CommandText = "insert into [order]([order_cost], [order_date], [order_worker_id]) values (@cost, @date, @workerid)";
            cmd.Parameters.Add("@cost", System.Data.DbType.String).Value = textBox1.Text;
            cmd.Parameters.Add("@date", System.Data.DbType.String).Value = DateTime.Now;
            cmd.Parameters.Add("@workerid", System.Data.DbType.String).Value = Global.GlobalVar;
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Заказ добавлен!");
                MainForm mainForm = new MainForm();
                string com = "select top 1 order_id from [order] order by order_id desc";
                int ID = 0;
                SqlCommand command = new SqlCommand(com, db);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ID = Convert.ToInt32(reader[0].ToString());
                }
                reader.Close();
                int ProductID = 0;
                int ProductCount = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    string com1 = "select product_id from [product] where product_name='" + dataGridView1[0, i].Value.ToString() + "'";
                    SqlCommand command1 = new SqlCommand(com1, db);
                    SqlDataReader reader1 = command1.ExecuteReader();
                    while (reader1.Read())
                    {
                        ProductID = Convert.ToInt32(reader1[0].ToString());
                        ProductCount = Convert.ToInt32(dataGridView1[2, i].Value.ToString());
                    }
                    reader1.Close();
                    cmd.CommandText = $"insert into [ordered_product]([ordered_product_count], [ordered_product_product_id], [ordered_product_order_id]) values ({ProductCount}, {ProductID}, {ID})";
                    cmd.ExecuteNonQuery();
                }
                
                this.Hide();
                mainForm.Show();  
            }
            else
            {

                MessageBox.Show("Ошибка добавления!");
            }
            db.Close();

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



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = $"select product.product_name, category.category_name,product.product_price from product inner join category on product_category_id = category.category_id where (product.product_name='{comboBox1.SelectedItem.ToString()}')";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
            SqlConnection connection = new SqlConnection(LoginForm.get_cs());
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[4]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][3] = reader[2].ToString();
            }

            reader.Close();
            connection.Close();
            foreach (var s in data)
            {
                dataGridView1.Rows.Add(s);
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dataGridView1[2, i].Value) * Convert.ToDouble(dataGridView1[3, i].Value);
            }
            textBox1.Text = sum.ToString();
        }
    }
}
