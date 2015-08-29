using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Contas_a_Pagar___Desktop.View
{
    public partial class FrmPlanoContas : Form
    {
        private bool Inserir;

        public FrmPlanoContas()
        {
            InitializeComponent();
        }

        private void FrmPlanoContas_Load(object sender, EventArgs e)
        {
            AtualizaDataSourceAsync();
        }

        private void SelecionaCampos(bool Habilitar)
        {
            var a = new List<TextBox>();
            a.Add(txtConta);
            a.Add(txtDescricao);
            if (Habilitar)
                EstadoCampos.HabilitaCampos(a);
            else
                EstadoCampos.DesabilitaCampos(a);
        }

        private void AtualizaDataSourceAsync()
        {
            using (var oDB = new CPlanoContas.CPlanoContasClient())
            {
                planoContasBindingSource.DataSource = oDB.SelecionarTodosAsync().Result.ToList();
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Inserir = true;
            bindingNavigatorAddNewItem.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = false;
            planoContasBindingNavigatorSaveItem.Enabled = true;
            toolStripButton1.Enabled = false;
            SelecionaCampos(true);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            toolStripButton1.Enabled = false;
            Inserir = false;
            bindingNavigatorDeleteItem.Enabled = false;
            planoContasBindingNavigatorSaveItem.Enabled = true;
            bindingNavigatorAddNewItem.Enabled = false;
            SelecionaCampos(true);
            txtConta.ReadOnly = true;
        }

        private void planoContasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            using (var oDB = new CPlanoContas.CPlanoContasClient())
            {
                if (ValidaCampos())
                {
                    var oPlanoContas = new CPlanoContas.PlanoContas();
                    oPlanoContas.Descricao = txtDescricao.Text;
                    oPlanoContas.Consolidacao = chkConsolidacao.Checked;
                    oPlanoContas.Conta = txtConta.Text;
                    if (Inserir)
                    {
                        var result = MensagemErro.Erro(oDB.InserirAsync(oPlanoContas).Result);
                        if (result)
                            MensagemAviso.MensagemUsuario(1, "Plano de Contas");
                    }
                    else
                    {
                        var result = MensagemErro.Erro(oDB.AlterarAsync(oPlanoContas).Result);
                        if (result)
                            MensagemAviso.MensagemUsuario(2, "Plano de Contas");
                    }
                    AtualizaDataSourceAsync();
                    toolStripButton1.Enabled = true;
                    bindingNavigatorAddNewItem.Enabled = true;
                    bindingNavigatorDeleteItem.Enabled = true;
                    Inserir = false;
                    planoContasBindingNavigatorSaveItem.Enabled = false;
                    SelecionaCampos(false);
                }
            }
        }

        private bool ValidaCampos()
        {
            using (var oDB = new CContaCorrente.CContaCorrenteClient())
            {
                if (oDB.ContaCorrenteExiste(txtConta.Text) == false)
                {
                    MessageBox.Show("A Conta Corrente não existe", "Aviso",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                                    MessageBoxDefaultButton.Button1);
                    return false;
                }
            }
            if (txtDescricao.Text == "")
            {
                MessageBox.Show("O campo Descrição é de preenchimento obrigatório", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);
                return false;
            }
            else if (txtConta.Text == "")
            {
                MessageBox.Show("O campo Conta é de preenchimento obrigatório", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);
                return false;
            }
            return true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MensagemAviso.MensagemUsuario(3, null))
            {
                using (var oDB = new CPlanoContas.CPlanoContasClient())
                {
                    var result = MensagemErro.Erro(oDB.ExcluirAsync(txtConta.Text).Result);
                    if (result)
                        MensagemAviso.MensagemUsuario(4, "Plano de Contas");
                }
                AtualizaDataSourceAsync();
            }
        }
    }
}