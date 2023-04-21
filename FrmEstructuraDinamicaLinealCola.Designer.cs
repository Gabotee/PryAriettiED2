namespace PryAriettiED2
{
    partial class FrmEstructuraDinamicaLinealCola
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstructuraDinamicaLinealCola));
            this.pbImagen1 = new System.Windows.Forms.PictureBox();
            this.mrcNuevoElemento = new System.Windows.Forms.GroupBox();
            this.cmdAceptar = new System.Windows.Forms.Button();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.txtMostrarTramite = new System.Windows.Forms.TextBox();
            this.txtMostrarNombre = new System.Windows.Forms.TextBox();
            this.txtMostrarCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DgvMostrar = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstCola = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen1)).BeginInit();
            this.mrcNuevoElemento.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImagen1
            // 
            this.pbImagen1.Image = ((System.Drawing.Image)(resources.GetObject("pbImagen1.Image")));
            this.pbImagen1.Location = new System.Drawing.Point(20, 24);
            this.pbImagen1.Name = "pbImagen1";
            this.pbImagen1.Size = new System.Drawing.Size(136, 146);
            this.pbImagen1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen1.TabIndex = 0;
            this.pbImagen1.TabStop = false;
            // 
            // mrcNuevoElemento
            // 
            this.mrcNuevoElemento.Controls.Add(this.cmdAceptar);
            this.mrcNuevoElemento.Controls.Add(this.txtTramite);
            this.mrcNuevoElemento.Controls.Add(this.txtNombre);
            this.mrcNuevoElemento.Controls.Add(this.txtCodigo);
            this.mrcNuevoElemento.Controls.Add(this.label3);
            this.mrcNuevoElemento.Controls.Add(this.label2);
            this.mrcNuevoElemento.Controls.Add(this.label1);
            this.mrcNuevoElemento.Location = new System.Drawing.Point(175, 24);
            this.mrcNuevoElemento.Name = "mrcNuevoElemento";
            this.mrcNuevoElemento.Size = new System.Drawing.Size(200, 146);
            this.mrcNuevoElemento.TabIndex = 1;
            this.mrcNuevoElemento.TabStop = false;
            this.mrcNuevoElemento.Text = "Nuevo Elemento";
            // 
            // cmdAceptar
            // 
            this.cmdAceptar.Location = new System.Drawing.Point(50, 113);
            this.cmdAceptar.Name = "cmdAceptar";
            this.cmdAceptar.Size = new System.Drawing.Size(97, 27);
            this.cmdAceptar.TabIndex = 2;
            this.cmdAceptar.Text = "Agregar";
            this.cmdAceptar.UseVisualStyleBackColor = true;
            this.cmdAceptar.Click += new System.EventHandler(this.cmdAceptar_Click);
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(82, 77);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(100, 20);
            this.txtTramite.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(82, 51);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(113, 25);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(69, 20);
            this.txtCodigo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tramite";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdEliminar);
            this.groupBox1.Controls.Add(this.txtMostrarTramite);
            this.groupBox1.Controls.Add(this.txtMostrarNombre);
            this.groupBox1.Controls.Add(this.txtMostrarCodigo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(390, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 146);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elemento Eliminado";
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Location = new System.Drawing.Point(52, 113);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(97, 27);
            this.cmdEliminar.TabIndex = 2;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // txtMostrarTramite
            // 
            this.txtMostrarTramite.Location = new System.Drawing.Point(82, 77);
            this.txtMostrarTramite.Name = "txtMostrarTramite";
            this.txtMostrarTramite.Size = new System.Drawing.Size(100, 20);
            this.txtMostrarTramite.TabIndex = 5;
            // 
            // txtMostrarNombre
            // 
            this.txtMostrarNombre.Location = new System.Drawing.Point(82, 51);
            this.txtMostrarNombre.Name = "txtMostrarNombre";
            this.txtMostrarNombre.Size = new System.Drawing.Size(100, 20);
            this.txtMostrarNombre.TabIndex = 4;
            // 
            // txtMostrarCodigo
            // 
            this.txtMostrarCodigo.Location = new System.Drawing.Point(113, 25);
            this.txtMostrarCodigo.Name = "txtMostrarCodigo";
            this.txtMostrarCodigo.Size = new System.Drawing.Size(69, 20);
            this.txtMostrarCodigo.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tramite";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Codigo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DgvMostrar);
            this.groupBox2.Controls.Add(this.lstCola);
            this.groupBox2.Location = new System.Drawing.Point(20, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(570, 224);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listado en una Lista y grilla";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // DgvMostrar
            // 
            this.DgvMostrar.AllowUserToAddRows = false;
            this.DgvMostrar.AllowUserToDeleteRows = false;
            this.DgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMostrar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.DgvMostrar.Location = new System.Drawing.Point(155, 19);
            this.DgvMostrar.Name = "DgvMostrar";
            this.DgvMostrar.ReadOnly = true;
            this.DgvMostrar.Size = new System.Drawing.Size(397, 186);
            this.DgvMostrar.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tramite";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // lstCola
            // 
            this.lstCola.FormattingEnabled = true;
            this.lstCola.Location = new System.Drawing.Point(17, 19);
            this.lstCola.Name = "lstCola";
            this.lstCola.Size = new System.Drawing.Size(120, 186);
            this.lstCola.TabIndex = 0;
            this.lstCola.SelectedIndexChanged += new System.EventHandler(this.lstPila_SelectedIndexChanged);
            // 
            // FrmEstructuraDinamicaLinealCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 443);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mrcNuevoElemento);
            this.Controls.Add(this.pbImagen1);
            this.Name = "FrmEstructuraDinamicaLinealCola";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura dinamica lineal";
            this.Load += new System.EventHandler(this.FrmEstructuraDinamicaLinealCola_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen1)).EndInit();
            this.mrcNuevoElemento.ResumeLayout(false);
            this.mrcNuevoElemento.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMostrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImagen1;
        private System.Windows.Forms.GroupBox mrcNuevoElemento;
        private System.Windows.Forms.Button cmdAceptar;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.TextBox txtMostrarTramite;
        private System.Windows.Forms.TextBox txtMostrarNombre;
        private System.Windows.Forms.TextBox txtMostrarCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DgvMostrar;
        private System.Windows.Forms.ListBox lstCola;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}