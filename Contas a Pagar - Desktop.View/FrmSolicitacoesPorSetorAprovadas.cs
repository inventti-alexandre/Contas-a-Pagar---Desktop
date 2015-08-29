using System;
using System.Linq;
using System.Windows.Forms;

namespace Contas_a_Pagar___Desktop.View
{
    public partial class FrmSolicitacoesPorSetorAprovadas : Form
    {
        public FrmSolicitacoesPorSetorAprovadas()
        {
            InitializeComponent();
        }

        private void FrmSolicitacoesPorSetorAprovadas_Load(object sender, EventArgs e)
        {
            AtualizaDataSourceAsync();
        }

        private void AtualizaDataSourceAsync()
        {
            using (var oDB = new CSolicitacaoMaterial.CSolicitacaoMaterialClient())
            {
                numSolicitacoesAprovadosPorSetorBindingSource.DataSource = oDB.SelecionarTodasSolicitacoesAprovadosPorSetorAsync().Result.ToList(); ;
            }
        }

        private void numSolicitacoesAprovadosPorSetorDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgAprovacoes.SelectedRows.Count > 0)
            {
                using (var oDB = new CSolicitacaoMaterial.CSolicitacaoMaterialClient())
                {
                    var oSolicitacao = dtgAprovacoes.SelectedRows[0].DataBoundItem as CSolicitacaoMaterial.NumSolicitacoesAprovadosPorSetor;
                    todasSolicitacoesAprovadas_ResultBindingSource.DataSource = oDB.SelecionarTodasSolicitacoesBasicoAprovadas(oSolicitacao.SetorID).ToList();
                }
            }
            else
            {
                using (var oDB = new CSolicitacaoMaterial.CSolicitacaoMaterialClient())
                {
                    todasSolicitacoesAprovadas_ResultBindingSource.DataSource = oDB.SelecionarTodasSolicitacoesBasicoAprovadas(-1).ToList();
                }
            }
        }

        private async void AtualizaDataSourcePesquisaAsync()
        {
            using (var oDB = new CSolicitacaoMaterial.CSolicitacaoMaterialClient())
            {
                if (toolStripComboBox1.SelectedItem != null && toolStripTextBox1.Text != "")
                {
                    numSolicitacoesAprovadosPorSetorBindingSource.DataSource = await oDB.SelecionarTodasSolicitacoesAprovadosPorSetorPesquisaAsync(toolStripTextBox1.Text, toolStripComboBox1.SelectedItem.ToString());
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

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            AtualizaDataSourcePesquisaAsync();
        }
    }
}