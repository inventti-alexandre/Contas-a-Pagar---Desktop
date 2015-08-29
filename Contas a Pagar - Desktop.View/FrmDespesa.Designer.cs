namespace Contas_a_Pagar___Desktop.View
{
    partial class FrmDespesa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label lancamentoLabel;
            System.Windows.Forms.Label numeroLabel;
            System.Windows.Forms.Label pagamentoLabel;
            System.Windows.Forms.Label valorPrevistoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDespesa));
            this.despesaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.despesaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.despesaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtLancamento = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtPagamento = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            descricaoLabel = new System.Windows.Forms.Label();
            lancamentoLabel = new System.Windows.Forms.Label();
            numeroLabel = new System.Windows.Forms.Label();
            pagamentoLabel = new System.Windows.Forms.Label();
            valorPrevistoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.despesaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.despesaBindingNavigator)).BeginInit();
            this.despesaBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(13, 57);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(58, 13);
            descricaoLabel.TabIndex = 1;
            descricaoLabel.Text = "Descrição:";
            // 
            // lancamentoLabel
            // 
            lancamentoLabel.AutoSize = true;
            lancamentoLabel.Location = new System.Drawing.Point(13, 135);
            lancamentoLabel.Name = "lancamentoLabel";
            lancamentoLabel.Size = new System.Drawing.Size(69, 13);
            lancamentoLabel.TabIndex = 3;
            lancamentoLabel.Text = "Lançamento:";
            // 
            // numeroLabel
            // 
            numeroLabel.AutoSize = true;
            numeroLabel.Location = new System.Drawing.Point(13, 31);
            numeroLabel.Name = "numeroLabel";
            numeroLabel.Size = new System.Drawing.Size(47, 13);
            numeroLabel.TabIndex = 5;
            numeroLabel.Text = "Número:";
            // 
            // pagamentoLabel
            // 
            pagamentoLabel.AutoSize = true;
            pagamentoLabel.Location = new System.Drawing.Point(13, 83);
            pagamentoLabel.Name = "pagamentoLabel";
            pagamentoLabel.Size = new System.Drawing.Size(64, 13);
            pagamentoLabel.TabIndex = 7;
            pagamentoLabel.Text = "Pagamento:";
            // 
            // valorPrevistoLabel
            // 
            valorPrevistoLabel.AutoSize = true;
            valorPrevistoLabel.Location = new System.Drawing.Point(13, 109);
            valorPrevistoLabel.Name = "valorPrevistoLabel";
            valorPrevistoLabel.Size = new System.Drawing.Size(75, 13);
            valorPrevistoLabel.TabIndex = 9;
            valorPrevistoLabel.Text = "Valor Previsto:";
            // 
            // despesaBindingSource
            // 
            this.despesaBindingSource.DataSource = typeof(Contas_a_Pagar___Desktop.View.CDespesa.Despesa);
            // 
            // despesaBindingNavigator
            // 
            this.despesaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.despesaBindingNavigator.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.despesaBindingNavigator.BindingSource = this.despesaBindingSource;
            this.despesaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.despesaBindingNavigator.CountItemFormat = "de {0}";
            this.despesaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.despesaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.despesaBindingNavigatorSaveItem,
            this.toolStripButton1});
            this.despesaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.despesaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.despesaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.despesaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.despesaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.despesaBindingNavigator.Name = "despesaBindingNavigator";
            this.despesaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.despesaBindingNavigator.Size = new System.Drawing.Size(316, 25);
            this.despesaBindingNavigator.TabIndex = 0;
            this.despesaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // despesaBindingNavigatorSaveItem
            // 
            this.despesaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.despesaBindingNavigatorSaveItem.Enabled = false;
            this.despesaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("despesaBindingNavigatorSaveItem.Image")));
            this.despesaBindingNavigatorSaveItem.Name = "despesaBindingNavigatorSaveItem";
            this.despesaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.despesaBindingNavigatorSaveItem.Text = "Save Data";
            this.despesaBindingNavigatorSaveItem.Click += new System.EventHandler(this.despesaBindingNavigatorSaveItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Contas_a_Pagar___Desktop.View.Properties.Resources.eraser;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.despesaBindingSource, "Descricao", true));
            this.txtDescricao.Location = new System.Drawing.Point(94, 54);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(100, 20);
            this.txtDescricao.TabIndex = 2;
            // 
            // txtLancamento
            // 
            this.txtLancamento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.despesaBindingSource, "Lancamento", true));
            this.txtLancamento.Location = new System.Drawing.Point(94, 132);
            this.txtLancamento.Name = "txtLancamento";
            this.txtLancamento.Size = new System.Drawing.Size(100, 20);
            this.txtLancamento.TabIndex = 4;
            // 
            // txtNumero
            // 
            this.txtNumero.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.despesaBindingSource, "Numero", true));
            this.txtNumero.Location = new System.Drawing.Point(94, 28);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.ReadOnly = true;
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 6;
            // 
            // txtPagamento
            // 
            this.txtPagamento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.despesaBindingSource, "Pagamento", true));
            this.txtPagamento.Location = new System.Drawing.Point(94, 80);
            this.txtPagamento.Name = "txtPagamento";
            this.txtPagamento.Size = new System.Drawing.Size(100, 20);
            this.txtPagamento.TabIndex = 8;
            // 
            // txtValor
            // 
            this.txtValor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.despesaBindingSource, "ValorPrevisto", true));
            this.txtValor.Location = new System.Drawing.Point(94, 106);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 10;
            // 
            // FrmDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(316, 154);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(lancamentoLabel);
            this.Controls.Add(this.txtLancamento);
            this.Controls.Add(numeroLabel);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(pagamentoLabel);
            this.Controls.Add(this.txtPagamento);
            this.Controls.Add(valorPrevistoLabel);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.despesaBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDespesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Despesas";
            this.Load += new System.EventHandler(this.FrmDespesa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.despesaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.despesaBindingNavigator)).EndInit();
            this.despesaBindingNavigator.ResumeLayout(false);
            this.despesaBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource despesaBindingSource;
        private System.Windows.Forms.BindingNavigator despesaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton despesaBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtLancamento;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtPagamento;
        private System.Windows.Forms.TextBox txtValor;
    }
}