namespace Omega
{
    partial class AboutForm
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
            this.lbSoft = new System.Windows.Forms.Label();
            this.lbTeam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbSoft
            // 
            this.lbSoft.AutoSize = true;
            this.lbSoft.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoft.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbSoft.Location = new System.Drawing.Point(78, 63);
            this.lbSoft.Name = "lbSoft";
            this.lbSoft.Size = new System.Drawing.Size(137, 26);
            this.lbSoft.TabIndex = 4;
            this.lbSoft.Text = "Omega v1.0.0";
            // 
            // lbTeam
            // 
            this.lbTeam.AutoSize = true;
            this.lbTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbTeam.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbTeam.Location = new System.Drawing.Point(22, 24);
            this.lbTeam.Name = "lbTeam";
            this.lbTeam.Size = new System.Drawing.Size(277, 18);
            this.lbTeam.TabIndex = 3;
            this.lbTeam.Text = "Zakład Elektroniczny Roman Engler";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 127);
            this.Controls.Add(this.lbSoft);
            this.Controls.Add(this.lbTeam);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(321, 161);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(321, 161);
            this.Name = "AboutForm";
            this.Text = "O programie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSoft;
        private System.Windows.Forms.Label lbTeam;
    }
}