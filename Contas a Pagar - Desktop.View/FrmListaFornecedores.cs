using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Contas_a_Pagar___Desktop.View
{
    public partial class FrmListaFornecedores : Form
    {
        public FrmListaFornecedores()
        {
            InitializeComponent();
        }

        private void AtualizaDataSource()
        {
            using (var trying = new CFornecedor.CFornecedorClient())
            {
                var a = new List<CFornecedor.Fornecedor>();
                fornecedorBindingSource.DataSource = trying.SelecionarTodosAsync().Result.ToList();
            }
        }

        private async void AtualizaDataSourceAsync()
        {
            using (var oDB = new CFornecedor.CFornecedorClient())
            {
                var a = new List<CFornecedor.Fornecedor>();
                fornecedorBindingSource.DataSource = await oDB.SelecionarTodosAsync();
            }
        }

        private void FrmListaFornecedores_Load(object sender, EventArgs e)
        {
            AtualizaDataSourceAsync();
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            AtualizaDataSourcePesquisaAsync();
        }

        private async void AtualizaDataSourcePesquisaAsync()
        {
            using (var oDB = new CFornecedor.CFornecedorClient())
            {
                if (toolStripComboBox1.SelectedItem != null && toolStripTextBox1.Text != "")
                {
                    fornecedorBindingSource.DataSource = await oDB.SelecionarTodosCriterioAsync(toolStripTextBox1.Text, toolStripComboBox1.SelectedItem.ToString());
                }
                if (toolStripTextBox1.Text == "")
                {
                    AtualizaDataSourceAsync();
                }
            }
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var relatorios = new FrmRelatorioFornecedor();
            relatorios.Show();
        }

        private void toolStripComboBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizaDataSourcePesquisaAsync();
        }
    }
}