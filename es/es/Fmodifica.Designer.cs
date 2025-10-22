namespace es
{
    partial class Fmodifica
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
            this.lbl_scegli = new System.Windows.Forms.Label();
            this.rdb_volume = new System.Windows.Forms.RadioButton();
            this.rdb_luminosita = new System.Windows.Forms.RadioButton();
            this.btn_decrementa = new System.Windows.Forms.Button();
            this.btn_Aumenta = new System.Windows.Forms.Button();
            this.cmb_elemento = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_scegli
            // 
            this.lbl_scegli.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_scegli.Location = new System.Drawing.Point(12, 9);
            this.lbl_scegli.Name = "lbl_scegli";
            this.lbl_scegli.Size = new System.Drawing.Size(240, 23);
            this.lbl_scegli.TabIndex = 0;
            this.lbl_scegli.Text = "scegli cosa modificare";
            // 
            // rdb_volume
            // 
            this.rdb_volume.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_volume.Location = new System.Drawing.Point(12, 35);
            this.rdb_volume.Name = "rdb_volume";
            this.rdb_volume.Size = new System.Drawing.Size(124, 24);
            this.rdb_volume.TabIndex = 1;
            this.rdb_volume.TabStop = true;
            this.rdb_volume.Text = "volume";
            this.rdb_volume.UseVisualStyleBackColor = true;
            // 
            // rdb_luminosita
            // 
            this.rdb_luminosita.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_luminosita.Location = new System.Drawing.Point(142, 35);
            this.rdb_luminosita.Name = "rdb_luminosita";
            this.rdb_luminosita.Size = new System.Drawing.Size(130, 24);
            this.rdb_luminosita.TabIndex = 2;
            this.rdb_luminosita.TabStop = true;
            this.rdb_luminosita.Text = "luminosità";
            this.rdb_luminosita.UseVisualStyleBackColor = true;
            // 
            // btn_decrementa
            // 
            this.btn_decrementa.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_decrementa.Location = new System.Drawing.Point(142, 80);
            this.btn_decrementa.Name = "btn_decrementa";
            this.btn_decrementa.Size = new System.Drawing.Size(130, 48);
            this.btn_decrementa.TabIndex = 3;
            this.btn_decrementa.Text = "decrementa";
            this.btn_decrementa.UseVisualStyleBackColor = true;
            this.btn_decrementa.Click += new System.EventHandler(this.btn_decrementa_Click);
            // 
            // btn_Aumenta
            // 
            this.btn_Aumenta.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aumenta.Location = new System.Drawing.Point(12, 80);
            this.btn_Aumenta.Name = "btn_Aumenta";
            this.btn_Aumenta.Size = new System.Drawing.Size(124, 48);
            this.btn_Aumenta.TabIndex = 4;
            this.btn_Aumenta.Text = "aumenta";
            this.btn_Aumenta.UseVisualStyleBackColor = true;
            this.btn_Aumenta.Click += new System.EventHandler(this.btn_Aumenta_Click);
            // 
            // cmb_elemento
            // 
            this.cmb_elemento.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_elemento.FormattingEnabled = true;
            this.cmb_elemento.Location = new System.Drawing.Point(16, 134);
            this.cmb_elemento.Name = "cmb_elemento";
            this.cmb_elemento.Size = new System.Drawing.Size(121, 30);
            this.cmb_elemento.TabIndex = 5;
            // 
            // Fmodifica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmb_elemento);
            this.Controls.Add(this.btn_Aumenta);
            this.Controls.Add(this.btn_decrementa);
            this.Controls.Add(this.rdb_luminosita);
            this.Controls.Add(this.rdb_volume);
            this.Controls.Add(this.lbl_scegli);
            this.Name = "Fmodifica";
            this.Text = "Fmodifica";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_scegli;
        private System.Windows.Forms.RadioButton rdb_volume;
        private System.Windows.Forms.RadioButton rdb_luminosita;
        private System.Windows.Forms.Button btn_decrementa;
        private System.Windows.Forms.Button btn_Aumenta;
        private System.Windows.Forms.ComboBox cmb_elemento;
    }
}