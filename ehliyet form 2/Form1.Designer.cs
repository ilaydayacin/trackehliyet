namespace ehliyet_form_2
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
            this.tbYas = new System.Windows.Forms.TrackBar();
            this.lblRenk = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.btnHesaplama = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbYas)).BeginInit();
            this.SuspendLayout();
            // 
            // tbYas
            // 
            this.tbYas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbYas.Location = new System.Drawing.Point(27, 28);
            this.tbYas.Maximum = 100;
            this.tbYas.Minimum = 1;
            this.tbYas.Name = "tbYas";
            this.tbYas.Size = new System.Drawing.Size(370, 45);
            this.tbYas.TabIndex = 0;
            this.tbYas.Value = 100;
            this.tbYas.ValueChanged += new System.EventHandler(this.tbYas_ValueChanged);
            // 
            // lblRenk
            // 
            this.lblRenk.AutoSize = true;
            this.lblRenk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRenk.Location = new System.Drawing.Point(404, 28);
            this.lblRenk.Name = "lblRenk";
            this.lblRenk.Size = new System.Drawing.Size(20, 24);
            this.lblRenk.TabIndex = 1;
            this.lblRenk.Text = "0";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(23, 92);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(230, 24);
            this.lblSonuc.TabIndex = 2;
            this.lblSonuc.Text = "Ehliyet almaya uygun mu: ";
            // 
            // btnHesaplama
            // 
            this.btnHesaplama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnHesaplama.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesaplama.Location = new System.Drawing.Point(27, 128);
            this.btnHesaplama.Name = "btnHesaplama";
            this.btnHesaplama.Size = new System.Drawing.Size(173, 111);
            this.btnHesaplama.TabIndex = 3;
            this.btnHesaplama.Text = "Hesapla";
            this.btnHesaplama.UseVisualStyleBackColor = false;
            this.btnHesaplama.Click += new System.EventHandler(this.btnHesaplama_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(495, 263);
            this.Controls.Add(this.btnHesaplama);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.lblRenk);
            this.Controls.Add(this.tbYas);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tbYas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tbYas;
        private System.Windows.Forms.Label lblRenk;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Button btnHesaplama;
    }
}

