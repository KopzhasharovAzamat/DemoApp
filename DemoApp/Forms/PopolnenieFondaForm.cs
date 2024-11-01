using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace DemoApp.Forms
{
    public partial class PopolnenieFondaForm : Form
    {
        private Database db = new();

        public PopolnenieFondaForm()
        {
            InitializeComponent();
            LoadDataFromDatabase();
        }

        public void LoadDataFromDatabase()
        {
            try
            {
                db.openCon();

                // SQL-запрос для получения данных из PopolnenieFonda
                SqlCommand cmd = new SqlCommand("SELECT * FROM PopolnenieFonda", db.getCon());

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

                // SQL-запрос для добавления новой записи в PopolnenieFonda
                string query = "INSERT INTO PopolnenieFonda (FondID, SotrudnikID, DataPopolneniya, NazvanieIstochnika, TipLiteraturyID, Izdatelstvo, DataIzdanija, KolichestvoEkzemplyarov) " +
                               "VALUES (@FondID, @SotrudnikID, @DataPopolneniya, @NazvanieIstochnika, @TipLiteraturyID, @Izdatelstvo, @DataIzdanija, @KolichestvoEkzemplyarov)";
                SqlCommand cmd = new SqlCommand(query, db.getCon());

                // Присваиваем значения параметрам из соответствующих TextBox
                cmd.Parameters.AddWithValue("@FondID", Convert.ToInt32(fondIdTextBox.Text));
                cmd.Parameters.AddWithValue("@SotrudnikID", Convert.ToInt32(sotrudnikIDTextBox.Text));
                cmd.Parameters.AddWithValue("@DataPopolneniya", Convert.ToDateTime(dataPopolneniaTextBox.Text));
                cmd.Parameters.AddWithValue("@NazvanieIstochnika", nazavanieIstochnikaTextBox.Text);
                cmd.Parameters.AddWithValue("@TipLiteraturyID", Convert.ToInt32(tipLiteraturyTextBox.Text));
                cmd.Parameters.AddWithValue("@Izdatelstvo", izdatelstvoTextBox.Text);
                cmd.Parameters.AddWithValue("@DataIzdanija", Convert.ToDateTime(dataIzdaniaTextBox.Text));
                cmd.Parameters.AddWithValue("@KolichestvoEkzemplyarov", Convert.ToInt32(kolichestvoEkzemplyarovTextBox.Text));

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

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                db.openCon();

                string query = "SELECT * FROM PopolnenieFonda WHERE NazvanieIstochnika LIKE @SearchText OR Izdatelstvo LIKE @SearchText";
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

                int popolnenieID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["PopolnenieID"].Value);

                string query = "DELETE FROM PopolnenieFonda WHERE PopolnenieID = @PopolnenieID";
                SqlCommand cmd = new SqlCommand(query, db.getCon());
                cmd.Parameters.AddWithValue("@PopolnenieID", popolnenieID);

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

                int popolnenieID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["PopolnenieID"].Value);

                // SQL-запрос для обновления записи
                string query = "UPDATE PopolnenieFonda SET FondID = @FondID, SotrudnikID = @SotrudnikID, DataPopolneniya = @DataPopolneniya, " +
                               "NazvanieIstochnika = @NazvanieIstochnika, TipLiteraturyID = @TipLiteraturyID, Izdatelstvo = @Izdatelstvo, " +
                               "DataIzdanija = @DataIzdanija, KolichestvoEkzemplyarov = @KolichestvoEkzemplyarov WHERE PopolnenieID = @PopolnenieID";
                SqlCommand cmd = new SqlCommand(query, db.getCon());

                cmd.Parameters.AddWithValue("@PopolnenieID", popolnenieID);
                cmd.Parameters.AddWithValue("@FondID", Convert.ToInt32(fondIdTextBox.Text));
                cmd.Parameters.AddWithValue("@SotrudnikID", Convert.ToInt32(sotrudnikIDTextBox.Text));
                cmd.Parameters.AddWithValue("@DataPopolneniya", Convert.ToDateTime(dataPopolneniaTextBox.Text));
                cmd.Parameters.AddWithValue("@NazvanieIstochnika", nazavanieIstochnikaTextBox.Text);
                cmd.Parameters.AddWithValue("@TipLiteraturyID", Convert.ToInt32(tipLiteraturyTextBox.Text));
                cmd.Parameters.AddWithValue("@Izdatelstvo", izdatelstvoTextBox.Text);
                cmd.Parameters.AddWithValue("@DataIzdanija", Convert.ToDateTime(dataIzdaniaTextBox.Text));
                cmd.Parameters.AddWithValue("@KolichestvoEkzemplyarov", Convert.ToInt32(kolichestvoEkzemplyarovTextBox.Text));

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
    }
}
