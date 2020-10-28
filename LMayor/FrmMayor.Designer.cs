namespace LMayor
{
    partial class FrmMayor
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
            this.components = new System.ComponentModel.Container();
            this.paCabezera = new System.Windows.Forms.Panel();
            this.BtnSiguiente = new System.Windows.Forms.Button();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.paCarga = new System.Windows.Forms.Panel();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCargar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHaber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDebe = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescripción = new System.Windows.Forms.TextBox();
            this.paCuerpo = new System.Windows.Forms.Panel();
            this.DGVM = new System.Windows.Forms.DataGridView();
            this.paPie = new System.Windows.Forms.Panel();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.BtnExportar = new System.Windows.Forms.Button();
            this.BtnImportar = new System.Windows.Forms.Button();
            this.txtCalcular = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.paCabezera.SuspendLayout();
            this.paCarga.SuspendLayout();
            this.paCuerpo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVM)).BeginInit();
            this.paPie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // paCabezera
            // 
            this.paCabezera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(111)))), ((int)(((byte)(139)))));
            this.paCabezera.Controls.Add(this.BtnSiguiente);
            this.paCabezera.Controls.Add(this.txtCuenta);
            this.paCabezera.Controls.Add(this.label1);
            this.paCabezera.Controls.Add(this.BtnNuevo);
            this.paCabezera.Controls.Add(this.paCarga);
            this.paCabezera.Dock = System.Windows.Forms.DockStyle.Top;
            this.paCabezera.Location = new System.Drawing.Point(0, 0);
            this.paCabezera.Name = "paCabezera";
            this.paCabezera.Size = new System.Drawing.Size(955, 100);
            this.paCabezera.TabIndex = 0;
            // 
            // BtnSiguiente
            // 
            this.BtnSiguiente.Location = new System.Drawing.Point(235, 59);
            this.BtnSiguiente.Name = "BtnSiguiente";
            this.BtnSiguiente.Size = new System.Drawing.Size(62, 23);
            this.BtnSiguiente.TabIndex = 16;
            this.BtnSiguiente.Text = "Siguiente";
            this.BtnSiguiente.UseVisualStyleBackColor = true;
            this.BtnSiguiente.Click += new System.EventHandler(this.BtnSiguiente_Click);
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(11, 60);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(208, 20);
            this.txtCuenta.TabIndex = 14;
            this.txtCuenta.TextChanged += new System.EventHandler(this.txtCuenta_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(8, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cuenta";
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Location = new System.Drawing.Point(11, 13);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(106, 23);
            this.BtnNuevo.TabIndex = 15;
            this.BtnNuevo.Text = "Nueva Cuenta";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // paCarga
            // 
            this.paCarga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(46)))), ((int)(((byte)(74)))));
            this.paCarga.Controls.Add(this.txtFecha);
            this.paCarga.Controls.Add(this.BtnLimpiar);
            this.paCarga.Controls.Add(this.label2);
            this.paCarga.Controls.Add(this.BtnCargar);
            this.paCarga.Controls.Add(this.label3);
            this.paCarga.Controls.Add(this.txtHaber);
            this.paCarga.Controls.Add(this.label4);
            this.paCarga.Controls.Add(this.txtDebe);
            this.paCarga.Controls.Add(this.label5);
            this.paCarga.Controls.Add(this.txtDescripción);
            this.paCarga.Enabled = false;
            this.paCarga.Location = new System.Drawing.Point(303, 6);
            this.paCarga.Name = "paCarga";
            this.paCarga.Size = new System.Drawing.Size(649, 91);
            this.paCarga.TabIndex = 13;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(63, 16);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 6;
            this.txtFecha.TextChanged += new System.EventHandler(this.txtFecha_TextChanged);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(519, 56);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpiar.TabIndex = 11;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(10, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha";
            // 
            // BtnCargar
            // 
            this.BtnCargar.Enabled = false;
            this.BtnCargar.Location = new System.Drawing.Point(519, 16);
            this.BtnCargar.Name = "BtnCargar";
            this.BtnCargar.Size = new System.Drawing.Size(75, 23);
            this.BtnCargar.TabIndex = 10;
            this.BtnCargar.Text = "Cargar";
            this.BtnCargar.UseVisualStyleBackColor = true;
            this.BtnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(182, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripción";
            // 
            // txtHaber
            // 
            this.txtHaber.Location = new System.Drawing.Point(252, 62);
            this.txtHaber.Name = "txtHaber";
            this.txtHaber.Size = new System.Drawing.Size(100, 20);
            this.txtHaber.TabIndex = 9;
            this.txtHaber.TextChanged += new System.EventHandler(this.txtHaber_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Debe";
            // 
            // txtDebe
            // 
            this.txtDebe.Location = new System.Drawing.Point(63, 59);
            this.txtDebe.Name = "txtDebe";
            this.txtDebe.Size = new System.Drawing.Size(100, 20);
            this.txtDebe.TabIndex = 8;
            this.txtDebe.TextChanged += new System.EventHandler(this.txtDebe_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(204, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Haber";
            // 
            // txtDescripción
            // 
            this.txtDescripción.Location = new System.Drawing.Point(253, 16);
            this.txtDescripción.Name = "txtDescripción";
            this.txtDescripción.Size = new System.Drawing.Size(190, 20);
            this.txtDescripción.TabIndex = 7;
            this.txtDescripción.TextChanged += new System.EventHandler(this.txtDescripción_TextChanged);
            // 
            // paCuerpo
            // 
            this.paCuerpo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(168)))), ((int)(((byte)(178)))));
            this.paCuerpo.Controls.Add(this.DGVM);
            this.paCuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paCuerpo.Enabled = false;
            this.paCuerpo.Location = new System.Drawing.Point(0, 100);
            this.paCuerpo.Name = "paCuerpo";
            this.paCuerpo.Size = new System.Drawing.Size(955, 411);
            this.paCuerpo.TabIndex = 1;
            // 
            // DGVM
            // 
            this.DGVM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVM.Location = new System.Drawing.Point(93, 20);
            this.DGVM.Name = "DGVM";
            this.DGVM.Size = new System.Drawing.Size(776, 216);
            this.DGVM.TabIndex = 0;
            // 
            // paPie
            // 
            this.paPie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(213)))), ((int)(((byte)(184)))));
            this.paPie.Controls.Add(this.BtnCalcular);
            this.paPie.Controls.Add(this.BtnExportar);
            this.paPie.Controls.Add(this.BtnImportar);
            this.paPie.Controls.Add(this.txtCalcular);
            this.paPie.Controls.Add(this.label6);
            this.paPie.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paPie.Enabled = false;
            this.paPie.Location = new System.Drawing.Point(0, 411);
            this.paPie.Name = "paPie";
            this.paPie.Size = new System.Drawing.Size(955, 100);
            this.paPie.TabIndex = 2;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(680, 18);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(75, 47);
            this.BtnCalcular.TabIndex = 13;
            this.BtnCalcular.Text = "Calcular Saldo";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // BtnExportar
            // 
            this.BtnExportar.Location = new System.Drawing.Point(135, 44);
            this.BtnExportar.Name = "BtnExportar";
            this.BtnExportar.Size = new System.Drawing.Size(75, 23);
            this.BtnExportar.TabIndex = 12;
            this.BtnExportar.Text = "Exportar";
            this.BtnExportar.UseVisualStyleBackColor = true;
            this.BtnExportar.Click += new System.EventHandler(this.BtnExportar_Click);
            // 
            // BtnImportar
            // 
            this.BtnImportar.Location = new System.Drawing.Point(28, 44);
            this.BtnImportar.Name = "BtnImportar";
            this.BtnImportar.Size = new System.Drawing.Size(75, 23);
            this.BtnImportar.TabIndex = 11;
            this.BtnImportar.Text = "Importar";
            this.BtnImportar.UseVisualStyleBackColor = true;
            this.BtnImportar.Click += new System.EventHandler(this.BtnImportar_Click);
            // 
            // txtCalcular
            // 
            this.txtCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalcular.Location = new System.Drawing.Point(783, 44);
            this.txtCalcular.Name = "txtCalcular";
            this.txtCalcular.ReadOnly = true;
            this.txtCalcular.Size = new System.Drawing.Size(100, 20);
            this.txtCalcular.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(780, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Saldo de la Cuenta";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmMayor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 511);
            this.Controls.Add(this.paPie);
            this.Controls.Add(this.paCuerpo);
            this.Controls.Add(this.paCabezera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmMayor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Libro Asiento";
            this.Load += new System.EventHandler(this.FrmMayor_Load);
            this.paCabezera.ResumeLayout(false);
            this.paCabezera.PerformLayout();
            this.paCarga.ResumeLayout(false);
            this.paCarga.PerformLayout();
            this.paCuerpo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVM)).EndInit();
            this.paPie.ResumeLayout(false);
            this.paPie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paCabezera;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnCargar;
        private System.Windows.Forms.TextBox txtHaber;
        private System.Windows.Forms.TextBox txtDebe;
        private System.Windows.Forms.TextBox txtDescripción;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel paCuerpo;
        private System.Windows.Forms.DataGridView DGVM;
        private System.Windows.Forms.Panel paPie;
        private System.Windows.Forms.Button BtnExportar;
        private System.Windows.Forms.Button BtnImportar;
        private System.Windows.Forms.TextBox txtCalcular;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel paCarga;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Button BtnSiguiente;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

