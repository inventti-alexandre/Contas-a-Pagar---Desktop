using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Contas_a_Pagar___Desktop.View
{
    public partial class FrmLancamento : Form
    {
        private bool Inserir = false;

        public FrmLancamento()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            toolStripButton1.Enabled = false;
            Inserir = false;
            bindingNavigatorDeleteItem.Enabled = false;
            lancamentoBindingNavigatorSaveItem.Enabled = true;
            bindingNavigatorAddNewItem.Enabled = false;
            SelecionaCampos(true);
        }

        private void SelecionaCampos(bool Habilitar)
        {
            var a = new List<TextBox>();
            a.Add(txtContaCredito);
            a.Add(txtDescricao);
            a.Add(txtValor);
            if (Habilitar)
                EstadoCampos.HabilitaCampos(a);
            else
                EstadoCampos.DesabilitaCampos(a);
        }

        private void lancamentoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                using (var oDB = new CLancamento.CLancamentoClient())
                {
                    var oLancamento = new CLancamento.Lancamento();
                    oLancamento.ContaCredito = txtContaCredito.Text;
                    oLancamento.DataLancamento = dtpLancamento.Value;
                    oLancamento.Descricao = txtDescricao.Text;
                    oLancamento.Valor = decimal.Parse(txtValor.Text);
                    if (Inserir)
                    {
                        var result = MensagemErro.Erro(oDB.InserirAsync(oLancamento).Result);
                        if (result)
                            MensagemAviso.MensagemUsuario(1, "Lançamento no Plano de Contas");
                    }
                    else
                    {
                        oLancamento.Numero = int.Parse(txtNumero.Text);
                        var result = MensagemErro.Erro(oDB.AlterarAsync(oLancamento).Result);
                        if (result)
                            MensagemAviso.MensagemUsuario(2, "Lançamento no Plano de Contas");
                    }
                }
                AtualizaDataSource();
                Inserir = false;
                toolStripButton1.Enabled = true;
                bindingNavigatorAddNewItem.Enabled = true;
                bindingNavigatorDeleteItem.Enabled = true;
                lancamentoBindingNavigatorSaveItem.Enabled = false;
                SelecionaCampos(false);
            }
        }

        private void AtualizaDataSource()
        {
            using (var oDB = new CLancamento.CLancamentoClient())
            {
                lancamentoBindingSource.DataSource = oDB.SelecionarTodosAsync().Result.ToList();
            }
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
            else if (txtContaCredito.Text == "")
            {
                MessageBox.Show("O campo Conta Crédito é de preenchimento obrigatório", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);
                return false;
            }
            else if (txtNumero.Text == "")
            {
                MessageBox.Show("O campo Número é de preenchimento obrigatório", "Aviso",
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

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Inserir = true;
            bindingNavigatorAddNewItem.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = false;
            lancamentoBindingNavigatorSaveItem.Enabled = true;
            toolStripButton1.Enabled = false;
            SelecionaCampos(true);
            dtpLancamento.Value = DateTime.Now;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MensagemAviso.MensagemUsuario(3, null))
            {
                using (var oDB = new CLancamento.CLancamentoClient())
                {
                    var result = MensagemErro.Erro(oDB.ExcluirAsync(Convert.ToInt32(txtNumero.Text)).Result);
                    if (result)
                        MensagemAviso.MensagemUsuario(4, "Lançamento no Plano de Contas");
                }
            }
        }

        private void FrmLancamento_Load(object sender, EventArgs e)
        {
            AtualizaDataSource();
        }

        private void txtContaCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacaoNumericos.NumericKeyPress(e);
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacaoNumericos.NumericKeyPress(e);
        }
    }
}