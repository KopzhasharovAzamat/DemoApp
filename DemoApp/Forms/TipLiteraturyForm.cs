using Microsoft.Data.SqlClient;
using System.Data;

namespace DemoApp.Forms;

public partial class TipLiteraturyForm : Form
{
    private Database db = new();

    public TipLiteraturyForm()
    {
        InitializeComponent();
        LoadDataFromDatabase();
    }

    public void LoadDataFromDatabase()
    {
        try
        {
            db.openCon();
            var cmd = new SqlCommand("SELECT * FROM TipLiteratury", db.getCon());

            var adapter = new SqlDataAdapter(cmd);
            var table = new DataTable();
            adapter.Fill(table);

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
            var query = "INSERT INTO TipLiteratury (NazvanieTipa) VALUES (@NazvanieTipa)";
            var cmd = new SqlCommand(query, db.getCon());
            cmd.Parameters.AddWithValue("@NazvanieTipa", nazvanieTipaTextBox.Text);

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
            var tipLiteraturyID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["TipLiteraturyID"].Value);
            var query =
                "UPDATE TipLiteratury SET NazvanieTipa = @NazvanieTipa WHERE TipLiteraturyID = @TipLiteraturyID";
            var cmd = new SqlCommand(query, db.getCon());
            cmd.Parameters.AddWithValue("@TipLiteraturyID", tipLiteraturyID);
            cmd.Parameters.AddWithValue("@NazvanieTipa", nazvanieTipaTextBox.Text);

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
            var tipLiteraturyID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["TipLiteraturyID"].Value);
            var query = "DELETE FROM TipLiteratury WHERE TipLiteraturyID = @TipLiteraturyID";
            var cmd = new SqlCommand(query, db.getCon());
            cmd.Parameters.AddWithValue("@TipLiteraturyID", tipLiteraturyID);

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
            var query = "SELECT * FROM TipLiteratury WHERE NazvanieTipa LIKE @SearchText";
            var cmd = new SqlCommand(query, db.getCon());
            cmd.Parameters.AddWithValue("@SearchText", "%" + searchTextBox.Text + "%");

            var adapter = new SqlDataAdapter(cmd);
            var table = new DataTable();
            adapter.Fill(table);

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