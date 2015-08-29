namespace Contas_a_Pagar___Desktop.View
{
    partial class FrmFornecimentoMaterial
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
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label fornecedorLabel;
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label servicoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFornecimentoMaterial));
            this.fornecimentoMaterialBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.fornecimentoMaterialBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.fornecimentoMaterialBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtServico = new System.Windows.Forms.TextBox();
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.materialBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dtgMaterial = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            dataLabel = new System.Windows.Forms.Label();
            fornecedorLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            servicoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fornecimentoMaterialBindingNavigator)).BeginInit();
            this.fornecimentoMaterialBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fornecimentoMaterialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMaterial)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(137, 32);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(33, 13);
            dataLabel.TabIndex = 2;
            dataLabel.Text = "Data:";
            // 
            // fornecedorLabel
            // 
            fornecedorLabel.AutoSize = true;
            fornecedorLabel.Location = new System.Drawing.Point(0, 57);
            fornecedorLabel.Name = "fornecedorLabel";
            fornecedorLabel.Size = new System.Drawing.Size(64, 13);
            fornecedorLabel.TabIndex = 4;
            fornecedorLabel.Text = "Fornecedor:";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(4, 31);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 6;
            iDLabel.Text = "ID:";
            // 
            // servicoLabel
            // 
            servicoLabel.AutoSize = true;
            servicoLabel.Location = new System.Drawing.Point(209, 57);
            servicoLabel.Name = "servicoLabel";
            servicoLabel.Size = new System.Drawing.Size(46, 13);
            servicoLabel.TabIndex = 8;
            servicoLabel.Text = "Serviço:";
            // 
            // fornecimentoMaterialBindingNavigator
            // 
            this.fornecimentoMaterialBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.fornecimentoMaterialBindingNavigator.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.fornecimentoMaterialBindingNavigator.BindingSource = this.fornecimentoMaterialBindingSource;
            this.fornecimentoMaterialBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.fornecimentoMaterialBindingNavigator.CountItemFormat = "de {0}";
            this.fornecimentoMaterialBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
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
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.fornecimentoMaterialBindingNavigatorSaveItem,
            this.toolStripButton1});
            this.fornecimentoMaterialBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.fornecimentoMaterialBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.fornecimentoMaterialBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.fornecimentoMaterialBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.fornecimentoMaterialBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.fornecimentoMaterialBindingNavigator.Name = "fornecimentoMaterialBindingNavigator";
            this.fornecimentoMaterialBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.fornecimentoMaterialBindingNavigator.Size = new System.Drawing.Size(375, 25);
            this.fornecimentoMaterialBindingNavigator.TabIndex = 0;
            this.fornecimentoMaterialBindingNavigator.Text = "bindingNavigator1";
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
            // fornecimentoMaterialBindingSource
            // 
            this.fornecimentoMaterialBindingSource.DataSource = typeof(Contas_a_Pagar___Desktop.View.CFornecimentoMaterial.FornecimentoMaterial);
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
            this.bindingNavigatorDeleteItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            // fornecimentoMaterialBindingNavigatorSaveItem
            // 
            this.fornecimentoMaterialBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fornecimentoMaterialBindingNavigatorSaveItem.Enabled = false;
            this.fornecimentoMaterialBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("fornecimentoMaterialBindingNavigatorSaveItem.Image")));
            this.fornecimentoMaterialBindingNavigatorSaveItem.Name = "fornecimentoMaterialBindingNavigatorSaveItem";
            this.fornecimentoMaterialBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.fornecimentoMaterialBindingNavigatorSaveItem.Text = "Save Data";
            this.fornecimentoMaterialBindingNavigatorSaveItem.Click += new System.EventHandler(this.fornecimentoMaterialBindingNavigatorSaveItem_Click);
            // 
            // dtpData
            // 
            this.dtpData.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.fornecimentoMaterialBindingSource, "Data", true));
            this.dtpData.Location = new System.Drawing.Point(176, 28);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(185, 20);
            this.dtpData.TabIndex = 1;
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecimentoMaterialBindingSource, "Fornecedor", true));
            this.txtFornecedor.Location = new System.Drawing.Point(70, 54);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(100, 20);
            this.txtFornecedor.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecimentoMaterialBindingSource, "ID", true));
            this.txtID.Location = new System.Drawing.Point(31, 28);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 0;
            // 
            // txtServico
            // 
            this.txtServico.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecimentoMaterialBindingSource, "Servico", true));
            this.txtServico.Location = new System.Drawing.Point(261, 54);
            this.txtServico.Name = "txtServico";
            this.txtServico.Size = new System.Drawing.Size(100, 20);
            this.txtServico.TabIndex = 3;
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataSource = typeof(Contas_a_Pagar___Desktop.View.CMaterial.Material);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(2, 303);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(110, 23);
            this.btnAdicionar.TabIndex = 5;
            this.btnAdicionar.Text = "Adicionar material";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // materialBindingSource1
            // 
            this.materialBindingSource1.DataMember = "Material";
            this.materialBindingSource1.DataSource = this.fornecimentoMaterialBindingSource;
            // 
            // dtgMaterial
            // 
            this.dtgMaterial.AllowUserToAddRows = false;
            this.dtgMaterial.AllowUserToDeleteRows = false;
            this.dtgMaterial.AutoGenerateColumns = false;
            this.dtgMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMaterial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3});
            this.dtgMaterial.DataSource = this.materialBindingSource1;
            this.dtgMaterial.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgMaterial.Location = new System.Drawing.Point(1, 77);
            this.dtgMaterial.Name = "dtgMaterial";
            this.dtgMaterial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgMaterial.Size = new System.Drawing.Size(360, 220);
            this.dtgMaterial.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn1.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PrecoUnitario";
            this.dataGridViewTextBoxColumn3.HeaderText = "Preço Unitário";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Enabled = false;
            this.toolStripButton1.Image = global::Contas_a_Pagar___Desktop.View.Properties.Resources.eraser;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // FrmFornecimentoMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(375, 332);
            this.Controls.Add(this.dtgMaterial);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(servicoLabel);
            this.Controls.Add(this.txtServico);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.txtID);
            this.Controls.Add(fornecedorLabel);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.fornecimentoMaterialBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmFornecimentoMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fornecimento de Material";
            this.Load += new System.EventHandler(this.FrmFornecimentoMaterial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fornecimentoMaterialBindingNavigator)).EndInit();
            this.fornecimentoMaterialBindingNavigator.ResumeLayout(false);
            this.fornecimentoMaterialBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fornecimentoMaterialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMaterial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource fornecimentoMaterialBindingSource;
        private System.Windows.Forms.BindingNavigator fornecimentoMaterialBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton fornecimentoMaterialBindingNavigatorSaveItem;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtServico;
        private System.Windows.Forms.BindingSource materialBindingSource;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.BindingSource materialBindingSource1;
        private System.Windows.Forms.DataGridView dtgMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}