using System;
using System.Linq;
using System.Windows.Forms;

namespace Contas_a_Pagar___Desktop.View
{
    public partial class FrmAprovarSolicitacao : Form
    {
        public FrmAprovarSolicitacao()
        {
            InitializeComponent();
        }

        private void aprovadoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void FrmAprovarSolicitacao_Load(object sender, EventArgs e)
        {
            AtualizaDataSource();
        }

        private void AtualizaDataSource()
        {
            using (var oDB = new CSolicitacaoMaterial.CSolicitacaoMaterialClient())
            {
                solicitacaoMaterialBindingSource.DataSource = oDB.SelecionarTodosNaoAprovadosAsync().Result.ToList();
            }
        }

        private void solicitacaoMaterialBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            using (var oDB = new CSolicitacaoMaterial.CSolicitacaoMaterialClient())
            {
                if (txtID.Text != "")
                {
                    if (oDB.SolicitacaoExiste(Convert.ToInt32(txtID.Text)) == false)
                    {
                        MessageBox.Show("A Solicitação não existe", "Aviso",
                                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                                        MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        var result = MensagemErro.Erro(oDB.AprovarSolicitacao(Convert.ToInt32(txtID.Text), chkAprovar.Checked));
                        if (result)
                            MensagemAviso.MensagemUsuario(1, "Aprovação");
                    }
                }
                AtualizaDataSource();
            }
        }
    }
}