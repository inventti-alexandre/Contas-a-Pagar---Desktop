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
    public partial class FrmBanco : Form
    {
        bool Inserir = false;
        public FrmBanco()
        {
            InitializeComponent();
        }

        private void FrmBanco_Load(object sender, EventArgs e)
        {
            AtualizaDataSource();
            bindingNavigatorAddNewItem.Enabled = true;
        }
        private void AtualizaDataSource()
        {
            using (var oDB = new CBanco.CBancoClient())
            {
                bancoBindingSource.DataSource = oDB.SelecionarTodosAsync().Result.ToList();
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Inserir = true;
            bindingNavigatorAddNewItem.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = false;
            bancoBindingNavigatorSaveItem.Enabled = true;
            toolStripButton1.Enabled = false;
            SelecionaCampos(true);

        }
        private void SelecionaCampos(bool Habilitar)
        {
            var a = new List<TextBox>();
            a.Add(txtNome);
            a.Add(txtNumero);
            if (Habilitar)
                EstadoCampos.HabilitaCampos(a);
            else
                EstadoCampos.DesabilitaCampos(a);
        }
        private void bancoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                using (var oDB = new CBanco.CBancoClient())
                {
                    var oBanco = new CBanco.Banco();
                    oBanco.Nome = txtNome.Text;
                    oBanco.Numero = txtNumero.Text;
                    if (Inserir)
                    {
                        var result = MensagemErro.Erro(oDB.InserirAsync(oBanco).Result);
                        if (result)
                            MensagemAviso.MensagemUsuario(1, "Banco");
                    }
                    else
                    {
                        oBanco.ID = Convert.ToInt32(txtID);
                        var result = MensagemErro.Erro(oDB.AlterarAsync(oBanco).Result);
                        if (result)
                            MensagemAviso.MensagemUsuario(2, "Banco");
                    }
                    AtualizaDataSource();
                    Inserir = false;
                    toolStripButton1.Enabled = true;
                    bindingNavigatorAddNewItem.Enabled = true;
                    bindingNavigatorDeleteItem.Enabled = true;
                    bancoBindingNavigatorSaveItem.Enabled = false;
                    SelecionaCampos(false);
                }
            }
        }

        private bool ValidaCampos()
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("O campo Nome é de preenchimento obrigatório", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);
                return false;
            }
            if (txtNumero.Text == "")
            {
                MessageBox.Show("O campo Numero é de preenchimento obrigatório", "Aviso",
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
            bancoBindingNavigatorSaveItem.Enabled = true;
            bindingNavigatorAddNewItem.Enabled = false;
            SelecionaCampos(true);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if(MensagemAviso.MensagemUsuario(3, null))
            {
                using (var oDB = new CBanco.CBancoClient())
                {
                    var result = MensagemErro.Erro(oDB.ExcluirAsync(Convert.ToInt32(txtID.Text)).Result);
                    if (result)
                        MensagemAviso.MensagemUsuario(4, "Banco");
                }
                AtualizaDataSource();
            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacaoNumericos.NumericKeyPress(e);
        }
    }
}
