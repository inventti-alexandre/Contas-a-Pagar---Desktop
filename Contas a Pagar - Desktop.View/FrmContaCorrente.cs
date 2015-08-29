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
    public partial class FrmContaCorrente : Form
    {
        private bool Inserir=false;

        public FrmContaCorrente()
        {
            InitializeComponent();
        }

        private void FrmContaCorrente_Load(object sender, EventArgs e)
        {
            AtualizaDataSourceAsync();
        }

        private void AtualizaDataSourceAsync()
        {
            using (var oDB = new CContaCorrente.CContaCorrenteClient())
            {
                contaCorrenteBindingSource.DataSource = oDB.SelecionarTodosAsync().Result.ToList();
            }
        }
        private void SelecionaCampos(bool Habilitar)
        {
            var a = new List<TextBox>();
            a.Add(txtAgencia);
            a.Add(txtConta);
            a.Add(txtLimite);
            if (Habilitar)
                EstadoCampos.HabilitaCampos(a);
            else
                EstadoCampos.DesabilitaCampos(a);
        }
        private void contaCorrenteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if(ValidaCampos())
            {
                using (var oDB = new CContaCorrente.CContaCorrenteClient())
                {
                    var oContaCorrente = new CContaCorrente.ContaCorrente();
                    oContaCorrente.Agencia = Convert.ToInt32(txtAgencia.Text);
                    oContaCorrente.Conta = txtConta.Text;
                    oContaCorrente.Limite = Convert.ToDecimal(txtLimite.Text);
                    if (Inserir)
                    {
                        var result = MensagemErro.Erro(oDB.InserirAsync(oContaCorrente).Result);
                        if (result)
                            MensagemAviso.MensagemUsuario(1, "Conta Corrente");
                    }
                    else
                    {
                        var result = MensagemErro.Erro(oDB.AlterarAsync(oContaCorrente).Result);
                        if (result)
                            MensagemAviso.MensagemUsuario(2, "Conta Corrente");
                    }
                }
                AtualizaDataSourceAsync();
                Inserir = false;
                toolStripButton1.Enabled = true;
                bindingNavigatorAddNewItem.Enabled = true;
                bindingNavigatorDeleteItem.Enabled = true;
                contaCorrenteBindingNavigatorSaveItem.Enabled = false;
                SelecionaCampos(false);
            }
           
        }

        private bool ValidaCampos()
        {
            using (var oDB = new CAgencia.CAgenciaClient())
            {
                if (oDB.AgenciaExiste(Convert.ToInt32(txtAgencia.Text)) == false)
                {
                    MessageBox.Show("O Banco não existe", "Aviso",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                                    MessageBoxDefaultButton.Button1);
                    return false;
                }
            }
            if (txtAgencia.Text == "")
            {
                MessageBox.Show("O campo Agência é de preenchimento obrigatório", "Aviso",
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
            if (txtLimite.Text == "")
            {
                MessageBox.Show("O campo Limite é de preenchimento obrigatório", "Aviso",
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
            contaCorrenteBindingNavigatorSaveItem.Enabled = true;
            bindingNavigatorAddNewItem.Enabled = false;
            SelecionaCampos(true);
            txtConta.ReadOnly = true;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Inserir = true;
            bindingNavigatorAddNewItem.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = false;
            contaCorrenteBindingNavigatorSaveItem.Enabled = true;
            toolStripButton1.Enabled = false;
            SelecionaCampos(true);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if(MensagemAviso.MensagemUsuario(3, null))
            {
                using (var oDB = new CContaCorrente.CContaCorrenteClient())
                {
                    var result = MensagemErro.Erro(oDB.ExcluirAsync(txtConta.Text).Result);
                    if (result)
                        MensagemAviso.MensagemUsuario(4, "Conta Corrente");
                }
                AtualizaDataSourceAsync();
            }

        }

        private void txtAgencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacaoNumericos.NumericKeyPress(e);
        }

        private void txtConta_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacaoNumericos.NumericKeyPress(e);
        }
    }
}
