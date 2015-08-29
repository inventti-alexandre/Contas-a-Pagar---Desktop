using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Contas_a_Pagar___Desktop.View
{
    public partial class FrmSolicitacaoMaterial : Form
    {
        public bool Inserir = false;
        private List<CSolicitacaoMaterial.Material> ListaMateriais = new List<CSolicitacaoMaterial.Material>();

        public FrmSolicitacaoMaterial()
        {
            InitializeComponent();
        }

        private void FrmSolicitacaoMaterial_Load(object sender, EventArgs e)
        {
            AtualizaDataSourceMaterialAsync();
            AtualizaDataSourceSolicitacao();
            bindingNavigatorAddNewItem.Enabled = true;
        }

        private void AtualizaDataSourceSolicitacao()
        {
            using (var oDB = new CSolicitacaoMaterial.CSolicitacaoMaterialClient())
            {
                solicitacaoMaterialBindingSource.DataSource = oDB.SelecionarTodosAsync().Result.ToList();
            }
        }

        private async void AtualizaDataSourceMaterialAsync()
        {
            using (var oDB = new CSolicitacaoMaterial.CSolicitacaoMaterialClient())
            {
                materialBindingSource.DataSource = await oDB.SelecionarTodosMateriaisAsync();
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            dtpData.Value = DateTime.Now;
            solicitacaoMaterialBindingNavigatorSaveItem.Enabled = true;
            bindingNavigatorAddNewItem.Enabled = false;
            Inserir = true;
        }

        private void solicitacaoMaterialBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            using (var oDB = new CSolicitacaoMaterial.CSolicitacaoMaterialClient())
            {
                if (ValidaCampos())
                {
                    CSolicitacaoMaterial.SolicitacaoMaterial oSolicitacao = new CSolicitacaoMaterial.SolicitacaoMaterial();
                    if (Inserir)
                    {
                        oSolicitacao.Data = DateTime.Now;
                        oSolicitacao.Aprovado = false;
                        oSolicitacao.Setor = Convert.ToInt32(txtSetor.Text);
                        oSolicitacao.Material = ListaMateriais;
                        var result = MensagemErro.Erro(oDB.Inserir(oSolicitacao));
                        if (result)
                            MensagemAviso.MensagemUsuario(1, "Solicitação de Material");
                    }
                    solicitacaoMaterialBindingNavigatorSaveItem.Enabled = false;
                    bindingNavigatorAddNewItem.Enabled = true;
                    AtualizaDataSourceSolicitacao();
                    AtualizaDataSourceMaterialAsync();
                }
            }
        }

        private bool ValidaCampos()
        {
            using (var oDB = new CSetor.CSetorClient())
            {
                /*if (oDB.SetorExiste(Convert.ToInt32(txtSetor.Text)) == false)
                {
                    MessageBox.Show("O Fornecedor não existe", "Aviso",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                                    MessageBoxDefaultButton.Button1);
                    return false;
                }*/
            }
            if (txtSetor.Text == "")
            {
                MessageBox.Show("O campo Setor é de preenchimento obrigatório", "Aviso",
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

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (dtgMaterial.SelectedRows.Count > 0)
            {
                var Material = dtgMaterial.SelectedRows[0].DataBoundItem as CSolicitacaoMaterial.Material;
                ListaMateriais.Add(Material);
                var b = dtgMaterial.SelectedRows[0].Index;
                if (dtgMaterial.Rows[b].Cells["Qtde"].Value == null)
                {
                    dtgMaterial.Rows[b].Cells["Qtde"].Value = "0";
                }
                uint a = Convert.ToUInt32(dtgMaterial.Rows[b].Cells["Qtde"].Value.ToString());

                a += 1;
                dtgMaterial.Rows[b].Cells["Qtde"].Value = a.ToString();
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dtgMaterial.SelectedRows.Count > 0)
            {
                var Material = dtgMaterial.SelectedRows[0].DataBoundItem as CSolicitacaoMaterial.Material;
                ListaMateriais.Remove(Material);
                var b = dtgMaterial.SelectedRows[0].Index;
                if (dtgMaterial.Rows[b].Cells["Qtde"].Value == null)
                {
                    dtgMaterial.Rows[b].Cells["Qtde"].Value = "0";
                }
                uint a = Convert.ToUInt32(dtgMaterial.Rows[b].Cells["Qtde"].Value.ToString());
                if (a > 0)
                {
                    a -= 1;
                    dtgMaterial.Rows[b].Cells["Qtde"].Value = a.ToString();
                }
            }
        }
    }
}