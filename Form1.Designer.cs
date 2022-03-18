namespace Tugas
{
    partial class Form1
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
            this.TxtboxInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnProses = new System.Windows.Forms.Button();
            this.LblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtboxInput
            // 
            this.TxtboxInput.Location = new System.Drawing.Point(12, 28);
            this.TxtboxInput.Name = "TxtboxInput";
            this.TxtboxInput.Size = new System.Drawing.Size(341, 22);
            this.TxtboxInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input Data :";
            // 
            // BtnProses
            // 
            this.BtnProses.Location = new System.Drawing.Point(10, 67);
            this.BtnProses.Name = "BtnProses";
            this.BtnProses.Size = new System.Drawing.Size(75, 23);
            this.BtnProses.TabIndex = 2;
            this.BtnProses.Text = "Proses";
            this.BtnProses.UseVisualStyleBackColor = true;
            this.BtnProses.Click += new System.EventHandler(this.BtnProses_Click);
            // 
            // LblOutput
            // 
            this.LblOutput.AutoSize = true;
            this.LblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOutput.Location = new System.Drawing.Point(12, 112);
            this.LblOutput.Name = "LblOutput";
            this.LblOutput.Size = new System.Drawing.Size(93, 25);
            this.LblOutput.TabIndex = 3;
            this.LblOutput.Text = "[EMPTY]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 174);
            this.Controls.Add(this.LblOutput);
            this.Controls.Add(this.BtnProses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtboxInput);
            this.Name = "Form1";
            this.Text = "Form Pengaturan Warna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtboxInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnProses; 
        private System.Windows.Forms.Label LblOutput;
    }
}

