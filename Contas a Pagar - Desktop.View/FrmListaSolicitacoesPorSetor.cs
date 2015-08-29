using System;
using System.Linq;
using System.Windows.Forms;

namespace Contas_a_Pagar___Desktop.View
{
    public partial class FrmListaSolicitacoesPorSetor : Form
    {
        public FrmListaSolicitacoesPorSetor()
        {
            InitializeComponent();
        }

        private void FrmListaFornecimentosPorEmpresa_Load(object sender, EventArgs e)
        {
            AtualizaDataSourceAsync();
        }

        private void AtualizaDataSourceAsync()
        {
            using (var oDB = new CSolicitacaoMaterial.CSolicitacaoMaterialClient())
            {
                numSolicitacoesPorSetorBindingSource.DataSource = oDB.SelecionarTodasSolicitacoesPorSetorAsync().Result.ToList(); ;
            }
        }

        private async void AtualizaDataSourcePesquisaAsync()
        {
            using (var oDB = new CSolicitacaoMaterial.CSolicitacaoMaterialClient())
            {
                if (toolStripComboBox1.SelectedItem != null && toolStripTextBox1.Text != "")
                {
                    numSolicitacoesPorSetorBindingSource.DataSource = await oDB.SelecionarTodasSolicitacoesPorSetorPesquisaAsync(toolStripTextBox1.Text, toolStripComboBox1.SelectedItem.ToString());
                }
                if (toolStripTextBox1.Text == "")
                {
                    AtualizaDataSourceAsync();
                }
            }
        }

        private void numSolicitacoesPorSetorDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgGrupoSetor.SelectedRows.Count > 0)
            {
                using (var oDB = new CSolicitacaoMaterial.CSolicitacaoMaterialClient())
                {
                    var oSolicitacao = dtgGrupoSetor.SelectedRows[0].DataBoundItem as CSolicitacaoMaterial.NumSolicitacoesPorSetor;
                    todasSolicitacoes_ResultBindingSource.DataSource = oDB.SelecionarTodasSolicitacoesBasicoAsync(oSolicitacao.SetorID).Result.ToList();
                }
            }
            else
            {
                using (var oDB = new CSolicitacaoMaterial.CSolicitacaoMaterialClient())
                {
                    todasSolicitacoes_ResultBindingSource.DataSource = oDB.SelecionarTodasSolicitacoesBasicoAsync(-1).Result.ToList();
                }
            }
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            AtualizaDataSourcePesquisaAsync();
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizaDataSourcePesquisaAsync();
        }
    }
}