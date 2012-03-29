namespace Omega
{
    partial class ContainerRecordForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbIsGrowing = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbContainerName = new System.Windows.Forms.TextBox();
            this.tbLiquidName = new System.Windows.Forms.TextBox();
            this.tbContainerNumber = new System.Windows.Forms.NumericUpDown();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboContainerType = new Omega.MyLib.UI.Controls.MyComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbCurrentDistance = new System.Windows.Forms.NumericUpDown();
            this.tbCurrentHeigh = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.tbCurrentCapacity = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.tbCapacityDelivered = new System.Windows.Forms.NumericUpDown();
            this.tbCapacityDeliveredDate = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbContainerNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCurrentDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCurrentHeigh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCurrentCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCapacityDelivered)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(525, 218);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Anuluj";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(428, 218);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Zapisz i zamknij";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nazwa zbiornika";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nr zbiornika";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rodzaj opakowania";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nazwa cieczy";
            // 
            // cbIsGrowing
            // 
            this.cbIsGrowing.AutoSize = true;
            this.cbIsGrowing.Location = new System.Drawing.Point(114, 136);
            this.cbIsGrowing.Name = "cbIsGrowing";
            this.cbIsGrowing.Size = new System.Drawing.Size(124, 17);
            this.cbIsGrowing.TabIndex = 8;
            this.cbIsGrowing.Text = "Stan zbiornika rośnie";
            this.cbIsGrowing.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Ilość wydana";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(51, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Data";
            // 
            // tbContainerName
            // 
            this.tbContainerName.Location = new System.Drawing.Point(114, 24);
            this.tbContainerName.Name = "tbContainerName";
            this.tbContainerName.Size = new System.Drawing.Size(184, 20);
            this.tbContainerName.TabIndex = 0;
            // 
            // tbLiquidName
            // 
            this.tbLiquidName.Location = new System.Drawing.Point(114, 102);
            this.tbLiquidName.Name = "tbLiquidName";
            this.tbLiquidName.Size = new System.Drawing.Size(184, 20);
            this.tbLiquidName.TabIndex = 3;
            // 
            // tbContainerNumber
            // 
            this.tbContainerNumber.Location = new System.Drawing.Point(113, 50);
            this.tbContainerNumber.Name = "tbContainerNumber";
            this.tbContainerNumber.Size = new System.Drawing.Size(71, 20);
            this.tbContainerNumber.TabIndex = 1;
            this.tbContainerNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboContainerType);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbContainerName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbIsGrowing);
            this.groupBox1.Controls.Add(this.tbContainerNumber);
            this.groupBox1.Controls.Add(this.tbLiquidName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametry zbiornika";
            // 
            // comboContainerType
            // 
            this.comboContainerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboContainerType.FormattingEnabled = true;
            this.comboContainerType.Location = new System.Drawing.Point(113, 76);
            this.comboContainerType.Name = "comboContainerType";
            this.comboContainerType.Size = new System.Drawing.Size(185, 21);
            this.comboContainerType.TabIndex = 2;
            this.comboContainerType.SelectedIndexChanged += new System.EventHandler(this.comboContainerType_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.tbCurrentDistance);
            this.groupBox2.Controls.Add(this.tbCurrentHeigh);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.tbCurrentCapacity);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(335, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 108);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stan zbiornika";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(34, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Odległość d[mm]";
            // 
            // tbCurrentDistance
            // 
            this.tbCurrentDistance.Location = new System.Drawing.Point(127, 19);
            this.tbCurrentDistance.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.tbCurrentDistance.Name = "tbCurrentDistance";
            this.tbCurrentDistance.Size = new System.Drawing.Size(106, 20);
            this.tbCurrentDistance.TabIndex = 0;
            this.tbCurrentDistance.ValueChanged += new System.EventHandler(this.tbCurrentDistance_ValueChanged);
            // 
            // tbCurrentHeigh
            // 
            this.tbCurrentHeigh.Location = new System.Drawing.Point(127, 45);
            this.tbCurrentHeigh.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.tbCurrentHeigh.Name = "tbCurrentHeigh";
            this.tbCurrentHeigh.Size = new System.Drawing.Size(106, 20);
            this.tbCurrentHeigh.TabIndex = 1;
            this.tbCurrentHeigh.ValueChanged += new System.EventHandler(this.tbCurrencyHeigh_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 47);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Poziom cieczy h[mm]";
            // 
            // tbCurrentCapacity
            // 
            this.tbCurrentCapacity.Location = new System.Drawing.Point(127, 71);
            this.tbCurrentCapacity.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.tbCurrentCapacity.Name = "tbCurrentCapacity";
            this.tbCurrentCapacity.Size = new System.Drawing.Size(106, 20);
            this.tbCurrentCapacity.TabIndex = 2;
            this.tbCurrentCapacity.ValueChanged += new System.EventHandler(this.tbCurrentCapacity_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(41, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Ilość cieczy V[l]";
            // 
            // tbCapacityDelivered
            // 
            this.tbCapacityDelivered.Location = new System.Drawing.Point(87, 19);
            this.tbCapacityDelivered.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.tbCapacityDelivered.Name = "tbCapacityDelivered";
            this.tbCapacityDelivered.Size = new System.Drawing.Size(120, 20);
            this.tbCapacityDelivered.TabIndex = 0;
            // 
            // tbCapacityDeliveredDate
            // 
            this.tbCapacityDeliveredDate.Location = new System.Drawing.Point(87, 45);
            this.tbCapacityDeliveredDate.Name = "tbCapacityDeliveredDate";
            this.tbCapacityDeliveredDate.Size = new System.Drawing.Size(120, 20);
            this.tbCapacityDeliveredDate.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbCapacityDeliveredDate);
            this.groupBox4.Controls.Add(this.tbCapacityDelivered);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(335, 126);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(262, 78);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Historia";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.DataSource = this.bindingSource1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalculate.Location = new System.Drawing.Point(347, 218);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Oblicz";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // ContainerRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 253);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Name = "ContainerRecordForm";
            this.Text = "Zbiornik";
            this.Shown += new System.EventHandler(this.ContainerRecordForm_Shown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ContainerRecordForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.tbContainerNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCurrentDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCurrentHeigh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCurrentCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCapacityDelivered)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbIsGrowing;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbContainerName;
        private System.Windows.Forms.TextBox tbLiquidName;
        private System.Windows.Forms.NumericUpDown tbContainerNumber;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown tbCurrentHeigh;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown tbCurrentCapacity;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown tbCapacityDelivered;
        private System.Windows.Forms.TextBox tbCapacityDeliveredDate;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown tbCurrentDistance;
        private Omega.MyLib.UI.Controls.MyComboBox comboContainerType;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnCalculate;
    }
}