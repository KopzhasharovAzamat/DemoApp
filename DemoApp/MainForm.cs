using Microsoft.Data.SqlClient;
using System.Data;
using DemoApp.Forms;

namespace DemoApp
{
    public partial class MainForm : Form
    {
        private Database db = new();

        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            BibliotekaForm bibliotekaForm = new BibliotekaForm();
            bibliotekaForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FondBibliotekiForm fondBibliotekiForm = new FondBibliotekiForm();
            fondBibliotekiForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }
    }
}