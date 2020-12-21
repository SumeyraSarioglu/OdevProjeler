namespace Muzik
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
            this.btnAra = new System.Windows.Forms.Button();
            this.btnEmail = new System.Windows.Forms.Button();
            this.btnGeriDonusum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(43, 59);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 56);
            this.btnAra.TabIndex = 0;
            this.btnAra.Text = "Arama";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnEmail
            // 
            this.btnEmail.Location = new System.Drawing.Point(165, 59);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(75, 56);
            this.btnEmail.TabIndex = 1;
            this.btnEmail.Text = "E-Mail";
            this.btnEmail.UseVisualStyleBackColor = true;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            // 
            // btnGeriDonusum
            // 
            this.btnGeriDonusum.Location = new System.Drawing.Point(281, 59);
            this.btnGeriDonusum.Name = "btnGeriDonusum";
            this.btnGeriDonusum.Size = new System.Drawing.Size(75, 56);
            this.btnGeriDonusum.TabIndex = 2;
            this.btnGeriDonusum.Text = "Geri Dönüşüm";
            this.btnGeriDonusum.UseVisualStyleBackColor = true;
            this.btnGeriDonusum.Click += new System.EventHandler(this.btnGeriDonusum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 237);
            this.Controls.Add(this.btnGeriDonusum);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.btnAra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.Button btnGeriDonusum;
    }
}

