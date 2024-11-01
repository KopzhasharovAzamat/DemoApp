using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoApp.Forms
{
    public partial class SotrudnikiForm : Form
    {
        private Database db = new();

        public SotrudnikiForm()
        {
            InitializeComponent();
            LoadDataFromDatabase();
        }

        public void LoadDataFromDatabase()
        {
            try
            {
                db.openCon();

                // SQL-запрос для получения данных из таблицы Sotrudniki
                SqlCommand cmd = new SqlCommand("SELECT * FROM Sotrudniki", db.getCon());

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
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

                // SQL-запрос для добавления новой записи в Sotrudniki
                string query = "INSERT INTO Sotrudniki (FIO, BibliotekaID, Dolzhnost, GodRozhdeniya, GodPostupleniya, Obrazovanie, Zarplata) " +
                               "VALUES (@FIO, @BibliotekaID, @Dolzhnost, @GodRozhdeniya, @GodPostupleniya, @Obrazovanie, @Zarplata)";
                SqlCommand cmd = new SqlCommand(query, db.getCon());

                // Присваиваем значения параметрам из соответствующих TextBox
                cmd.Parameters.AddWithValue("@FIO", FIOTextBox.Text);
                cmd.Parameters.AddWithValue("@BibliotekaID", Convert.ToInt32(bibliotekaIDTextBox.Text));
                cmd.Parameters.AddWithValue("@Dolzhnost", dolzhnostTextBox.Text);
                cmd.Parameters.AddWithValue("@GodRozhdeniya", Convert.ToInt32(godRozhdeniyaTextBox.Text));
                cmd.Parameters.AddWithValue("@GodPostupleniya", Convert.ToInt32(godPostupleniyaTextBox.Text));
                cmd.Parameters.AddWithValue("@Obrazovanie", obrazovanieTextBox.Text);
                cmd.Parameters.AddWithValue("@Zarplata", Convert.ToDecimal(zarplataTextBox.Text));

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

                int sotrudnikID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["SotrudnikID"].Value);

                // SQL-запрос для обновления записи
                string query = "UPDATE Sotrudniki SET FIO = @FIO, BibliotekaID = @BibliotekaID, Dolzhnost = @Dolzhnost, " +
                               "GodRozhdeniya = @GodRozhdeniya, GodPostupleniya = @GodPostupleniya, Obrazovanie = @Obrazovanie, " +
                               "Zarplata = @Zarplata WHERE SotrudnikID = @SotrudnikID";
                SqlCommand cmd = new SqlCommand(query, db.getCon());

                cmd.Parameters.AddWithValue("@SotrudnikID", sotrudnikID);
                cmd.Parameters.AddWithValue("@FIO", FIOTextBox.Text);
                cmd.Parameters.AddWithValue("@BibliotekaID", Convert.ToInt32(bibliotekaIDTextBox.Text));
                cmd.Parameters.AddWithValue("@Dolzhnost", dolzhnostTextBox.Text);
                cmd.Parameters.AddWithValue("@GodRozhdeniya", Convert.ToInt32(godRozhdeniyaTextBox.Text));
                cmd.Parameters.AddWithValue("@GodPostupleniya", Convert.ToInt32(godPostupleniyaTextBox.Text));
                cmd.Parameters.AddWithValue("@Obrazovanie", obrazovanieTextBox.Text);
                cmd.Parameters.AddWithValue("@Zarplata", Convert.ToDecimal(zarplataTextBox.Text));

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

                int sotrudnikID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["SotrudnikID"].Value);

                string query = "DELETE FROM Sotrudniki WHERE SotrudnikID = @SotrudnikID";
                SqlCommand cmd = new SqlCommand(query, db.getCon());
                cmd.Parameters.AddWithValue("@SotrudnikID", sotrudnikID);

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

                string query = "SELECT * FROM Sotrudniki WHERE FIO LIKE @SearchText OR Dolzhnost LIKE @SearchText";
                SqlCommand cmd = new SqlCommand(query, db.getCon());
                cmd.Parameters.AddWithValue("@SearchText", "%" + searchTextBox.Text + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
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
}
