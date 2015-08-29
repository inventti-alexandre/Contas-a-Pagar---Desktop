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
    public partial class FrmDespesa : Form
    {
        private bool Inserir=false;

        public FrmDespesa()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            toolStripButton1.Enabled = false;
            Inserir = false;
            bindingNavigatorDeleteItem.Enabled = false;
            despesaBindingNavigatorSaveItem.Enabled = true;
            bindingNavigatorAddNewItem.Enabled = false;
            SelecionaCampos(true);
        }

        private void despesaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            using (var oDB = new CDespesa.CDespesaClient())
            {
                if (ValidaCampos())
                {
                    var oDespesa = new CDespesa.Despesa();
                    oDespesa.Descricao = txtDescricao.Text;
                    oDespesa.ValorPrevisto = Convert.ToDecimal(txtValor.Text);
                    oDespesa.Pagamento = Convert.ToInt32(txtPagamento.Text);
                    oDespesa.Lancamento = Convert.ToInt32(txtLancamento.Text);
                    if (Inserir)
                    {
                        var result = MensagemErro.Erro(oDB.InserirAsync(oDespesa).Result);
                        if (result)
                            MensagemAviso.MensagemUsuario(1, "Despesa");
                    }
                    else
                    {
                        oDespesa.Numero = Convert.ToInt32(txtNumero.Text);
                        var result = MensagemErro.Erro(oDB.AlterarAsync(oDespesa).Result);
                        if (result)
                            MensagemAviso.MensagemUsuario(2, "Despesa");
                    }
                    AtualizaDataSource();
                    toolStripButton1.Enabled = true;
                    bindingNavigatorAddNewItem.Enabled = true;
                    bindingNavigatorDeleteItem.Enabled = true;
                    Inserir = false;
                    despesaBindingNavigatorSaveItem.Enabled = false;
                    SelecionaCampos(false);
                }
            }
        }
        private void SelecionaCampos(bool Habilitar)
        {
            var a = new List<TextBox>();
            a.Add(txtDescricao);
            a.Add(txtLancamento);
            a.Add(txtPagamento);
            a.Add(txtValor);
            if (Habilitar)
                EstadoCampos.HabilitaCampos(a);
            else
                EstadoCampos.DesabilitaCampos(a);
        }
        private bool ValidaCampos()
        {
            using (var oDB = new CPagamento.CPagamentoClient())
            {
                if (oDB.PagamentoExiste(Convert.ToInt32(txtPagamento.Text)) == false)
                {
                    MessageBox.Show("O Pagamento não existe", "Aviso",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                                    MessageBoxDefaultButton.Button1);
                    return false;
                }
            }
            using (var oDB = new CLancamento.CLancamentoClient())
            {
                if (oDB.LancamentoExiste(Convert.ToInt32(txtLancamento.Text)) == false)
                {
                    MessageBox.Show("O Lançamento não existe", "Aviso",
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
            else if (txtValor.Text == "")
            {
                MessageBox.Show("O campo Valor Previsto é de preenchimento obrigatório", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);
                return false;
            }
            else if (txtPagamento.Text == "")
            {
                MessageBox.Show("O campo Pagamento é de preenchimento obrigatório", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);
                return false;
            }
            return true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            var a = Convert.ToInt32(txtNumero.Text);
            if (MensagemAviso.MensagemUsuario(3, null))
            {
                using (var oDB = new CDespesa.CDespesaClient())
                {
                    var result = MensagemErro.Erro(oDB.ExcluirAsync(a).Result);
                    if (result)
                        MensagemAviso.MensagemUsuario(4, "Despsa");
                }
                AtualizaDataSource();
            }
        }

        private void AtualizaDataSource()
        {
            using (var oDB = new CDespesa.CDespesaClient())
            {
                despesaBindingSource.DataSource = oDB.SelecionarTodosAsync().Result.ToList();
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Inserir = true;
            bindingNavigatorAddNewItem.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = false;
            despesaBindingNavigatorSaveItem.Enabled = true;
            toolStripButton1.Enabled = false;
            SelecionaCampos(true);
        }

        private void FrmDespesa_Load(object sender, EventArgs e)
        {
            AtualizaDataSource();
        }
    }
}
