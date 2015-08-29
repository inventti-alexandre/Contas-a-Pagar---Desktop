using System;
using System.Linq;
using System.Windows.Forms;

namespace Contas_a_Pagar___Desktop.View
{
    public partial class FrmListaFornecimentosPorEmpresa : Form
    {
        public FrmListaFornecimentosPorEmpresa()
        {
            InitializeComponent();
        }

        private void FrmListaFornecimentosPorEmpresa_Load(object sender, EventArgs e)
        {
            AtualizaDataSourceAsync();
        }

        private void AtualizaDataSourceAsync()
        {
            using (var oDB = new CFornecimentoMaterial.CFornecimentoMaterialClient())
            {
                numFornecimentosPorEmpresaBindingSource.DataSource = oDB.SelecionarTodosFornecimentosPorEmpresaAsync().Result.ToList(); ;
            }
        }

        private void numFornecimentosPorEmpresaDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgGrupoFornecimento.SelectedRows.Count > 0)
            {
                using (var oDB = new CFornecimentoMaterial.CFornecimentoMaterialClient())
                {
                    var oFornecimento = dtgGrupoFornecimento.SelectedRows[0].DataBoundItem as CFornecimentoMaterial.NumFornecimentosPorEmpresa;
                    todosFornecimentos_ResultBindingSource.DataSource = oDB.SelecionarTodosFornecimentosBasicoAsync(oFornecimento.FornecedorID).Result.ToList();
                }
            }
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizaDataSourcePesquisaAsync();
        }

        private async void AtualizaDataSourcePesquisaAsync()
        {
            using (var oDB = new CFornecimentoMaterial.CFornecimentoMaterialClient())
            {
                if (toolStripComboBox1.SelectedItem != null && toolStripTextBox1.Text != "")
                {
                    numFornecimentosPorEmpresaBindingSource.DataSource = await oDB.SelecionarTodosFornecimentosPorEmpresaPesquisaAsync(toolStripTextBox1.Text, toolStripComboBox1.SelectedItem.ToString());
                }
                if (toolStripTextBox1.Text == "")
                {
                    AtualizaDataSourceAsync();
                }
            }
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            AtualizaDataSourcePesquisaAsync();
        }
    }
}