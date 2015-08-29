using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Contas_a_Pagar___Desktop.View
{
    public partial class FrmMaterial : Form
    {
        bool Inserir = false;
        public FrmMaterial()
        {
            InitializeComponent();
        }

        private void FrmMaterial_Load(object sender, EventArgs e)
        {
            AtualizaDataSource();
            materialBindingNavigator.AddNewItem.Enabled = true;
        }

        private void AtualizaDataSource()
        {
            using (var oDB = new CMaterial.CMaterialClient())
            {
                materialBindingSource.DataSource = oDB.SelecionarTodosAsync().Result.ToList();
            }
        }
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Inserir = true;
            bindingNavigatorAddNewItem.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = false;
            materialBindingNavigatorSaveItem.Enabled = true;
            toolStripButton1.Enabled = false;
            SelecionaCampos(true);
        }
        private void SelecionaCampos(bool Habilitar)
        {
            var a = new List<TextBox>();
            a.Add(txtDescricao);
            a.Add(txtPrecoUnitario);
            if (Habilitar)
                EstadoCampos.HabilitaCampos(a);
            else
                EstadoCampos.DesabilitaCampos(a);
        }
        private void materialBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            using (var oDB = new CMaterial.CMaterialClient())
            {
                if (ValidaCampos())
                {
                    var oMaterial = new CMaterial.Material();
                    oMaterial.Descricao = txtDescricao.Text;
                    oMaterial.PrecoUnitario = Convert.ToDecimal(txtPrecoUnitario.Text);
                    if (Inserir)
                    {
                        var result = MensagemErro.Erro(oDB.InserirAsync(oMaterial).Result);
                        if(result)
                            MensagemAviso.MensagemUsuario(1, "Material");
                    }
                    else
                    {
                        oMaterial.ID = Convert.ToInt32(txtID.Text);
                        var result = MensagemErro.Erro(oDB.AlterarAsync(oMaterial).Result);
                        if(result)
                        MensagemAviso.MensagemUsuario(2, "Material");
                    }
                    AtualizaDataSource();
                    toolStripButton1.Enabled = true;
                    bindingNavigatorAddNewItem.Enabled = true;
                    bindingNavigatorDeleteItem.Enabled = true;
                    Inserir = false;
                    materialBindingNavigatorSaveItem.Enabled = false;
                    SelecionaCampos(false);
                }
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
            else if (txtPrecoUnitario.Text == "")
            {
                MessageBox.Show("O campo Preço Unitário é de preenchimento obrigatório", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);
                return false;
            }
            return true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            var a = Convert.ToInt32(txtID.Text);
            if(MensagemAviso.MensagemUsuario(3, null))
            {
                using (var oDB = new CMaterial.CMaterialClient())
                {
                    var result = MensagemErro.Erro(oDB.ExcluirAsync(Convert.ToInt32(txtID.Text)).Result);
                    if (result)
                        MensagemAviso.MensagemUsuario(4, "Material");
                }
                AtualizaDataSource();
            }
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            toolStripButton1.Enabled = false;
            Inserir = false;
            bindingNavigatorDeleteItem.Enabled = false;
            materialBindingNavigatorSaveItem.Enabled = true;
            bindingNavigatorAddNewItem.Enabled = false;
            SelecionaCampos(true);
        }

        private void txtPrecoUnitario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecoUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacaoNumericos.NumericKeyPress(e);
        }
    }
}
