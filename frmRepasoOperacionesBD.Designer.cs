namespace PryAriettiED2
{
    partial class frmRepasoOperacionesBD
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
            this.dgvMostrar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbOperaciones = new System.Windows.Forms.ComboBox();
            this.txtCodigoSQL = new System.Windows.Forms.TextBox();
            this.btnListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMostrar
            // 
            this.dgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrar.Location = new System.Drawing.Point(3, 323);
            this.dgvMostrar.Name = "dgvMostrar";
            this.dgvMostrar.Size = new System.Drawing.Size(926, 250);
            this.dgvMostrar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Operacion a realizar :";
            // 
            // cbOperaciones
            // 
            this.cbOperaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOperaciones.FormattingEnabled = true;
            this.cbOperaciones.Items.AddRange(new object[] {
            "Proyeccion Simple",
            "Proyeccion MultiAtributo",
            "Juntar",
            "Seleccion Simple",
            "Seleccion MultiAtributo",
            "Seleccion por Convolucion",
            "Union",
            "Interseccion",
            "Diferencia"});
            this.cbOperaciones.Location = new System.Drawing.Point(207, 12);
            this.cbOperaciones.Name = "cbOperaciones";
            this.cbOperaciones.Size = new System.Drawing.Size(327, 21);
            this.cbOperaciones.TabIndex = 3;
            // 
            // txtCodigoSQL
            // 
            this.txtCodigoSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoSQL.Location = new System.Drawing.Point(3, 39);
            this.txtCodigoSQL.Multiline = true;
            this.txtCodigoSQL.Name = "txtCodigoSQL";
            this.txtCodigoSQL.ReadOnly = true;
            this.txtCodigoSQL.Size = new System.Drawing.Size(926, 278);
            this.txtCodigoSQL.TabIndex = 4;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(604, 12);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(140, 23);
            this.btnListar.TabIndex = 5;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // frmRepasoOperacionesBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 572);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.txtCodigoSQL);
            this.Controls.Add(this.cbOperaciones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMostrar);
            this.Name = "frmRepasoOperacionesBD";
            this.Text = "Repaso de Operaciones";
            this.Load += new System.EventHandler(this.frmRepasoOperacionesBD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMostrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbOperaciones;
        private System.Windows.Forms.TextBox txtCodigoSQL;
        private System.Windows.Forms.Button btnListar;
    }
}