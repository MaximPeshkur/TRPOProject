using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRPOProject
{
    public partial class StatisticForm : Form
    {
        public StatisticForm()
        {
            InitializeComponent();
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void StatisticForm_Load(object sender, EventArgs e)
        {

        }

        private void fileName_TextChanged(object sender, EventArgs e)
        {
            panelNumber.BackColor = Color.FromArgb(78, 184, 206);
            fileName.ForeColor = Color.FromArgb(78, 184, 206);
        }

        private void fileName_Click(object sender, EventArgs e)
        {
            fileName.Clear();
            panelNumber.BackColor = Color.FromArgb(78, 184, 206);
            fileName.ForeColor = Color.FromArgb(78, 184, 206);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        public string categoryCounts(string data, DateTime start, DateTime finish)
        {
            SqlConnection db = new SqlConnection(LoginForm.get_cs());
            db.Open();
            SqlCommand cmd = db.CreateCommand();
            cmd.CommandText = "select * from [category]";
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                int totalCount;
                while (reader.Read())
                {
                    totalCount = 0;

                    string name = reader.GetValue(1).ToString();
                    int category_id = Convert.ToInt32(reader.GetValue(0));

                    SqlConnection db1 = new SqlConnection(LoginForm.get_cs());
                    db1.Open();
                    SqlCommand cmd1 = db1.CreateCommand();
                    cmd1.CommandText = "select * from [ordered_product]";
                    SqlDataReader reader1 = cmd1.ExecuteReader();
                    if (reader1.HasRows)
                    {
                        while (reader1.Read())
                        {
                            int count = Convert.ToInt32(reader1.GetValue(1));
                            int product_id = Convert.ToInt32(reader1.GetValue(2));
                            int order_id = Convert.ToInt32(reader1.GetValue(3));

                            if (start < GetOrderDate(order_id) && finish > GetOrderDate(order_id) && category_id == GetProductCategory(product_id))
                            {
                                totalCount += count;
                            }
                        }

                        data += $"\n\nколичество продаж в категории '{name}': {totalCount}";
                    }
                }
            }

            return data;
        }

        private int GetProductCategory(int product_id)
        {
            SqlConnection db = new SqlConnection(LoginForm.get_cs());
            db.Open();
            SqlCommand cmd = db.CreateCommand();
            cmd.CommandText = "select * from [product] where [product_id] = @product_id";
            cmd.Parameters.Add("@product_id", DbType.Int32).Value = product_id;
            SqlDataReader reader = cmd.ExecuteReader();

            int id = -1;

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader.GetValue(3));
                }
            }
            else
            {
                MessageBox.Show("Нет записей");
            }

            return id;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SqlConnection db = new SqlConnection(LoginForm.get_cs());
            db.Open();
            SqlCommand cmd = db.CreateCommand();
            cmd.CommandText = "select * from [ordered_product]";
            DateTime start = Convert.ToDateTime(dateTimePicker1.Value);
            DateTime finish = Convert.ToDateTime(dateTimePicker2.Value);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                string data = "---------[ОТЧЕТ]---------\n\n";
                data += $"C: {DateFormatter(start)} по {DateFormatter(finish)}\n\n";

                int totalCount = 0;

                while (reader.Read())
                {
                    int count = Convert.ToInt32(reader.GetValue(1));
                    int order_id = Convert.ToInt32(reader.GetValue(3));

                    if (start < GetOrderDate(order_id) && finish > GetOrderDate(order_id))
                    {
                        totalCount += count;
                    }
                }

                data += $"количество продаж всего: ";


                if (totalCount != 0)
                {
                    data += totalCount;
                    data = categoryCounts(data, start, finish);
                    data += "\n\n© 2021 | PIMShop";
                    MessageBox.Show(data);
                    GenerateReport(data, fileName.Text, start, finish);
                }
                else
                {
                    MessageBox.Show("Нет записей");
                }
            }
            else
            {
                MessageBox.Show("Нет записей");
            }
            db.Close();
        }

        private void GenerateReport(string report, string fileName, DateTime start, DateTime finish)
        {
            if (fileName.Length == 0)
            {
                MessageBox.Show("Недопустимое имя файла!");
            }
            else
            {
                StreamWriter w = new StreamWriter($"{fileName}_report_{DateFormatter(start)}_{DateFormatter(finish)}.txt", false, Encoding.GetEncoding(1251));
                
                    w.Write(report);
                w.Close();
            }
        }

        private string DateFormatter(DateTime date)
        {
            return date.ToString().Split(' ')[0].Replace('/', '-');
        }

        private DateTime GetOrderDate(int order_id)
        {
            SqlConnection db = new SqlConnection(LoginForm.get_cs());
            db.Open();
            SqlCommand cmd = db.CreateCommand();
            cmd.CommandText = "select * from [order] where [order_id] = @order_id";
            cmd.Parameters.Add("@order_id", DbType.Int32).Value = order_id;
            SqlDataReader reader = cmd.ExecuteReader();

            DateTime date = DateTime.Now;

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    date = Convert.ToDateTime(reader.GetValue(2));
                }
            }
            else
            {
                MessageBox.Show("Нет записей");
            }

            return date;
        }
    }
}
