using System;
using System.Linq;
using System.Windows.Forms;

namespace Contas_a_Pagar___Desktop.View
{
    public partial class FrmListaFornecimentos : Form
    {
        public FrmListaFornecimentos()
        {
            InitializeComponent();
        }

        private void relacaoFornecimentoDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgFornecimento.SelectedRows.Count > 0)
            {
                using (var oDB = new CFornecimentoMaterial.CFornecimentoMaterialClient())
                {
                    var oFornecimento = dtgFornecimento.SelectedRows[0].DataBoundItem as CFornecimentoMaterial.RelacaoFornecimento;
                    detalhesFornecimento_ResultBindingSource.DataSource = oDB.SelecionarTodosDetalhesFornecimentos(oFornecimento.FornecimentoID).ToList();
                }
            }
        }

        private void FrmListaFornecimentos_Load(object sender, EventArgs e)
        {
            AtualizaDataSourceAsync();
        }

        private async void AtualizaDataSourceAsync()
        {
            using (var oDB = new CFornecimentoMaterial.CFornecimentoMaterialClient())
            {
                relacaoFornecimentoBindingSource.DataSource = await oDB.SelecionarTodosFornecimentosAsync();
            }
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            AtualizaDataSourcePesquisaAsync();
        }

        private async void AtualizaDataSourcePesquisaAsync()
        {
            using (var oDB = new CFornecimentoMaterial.CFornecimentoMaterialClient())
            {
                if (toolStripComboBox1.SelectedItem != null && toolStripTextBox1.Text != "")
                {
                    relacaoFornecimentoBindingSource.DataSource = await oDB.SelecionarTodosFornecimentosCriterioAsync(toolStripTextBox1.Text, toolStripComboBox1.SelectedItem.ToString());
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