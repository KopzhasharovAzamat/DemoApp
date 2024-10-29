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

        private void ExecuteQuery()
        {
            try
            {
                db.openCon();

                // ������� SQL-������
                SqlCommand cmd = new SqlCommand("SELECT * FROM TestTable", db.getCon());

                // ���������� SqlDataAdapter ��� ���������� ������� � ���������� DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                // ��������� DataGridView ������� �� DataTable
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            ExecuteQuery();
        }
    }
}