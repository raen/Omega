namespace Omega
{
    partial class ContainerListForm
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.miEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.miView = new System.Windows.Forms.ToolStripMenuItem();
            this.miUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.miDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.miRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolUpdate = new System.Windows.Forms.ToolStrip();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnModify = new System.Windows.Forms.ToolStripButton();
            this.btnDetail = new System.Windows.Forms.ToolStripButton();
            this.btnUpdate = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.gridContainer = new Omega.MyLib.UI.Controls.MyGrid();
            this.gcContainerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcContainerNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcLiquidName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcCurrentCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcCurrentHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1.SuspendLayout();
            this.toolUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContainer)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAdd,
            this.miEdit,
            this.miView,
            this.miUpdate,
            this.miDelete,
            this.miRefresh});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(195, 136);
            // 
            // miAdd
            // 
            this.miAdd.Name = "miAdd";
            this.miAdd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this.miAdd.Size = new System.Drawing.Size(194, 22);
            this.miAdd.Text = "Dodaj nowy";
            this.miAdd.Click += new System.EventHandler(this.miAdd_Click);
            // 
            // miEdit
            // 
            this.miEdit.Name = "miEdit";
            this.miEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.miEdit.Size = new System.Drawing.Size(194, 22);
            this.miEdit.Text = "Modyfikuj";
            this.miEdit.Click += new System.EventHandler(this.miEdit_Click);
            // 
            // miView
            // 
            this.miView.Name = "miView";
            this.miView.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.miView.Size = new System.Drawing.Size(194, 22);
            this.miView.Text = "Pokaż szczególy";
            this.miView.Click += new System.EventHandler(this.miView_Click);
            // 
            // miUpdate
            // 
            this.miUpdate.Name = "miUpdate";
            this.miUpdate.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.miUpdate.Size = new System.Drawing.Size(194, 22);
            this.miUpdate.Text = "Aktualizuj stan";
            this.miUpdate.Click += new System.EventHandler(this.miUpdate_Click);
            // 
            // miDelete
            // 
            this.miDelete.Name = "miDelete";
            this.miDelete.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.miDelete.Size = new System.Drawing.Size(194, 22);
            this.miDelete.Text = "Usuń";
            this.miDelete.Click += new System.EventHandler(this.miDelete_Click);
            // 
            // miRefresh
            // 
            this.miRefresh.Name = "miRefresh";
            this.miRefresh.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.miRefresh.Size = new System.Drawing.Size(194, 22);
            this.miRefresh.Text = "Refresh";
            this.miRefresh.Visible = false;
            this.miRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // toolUpdate
            // 
            this.toolUpdate.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnModify,
            this.btnDetail,
            this.btnUpdate,
            this.btnDelete,
            this.toolStripSeparator1,
            this.btnRefresh});
            this.toolUpdate.Location = new System.Drawing.Point(0, 0);
            this.toolUpdate.Name = "toolUpdate";
            this.toolUpdate.Size = new System.Drawing.Size(693, 25);
            this.toolUpdate.TabIndex = 1;
            this.toolUpdate.Text = "toolStrip1";
            // 
            // btnNew
            // 
            this.btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNew.Image = global::Omega.Properties.Resources._21;
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(23, 22);
            this.btnNew.Text = "Dodaj nowy (Alt+N)";
            this.btnNew.Click += new System.EventHandler(this.miAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnModify.Image = global::Omega.Properties.Resources.configure;
            this.btnModify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(23, 22);
            this.btnModify.Text = "Modyfikuj (Alt+E)";
            this.btnModify.Click += new System.EventHandler(this.miEdit_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDetail.Image = global::Omega.Properties.Resources.mail_find;
            this.btnDetail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(23, 22);
            this.btnDetail.Text = "Szczegóły (Alt+S)";
            this.btnDetail.Click += new System.EventHandler(this.miView_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUpdate.Image = global::Omega.Properties.Resources.agt_uninstall_product;
            this.btnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(23, 22);
            this.btnUpdate.Text = "Aktualizuj stan (Alt+A)";
            this.btnUpdate.Click += new System.EventHandler(this.miUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelete.Image = global::Omega.Properties.Resources._01;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(23, 22);
            this.btnDelete.Text = "Usuń (Alt+D)";
            this.btnDelete.Click += new System.EventHandler(this.miDelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnRefresh
            // 
            this.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRefresh.Image = global::Omega.Properties.Resources._22;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(23, 22);
            this.btnRefresh.Text = "Odśwież (F5)";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // gridContainer
            // 
            this.gridContainer.AllowUserToAddRows = false;
            this.gridContainer.AllowUserToDeleteRows = false;
            this.gridContainer.AllowUserToOrderColumns = true;
            this.gridContainer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gcContainerName,
            this.gcContainerNumber,
            this.gcLiquidName,
            this.gcCurrentCapacity,
            this.gcCurrentHeight});
            this.gridContainer.ContextMenuStrip = this.contextMenuStrip1;
            this.gridContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContainer.Location = new System.Drawing.Point(0, 25);
            this.gridContainer.Name = "gridContainer";
            this.gridContainer.ReadOnly = true;
            this.gridContainer.Size = new System.Drawing.Size(693, 438);
            this.gridContainer.TabIndex = 0;
            // 
            // gcContainerName
            // 
            this.gcContainerName.DataPropertyName = "ContainerName";
            this.gcContainerName.HeaderText = "Nazwa zbiornika";
            this.gcContainerName.Name = "gcContainerName";
            this.gcContainerName.ReadOnly = true;
            // 
            // gcContainerNumber
            // 
            this.gcContainerNumber.DataPropertyName = "ContainerNumber";
            this.gcContainerNumber.HeaderText = "Numer zbiornika";
            this.gcContainerNumber.Name = "gcContainerNumber";
            this.gcContainerNumber.ReadOnly = true;
            // 
            // gcLiquidName
            // 
            this.gcLiquidName.DataPropertyName = "LiquidName";
            this.gcLiquidName.HeaderText = "Nazwa cieczy";
            this.gcLiquidName.Name = "gcLiquidName";
            this.gcLiquidName.ReadOnly = true;
            // 
            // gcCurrentCapacity
            // 
            this.gcCurrentCapacity.DataPropertyName = "CurrentCapacity";
            this.gcCurrentCapacity.HeaderText = "Ilość cieczy";
            this.gcCurrentCapacity.Name = "gcCurrentCapacity";
            this.gcCurrentCapacity.ReadOnly = true;
            // 
            // gcCurrentHeight
            // 
            this.gcCurrentHeight.DataPropertyName = "CurrentHeight";
            this.gcCurrentHeight.HeaderText = "Poziom cieczy";
            this.gcCurrentHeight.Name = "gcCurrentHeight";
            this.gcCurrentHeight.ReadOnly = true;
            // 
            // ContainerListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 463);
            this.Controls.Add(this.gridContainer);
            this.Controls.Add(this.toolUpdate);
            this.Name = "ContainerListForm";
            this.Text = "Kartoteka zbiorników";
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolUpdate.ResumeLayout(false);
            this.toolUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContainer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyLib.UI.Controls.MyGrid gridContainer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miView;
        private System.Windows.Forms.ToolStripMenuItem miEdit;
        private System.Windows.Forms.ToolStripMenuItem miAdd;
        private System.Windows.Forms.ToolStripMenuItem miUpdate;
        private System.Windows.Forms.ToolStripMenuItem miDelete;
        private System.Windows.Forms.ToolStrip toolUpdate;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnDetail;
        private System.Windows.Forms.ToolStripButton btnModify;
        private System.Windows.Forms.ToolStripButton btnUpdate;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem miRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcContainerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcContainerNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcLiquidName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcCurrentCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcCurrentHeight;
    }
}