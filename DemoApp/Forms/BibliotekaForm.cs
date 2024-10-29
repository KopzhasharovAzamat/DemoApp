using Microsoft.Data.SqlClient;
using System.Data;

namespace DemoApp.Forms
{
    public partial class BibliotekaForm : Form
    {
        private Database db = new();
        public BibliotekaForm()
        {
            InitializeComponent();
            LoadDataFromDatabase();
        }

        public void LoadDataFromDatabase()
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                db.openCon();

                // Создаем SQL-запрос для добавления новой записи
                string query = "INSERT INTO Biblioteka (Nazvanie, Adres, Gorod) VALUES (@Nazvanie, @Adres, @Gorod)";
                SqlCommand cmd = new SqlCommand(query, db.getCon());

                // Присваиваем значения параметрам
                cmd.Parameters.AddWithValue("@Nazvanie", nazvanieTextBox.Text); // TextBox для названия библиотеки
                cmd.Parameters.AddWithValue("@Adres", adresTextBox.Text); // TextBox для адреса
                cmd.Parameters.AddWithValue("@Gorod", gorodTextBox.Text); // TextBox для города

                // Выполняем запрос
                cmd.ExecuteNonQuery();

                MessageBox.Show("Запись успешно добавлена.");
                LoadDataFromDatabase();
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


        private void EditButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите запись для редактирования.");
                return;
            }

            try
            {
                db.openCon();

                // Получаем ID выбранной записи
                int bibliotekaID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["BibliotekaID"].Value);

                // Создаем SQL-запрос для обновления записи
                string query = "UPDATE Biblioteka SET Nazvanie = @Nazvanie, Adres = @Adres, Gorod = @Gorod WHERE BibliotekaID = @BibliotekaID";
                SqlCommand cmd = new SqlCommand(query, db.getCon());

                // Присваиваем значения параметрам
                cmd.Parameters.AddWithValue("@BibliotekaID", bibliotekaID);
                cmd.Parameters.AddWithValue("@Nazvanie", nazvanieTextBox.Text);
                cmd.Parameters.AddWithValue("@Adres", adresTextBox.Text);
                cmd.Parameters.AddWithValue("@Gorod", gorodTextBox.Text);

                // Выполняем запрос
                cmd.ExecuteNonQuery();

                MessageBox.Show("Запись успешно обновлена.");
                LoadDataFromDatabase();
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

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите запись для удаления.");
                return;
            }

            try
            {
                db.openCon();

                // Получаем ID выбранной записи
                int bibliotekaID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["BibliotekaID"].Value);

                // Создаем SQL-запрос для удаления записи
                string query = "DELETE FROM Biblioteka WHERE BibliotekaID = @BibliotekaID";
                SqlCommand cmd = new SqlCommand(query, db.getCon());

                // Присваиваем значение параметру
                cmd.Parameters.AddWithValue("@BibliotekaID", bibliotekaID);

                // Выполняем запрос
                cmd.ExecuteNonQuery();

                MessageBox.Show("Запись успешно удалена.");
                LoadDataFromDatabase();
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
        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                db.openCon();

                // Создаем SQL-запрос для поиска записей только по searchTextBox
                string query = "SELECT * FROM Biblioteka WHERE Nazvanie LIKE @SearchText OR Adres LIKE @SearchText OR Gorod LIKE @SearchText";
                SqlCommand cmd = new SqlCommand(query, db.getCon());

                // Используем значение из searchTextBox для поиска
                cmd.Parameters.AddWithValue("@SearchText", "%" + searchTextBox.Text + "%");

                // Выполняем запрос и заполняем DataTable
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

        private void RefreshTableButton_Click(object sender, EventArgs e)
        {
            LoadDataFromDatabase();
        }
    }
}
