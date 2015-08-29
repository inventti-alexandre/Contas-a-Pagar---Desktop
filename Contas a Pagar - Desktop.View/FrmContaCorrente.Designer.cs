namespace Contas_a_Pagar___Desktop.View
{
    partial class FrmContaCorrente
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
            System.Windows.Forms.Label agenciaLabel;
            System.Windows.Forms.Label contaLabel;
            System.Windows.Forms.Label limiteLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContaCorrente));
            this.contaCorrenteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.contaCorrenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.contaCorrenteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.txtAgencia = new System.Windows.Forms.TextBox();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.txtLimite = new System.Windows.Forms.TextBox();
            agenciaLabel = new System.Windows.Forms.Label();
            contaLabel = new System.Windows.Forms.Label();
            limiteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.contaCorrenteBindingNavigator)).BeginInit();
            this.contaCorrenteBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contaCorrenteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // agenciaLabel
            // 
            agenciaLabel.AutoSize = true;
            agenciaLabel.Location = new System.Drawing.Point(11, 31);
            agenciaLabel.Name = "agenciaLabel";
            agenciaLabel.Size = new System.Drawing.Size(49, 13);
            agenciaLabel.TabIndex = 1;
            agenciaLabel.Text = "Agencia:";
            // 
            // contaLabel
            // 
            contaLabel.AutoSize = true;
            contaLabel.Location = new System.Drawing.Point(182, 31);
            contaLabel.Name = "contaLabel";
            contaLabel.Size = new System.Drawing.Size(38, 13);
            contaLabel.TabIndex = 3;
            contaLabel.Text = "Conta:";
            // 
            // limiteLabel
            // 
            limiteLabel.AutoSize = true;
            limiteLabel.Location = new System.Drawing.Point(340, 31);
            limiteLabel.Name = "limiteLabel";
            limiteLabel.Size = new System.Drawing.Size(37, 13);
            limiteLabel.TabIndex = 5;
            limiteLabel.Text = "Limite:";
            // 
            // contaCorrenteBindingNavigator
            // 
            this.contaCorrenteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.contaCorrenteBindingNavigator.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.contaCorrenteBindingNavigator.BindingSource = this.contaCorrenteBindingSource;
            this.contaCorrenteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.contaCorrenteBindingNavigator.CountItemFormat = "de {0}";
            this.contaCorrenteBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.contaCorrenteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.contaCorrenteBindingNavigatorSaveItem,
            this.toolStripButton1});
            this.contaCorrenteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.contaCorrenteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.contaCorrenteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.contaCorrenteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.contaCorrenteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.contaCorrenteBindingNavigator.Name = "contaCorrenteBindingNavigator";
            this.contaCorrenteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.contaCorrenteBindingNavigator.Size = new System.Drawing.Size(503, 25);
            this.contaCorrenteBindingNavigator.TabIndex = 0;
            this.contaCorrenteBindingNavigator.Text = "bindingNavigator1";
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
            // contaCorrenteBindingSource
            // 
            this.contaCorrenteBindingSource.DataSource = typeof(Contas_a_Pagar___Desktop.View.CContaCorrente.ContaCorrente);
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
            // contaCorrenteBindingNavigatorSaveItem
            // 
            this.contaCorrenteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.contaCorrenteBindingNavigatorSaveItem.Enabled = false;
            this.contaCorrenteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("contaCorrenteBindingNavigatorSaveItem.Image")));
            this.contaCorrenteBindingNavigatorSaveItem.Name = "contaCorrenteBindingNavigatorSaveItem";
            this.contaCorrenteBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.contaCorrenteBindingNavigatorSaveItem.Text = "Save Data";
            this.contaCorrenteBindingNavigatorSaveItem.Click += new System.EventHandler(this.contaCorrenteBindingNavigatorSaveItem_Click);
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
            // txtAgencia
            // 
            this.txtAgencia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contaCorrenteBindingSource, "Agencia", true));
            this.txtAgencia.Location = new System.Drawing.Point(66, 28);
            this.txtAgencia.Name = "txtAgencia";
            this.txtAgencia.ReadOnly = true;
            this.txtAgencia.Size = new System.Drawing.Size(100, 20);
            this.txtAgencia.TabIndex = 0;
            this.txtAgencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAgencia_KeyPress);
            // 
            // txtConta
            // 
            this.txtConta.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contaCorrenteBindingSource, "Conta", true));
            this.txtConta.Location = new System.Drawing.Point(226, 28);
            this.txtConta.Name = "txtConta";
            this.txtConta.ReadOnly = true;
            this.txtConta.Size = new System.Drawing.Size(100, 20);
            this.txtConta.TabIndex = 1;
            this.txtConta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConta_KeyPress);
            // 
            // txtLimite
            // 
            this.txtLimite.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contaCorrenteBindingSource, "Limite", true));
            this.txtLimite.Location = new System.Drawing.Point(383, 28);
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.ReadOnly = true;
            this.txtLimite.Size = new System.Drawing.Size(100, 20);
            this.txtLimite.TabIndex = 2;
            // 
            // FrmContaCorrente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(503, 60);
            this.Controls.Add(limiteLabel);
            this.Controls.Add(this.txtLimite);
            this.Controls.Add(contaLabel);
            this.Controls.Add(this.txtConta);
            this.Controls.Add(agenciaLabel);
            this.Controls.Add(this.txtAgencia);
            this.Controls.Add(this.contaCorrenteBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmContaCorrente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conta Corrente";
            this.Load += new System.EventHandler(this.FrmContaCorrente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contaCorrenteBindingNavigator)).EndInit();
            this.contaCorrenteBindingNavigator.ResumeLayout(false);
            this.contaCorrenteBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contaCorrenteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource contaCorrenteBindingSource;
        private System.Windows.Forms.BindingNavigator contaCorrenteBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton contaCorrenteBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox txtAgencia;
        private System.Windows.Forms.TextBox txtConta;
        private System.Windows.Forms.TextBox txtLimite;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}