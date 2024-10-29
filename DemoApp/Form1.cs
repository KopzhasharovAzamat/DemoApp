using Microsoft.Data.SqlClient;
using System.Data;

namespace DemoApp
{
    public partial class Form1 : Form
    {
        private Database db = new Database();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                db.openCon();

                // Создаем SQL-запрос
                SqlCommand cmd = new SqlCommand("SELECT * FROM Biblioteka", db.getCon());

                // Используем SqlDataAdapter для выполнения запроса и заполнения DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                // Заполняем DataGridView данными из DataTable
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.closeCon();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                db.openCon();

                // Создаем SQL-запрос
                SqlCommand cmd = new SqlCommand("SELECT * FROM FondBiblioteki", db.getCon());

                // Используем SqlDataAdapter для выполнения запроса и заполнения DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                // Заполняем DataGridView данными из DataTable
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.closeCon();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                db.openCon();

                // Создаем SQL-запрос
                SqlCommand cmd = new SqlCommand("SELECT * FROM TipLiteratury", db.getCon());

                // Используем SqlDataAdapter для выполнения запроса и заполнения DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                // Заполняем DataGridView данными из DataTable
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.closeCon();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                db.openCon();

                // Создаем SQL-запрос
                SqlCommand cmd = new SqlCommand("SELECT * FROM Sotrudniki", db.getCon());

                // Используем SqlDataAdapter для выполнения запроса и заполнения DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                // Заполняем DataGridView данными из DataTable
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.closeCon();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                db.openCon();

                // Создаем SQL-запрос
                SqlCommand cmd = new SqlCommand("SELECT * FROM PopolnenieFonda", db.getCon());

                // Используем SqlDataAdapter для выполнения запроса и заполнения DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                // Заполняем DataGridView данными из DataTable
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.closeCon();
            }
        }
    }
}