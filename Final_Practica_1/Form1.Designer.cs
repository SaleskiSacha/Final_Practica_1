namespace Final_Practica_1
{
    partial class frmPedido
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnRam = new System.Windows.Forms.Button();
            this.btnProcesador = new System.Windows.Forms.Button();
            this.btnCargarPM = new System.Windows.Forms.Button();
            this.cmbRam = new System.Windows.Forms.ComboBox();
            this.cmbProcesador = new System.Windows.Forms.ComboBox();
            this.cmbPlaca_Madre = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPlacamadre = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTabla
            // 
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Location = new System.Drawing.Point(269, 40);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.Size = new System.Drawing.Size(490, 293);
            this.dgvTabla.TabIndex = 23;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(62, 375);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 49);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Reiniciar Compra";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(238, 375);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(123, 49);
            this.btnComprar.TabIndex = 21;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            // 
            // btnRam
            // 
            this.btnRam.Location = new System.Drawing.Point(62, 301);
            this.btnRam.Name = "btnRam";
            this.btnRam.Size = new System.Drawing.Size(121, 32);
            this.btnRam.TabIndex = 20;
            this.btnRam.Text = "Cargar";
            this.btnRam.UseVisualStyleBackColor = true;
            this.btnRam.Click += new System.EventHandler(this.btbRam_Click);
            // 
            // btnProcesador
            // 
            this.btnProcesador.Location = new System.Drawing.Point(62, 201);
            this.btnProcesador.Name = "btnProcesador";
            this.btnProcesador.Size = new System.Drawing.Size(121, 29);
            this.btnProcesador.TabIndex = 19;
            this.btnProcesador.Text = "Cargar";
            this.btnProcesador.UseVisualStyleBackColor = true;
            this.btnProcesador.Click += new System.EventHandler(this.btnProcesador_Click);
            // 
            // btnCargarPM
            // 
            this.btnCargarPM.Location = new System.Drawing.Point(62, 94);
            this.btnCargarPM.Name = "btnCargarPM";
            this.btnCargarPM.Size = new System.Drawing.Size(121, 30);
            this.btnCargarPM.TabIndex = 18;
            this.btnCargarPM.Text = "Cargar";
            this.btnCargarPM.UseVisualStyleBackColor = true;
            this.btnCargarPM.Click += new System.EventHandler(this.btnCargarPM_Click);
            // 
            // cmbRam
            // 
            this.cmbRam.FormattingEnabled = true;
            this.cmbRam.Location = new System.Drawing.Point(62, 274);
            this.cmbRam.Name = "cmbRam";
            this.cmbRam.Size = new System.Drawing.Size(121, 21);
            this.cmbRam.TabIndex = 17;
            // 
            // cmbProcesador
            // 
            this.cmbProcesador.FormattingEnabled = true;
            this.cmbProcesador.Location = new System.Drawing.Point(62, 174);
            this.cmbProcesador.Name = "cmbProcesador";
            this.cmbProcesador.Size = new System.Drawing.Size(121, 21);
            this.cmbProcesador.TabIndex = 16;
            // 
            // cmbPlaca_Madre
            // 
            this.cmbPlaca_Madre.FormattingEnabled = true;
            this.cmbPlaca_Madre.Location = new System.Drawing.Point(62, 67);
            this.cmbPlaca_Madre.Name = "cmbPlaca_Madre";
            this.cmbPlaca_Madre.Size = new System.Drawing.Size(121, 21);
            this.cmbPlaca_Madre.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ram";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Procesador";
            // 
            // lblPlacamadre
            // 
            this.lblPlacamadre.AutoSize = true;
            this.lblPlacamadre.Location = new System.Drawing.Point(59, 40);
            this.lblPlacamadre.Name = "lblPlacamadre";
            this.lblPlacamadre.Size = new System.Drawing.Size(67, 13);
            this.lblPlacamadre.TabIndex = 12;
            this.lblPlacamadre.Text = "Placa Madre";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(477, 366);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(143, 20);
            this.txtTotal.TabIndex = 24;
            // 
            // frmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.dgvTabla);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.btnRam);
            this.Controls.Add(this.btnProcesador);
            this.Controls.Add(this.btnCargarPM);
            this.Controls.Add(this.cmbRam);
            this.Controls.Add(this.cmbProcesador);
            this.Controls.Add(this.cmbPlaca_Madre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPlacamadre);
            this.Name = "frmPedido";
            this.Text = "frmPedidos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnRam;
        private System.Windows.Forms.Button btnProcesador;
        private System.Windows.Forms.Button btnCargarPM;
        private System.Windows.Forms.ComboBox cmbRam;
        private System.Windows.Forms.ComboBox cmbProcesador;
        private System.Windows.Forms.ComboBox cmbPlaca_Madre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPlacamadre;
        private System.Windows.Forms.TextBox txtTotal;
    }
}

