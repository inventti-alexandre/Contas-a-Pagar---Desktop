using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Contas_a_Pagar___Desktop.View
{
    public partial class FrmPagamento : Form
    {
        private bool Inserir;

        public FrmPagamento()
        {
            InitializeComponent();
        }

        private void FrmPagamento_Load(object sender, EventArgs e)
        {
            AtualizaDataSource();
        }

        private void AtualizaDataSource()
        {
            using (var oDB = new CPagamento.CPagamentoClient())
            {
                pagamentoBindingSource.DataSource = oDB.SelecionarTodos().ToList();
            }
        }

        private bool ValidaCampos()
        {
            using (var oDB = new CFornecimentoMaterial.CFornecimentoMaterialClient())
            {
                if (oDB.FornecimentoExiste(Convert.ToInt32(txtFornecimento.Text)) == false)
                {
                    MessageBox.Show("O Fornecimento não existe", "Aviso",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                                    MessageBoxDefaultButton.Button1);
                    return false;
                }
            }
            if (txtFornecimento.Text == "")
            {
                MessageBox.Show("O campo Fornecimento é de preenchimento obrigatório", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);
                return false;
            }
            else if (txtValor.Text == "")
            {
                MessageBox.Show("O campo Valor é de preenchimento obrigatório", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);
                return false;
            }
            return true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            toolStripButton1.Enabled = false;
            Inserir = false;
            bindingNavigatorDeleteItem.Enabled = false;
            pagamentoBindingNavigatorSaveItem.Enabled = true;
            bindingNavigatorAddNewItem.Enabled = false;
            SelecionaCampos(true);
            txtFornecimento.ReadOnly = true;
        }

        private void pagamentoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            using (var oDB = new CPagamento.CPagamentoClient())
            {
                if (ValidaCampos())
                {
                    var oPagamento = new CPagamento.Pagamento();
                    oPagamento.DataEmissao = dtpEmissao.Value;
                    oPagamento.Fornecimento = Convert.ToInt32(txtFornecimento.Text);
                    oPagamento.Valor = Convert.ToDecimal(txtValor.Text);
                    if (Inserir)
                    {
                        var result = MensagemErro.Erro(oDB.InserirAsync(oPagamento).Result);
                        if (result)
                            MensagemAviso.MensagemUsuario(1, "Pagamento");
                    }
                    else
                    {
                        var result = MensagemErro.Erro(oDB.AlterarAsync(oPagamento).Result);
                        if (result)
                            MensagemAviso.MensagemUsuario(2, "Pagamento");
                    }
                    AtualizaDataSource();
                    toolStripButton1.Enabled = true;
                    bindingNavigatorAddNewItem.Enabled = true;
                    bindingNavigatorDeleteItem.Enabled = true;
                    Inserir = false;
                    pagamentoBindingNavigatorSaveItem.Enabled = false;
                    SelecionaCampos(false);
                }
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MensagemAviso.MensagemUsuario(3, null))
            {
                var a = Convert.ToInt32(txtFornecimento.Text);
                using (var oDB = new CPagamento.CPagamentoClient())
                {
                    var result = MensagemErro.Erro(oDB.ExcluirAsync(a).Result);
                    if (result)
                        MensagemAviso.MensagemUsuario(4, "Pagamento");
                }
                AtualizaDataSource();
            }
        }

        private void SelecionaCampos(bool Habilitar)
        {
            var a = new List<TextBox>();
            a.Add(txtValor);
            a.Add(txtFornecimento);
            if (Habilitar)
                EstadoCampos.HabilitaCampos(a);
            else
                EstadoCampos.DesabilitaCampos(a);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Inserir = true;
            bindingNavigatorAddNewItem.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = false;
            pagamentoBindingNavigatorSaveItem.Enabled = true;
            toolStripButton1.Enabled = false;
            SelecionaCampos(true);
        }

        private void txtFornecimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacaoNumericos.NumericKeyPress(e);
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacaoNumericos.NumericKeyPress(e);
        }
    }
}