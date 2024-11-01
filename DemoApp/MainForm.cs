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

        private void bibliotekiButton_Click(object sender, EventArgs e)
        {
            BibliotekaForm bibliotekaForm = new BibliotekaForm();
            bibliotekaForm.Show();
        }

        private void fondBibliotekButton_Click(object sender, EventArgs e)
        {
            FondBibliotekiForm fondBibliotekiForm = new FondBibliotekiForm();
            fondBibliotekiForm.Show();
        }

        private void popolnenieFondaButton_Click(object sender, EventArgs e)
        {
            PopolnenieFondaForm popolnenieFondaForm = new PopolnenieFondaForm();
            popolnenieFondaForm.Show();
        }

        private void tipLiteraturyButton_Click(object sender, EventArgs e)
        {

        }

        private void sotrudnikiButton_Click(object sender, EventArgs e)
        {
            SotrudnikiForm sotrudnikiForm = new SotrudnikiForm();
            sotrudnikiForm.Show();
        }
    }
}