using System.Xml.Linq;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PR_4
{
    public partial class Form1 : Form
    {
        string connectionString = "Server=localhost;Database=testDB;User Id=YourUsername;Password=1111;";
        public Form1()
        {
            InitializeComponent();
        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadPartners();
        }

        private void dataGridPartners_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadPartners()
        {
            string query = "SELECT PartnerID, Name, Phone, Rating, TotalSales FROM Partners";
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt);
            }

            // Добавляем расчет скидки для каждой строки
            dt.Columns.Add("Discount", typeof(int)); // Добавляем новый столбец для скидки

            foreach (DataRow row in dt.Rows)
            {
                decimal totalSales = Convert.ToDecimal(row["TotalSales"]);
                row["Discount"] = CalculateDiscount(totalSales); // Вычисляем скидку
            }

            // Привязываем таблицу к DataGridView
            dataGridPartners.DataSource = dt;
        }


        // Добавление партнера
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Partners (Name, Phone, Rating, TotalSales) VALUES (@Name, @Phone, @Rating, @Sales)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", textName.Text);
                cmd.Parameters.AddWithValue("@Phone", textPhone.Text);
                cmd.Parameters.AddWithValue("@Rating", int.Parse(textRating.Text));
                cmd.Parameters.AddWithValue("@Sales", decimal.Parse(textSales.Text));

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            LoadPartners();
            ClearInputs();
        }


        // Редактирование партнера
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridPartners.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridPartners.SelectedRows[0].Cells["PartnerID"].Value);
                string query = "UPDATE Partners SET Name = @Name, Phone = @Phone, Rating = @Rating, TotalSales = @Sales WHERE PartnerID = @ID";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Name", textName.Text);
                    cmd.Parameters.AddWithValue("@Phone", textPhone.Text);
                    cmd.Parameters.AddWithValue("@Rating", int.Parse(textRating.Text));
                    cmd.Parameters.AddWithValue("@Sales", decimal.Parse(textSales.Text));
                    cmd.Parameters.AddWithValue("@ID", id);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                LoadPartners();
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Выберите партнера для редактирования.");
            }
        }


        // Удаление партнера
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridPartners.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridPartners.SelectedRows[0].Cells["PartnerID"].Value);
                string query = "DELETE FROM Partners WHERE PartnerID = @ID";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID", id);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                LoadPartners();
            }
            else
            {
                MessageBox.Show("Выберите партнера для удаления.");
            }
        }

        // Очистка полей ввода
        private void ClearInputs()
        {
            textName.Clear();
            textPhone.Clear();
            textRating.Clear();
            textSales.Clear();
        }

        private int CalculateDiscount(decimal totalSales)
        {
            if (totalSales <= 10000) return 0;
            if (totalSales <= 50000) return 5;
            if (totalSales <= 300000) return 10;
            return 15;
        }
        // Обновление данных
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadPartners();
        }
    }
}

