namespace es
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_messa = new System.Windows.Forms.Label();
            this.btn_compara = new System.Windows.Forms.Button();
            this.btn_ordina = new System.Windows.Forms.Button();
            this.btn_filtra = new System.Windows.Forms.Button();
            this.btn_modifica = new System.Windows.Forms.Button();
            this.btn_esegui = new System.Windows.Forms.Button();
            this.dtg_visualizza = new System.Windows.Forms.DataGridView();
            this.cmb_scelta_1 = new System.Windows.Forms.ComboBox();
            this.lbl_seleziona = new System.Windows.Forms.Label();
            this.cmb_scelta_2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_visualizza)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_messa
            // 
            this.lbl_messa.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_messa.Location = new System.Drawing.Point(0, 0);
            this.lbl_messa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_messa.Name = "lbl_messa";
            this.lbl_messa.Size = new System.Drawing.Size(239, 34);
            this.lbl_messa.TabIndex = 0;
            this.lbl_messa.Text = "scegli cosa vuoi fare";
            // 
            // btn_compara
            // 
            this.btn_compara.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_compara.Location = new System.Drawing.Point(19, 116);
            this.btn_compara.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_compara.Name = "btn_compara";
            this.btn_compara.Size = new System.Drawing.Size(108, 76);
            this.btn_compara.TabIndex = 1;
            this.btn_compara.Text = "compara 2 film";
            this.btn_compara.UseVisualStyleBackColor = true;
            this.btn_compara.Click += new System.EventHandler(this.btn_compara_Click);
            // 
            // btn_ordina
            // 
            this.btn_ordina.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ordina.Location = new System.Drawing.Point(19, 36);
            this.btn_ordina.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_ordina.Name = "btn_ordina";
            this.btn_ordina.Size = new System.Drawing.Size(108, 76);
            this.btn_ordina.TabIndex = 2;
            this.btn_ordina.Text = "ordina elementi in ordine alfabetico";
            this.btn_ordina.UseVisualStyleBackColor = true;
            this.btn_ordina.Click += new System.EventHandler(this.btn_ordina_Click);
            // 
            // btn_filtra
            // 
            this.btn_filtra.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_filtra.Location = new System.Drawing.Point(19, 196);
            this.btn_filtra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_filtra.Name = "btn_filtra";
            this.btn_filtra.Size = new System.Drawing.Size(108, 76);
            this.btn_filtra.TabIndex = 3;
            this.btn_filtra.Text = "filtra film";
            this.btn_filtra.UseVisualStyleBackColor = true;
            this.btn_filtra.Click += new System.EventHandler(this.btn_filtra_Click);
            // 
            // btn_modifica
            // 
            this.btn_modifica.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modifica.Location = new System.Drawing.Point(131, 36);
            this.btn_modifica.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_modifica.Name = "btn_modifica";
            this.btn_modifica.Size = new System.Drawing.Size(108, 76);
            this.btn_modifica.TabIndex = 4;
            this.btn_modifica.Text = "modifica un elemento";
            this.btn_modifica.UseVisualStyleBackColor = true;
            this.btn_modifica.Click += new System.EventHandler(this.btn_modifica_Click);
            // 
            // btn_esegui
            // 
            this.btn_esegui.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_esegui.Location = new System.Drawing.Point(131, 116);
            this.btn_esegui.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_esegui.Name = "btn_esegui";
            this.btn_esegui.Size = new System.Drawing.Size(108, 76);
            this.btn_esegui.TabIndex = 5;
            this.btn_esegui.Text = "esegui un elemento";
            this.btn_esegui.UseVisualStyleBackColor = true;
            this.btn_esegui.Click += new System.EventHandler(this.btn_esegui_Click);
            // 
            // dtg_visualizza
            // 
            this.dtg_visualizza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_visualizza.Location = new System.Drawing.Point(254, 12);
            this.dtg_visualizza.Name = "dtg_visualizza";
            this.dtg_visualizza.Size = new System.Drawing.Size(240, 150);
            this.dtg_visualizza.TabIndex = 6;
            // 
            // cmb_scelta_1
            // 
            this.cmb_scelta_1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_scelta_1.FormattingEnabled = true;
            this.cmb_scelta_1.Location = new System.Drawing.Point(254, 191);
            this.cmb_scelta_1.Name = "cmb_scelta_1";
            this.cmb_scelta_1.Size = new System.Drawing.Size(121, 30);
            this.cmb_scelta_1.TabIndex = 7;
            // 
            // lbl_seleziona
            // 
            this.lbl_seleziona.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_seleziona.Location = new System.Drawing.Point(251, 165);
            this.lbl_seleziona.Name = "lbl_seleziona";
            this.lbl_seleziona.Size = new System.Drawing.Size(243, 23);
            this.lbl_seleziona.TabIndex = 8;
            this.lbl_seleziona.Text = "seleziona ";
            // 
            // cmb_scelta_2
            // 
            this.cmb_scelta_2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_scelta_2.FormattingEnabled = true;
            this.cmb_scelta_2.Location = new System.Drawing.Point(381, 191);
            this.cmb_scelta_2.Name = "cmb_scelta_2";
            this.cmb_scelta_2.Size = new System.Drawing.Size(121, 30);
            this.cmb_scelta_2.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.cmb_scelta_2);
            this.Controls.Add(this.lbl_seleziona);
            this.Controls.Add(this.cmb_scelta_1);
            this.Controls.Add(this.dtg_visualizza);
            this.Controls.Add(this.btn_esegui);
            this.Controls.Add(this.btn_modifica);
            this.Controls.Add(this.btn_filtra);
            this.Controls.Add(this.btn_ordina);
            this.Controls.Add(this.btn_compara);
            this.Controls.Add(this.lbl_messa);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_visualizza)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_messa;
        private System.Windows.Forms.Button btn_compara;
        private System.Windows.Forms.Button btn_ordina;
        private System.Windows.Forms.Button btn_filtra;
        private System.Windows.Forms.Button btn_modifica;
        private System.Windows.Forms.Button btn_esegui;
        private System.Windows.Forms.DataGridView dtg_visualizza;
        private System.Windows.Forms.ComboBox cmb_scelta_1;
        private System.Windows.Forms.Label lbl_seleziona;
        private System.Windows.Forms.ComboBox cmb_scelta_2;
    }
}

