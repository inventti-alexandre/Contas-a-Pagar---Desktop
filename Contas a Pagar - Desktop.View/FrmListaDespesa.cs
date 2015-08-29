using System;
using System.Windows.Forms;

namespace Contas_a_Pagar___Desktop.View
{
    public partial class FrmListaDespesa : Form
    {
        public FrmListaDespesa()
        {
            InitializeComponent();
        }

        private void FrmListaDespesa_Load(object sender, EventArgs e)
        {
            AtualizaDataSourceAsync();
        }

        private async void AtualizaDataSourceAsync()
        {
            using (var oDB = new CDespesa.CDespesaClient())
            {
                despesaBindingSource.DataSource = await oDB.SelecionarTodosAsync();
            }
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            AtualizaDataSourcePesquisaAsync();
        }

        private async void AtualizaDataSourcePesquisaAsync()
        {
            using (var oDB = new CDespesa.CDespesaClient())
            {
                if (toolStripComboBox1.SelectedItem != null && toolStripTextBox1.Text != "")
                {
                    despesaBindingSource.DataSource = await oDB.SelecionarTodosCriterioAsync(toolStripTextBox1.Text, toolStripComboBox1.SelectedItem.ToString());
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