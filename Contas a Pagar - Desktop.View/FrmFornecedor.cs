using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contas_a_Pagar___Desktop.View
{
    public partial class FrmFornecedor : Form
    {
        bool Inserir = false;
        public FrmFornecedor()
        {
            InitializeComponent();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void AtualizaDataSource()
        {
            using (var oDB = new CFornecedor.CFornecedorClient())
            {
                fornecedorBindingSource.DataSource = oDB.SelecionarTodosAsync().Result.ToList();
            }
        }
        private void FrmFornecedor_Load(object sender, EventArgs e)
        {
            AtualizaDataSource();
            fornecedorBindingNavigator.AddNewItem.Enabled = true;
        }

        private void bindingNavigatorAddNewItem_Click_1(object sender, EventArgs e)
        {
            Inserir = true;
            bindingNavigatorAddNewItem.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = false;
            fornecedorBindingNavigatorSaveItem.Enabled = true;
            toolStripButton1.Enabled = false;
            SelecionaCampos(true);
        }
        private void SelecionaCampos(bool Habilitar)
        {
            var a = new List<TextBox>();
            a.Add(txtCidade);
            a.Add(txtCNPJ);
            a.Add(txtEndereco);
            a.Add(txtRazaoSocial);
            if (Habilitar)
                EstadoCampos.HabilitaCampos(a);
            else
                EstadoCampos.DesabilitaCampos(a);
        }
        private void fornecedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            using (var oDB = new CFornecedor.CFornecedorClient())
            {
                if (ValidaCampos())
                {
                    var oFornecedor = new CFornecedor.Fornecedor();
                    oFornecedor.Cidade = txtCidade.Text;
                    oFornecedor.CNPJ = txtCNPJ.Text;
                    oFornecedor.Endereco = txtEndereco.Text;
                    oFornecedor.Estado = cmbEstado.SelectedItem.ToString();
                    oFornecedor.RazaoSocial = txtRazaoSocial.Text;
                    if (Inserir)
                    {
                        var result = MensagemErro.Erro(oDB.InserirAsync(oFornecedor).Result);
                        if (result)
                            MensagemAviso.MensagemUsuario(1, "Fornecedor");
                    }
                    else
                    {
                        oFornecedor.ID = Convert.ToInt32(txtID.Text);
                        var result = MensagemErro.Erro(oDB.AlterarAsync(oFornecedor).Result);
                        if (result)
                            MensagemAviso.MensagemUsuario(2, "Fornecedor");
                    }
                    AtualizaDataSource();
                    Inserir = false;
                    toolStripButton1.Enabled = true;
                    bindingNavigatorAddNewItem.Enabled = true;
                    bindingNavigatorDeleteItem.Enabled = true;
                    fornecedorBindingNavigatorSaveItem.Enabled = false;
                    SelecionaCampos(false);
                }
            }
        }
        private bool ValidaCampos()
        {
           if (txtCidade.Text=="")
            {
                MessageBox.Show("O campo Cidade é de preenchimento obrigatório", "Aviso", 
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation, 
                                MessageBoxDefaultButton.Button1);
                return false;
            }
           else if (txtCNPJ.Text == "")
            {
                MessageBox.Show("O campo CNPJ é de preenchimento obrigatório", "Aviso",
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
            else if (txtRazaoSocial.Text == "")
            {
                MessageBox.Show("O campo Razão Social é de preenchimento obrigatório", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);
                return false;
            }
            else if (cmbEstado.SelectedItem.ToString() == "")
            {
                MessageBox.Show("O campo Estado é de seleção obrigatória", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);
                return false;
            }
            return true;
        }

        private void fornecedorBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if(MensagemAviso.MensagemUsuario(3, null))
            {
                using (var oDB = new CFornecedor.CFornecedorClient())
                {
                    var result = MensagemErro.Erro(oDB.ExcluirAsync(Convert.ToInt32(txtID.Text)).Result);
                    if (result)
                        MensagemAviso.MensagemUsuario(4, "Fornecedor");
                }
                AtualizaDataSource();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            toolStripButton1.Enabled = false;
            Inserir = false;
            bindingNavigatorDeleteItem.Enabled = false;
            fornecedorBindingNavigatorSaveItem.Enabled = true;
            bindingNavigatorAddNewItem.Enabled = false;
            SelecionaCampos(true);
        }
    }
}
