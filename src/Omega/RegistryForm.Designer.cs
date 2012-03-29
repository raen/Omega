namespace Omega
{
    partial class RegistryForm
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
            this.ctxShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.gridRegistry = new Omega.MyLib.UI.Controls.MyGrid();
            this.gcMeasurementDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcContainerNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcContainerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcLiquidName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRegistry)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxShowDetails});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(159, 26);
            // 
            // ctxShowDetails
            // 
            this.ctxShowDetails.Name = "ctxShowDetails";
            this.ctxShowDetails.Size = new System.Drawing.Size(158, 22);
            this.ctxShowDetails.Text = "Pokaż szczegóły";
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.btnFilter);
            this.panelTop.Controls.Add(this.dtTo);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.dtFrom);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(610, 40);
            this.panelTop.TabIndex = 1;
            this.panelTop.Visible = false;
            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilter.Location = new System.Drawing.Point(523, 9);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.Text = "Pokaż";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // dtTo
            // 
            this.dtTo.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(254, 9);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(120, 20);
            this.dtTo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "do";
            // 
            // dtFrom
            // 
            this.dtFrom.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(103, 9);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(120, 20);
            this.dtFrom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data pomiaru od";
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btnCalculate);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 349);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(610, 40);
            this.panelBottom.TabIndex = 2;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalculate.Location = new System.Drawing.Point(523, 14);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Oblicz";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Visible = false;
            // 
            // panelCenter
            // 
            this.panelCenter.Controls.Add(this.gridRegistry);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(0, 40);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(610, 309);
            this.panelCenter.TabIndex = 3;
            // 
            // gridRegistry
            // 
            this.gridRegistry.AllowUserToAddRows = false;
            this.gridRegistry.AllowUserToDeleteRows = false;
            this.gridRegistry.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridRegistry.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gcMeasurementDate,
            this.gcContainerNumber,
            this.gcContainerName,
            this.gcLiquidName,
            this.gcCapacity,
            this.gcHeight});
            this.gridRegistry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridRegistry.Location = new System.Drawing.Point(0, 0);
            this.gridRegistry.Name = "gridRegistry";
            this.gridRegistry.ReadOnly = true;
            this.gridRegistry.Size = new System.Drawing.Size(610, 309);
            this.gridRegistry.TabIndex = 0;
            // 
            // gcMeasurementDate
            // 
            this.gcMeasurementDate.DataPropertyName = "MeasurementDate";
            this.gcMeasurementDate.HeaderText = "Data";
            this.gcMeasurementDate.Name = "gcMeasurementDate";
            this.gcMeasurementDate.ReadOnly = true;
            // 
            // gcContainerNumber
            // 
            this.gcContainerNumber.DataPropertyName = "ContainerNumber";
            this.gcContainerNumber.HeaderText = "Nr zbiornika";
            this.gcContainerNumber.Name = "gcContainerNumber";
            this.gcContainerNumber.ReadOnly = true;
            // 
            // gcContainerName
            // 
            this.gcContainerName.DataPropertyName = "ContainerName";
            this.gcContainerName.HeaderText = "Nazwa zbiornika";
            this.gcContainerName.Name = "gcContainerName";
            this.gcContainerName.ReadOnly = true;
            // 
            // gcLiquidName
            // 
            this.gcLiquidName.DataPropertyName = "LiquidName";
            this.gcLiquidName.HeaderText = "Nazwa cieczy";
            this.gcLiquidName.Name = "gcLiquidName";
            this.gcLiquidName.ReadOnly = true;
            // 
            // gcCapacity
            // 
            this.gcCapacity.DataPropertyName = "Capacity";
            this.gcCapacity.HeaderText = "Ilość V[l]";
            this.gcCapacity.Name = "gcCapacity";
            this.gcCapacity.ReadOnly = true;
            // 
            // gcHeight
            // 
            this.gcHeight.DataPropertyName = "Height";
            this.gcHeight.HeaderText = "Poziom h[mm]";
            this.gcHeight.Name = "gcHeight";
            this.gcHeight.ReadOnly = true;
            // 
            // RegistryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 389);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Name = "RegistryForm";
            this.Text = "Historia pomiarów";
            this.contextMenuStrip1.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridRegistry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyLib.UI.Controls.MyGrid gridRegistry;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ctxShowDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcMeasurementDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcContainerNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcContainerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcLiquidName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcHeight;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalculate;
    }
}