using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contas_a_Pagar___Desktop.View
{
    public partial class FrmSolicitacoesPorSetorNaoAprovadas : Form
    {
        public FrmSolicitacoesPorSetorNaoAprovadas()
        {
            InitializeComponent();
        }

        private void FrmSolicitacoesPorSetorNaoAprovadas_Load(object sender, EventArgs e)
        {
            AtualizaDataSourceAsync();
        }
        private void AtualizaDataSourceAsync()
        {
            using (var oDB = new CSolicitacaoMaterial.CSolicitacaoMaterialClient())
            {
                numSolicitacoesNaoAprovadosPorSetorBindingSource.DataSource = oDB.SelecionarTodasSolicitacoesNaoAprovadosPorSetor().ToList(); ;
            }
        }

        private void numSolicitacoesNaoAprovadosPorSetorDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgDesaprovacoes.SelectedRows.Count > 0)
            {
                using (var oDB = new CSolicitacaoMaterial.CSolicitacaoMaterialClient())
                {
                    var oSolicitacao = dtgDesaprovacoes.SelectedRows[0].DataBoundItem as CSolicitacaoMaterial.NumSolicitacoesNaoAprovadosPorSetor;
                    todasSolicitacoesNaoAprovadas_ResultBindingSource.DataSource = oDB.SelecionarTodasSolicitacoesBasicoNaoAprovadas(oSolicitacao.SetorID).ToList();
                }
            }
            else
            {
                using (var oDB = new CSolicitacaoMaterial.CSolicitacaoMaterialClient())
                {
                    todasSolicitacoesNaoAprovadas_ResultBindingSource.DataSource = oDB.SelecionarTodasSolicitacoesBasicoNaoAprovadas(-1).ToList();
                }
            }
        }
        private async void AtualizaDataSourcePesquisaAsync()
        {
            using (var oDB = new CSolicitacaoMaterial.CSolicitacaoMaterialClient())
            {
                if (toolStripComboBox1.SelectedItem != null && toolStripTextBox1.Text != "")
                {
                    numSolicitacoesNaoAprovadosPorSetorBindingSource.DataSource = await oDB.SelecionarTodasSolicitacoesNaoAprovadosPorSetorPesquisaAsync(toolStripTextBox1.Text, toolStripComboBox1.SelectedItem.ToString());
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
