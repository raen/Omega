namespace Omega
{
    partial class MainForm
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
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.miRegistry = new System.Windows.Forms.ToolStripButton();
            this.miContainerType = new System.Windows.Forms.ToolStripButton();
            this.miContainer = new System.Windows.Forms.ToolStripButton();
            this.miConfiguration = new System.Windows.Forms.ToolStripButton();
            this.miAbout = new System.Windows.Forms.ToolStripButton();
            this.btnTransmission = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTransmissionReset = new System.Windows.Forms.Button();
            this.gridMeasures = new Omega.MyLib.UI.Controls.MyGrid();
            this.gcNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcMeasure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAccept = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainToolStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMeasures)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miRegistry,
            this.miContainerType,
            this.miContainer,
            this.miConfiguration,
            this.miAbout});
            this.mainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Size = new System.Drawing.Size(642, 25);
            this.mainToolStrip.TabIndex = 0;
            this.mainToolStrip.Text = "toolStrip1";
            // 
            // miRegistry
            // 
            this.miRegistry.Image = global::Omega.Properties.Resources._1day;
            this.miRegistry.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.miRegistry.Name = "miRegistry";
            this.miRegistry.Size = new System.Drawing.Size(125, 22);
            this.miRegistry.Text = "&Historia pomiarów";
            this.miRegistry.Click += new System.EventHandler(this.miRegistry_Click);
            // 
            // miContainerType
            // 
            this.miContainerType.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.miContainerType.Name = "miContainerType";
            this.miContainerType.Size = new System.Drawing.Size(77, 22);
            this.miContainerType.Text = "Opakowania";
            this.miContainerType.Click += new System.EventHandler(this.miContainerType_Click);
            // 
            // miContainer
            // 
            this.miContainer.Image = global::Omega.Properties.Resources.filter;
            this.miContainer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.miContainer.Name = "miContainer";
            this.miContainer.Size = new System.Drawing.Size(74, 22);
            this.miContainer.Text = "&Zbiorniki";
            this.miContainer.Click += new System.EventHandler(this.miContainer_Click);
            // 
            // miConfiguration
            // 
            this.miConfiguration.Image = global::Omega.Properties.Resources.configure;
            this.miConfiguration.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.miConfiguration.Name = "miConfiguration";
            this.miConfiguration.Size = new System.Drawing.Size(94, 22);
            this.miConfiguration.Text = "&Konfiguracja";
            this.miConfiguration.Click += new System.EventHandler(this.miConfiguration_Click);
            // 
            // miAbout
            // 
            this.miAbout.Image = global::Omega.Properties.Resources.ktip;
            this.miAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.miAbout.Name = "miAbout";
            this.miAbout.Size = new System.Drawing.Size(94, 22);
            this.miAbout.Text = "&O programie";
            this.miAbout.Click += new System.EventHandler(this.miAbout_Click);
            // 
            // btnTransmission
            // 
            this.btnTransmission.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTransmission.Location = new System.Drawing.Point(6, 392);
            this.btnTransmission.Name = "btnTransmission";
            this.btnTransmission.Size = new System.Drawing.Size(75, 23);
            this.btnTransmission.TabIndex = 1;
            this.btnTransmission.Text = "Transmisja";
            this.btnTransmission.UseVisualStyleBackColor = true;
            this.btnTransmission.Click += new System.EventHandler(this.btnTransmission_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(474, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnTransmissionReset);
            this.groupBox1.Controls.Add(this.gridMeasures);
            this.groupBox1.Controls.Add(this.btnAccept);
            this.groupBox1.Controls.Add(this.btnTransmission);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 421);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Odczyty";
            // 
            // btnTransmissionReset
            // 
            this.btnTransmissionReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTransmissionReset.Location = new System.Drawing.Point(253, 392);
            this.btnTransmissionReset.Name = "btnTransmissionReset";
            this.btnTransmissionReset.Size = new System.Drawing.Size(104, 23);
            this.btnTransmissionReset.TabIndex = 6;
            this.btnTransmissionReset.Text = "Reset transmisji";
            this.btnTransmissionReset.UseVisualStyleBackColor = true;
            this.btnTransmissionReset.Visible = false;
            // 
            // gridMeasures
            // 
            this.gridMeasures.AllowUserToAddRows = false;
            this.gridMeasures.AllowUserToDeleteRows = false;
            this.gridMeasures.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridMeasures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridMeasures.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gcNumber,
            this.gcName,
            this.gcMeasure});
            this.gridMeasures.Location = new System.Drawing.Point(3, 16);
            this.gridMeasures.Name = "gridMeasures";
            this.gridMeasures.ReadOnly = true;
            this.gridMeasures.Size = new System.Drawing.Size(354, 370);
            this.gridMeasures.TabIndex = 0;
            // 
            // gcNumber
            // 
            this.gcNumber.DataPropertyName = "ContainerNumber";
            this.gcNumber.HeaderText = "Nr zbiornika";
            this.gcNumber.Name = "gcNumber";
            this.gcNumber.ReadOnly = true;
            this.gcNumber.Width = 104;
            // 
            // gcName
            // 
            this.gcName.DataPropertyName = "ContainerName";
            this.gcName.HeaderText = "Nazwa zbiornika";
            this.gcName.Name = "gcName";
            this.gcName.ReadOnly = true;
            this.gcName.Width = 104;
            // 
            // gcMeasure
            // 
            this.gcMeasure.DataPropertyName = "CurrentHeight";
            this.gcMeasure.HeaderText = "Odczyt";
            this.gcMeasure.Name = "gcMeasure";
            this.gcMeasure.ReadOnly = true;
            this.gcMeasure.Width = 104;
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAccept.Location = new System.Drawing.Point(87, 392);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 5;
            this.btnAccept.Text = "Akceptacja";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(381, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 143);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacje";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "- miernik zbyt blisko poziomu cieczy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "- przekroczony zakres miernika";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "- d[mm]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(28, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "-9999";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(28, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "9999";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(17, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Odczyt";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 465);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mainToolStrip);
            this.Name = "MainForm";
            this.Text = "Monitorowanie zbiorników - program Omega";
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMeasures)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.ToolStripButton miRegistry;
        private System.Windows.Forms.ToolStripButton miContainer;
        private System.Windows.Forms.ToolStripButton miConfiguration;
        private System.Windows.Forms.Button btnTransmission;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Omega.MyLib.UI.Controls.MyGrid gridMeasures;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnTransmissionReset;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcMeasure;
        private System.Windows.Forms.ToolStripButton miAbout;
        private System.Windows.Forms.ToolStripButton miContainerType;
    }
}

