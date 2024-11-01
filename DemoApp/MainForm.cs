using Microsoft.Data.SqlClient;
using System.Data;
using DemoApp.Forms;

namespace DemoApp;

public partial class MainForm : Form
{
    private Database db = new();

    public MainForm()
    {
        InitializeComponent();
    }

    private void bibliotekiButton_Click(object sender, EventArgs e)
    {
        var bibliotekaForm = new BibliotekaForm();
        bibliotekaForm.Show();
    }

    private void fondBibliotekButton_Click(object sender, EventArgs e)
    {
        var fondBibliotekiForm = new FondBibliotekiForm();
        fondBibliotekiForm.Show();
    }

    private void popolnenieFondaButton_Click(object sender, EventArgs e)
    {
        var popolnenieFondaForm = new PopolnenieFondaForm();
        popolnenieFondaForm.Show();
    }

    private void tipLiteraturyButton_Click(object sender, EventArgs e)
    {
        var tipLiteraturyForm = new TipLiteraturyForm();
        tipLiteraturyForm.Show();
    }

    private void sotrudnikiButton_Click(object sender, EventArgs e)
    {
        var sotrudnikiForm = new SotrudnikiForm();
        sotrudnikiForm.Show();
    }
}