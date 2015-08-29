using System;
using System.Windows.Forms;

namespace Contas_a_Pagar___Desktop.View
{
    public partial class FrmListaLancamento : Form
    {
        public FrmListaLancamento()
        {
            InitializeComponent();
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            AtualizaDataSourcePesquisaAsync();
        }

        private async void AtualizaDataSourcePesquisaAsync()
        {
            using (var oDB = new CAgencia.CAgenciaClient())
            {
                if (toolStripComboBox1.SelectedItem != null && toolStripTextBox1.Text != "")
                {
                    lancamentoBindingSource.DataSource = await oDB.SelecionarTodosViewCriterioAsync(toolStripTextBox1.Text, toolStripComboBox1.SelectedItem.ToString());
                }
                if (toolStripTextBox1.Text == "")
                {
                    AtualizaDataSourceAsync();
                }
            }
        }

        private void FrmListaLancamento_Load(object sender, EventArgs e)
        {
            AtualizaDataSourceAsync();
        }

        private async void AtualizaDataSourceAsync()
        {
            using (var oDB = new CLancamento.CLancamentoClient())
            {
                lancamentoBindingSource.DataSource = await oDB.SelecionarTodosAsync();
            }
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizaDataSourcePesquisaAsync();
        }
    }
}