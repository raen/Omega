namespace Omega
{
    partial class ContainerTypeListForm
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
            this.miDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.miRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDetail = new System.Windows.Forms.ToolStripButton();
            this.btnModify = new System.Windows.Forms.ToolStripButton();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.toolUpdate = new System.Windows.Forms.ToolStrip();
            this.gridContainerType = new Omega.MyLib.UI.Controls.MyGrid();
            this.gcContainerTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1.SuspendLayout();
            this.toolUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContainerType)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAdd,
            this.miEdit,
            this.miView,
            this.miDelete,
            this.miRefresh});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(195, 114);
            // 
            // miAdd
            // 
            this.miAdd.Name = "miAdd";
            this.miAdd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this.miAdd.Size = new System.Drawing.Size(194, 22);
            this.miAdd.Text = "Dodaj nowy";
            // 
            // miEdit
            // 
            this.miEdit.Name = "miEdit";
            this.miEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.miEdit.Size = new System.Drawing.Size(194, 22);
            this.miEdit.Text = "Modyfikuj";
            // 
            // miView
            // 
            this.miView.Name = "miView";
            this.miView.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.miView.Size = new System.Drawing.Size(194, 22);
            this.miView.Text = "Pokaż szczególy";
            // 
            // miDelete
            // 
            this.miDelete.Name = "miDelete";
            this.miDelete.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.miDelete.Size = new System.Drawing.Size(194, 22);
            this.miDelete.Text = "Usuń";
            // 
            // miRefresh
            // 
            this.miRefresh.Name = "miRefresh";
            this.miRefresh.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.miRefresh.Size = new System.Drawing.Size(194, 22);
            this.miRefresh.Text = "Refresh";
            this.miRefresh.Visible = false;
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // toolUpdate
            // 
            this.toolUpdate.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnModify,
            this.btnDetail,
            this.toolStripSeparator1,
            this.btnRefresh});
            this.toolUpdate.Location = new System.Drawing.Point(0, 0);
            this.toolUpdate.Name = "toolUpdate";
            this.toolUpdate.Size = new System.Drawing.Size(582, 25);
            this.toolUpdate.TabIndex = 3;
            this.toolUpdate.Text = "toolStrip1";
            // 
            // gridContainerType
            // 
            this.gridContainerType.AllowUserToAddRows = false;
            this.gridContainerType.AllowUserToDeleteRows = false;
            this.gridContainerType.AllowUserToOrderColumns = true;
            this.gridContainerType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gcContainerTypeName,
            this.gcCapacity,
            this.gcHeight,
            this.gcWidth,
            this.gcLength});
            this.gridContainerType.ContextMenuStrip = this.contextMenuStrip1;
            this.gridContainerType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContainerType.Location = new System.Drawing.Point(0, 25);
            this.gridContainerType.Name = "gridContainerType";
            this.gridContainerType.ReadOnly = true;
            this.gridContainerType.Size = new System.Drawing.Size(582, 397);
            this.gridContainerType.TabIndex = 2;
            // 
            // gcContainerTypeName
            // 
            this.gcContainerTypeName.DataPropertyName = "ContainerTypeName";
            this.gcContainerTypeName.HeaderText = "Rodzaj pojemnika";
            this.gcContainerTypeName.Name = "gcContainerTypeName";
            this.gcContainerTypeName.ReadOnly = true;
            // 
            // gcCapacity
            // 
            this.gcCapacity.DataPropertyName = "Capacity";
            this.gcCapacity.HeaderText = "Pojemność";
            this.gcCapacity.Name = "gcCapacity";
            this.gcCapacity.ReadOnly = true;
            // 
            // gcHeight
            // 
            this.gcHeight.DataPropertyName = "Height";
            this.gcHeight.HeaderText = "Wysokość";
            this.gcHeight.Name = "gcHeight";
            this.gcHeight.ReadOnly = true;
            // 
            // gcWidth
            // 
            this.gcWidth.DataPropertyName = "Width";
            this.gcWidth.HeaderText = "Szerokość";
            this.gcWidth.Name = "gcWidth";
            this.gcWidth.ReadOnly = true;
            // 
            // gcLength
            // 
            this.gcLength.DataPropertyName = "Length";
            this.gcLength.HeaderText = "Długość";
            this.gcLength.Name = "gcLength";
            this.gcLength.ReadOnly = true;
            // 
            // ContainerTypeListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 422);
            this.Controls.Add(this.gridContainerType);
            this.Controls.Add(this.toolUpdate);
            this.Name = "ContainerTypeListForm";
            this.Text = "Kartoteka opakowań";
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolUpdate.ResumeLayout(false);
            this.toolUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContainerType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miAdd;
        private System.Windows.Forms.ToolStripMenuItem miEdit;
        private System.Windows.Forms.ToolStripMenuItem miView;
        private System.Windows.Forms.ToolStripMenuItem miDelete;
        private System.Windows.Forms.ToolStripMenuItem miRefresh;
        private Omega.MyLib.UI.Controls.MyGrid gridContainerType;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnDetail;
        private System.Windows.Forms.ToolStripButton btnModify;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStrip toolUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcContainerTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcHeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcLength;
    }
}