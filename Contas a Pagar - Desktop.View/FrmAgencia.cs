using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Contas_a_Pagar___Desktop.View
{
    public partial class FrmAgencia : Form
    {
        public bool Inserir = false;

        public FrmAgencia()
        {
            InitializeComponent();
        }

        private void FrmAgencia_Load(object sender, EventArgs e)
        {
            AtualizaDataSource();
        }

        private void AtualizaDataSource()
        {
            using (var oDB = new CAgencia.CAgenciaClient())
            {
                agenciaBindingSource.DataSource = oDB.SelecionarTodosAsync().Result.ToList();
            }
        }

        private void agenciaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                using (var oDB = new CAgencia.CAgenciaClient())
                {
                    var oAgencia = new CAgencia.Agencia();
                    oAgencia.Banco = int.Parse(txtBanco.Text);
                    oAgencia.Cidade = txtCidade.Text;
                    oAgencia.Email = txtEmail.Text;
                    oAgencia.Endereco = txtEndereco.Text;
                    oAgencia.Gerente = txtGerente.Text;
                    oAgencia.Telefone = txtTelefone.Text;
                    if (Inserir)
                    {
                        var result = MensagemErro.Erro(oDB.InserirAsync(oAgencia).Result);
                        if (result)
                            MensagemAviso.MensagemUsuario(1, "Agência");
                    }
                    else
                    {
                        oAgencia.ID = Convert.ToInt32(txtID.Text);
                        var result = MensagemErro.Erro(oDB.AlterarAsync(oAgencia).Result);
                        if (result)
                            MensagemAviso.MensagemUsuario(2, "Agência");
                    }
                }
                AtualizaDataSource();
                toolStripButton1.Enabled = true;
                bindingNavigatorAddNewItem.Enabled = true;
                bindingNavigatorDeleteItem.Enabled = true;
                Inserir = false;
                agenciaBindingNavigatorSaveItem.Enabled = false;
                SelecionaCampos(false);
            }
        }

        private bool ValidaCampos()
        {
            using (var oDB = new CBanco.CBancoClient())
            {
                if (oDB.BancoExiste(Convert.ToInt32(txtBanco.Text)) == false)
                {
                    MessageBox.Show("O Banco não existe", "Aviso",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                                    MessageBoxDefaultButton.Button1);
                    return false;
                }
            }
            if (txtCidade.Text == "")
            {
                MessageBox.Show("O campo Cidade é de preenchimento obrigatório", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);
                return false;
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("O campo Email é de preenchimento obrigatório", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);
                return false;
            }
            else if (txtEndereco.Text == "")
            {
                MessageBox.Show("O campo Endereço é de preenchimento obrigatório", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);
                return false;
            }
            else if (txtGerente.Text == "")
            {
                MessageBox.Show("O campo Gerente é de preenchimento obrigatório", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);
                return false;
            }
            else if (txtTelefone.Text == "")
            {
                MessageBox.Show("O campo Telefone é de preenchimento obrigatório", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);
                return false;
            }
            else if (txtBanco.Text == "")
            {
                MessageBox.Show("O campo Banco é de preenchimento obrigatório", "Aviso",
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
            agenciaBindingNavigatorSaveItem.Enabled = true;
            toolStripButton1.Enabled = false;
            SelecionaCampos(true);
        }

        private void SelecionaCampos(bool Habilitar)
        {
            var a = new List<TextBox>();
            a.Add(txtBanco);
            a.Add(txtCidade);
            a.Add(txtEmail);
            a.Add(txtEndereco);
            a.Add(txtGerente);
            a.Add(txtTelefone);
            if (Habilitar)
                EstadoCampos.HabilitaCampos(a);
            else
                EstadoCampos.DesabilitaCampos(a);
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            toolStripButton1.Enabled = false;
            Inserir = false;
            bindingNavigatorDeleteItem.Enabled = false;
            agenciaBindingNavigatorSaveItem.Enabled = true;
            bindingNavigatorAddNewItem.Enabled = false;
            SelecionaCampos(true);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MensagemAviso.MensagemUsuario(3, null))
            {
                using (var oDB = new CAgencia.CAgenciaClient())
                {
                    var result = MensagemErro.Erro(oDB.ExcluirAsync(Convert.ToInt32(txtID.Text)).Result);
                    if (result)
                        MensagemAviso.MensagemUsuario(4, "Agência");
                }
                AtualizaDataSource();
            }
        }
    }
}