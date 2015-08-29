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
using System.Timers;
using System.ServiceModel.Dispatcher;

namespace Contas_a_Pagar___Desktop.View
{
    public partial class FrmPrincipal : Form
    {
        private System.Timers.Timer a = new System.Timers.Timer();
        private System.Windows.Forms.Timer b = new System.Windows.Forms.Timer();
        private bool clock=true;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmfornecedor = new FrmFornecedor();
            frmfornecedor.MdiParent = this;
            frmfornecedor.Show();
        }

        private void fornecedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frmListaFornecedores = new FrmListaFornecedores();
            frmListaFornecedores.MdiParent = this;
            frmListaFornecedores.Show();
        }
        
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            //var thrd = new Thread(new ThreadStart(CarregaForm));
            //thrd.Start();
            backgroundWorker1.RunWorkerAsync();
            CarregaForm();
        }

        private void CarregaForm()
        {
            foreach (var control in this.Controls)
            {
                MdiClient client = control as MdiClient;
                if (!(client == null))
                {
                    client.BackColor = Color.White;
                    break;
                }
            }

            b.Interval = 1;
            b.Enabled = true;
            b.Start();
            b.Tick += new EventHandler(OnTimedEvent2);
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmMaterial = new FrmMaterial();
            frmMaterial.MdiParent = this;
            frmMaterial.Show();
        }

        private void materialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmlistamaterial = new FrmListaMaterial();
            frmlistamaterial.MdiParent = this;
            frmlistamaterial.Show();
        }

        private void bancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmagencia = new FrmAgencia();
            frmagencia.MdiParent = this;
            frmagencia.Show();
        }

        private void setorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmsetor = new FrmSetor();
            frmsetor.MdiParent = this;
            frmsetor.Show();
        }

        private void setorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frmlistasetor = new FrmListaSetor();
            frmlistasetor.MdiParent = this;
            frmlistasetor.Show();
        }

        private void bancoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frmbanco = new FrmBanco();
            frmbanco.MdiParent = this;
            frmbanco.Show();
        }

        private void agênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmlistaagencia = new FrmListaAgencia();
            frmlistaagencia.MdiParent = this;
            frmlistaagencia.Show();
        }

        private void contaCorrenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmlistacc = new FrmListaContaCorrente();
            frmlistacc.MdiParent = this;
            frmlistacc.Show();
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmcontacorrente = new FrmContaCorrente();
            frmcontacorrente.MdiParent = this;
            frmcontacorrente.Show();
        }

        private void bancoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var frmbanco = new FrmListaBanco();
            frmbanco.MdiParent = this;
            frmbanco.Show();
        }

        private void lançamentoNoPlanoDeContasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frmplanocontas = new FrmPlanoContas();
            frmplanocontas.MdiParent = this;
            frmplanocontas.Show();
        }

        private void lançamentoNoPlanoDeContasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmlistaplanocontas = new FrmListaPlanoContas();
            frmlistaplanocontas.MdiParent = this;
            frmlistaplanocontas.Show();
        }

        private void lançamentoNoPlanoDeContasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var frmlancamento = new FrmLancamento();
            frmlancamento.MdiParent = this;
            frmlancamento.Show();
        }

        private void lançamentoNoPlanoDeContasToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            var frmlistalancamento = new FrmListaLancamento();
            frmlistalancamento.MdiParent = this;
            frmlistalancamento.Show();
        }

        private void fornecimentoDeMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fornecimentoDeMaterialToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void pagamentosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frmpagamentos = new FrmPagamento();
            frmpagamentos.MdiParent = this;
            frmpagamentos.Show();
        }

        private void despesasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var frmlistadespesa = new FrmListaDespesa();
            frmlistadespesa.MdiParent = this;
            frmlistadespesa.Show();
        }

        private void pagamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmlistapagamentos = new FrmListaPagamentos();
            frmlistapagamentos.MdiParent = this;
            frmlistapagamentos.Show();
        }

        private void despesasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frmdespesa = new FrmDespesa();
            frmdespesa.MdiParent = this;
            frmdespesa.Show();
        }

        private void solicitarMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmsolicitacao = new FrmSolicitacaoMaterial();
            frmsolicitacao.MdiParent = this;
            frmsolicitacao.Show();
        }

        private void solicitaçõesDeMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aprovarSolicitaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmaprovarsolicitacao = new FrmAprovarSolicitacao();
            frmaprovarsolicitacao.MdiParent = this;
            frmaprovarsolicitacao.Show();
        }

        private void solicitaçãoDeMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void númeroDeSolicitaçõesPorSetorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmsolsetor = new FrmListaSolicitacoesPorSetor();
            frmsolsetor.MdiParent = this;
            frmsolsetor.Show();
        }

        private void númeroDeFornecimentosPorEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmforempre = new FrmListaFornecimentosPorEmpresa();
            frmforempre.MdiParent = this;
            frmforempre.Show();
        }

        private void solicitaçõesPorSetorAprovadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmSolicitacoesPorSetorAprovadas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void listaDeSolicitaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmlistasolicitacao = new FrmListaSolicitacao();
            frmlistasolicitacao.MdiParent = this;
            frmlistasolicitacao.Show();
        }

        private void listaDeFornecimentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmlistafornecimento = new FrmListaFornecimentos();
            frmlistafornecimento.MdiParent = this;
            frmlistafornecimento.Show();
        }

        private void solicitaçõesPorSetorNãoAprovadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmSolicitacoesPorSetorNaoAprovadas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void cancelarFornecimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmCancelarFornecimento();
            frm.MdiParent = this;
            frm.Show();
        }

        private void fornecimentoDeMaterialToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var frmfornecimento = new FrmFornecimentoMaterial();
            frmfornecimento.MdiParent = this;
            frmfornecimento.Show();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            //a.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            //a.Interval = 10;
            //a.Enabled = true;

        }

        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            if(toolStripStatusLabel1.IsDisposed==false)
            {
                Invoke(new MethodInvoker(() => toolStripStatusLabel1.Text = DateTime.Now.ToLongDateString()), null);
                Invoke(new MethodInvoker(() => toolStripStatusLabel2.Text = DateTime.Now.ToLongTimeString()), null);
            }
        }
        private void OnTimedEvent2(object sender, EventArgs e)
        {
            //if (toolStripStatusLabel1.IsDisposed == false)
            //{
            //    Invoke(new MethodInvoker(() => toolStripStatusLabel1.Text = DateTime.Now.ToLongDateString()), null);
            //    Invoke(new MethodInvoker(() => toolStripStatusLabel2.Text = DateTime.Now.ToLongTimeString()), null);
            //}
            toolStripStatusLabel1.Text = DateTime.Now.ToLongDateString();
            toolStripStatusLabel2.Text = DateTime.Now.ToLongTimeString();

        }
        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            clock = false;
            backgroundWorker1.Dispose();
        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            clock = false;
            backgroundWorker1.Dispose();
        }
    }
}
