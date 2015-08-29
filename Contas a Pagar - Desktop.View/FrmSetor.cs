using System;
using System.Linq;
using System.Windows.Forms;

namespace Contas_a_Pagar___Desktop.View
{
    public partial class FrmSetor : Form
    {
        private bool Inserir = false;

        public FrmSetor()
        {
            InitializeComponent();
        }

        private void FrmSetor_Load(object sender, EventArgs e)
        {
            AtualizaDataSource();
        }

        public void AtualizaDataSource()
        {
            using (var oDB = new CSetor.CSetorClient())
            {
                setorBindingSource.DataSource = oDB.SelecionarTodosAsync().Result.ToList();
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Inserir = true;
            bindingNavigatorAddNewItem.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = false;
            setorBindingNavigatorSaveItem.Enabled = true;
            toolStripButton1.Enabled = false;
        }

        private bool ValidaCampos()
        {
            if (txtDescricao.Text == "")
            {
                MessageBox.Show("O campo Descrição é de preenchimento obrigatório", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);
                return false;
            }
            return true;
        }

        private void descricaoTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void setorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                using (var oDB = new CSetor.CSetorClient())
                {
                    var oSetor = new CSetor.Setor();
                    oSetor.Descricao = txtDescricao.Text;
                    if (Inserir)
                    {
                        var result = MensagemErro.Erro(oDB.InserirAsync(oSetor).Result);
                        if (result)
                            MensagemAviso.MensagemUsuario(1, "Setor");
                    }
                    else
                    {
                        oSetor.ID = Convert.ToInt32(txtID.Text);
                        var result = MensagemErro.Erro(oDB.AlterarAsync(oSetor).Result);
                        if (result)
                            MensagemAviso.MensagemUsuario(2, "Setor");
                    }
                }
                AtualizaDataSource();
                toolStripButton1.Enabled = true;
                bindingNavigatorAddNewItem.Enabled = true;
                bindingNavigatorDeleteItem.Enabled = true;
                Inserir = false;
                setorBindingNavigatorSaveItem.Enabled = false;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            toolStripButton1.Enabled = false;
            Inserir = false;
            bindingNavigatorDeleteItem.Enabled = false;
            setorBindingNavigatorSaveItem.Enabled = true;
            bindingNavigatorAddNewItem.Enabled = false;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MensagemAviso.MensagemUsuario(3, null))
            {
                using (var oDB = new CSetor.CSetorClient())
                {
                    var result = MensagemErro.Erro(oDB.ExcluirAsync(Convert.ToInt32(txtID.Text)).Result);
                    if (result)
                        MensagemAviso.MensagemUsuario(4, "Setor");
                }
                AtualizaDataSource();
            }
        }
    }
}