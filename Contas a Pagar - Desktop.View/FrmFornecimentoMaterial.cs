using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Contas_a_Pagar___Desktop.View
{
    public partial class FrmFornecimentoMaterial : Form
    {
        public bool Inserir = false;
        private List<CFornecimentoMaterial.Material> ListaMateriais = new List<CFornecimentoMaterial.Material>();

        public FrmFornecimentoMaterial()
        {
            InitializeComponent();
        }

        private void AtualizaDataSourceFornecimento()
        {
            using (var oDB = new CFornecimentoMaterial.CFornecimentoMaterialClient())
            {
                fornecimentoMaterialBindingSource.DataSource = oDB.SelecionarTodosAsync().Result.ToList();
            }
        }

        private async void AtualizaDataSourceMaterialAsync()
        {
            using (var oDB = new CFornecimentoMaterial.CFornecimentoMaterialClient())
            {
                materialBindingSource1.DataSource = await oDB.SelecionarTodosMateriaisAsync();
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (dtgMaterial.SelectedRows.Count > 0)
            {
                var Material = dtgMaterial.SelectedRows[0].DataBoundItem as CFornecimentoMaterial.Material;
                ListaMateriais.Add(Material);
                var a = dtgMaterial.SelectedRows[0].Index;
                dtgMaterial.CurrentCell = null;
                dtgMaterial.Rows[a].Visible = false;
            }
        }

        private void fornecimentoMaterialBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            using (var oDB = new CFornecimentoMaterial.CFornecimentoMaterialClient())
            {
                if (ValidaCampos())
                {
                    CFornecimentoMaterial.FornecimentoMaterial oFornecimento = new CFornecimentoMaterial.FornecimentoMaterial();
                    if (Inserir)
                    {
                        oFornecimento.Data = DateTime.Now;
                        oFornecimento.Fornecedor = Convert.ToInt32(txtFornecedor.Text);
                        oFornecimento.Servico = Convert.ToInt32(txtServico.Text);
                        oFornecimento.Material = ListaMateriais;
                        oFornecimento.Cancelado = false;
                        var result = MensagemErro.Erro(oDB.Inserir(oFornecimento));
                        if (result)
                            MensagemAviso.MensagemUsuario(1, "Fornecimento de Material");
                    }
                    fornecimentoMaterialBindingNavigatorSaveItem.Enabled = false;
                    bindingNavigatorAddNewItem.Enabled = true;
                    AtualizaDataSourceFornecimento();
                    AtualizaDataSourceMaterialAsync();
                }
            }
        }

        private void FrmFornecimentoMaterial_Load(object sender, EventArgs e)
        {
            AtualizaDataSourceMaterialAsync();
            AtualizaDataSourceFornecimento();
        }

        private bool ValidaCampos()
        {
            using (var oDB = new CFornecedor.CFornecedorClient())
            {
                if (oDB.FornecedorExiste(Convert.ToInt32(txtFornecedor.Text)) == false)
                {
                    MessageBox.Show("O Fornecedor não existe", "Aviso",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                                    MessageBoxDefaultButton.Button1);
                    return false;
                }
            }
            if (txtFornecedor.Text == "")
            {
                MessageBox.Show("O campo Fornecedor é de preenchimento obrigatório", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);
                return false;
            }
            else if (txtServico.Text == "")
            {
                MessageBox.Show("O campo Serviço é de preenchimento obrigatório", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);
                return false;
            }
            else if (ListaMateriais.Count() == 0)
            {
                MessageBox.Show("O fornecimento deve ter pelo menos 1 (um) item", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);
                return false;
            }
            return true;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            dtpData.Value = DateTime.Now;
            fornecimentoMaterialBindingNavigatorSaveItem.Enabled = true;
            bindingNavigatorAddNewItem.Enabled = false;
            Inserir = true;
        }
    }
}