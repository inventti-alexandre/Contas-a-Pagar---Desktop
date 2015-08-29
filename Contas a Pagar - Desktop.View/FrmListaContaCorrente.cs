using System;
using System.Windows.Forms;

namespace Contas_a_Pagar___Desktop.View
{
    public partial class FrmListaContaCorrente : Form
    {
        public FrmListaContaCorrente()
        {
            InitializeComponent();
        }

        private void FrmListaContaCorrente_Load(object sender, EventArgs e)
        {
            AtualizaDataSourceAsync();
        }

        private async void AtualizaDataSourceAsync()
        {
            using (var oDB = new CContaCorrente.CContaCorrenteClient())
            {
                pesquisarCCBindingSource.DataSource = await oDB.SelecionarTodosViewAsync();
            }
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            AtualizaDataSourcePesquisaAsync();
        }

        private async void AtualizaDataSourcePesquisaAsync()
        {
            using (var oDB = new CContaCorrente.CContaCorrenteClient())
            {
                if (toolStripComboBox1.SelectedItem != null && toolStripTextBox1.Text != "")
                {
                    pesquisarCCBindingSource.DataSource = await oDB.SelecionarTodosViewCriterioAsync(toolStripTextBox1.Text, toolStripComboBox1.SelectedItem.ToString());
                }
                if (toolStripTextBox1.Text == "")
                {
                    AtualizaDataSourceAsync();
                }
            }
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizaDataSourcePesquisaAsync();
        }
    }
}