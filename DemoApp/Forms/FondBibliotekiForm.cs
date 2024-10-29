using Microsoft.Data.SqlClient;
using System.Data;

namespace DemoApp.Forms;

public partial class FondBibliotekiForm : Form
{
    private Database db = new();

    public FondBibliotekiForm()
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
            var cmd = new SqlCommand("SELECT * FROM FondBiblioteki", db.getCon());

            // Используем SqlDataAdapter для выполнения запроса и заполнения DataTable
            var adapter = new SqlDataAdapter(cmd);
            var table = new DataTable();
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
            var query =
                "INSERT INTO FondBiblioteki (BibliotekaID, NazvanieFond, KolichestvoKnig, KolichestvoZurnalov, KolichestvoGazet, KolichestvoSbornikov, KolichestvoDissertacij, KolichestvoReferatov) " +
                "VALUES (@BibliotekaID, @NazvanieFond, @KolichestvoKnig, @KolichestvoZurnalov, @KolichestvoGazet, @KolichestvoSbornikov, @KolichestvoDissertacij, @KolichestvoReferatov)";
            var cmd = new SqlCommand(query, db.getCon());

            cmd.Parameters.AddWithValue("@BibliotekaID", bibliotekaIDTextBox.Text);
            cmd.Parameters.AddWithValue("@NazvanieFond", nazvanieFondTextBox.Text);
            cmd.Parameters.AddWithValue("@KolichestvoKnig", kolichestvoKnigTextBox.Text);
            cmd.Parameters.AddWithValue("@KolichestvoZurnalov", kolichestvoZurnalovTextBox.Text);
            cmd.Parameters.AddWithValue("@KolichestvoGazet", kolichestvoGazetTextBox.Text);
            cmd.Parameters.AddWithValue("@KolichestvoSbornikov", kolichestvoSbornikovTextBox.Text);
            cmd.Parameters.AddWithValue("@KolichestvoDissertacij", kolichestvoDissTextBox.Text);
            cmd.Parameters.AddWithValue("@KolichestvoReferatov", kolichestvoReferatovTextBox.Text);

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
            var fondID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["FondID"].Value);

            // Создаем SQL-запрос для обновления записи
            var query =
                "UPDATE FondBiblioteki SET BibliotekaID = @BibliotekaID, NazvanieFond = @NazvanieFond, KolichestvoKnig = @KolichestvoKnig, KolichestvoZurnalov = @KolichestvoZurnalov, " +
                "KolichestvoGazet = @KolichestvoGazet, KolichestvoSbornikov = @KolichestvoSbornikov, KolichestvoDissertacij = @KolichestvoDissertacij, KolichestvoReferatov = @KolichestvoReferatov " +
                "WHERE FondID = @FondID";
            var cmd = new SqlCommand(query, db.getCon());

            // Присваиваем значения параметрам
            cmd.Parameters.AddWithValue("@FondID", fondID);
            cmd.Parameters.AddWithValue("@BibliotekaID", bibliotekaIDTextBox.Text);
            cmd.Parameters.AddWithValue("@NazvanieFond", nazvanieFondTextBox.Text);
            cmd.Parameters.AddWithValue("@KolichestvoKnig", kolichestvoKnigTextBox.Text);
            cmd.Parameters.AddWithValue("@KolichestvoZurnalov", kolichestvoZurnalovTextBox.Text);
            cmd.Parameters.AddWithValue("@KolichestvoGazet", kolichestvoGazetTextBox.Text);
            cmd.Parameters.AddWithValue("@KolichestvoSbornikov", kolichestvoSbornikovTextBox.Text);
            cmd.Parameters.AddWithValue("@KolichestvoDissertacij", kolichestvoDissTextBox.Text);
            cmd.Parameters.AddWithValue("@KolichestvoReferatov", kolichestvoReferatovTextBox.Text);

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
            var fondID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["FondID"].Value);

            // Создаем SQL-запрос для удаления записи
            var query = "DELETE FROM FondBiblioteki WHERE FondID = @FondID";
            var cmd = new SqlCommand(query, db.getCon());

            // Присваиваем значение параметру
            cmd.Parameters.AddWithValue("@FondID", fondID);

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
            string query = "SELECT * FROM FondBiblioteki WHERE NazvanieFond LIKE @SearchText";
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