namespace Contas_a_Pagar___Desktop.View
{
    partial class FrmCancelarFornecimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCancelarFornecimento));
            System.Windows.Forms.Label iDLabel;
            this.fornecimentoMaterialBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.chkCancelar = new System.Windows.Forms.CheckBox();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.fornecimentoMaterialBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.txtID = new System.Windows.Forms.TextBox();
            this.fornecimentoMaterialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            iDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fornecimentoMaterialBindingNavigator)).BeginInit();
            this.fornecimentoMaterialBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fornecimentoMaterialBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fornecimentoMaterialBindingNavigator
            // 
            this.fornecimentoMaterialBindingNavigator.AddNewItem = null;
            this.fornecimentoMaterialBindingNavigator.BindingSource = this.fornecimentoMaterialBindingSource;
            this.fornecimentoMaterialBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.fornecimentoMaterialBindingNavigator.DeleteItem = null;
            this.fornecimentoMaterialBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.fornecimentoMaterialBindingNavigatorSaveItem});
            this.fornecimentoMaterialBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.fornecimentoMaterialBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.fornecimentoMaterialBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.fornecimentoMaterialBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.fornecimentoMaterialBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.fornecimentoMaterialBindingNavigator.Name = "fornecimentoMaterialBindingNavigator";
            this.fornecimentoMaterialBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.fornecimentoMaterialBindingNavigator.Size = new System.Drawing.Size(270, 25);
            this.fornecimentoMaterialBindingNavigator.TabIndex = 0;
            this.fornecimentoMaterialBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // chkCancelar
            // 
            this.chkCancelar.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.fornecimentoMaterialBindingSource, "Cancelado", true));
            this.chkCancelar.Location = new System.Drawing.Point(158, 39);
            this.chkCancelar.Name = "chkCancelar";
            this.chkCancelar.Size = new System.Drawing.Size(104, 24);
            this.chkCancelar.TabIndex = 2;
            this.chkCancelar.Text = "Cancelar";
            this.chkCancelar.UseVisualStyleBackColor = true;
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
            // fornecimentoMaterialBindingNavigatorSaveItem
            // 
            this.fornecimentoMaterialBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fornecimentoMaterialBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("fornecimentoMaterialBindingNavigatorSaveItem.Image")));
            this.fornecimentoMaterialBindingNavigatorSaveItem.Name = "fornecimentoMaterialBindingNavigatorSaveItem";
            this.fornecimentoMaterialBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.fornecimentoMaterialBindingNavigatorSaveItem.Text = "Save Data";
            this.fornecimentoMaterialBindingNavigatorSaveItem.Click += new System.EventHandler(this.fornecimentoMaterialBindingNavigatorSaveItem_Click);
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(15, 44);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 3;
            iDLabel.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecimentoMaterialBindingSource, "ID", true));
            this.txtID.Location = new System.Drawing.Point(42, 41);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 4;
            // 
            // fornecimentoMaterialBindingSource
            // 
            this.fornecimentoMaterialBindingSource.DataSource = typeof(Contas_a_Pagar___Desktop.View.CFornecimentoMaterial.FornecimentoMaterial);
            // 
            // FrmCancelarFornecimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 71);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.chkCancelar);
            this.Controls.Add(this.fornecimentoMaterialBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmCancelarFornecimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancelar Fornecimento";
            this.Load += new System.EventHandler(this.FrmCancelarFornecimento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fornecimentoMaterialBindingNavigator)).EndInit();
            this.fornecimentoMaterialBindingNavigator.ResumeLayout(false);
            this.fornecimentoMaterialBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fornecimentoMaterialBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource fornecimentoMaterialBindingSource;
        private System.Windows.Forms.BindingNavigator fornecimentoMaterialBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton fornecimentoMaterialBindingNavigatorSaveItem;
        private System.Windows.Forms.CheckBox chkCancelar;
        private System.Windows.Forms.TextBox txtID;
    }
}