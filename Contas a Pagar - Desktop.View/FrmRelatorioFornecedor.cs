using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Contas_a_Pagar___Desktop.View
{
    public partial class FrmRelatorioFornecedor : Form
    {
        public FrmRelatorioFornecedor()
        {
            InitializeComponent();
        }

        private async void AtualizaDataSourceAsync()
        {
            using (var trying = new CFornecedor.CFornecedorClient())
            {
                var a = new List<CFornecedor.Fornecedor>();
                FornecedorBindingSource.DataSource = await trying.SelecionarTodosAsync();
            }
        }

        private void FrmRelatorioFornecedor_Load(object sender, EventArgs e)
        {
            AtualizaDataSourceAsync();
            this.reportViewer1.RefreshReport();
        }
    }
}