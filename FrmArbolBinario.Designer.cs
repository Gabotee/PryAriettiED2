﻿namespace PryAriettiED2
{
    partial class FrmArbolBinario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArbolBinario));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstCodigo = new System.Windows.Forms.ComboBox();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tvMostrar = new System.Windows.Forms.TreeView();
            this.DgvMostrar = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstArbolBinario = new System.Windows.Forms.ListBox();
            this.mrcNuevoElemento = new System.Windows.Forms.GroupBox();
            this.cmdAceptar = new System.Windows.Forms.Button();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbImagen1 = new System.Windows.Forms.PictureBox();
            this.mrcRecorrido = new System.Windows.Forms.GroupBox();
            this.rbPostOrden = new System.Windows.Forms.RadioButton();
            this.rbPreOrden = new System.Windows.Forms.RadioButton();
            this.rbInOrdenDesc = new System.Windows.Forms.RadioButton();
            this.rbOrdenAsc = new System.Windows.Forms.RadioButton();
            this.txtNombretv = new System.Windows.Forms.TextBox();
            this.txtCodigoTv = new System.Windows.Forms.TextBox();
            this.txtTramiteTv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMostrar)).BeginInit();
            this.mrcNuevoElemento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen1)).BeginInit();
            this.mrcRecorrido.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstCodigo);
            this.groupBox1.Controls.Add(this.cmdEliminar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(383, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 159);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elemento Eliminado";
            // 
            // lstCodigo
            // 
            this.lstCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstCodigo.FormattingEnabled = true;
            this.lstCodigo.Location = new System.Drawing.Point(53, 57);
            this.lstCodigo.Name = "lstCodigo";
            this.lstCodigo.Size = new System.Drawing.Size(121, 21);
            this.lstCodigo.TabIndex = 3;
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Location = new System.Drawing.Point(64, 103);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(97, 27);
            this.cmdEliminar.TabIndex = 2;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Codigo";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtNombretv);
            this.groupBox2.Controls.Add(this.txtTramiteTv);
            this.groupBox2.Controls.Add(this.tvMostrar);
            this.groupBox2.Controls.Add(this.txtCodigoTv);
            this.groupBox2.Controls.Add(this.DgvMostrar);
            this.groupBox2.Controls.Add(this.lstArbolBinario);
            this.groupBox2.Location = new System.Drawing.Point(13, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(720, 315);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listado en una Lista y grilla";
            // 
            // tvMostrar
            // 
            this.tvMostrar.Location = new System.Drawing.Point(6, 19);
            this.tvMostrar.Name = "tvMostrar";
            this.tvMostrar.Size = new System.Drawing.Size(179, 181);
            this.tvMostrar.TabIndex = 21;
            this.tvMostrar.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvMostrar_NodeMouseDoubleClick);
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
            this.DgvMostrar.Location = new System.Drawing.Point(358, 19);
            this.DgvMostrar.Name = "DgvMostrar";
            this.DgvMostrar.ReadOnly = true;
            this.DgvMostrar.Size = new System.Drawing.Size(344, 277);
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
            // lstArbolBinario
            // 
            this.lstArbolBinario.FormattingEnabled = true;
            this.lstArbolBinario.Location = new System.Drawing.Point(191, 19);
            this.lstArbolBinario.Name = "lstArbolBinario";
            this.lstArbolBinario.Size = new System.Drawing.Size(161, 277);
            this.lstArbolBinario.TabIndex = 0;
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
            this.mrcNuevoElemento.Location = new System.Drawing.Point(168, 12);
            this.mrcNuevoElemento.Name = "mrcNuevoElemento";
            this.mrcNuevoElemento.Size = new System.Drawing.Size(209, 159);
            this.mrcNuevoElemento.TabIndex = 17;
            this.mrcNuevoElemento.TabStop = false;
            this.mrcNuevoElemento.Text = "Nuevo Elemento";
            // 
            // cmdAceptar
            // 
            this.cmdAceptar.Location = new System.Drawing.Point(101, 103);
            this.cmdAceptar.Name = "cmdAceptar";
            this.cmdAceptar.Size = new System.Drawing.Size(81, 27);
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
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
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
            // pbImagen1
            // 
            this.pbImagen1.Image = ((System.Drawing.Image)(resources.GetObject("pbImagen1.Image")));
            this.pbImagen1.Location = new System.Drawing.Point(13, 12);
            this.pbImagen1.Name = "pbImagen1";
            this.pbImagen1.Size = new System.Drawing.Size(149, 155);
            this.pbImagen1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen1.TabIndex = 16;
            this.pbImagen1.TabStop = false;
            // 
            // mrcRecorrido
            // 
            this.mrcRecorrido.Controls.Add(this.rbPostOrden);
            this.mrcRecorrido.Controls.Add(this.rbPreOrden);
            this.mrcRecorrido.Controls.Add(this.rbInOrdenDesc);
            this.mrcRecorrido.Controls.Add(this.rbOrdenAsc);
            this.mrcRecorrido.Location = new System.Drawing.Point(589, 12);
            this.mrcRecorrido.Name = "mrcRecorrido";
            this.mrcRecorrido.Size = new System.Drawing.Size(144, 159);
            this.mrcRecorrido.TabIndex = 20;
            this.mrcRecorrido.TabStop = false;
            this.mrcRecorrido.Text = "Recorrido";
            // 
            // rbPostOrden
            // 
            this.rbPostOrden.AutoSize = true;
            this.rbPostOrden.Location = new System.Drawing.Point(6, 103);
            this.rbPostOrden.Name = "rbPostOrden";
            this.rbPostOrden.Size = new System.Drawing.Size(75, 17);
            this.rbPostOrden.TabIndex = 3;
            this.rbPostOrden.TabStop = true;
            this.rbPostOrden.Text = "PostOrden";
            this.rbPostOrden.UseVisualStyleBackColor = true;
            this.rbPostOrden.CheckedChanged += new System.EventHandler(this.rbPostOrden_CheckedChanged);
            // 
            // rbPreOrden
            // 
            this.rbPreOrden.AutoSize = true;
            this.rbPreOrden.Location = new System.Drawing.Point(6, 80);
            this.rbPreOrden.Name = "rbPreOrden";
            this.rbPreOrden.Size = new System.Drawing.Size(70, 17);
            this.rbPreOrden.TabIndex = 2;
            this.rbPreOrden.TabStop = true;
            this.rbPreOrden.Text = "PreOrden";
            this.rbPreOrden.UseVisualStyleBackColor = true;
            this.rbPreOrden.CheckedChanged += new System.EventHandler(this.rbPreOrden_CheckedChanged);
            // 
            // rbInOrdenDesc
            // 
            this.rbInOrdenDesc.AutoSize = true;
            this.rbInOrdenDesc.Location = new System.Drawing.Point(6, 58);
            this.rbInOrdenDesc.Name = "rbInOrdenDesc";
            this.rbInOrdenDesc.Size = new System.Drawing.Size(127, 17);
            this.rbInOrdenDesc.TabIndex = 1;
            this.rbInOrdenDesc.TabStop = true;
            this.rbInOrdenDesc.Text = "InOrdenDescendente";
            this.rbInOrdenDesc.UseVisualStyleBackColor = true;
            this.rbInOrdenDesc.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbOrdenAsc
            // 
            this.rbOrdenAsc.AutoSize = true;
            this.rbOrdenAsc.Checked = true;
            this.rbOrdenAsc.Location = new System.Drawing.Point(6, 35);
            this.rbOrdenAsc.Name = "rbOrdenAsc";
            this.rbOrdenAsc.Size = new System.Drawing.Size(120, 17);
            this.rbOrdenAsc.TabIndex = 0;
            this.rbOrdenAsc.TabStop = true;
            this.rbOrdenAsc.Text = "InOrdenAscendente";
            this.rbOrdenAsc.UseVisualStyleBackColor = true;
            this.rbOrdenAsc.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // txtNombretv
            // 
            this.txtNombretv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombretv.Location = new System.Drawing.Point(65, 250);
            this.txtNombretv.Name = "txtNombretv";
            this.txtNombretv.ReadOnly = true;
            this.txtNombretv.Size = new System.Drawing.Size(120, 20);
            this.txtNombretv.TabIndex = 6;
            // 
            // txtCodigoTv
            // 
            this.txtCodigoTv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoTv.Location = new System.Drawing.Point(65, 224);
            this.txtCodigoTv.Name = "txtCodigoTv";
            this.txtCodigoTv.ReadOnly = true;
            this.txtCodigoTv.Size = new System.Drawing.Size(120, 20);
            this.txtCodigoTv.TabIndex = 7;
            // 
            // txtTramiteTv
            // 
            this.txtTramiteTv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTramiteTv.Location = new System.Drawing.Point(65, 276);
            this.txtTramiteTv.Name = "txtTramiteTv";
            this.txtTramiteTv.ReadOnly = true;
            this.txtTramiteTv.Size = new System.Drawing.Size(120, 20);
            this.txtTramiteTv.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Tramite";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Nombre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Codigo";
            // 
            // FrmArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 525);
            this.Controls.Add(this.mrcRecorrido);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.mrcNuevoElemento);
            this.Controls.Add(this.pbImagen1);
            this.Name = "FrmArbolBinario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arbol Binario";
            this.Load += new System.EventHandler(this.FrmArbolBinario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMostrar)).EndInit();
            this.mrcNuevoElemento.ResumeLayout(false);
            this.mrcNuevoElemento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen1)).EndInit();
            this.mrcRecorrido.ResumeLayout(false);
            this.mrcRecorrido.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox lstCodigo;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DgvMostrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ListBox lstArbolBinario;
        private System.Windows.Forms.GroupBox mrcNuevoElemento;
        private System.Windows.Forms.Button cmdAceptar;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbImagen1;
        private System.Windows.Forms.GroupBox mrcRecorrido;
        private System.Windows.Forms.RadioButton rbPostOrden;
        private System.Windows.Forms.RadioButton rbPreOrden;
        private System.Windows.Forms.RadioButton rbInOrdenDesc;
        private System.Windows.Forms.RadioButton rbOrdenAsc;
        private System.Windows.Forms.TreeView tvMostrar;
        private System.Windows.Forms.TextBox txtNombretv;
        private System.Windows.Forms.TextBox txtTramiteTv;
        private System.Windows.Forms.TextBox txtCodigoTv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}