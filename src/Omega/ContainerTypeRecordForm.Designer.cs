namespace Omega
{
    partial class ContainerTypeRecordForm
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
            this.btnClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCapacity = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbHeight = new System.Windows.Forms.NumericUpDown();
            this.tbWidth = new System.Windows.Forms.NumericUpDown();
            this.tbLength = new System.Windows.Forms.NumericUpDown();
            this.tbContainerTypeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboContainerKind = new Omega.MyLib.UI.Controls.MyComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLength)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(238, 203);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Anuluj";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.DataSource = this.bindingSource1;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(141, 203);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Zapisz i zamknij";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Typ bryły";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Pojemność Vc[l]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Wysokość H[mm]";
            // 
            // tbCapacity
            // 
            this.tbCapacity.Location = new System.Drawing.Point(117, 154);
            this.tbCapacity.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.tbCapacity.Name = "tbCapacity";
            this.tbCapacity.Size = new System.Drawing.Size(120, 20);
            this.tbCapacity.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Szerokość b[mm]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Długość a/r[mm]";
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(117, 73);
            this.tbHeight.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(120, 20);
            this.tbHeight.TabIndex = 4;
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(117, 128);
            this.tbWidth.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(120, 20);
            this.tbWidth.TabIndex = 6;
            // 
            // tbLength
            // 
            this.tbLength.Location = new System.Drawing.Point(117, 102);
            this.tbLength.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.tbLength.Name = "tbLength";
            this.tbLength.Size = new System.Drawing.Size(120, 20);
            this.tbLength.TabIndex = 5;
            // 
            // tbContainerTypeName
            // 
            this.tbContainerTypeName.Location = new System.Drawing.Point(117, 18);
            this.tbContainerTypeName.Name = "tbContainerTypeName";
            this.tbContainerTypeName.Size = new System.Drawing.Size(184, 20);
            this.tbContainerTypeName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rodzaj opakownia";
            // 
            // comboContainerKind
            // 
            this.comboContainerKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboContainerKind.FormattingEnabled = true;
            this.comboContainerKind.Location = new System.Drawing.Point(117, 44);
            this.comboContainerKind.Name = "comboContainerKind";
            this.comboContainerKind.Size = new System.Drawing.Size(184, 21);
            this.comboContainerKind.TabIndex = 2;
            this.comboContainerKind.SelectedIndexChanged += new System.EventHandler(this.comboContainerKind_SelectedIndexChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(60, 203);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 14;
            this.btnCalculate.Text = "Oblicz";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // ContainerTypeRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 238);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.tbLength);
            this.Controls.Add(this.comboContainerKind);
            this.Controls.Add(this.tbWidth);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbContainerTypeName);
            this.Controls.Add(this.tbHeight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbCapacity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Name = "ContainerTypeRecordForm";
            this.Text = "Rodzaj pojemnika";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Omega.MyLib.UI.Controls.MyComboBox comboContainerKind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbContainerTypeName;
        private System.Windows.Forms.NumericUpDown tbLength;
        private System.Windows.Forms.NumericUpDown tbWidth;
        private System.Windows.Forms.NumericUpDown tbHeight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown tbCapacity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnCalculate;
    }
}