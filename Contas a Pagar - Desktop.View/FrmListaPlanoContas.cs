using System;
using System.Windows.Forms;

namespace Contas_a_Pagar___Desktop.View
{
    public partial class FrmListaPlanoContas : Form
    {
        public FrmListaPlanoContas()
        {
            InitializeComponent();
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            AtualizaDataSourcePesquisaAsync();
        }

        private async void AtualizaDataSourcePesquisaAsync()
        {
            using (var oDB = new CPlanoContas.CPlanoContasClient())
            {
                if (toolStripComboBox1.SelectedItem != null && toolStripTextBox1.Text != "")
                {
                    planoContasBindingSource.DataSource = await oDB.SelecionarTodosCriterioAsync(toolStripTextBox1.Text, toolStripComboBox1.SelectedItem.ToString());
                }
                if (toolStripTextBox1.Text == "")
                {
                    AtualizaDataSourceAsync();
                }
            }
        }

        private async void AtualizaDataSourceAsync()
        {
            using (var oDB = new CPlanoContas.CPlanoContasClient())
            {
                planoContasBindingSource.DataSource = await oDB.SelecionarTodosAsync();
            }
        }

        private void FrmListaPlanoContas_Load(object sender, EventArgs e)
        {
            AtualizaDataSourceAsync();
        }

        private void toolStripComboBox1_TextChanged(object sender, EventArgs e)
        {
            AtualizaDataSourcePesquisaAsync();
        }
    }
}