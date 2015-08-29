using System;
using System.Linq;
using System.Windows.Forms;

namespace Contas_a_Pagar___Desktop.View
{
    public partial class FrmListaSolicitacao : Form
    {
        public FrmListaSolicitacao()
        {
            InitializeComponent();
        }

        private void FrmListaSolicitacao_Load(object sender, EventArgs e)
        {
            AtualizaDataSourceAsync();
        }

        private async void AtualizaDataSourceAsync()
        {
            using (var oDB = new CSolicitacaoMaterial.CSolicitacaoMaterialClient())
            {
                relacaoSolicitacaoBindingSource.DataSource = await oDB.SelecionarTodosSolicitacaosAsync();
            }
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            AtualizaDataSourcePesquisaAsync();
        }

        private async void AtualizaDataSourcePesquisaAsync()
        {
            using (var oDB = new CSolicitacaoMaterial.CSolicitacaoMaterialClient())
            {
                if (toolStripComboBox1.SelectedItem != null && toolStripTextBox1.Text != "")
                {
                    relacaoSolicitacaoBindingSource.DataSource = await oDB.SelecionarTodosSolicitacaosCriterioAsync(toolStripTextBox1.Text, toolStripComboBox1.SelectedItem.ToString());
                }
                if (toolStripTextBox1.Text == "")
                {
                    AtualizaDataSourceAsync();
                }
            }
        }

        private void relacaoSolicitacaoDataGridView_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void dtgSolicitacao_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgSolicitacao.SelectedRows.Count > 0)
            {
                using (var oDB = new CSolicitacaoMaterial.CSolicitacaoMaterialClient())
                {
                    var oSolicitacao = dtgSolicitacao.SelectedRows[0].DataBoundItem as CSolicitacaoMaterial.RelacaoSolicitacao;
                    detalhesSolicitacao_ResultBindingSource.DataSource = oDB.SelecionarTodosDetalhesSolicitacaos(oSolicitacao.SolicitacaoID).ToList();
                }
            }
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizaDataSourcePesquisaAsync();
        }
    }
}