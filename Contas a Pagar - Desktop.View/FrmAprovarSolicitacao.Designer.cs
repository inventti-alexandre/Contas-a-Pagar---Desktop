namespace Contas_a_Pagar___Desktop.View
{
    partial class FrmAprovarSolicitacao
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
            System.Windows.Forms.Label iDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAprovarSolicitacao));
            this.solicitacaoMaterialBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.solicitacaoMaterialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.solicitacaoMaterialBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.chkAprovar = new System.Windows.Forms.CheckBox();
            this.txtID = new System.Windows.Forms.TextBox();
            iDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.solicitacaoMaterialBindingNavigator)).BeginInit();
            this.solicitacaoMaterialBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.solicitacaoMaterialBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(14, 31);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 3;
            iDLabel.Text = "ID:";
            // 
            // solicitacaoMaterialBindingNavigator
            // 
            this.solicitacaoMaterialBindingNavigator.AddNewItem = null;
            this.solicitacaoMaterialBindingNavigator.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.solicitacaoMaterialBindingNavigator.BindingSource = this.solicitacaoMaterialBindingSource;
            this.solicitacaoMaterialBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.solicitacaoMaterialBindingNavigator.DeleteItem = null;
            this.solicitacaoMaterialBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.solicitacaoMaterialBindingNavigatorSaveItem});
            this.solicitacaoMaterialBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.solicitacaoMaterialBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.solicitacaoMaterialBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.solicitacaoMaterialBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.solicitacaoMaterialBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.solicitacaoMaterialBindingNavigator.Name = "solicitacaoMaterialBindingNavigator";
            this.solicitacaoMaterialBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.solicitacaoMaterialBindingNavigator.Size = new System.Drawing.Size(247, 25);
            this.solicitacaoMaterialBindingNavigator.TabIndex = 0;
            this.solicitacaoMaterialBindingNavigator.Text = "bindingNavigator1";
            // 
            // solicitacaoMaterialBindingSource
            // 
            this.solicitacaoMaterialBindingSource.DataSource = typeof(Contas_a_Pagar___Desktop.View.CSolicitacaoMaterial.SolicitacaoMaterial);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // solicitacaoMaterialBindingNavigatorSaveItem
            // 
            this.solicitacaoMaterialBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.solicitacaoMaterialBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("solicitacaoMaterialBindingNavigatorSaveItem.Image")));
            this.solicitacaoMaterialBindingNavigatorSaveItem.Name = "solicitacaoMaterialBindingNavigatorSaveItem";
            this.solicitacaoMaterialBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.solicitacaoMaterialBindingNavigatorSaveItem.Text = "Save Data";
            this.solicitacaoMaterialBindingNavigatorSaveItem.Click += new System.EventHandler(this.solicitacaoMaterialBindingNavigatorSaveItem_Click);
            // 
            // chkAprovar
            // 
            this.chkAprovar.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.solicitacaoMaterialBindingSource, "Aprovado", true));
            this.chkAprovar.Location = new System.Drawing.Point(147, 26);
            this.chkAprovar.Name = "chkAprovar";
            this.chkAprovar.Size = new System.Drawing.Size(104, 24);
            this.chkAprovar.TabIndex = 2;
            this.chkAprovar.Text = "Aprovar";
            this.chkAprovar.UseVisualStyleBackColor = true;
            this.chkAprovar.CheckedChanged += new System.EventHandler(this.aprovadoCheckBox_CheckedChanged);
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.solicitacaoMaterialBindingSource, "ID", true));
            this.txtID.Location = new System.Drawing.Point(41, 28);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 4;
            // 
            // FrmAprovarSolicitacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(247, 57);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.chkAprovar);
            this.Controls.Add(this.solicitacaoMaterialBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmAprovarSolicitacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aprovar Solicitação";
            this.Load += new System.EventHandler(this.FrmAprovarSolicitacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.solicitacaoMaterialBindingNavigator)).EndInit();
            this.solicitacaoMaterialBindingNavigator.ResumeLayout(false);
            this.solicitacaoMaterialBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.solicitacaoMaterialBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource solicitacaoMaterialBindingSource;
        private System.Windows.Forms.BindingNavigator solicitacaoMaterialBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton solicitacaoMaterialBindingNavigatorSaveItem;
        private System.Windows.Forms.CheckBox chkAprovar;
        private System.Windows.Forms.TextBox txtID;
    }
}