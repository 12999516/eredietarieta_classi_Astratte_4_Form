namespace es
{
    partial class FFiltra
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
            this.txt_durata = new System.Windows.Forms.TextBox();
            this.btn_conferma = new System.Windows.Forms.Button();
            this.lbl_dur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_durata
            // 
            this.txt_durata.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_durata.Location = new System.Drawing.Point(16, 35);
            this.txt_durata.Name = "txt_durata";
            this.txt_durata.Size = new System.Drawing.Size(100, 30);
            this.txt_durata.TabIndex = 0;
            this.txt_durata.TextChanged += new System.EventHandler(this.txt_durata_TextChanged);
            // 
            // btn_conferma
            // 
            this.btn_conferma.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_conferma.Location = new System.Drawing.Point(16, 71);
            this.btn_conferma.Name = "btn_conferma";
            this.btn_conferma.Size = new System.Drawing.Size(106, 65);
            this.btn_conferma.TabIndex = 1;
            this.btn_conferma.Text = "conferma";
            this.btn_conferma.UseVisualStyleBackColor = true;
            this.btn_conferma.Click += new System.EventHandler(this.btn_conferma_Click);
            // 
            // lbl_dur
            // 
            this.lbl_dur.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dur.Location = new System.Drawing.Point(12, 9);
            this.lbl_dur.Name = "lbl_dur";
            this.lbl_dur.Size = new System.Drawing.Size(285, 23);
            this.lbl_dur.TabIndex = 2;
            this.lbl_dur.Text = "inserisci la durata massima";
            this.lbl_dur.Click += new System.EventHandler(this.lbl_dur_Click);
            // 
            // FFiltra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_dur);
            this.Controls.Add(this.btn_conferma);
            this.Controls.Add(this.txt_durata);
            this.Name = "FFiltra";
            this.Text = "FFiltra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_durata;
        private System.Windows.Forms.Button btn_conferma;
        private System.Windows.Forms.Label lbl_dur;
    }
}