using System;
using System.Linq;
using System.Windows.Forms;

namespace Contas_a_Pagar___Desktop.View
{
    public partial class FrmCancelarFornecimento : Form
    {
        public FrmCancelarFornecimento()
        {
            InitializeComponent();
        }

        private void fornecimentoMaterialBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            using (var oDB = new CFornecimentoMaterial.CFornecimentoMaterialClient())
            {
                if (txtID.Text != "")
                {
                    if (oDB.FornecimentoExiste(Convert.ToInt32(txtID.Text)) == false)
                    {
                        MessageBox.Show("O Fornecimento não existe", "Aviso",
                                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                                        MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        var result = MensagemErro.Erro(oDB.CancelarFornecimento(Convert.ToInt32(txtID.Text), chkCancelar.Checked));
                        if (result)
                            MensagemAviso.MensagemUsuario(1, "Cancelamento");
                    }
                }
                AtualizaDataSource();
            }
        }

        private void AtualizaDataSource()
        {
            using (var oDB = new CFornecimentoMaterial.CFornecimentoMaterialClient())
            {
                fornecimentoMaterialBindingSource.DataSource = oDB.SelecionarTodosNaoCancelados().ToList();
            }
        }

        private void FrmCancelarFornecimento_Load(object sender, EventArgs e)
        {
            AtualizaDataSource();
        }
    }
}