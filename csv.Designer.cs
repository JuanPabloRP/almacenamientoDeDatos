﻿namespace almacenamientoDeDatos
{
    partial class frmCsv
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
            this.lblAgregar = new System.Windows.Forms.Label();
            this.lblEliminar = new System.Windows.Forms.Label();
            this.lblNuevoNombre = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblEditarId = new System.Windows.Forms.Label();
            this.txtEliminar = new System.Windows.Forms.TextBox();
            this.txtEditar = new System.Windows.Forms.TextBox();
            this.txtAgregar = new System.Windows.Forms.TextBox();
            this.dgvPersonas = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.imgAtras = new System.Windows.Forms.PictureBox();
            this.lblTituloCSV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAtras)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAgregar
            // 
            this.lblAgregar.AutoSize = true;
            this.lblAgregar.Location = new System.Drawing.Point(51, 117);
            this.lblAgregar.Name = "lblAgregar";
            this.lblAgregar.Size = new System.Drawing.Size(82, 13);
            this.lblAgregar.TabIndex = 27;
            this.lblAgregar.Text = "Agregar nombre";
            // 
            // lblEliminar
            // 
            this.lblEliminar.AutoSize = true;
            this.lblEliminar.Location = new System.Drawing.Point(540, 117);
            this.lblEliminar.Name = "lblEliminar";
            this.lblEliminar.Size = new System.Drawing.Size(56, 13);
            this.lblEliminar.TabIndex = 26;
            this.lblEliminar.Text = "Ingrese ID";
            // 
            // lblNuevoNombre
            // 
            this.lblNuevoNombre.AutoSize = true;
            this.lblNuevoNombre.Location = new System.Drawing.Point(351, 117);
            this.lblNuevoNombre.Name = "lblNuevoNombre";
            this.lblNuevoNombre.Size = new System.Drawing.Size(77, 13);
            this.lblNuevoNombre.TabIndex = 25;
            this.lblNuevoNombre.Text = "Nuevo nombre";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(248, 142);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 24;
            // 
            // lblEditarId
            // 
            this.lblEditarId.AutoSize = true;
            this.lblEditarId.Location = new System.Drawing.Point(245, 117);
            this.lblEditarId.Name = "lblEditarId";
            this.lblEditarId.Size = new System.Drawing.Size(56, 13);
            this.lblEditarId.TabIndex = 23;
            this.lblEditarId.Text = "Ingrese ID";
            // 
            // txtEliminar
            // 
            this.txtEliminar.Location = new System.Drawing.Point(543, 142);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(100, 20);
            this.txtEliminar.TabIndex = 22;
            // 
            // txtEditar
            // 
            this.txtEditar.Location = new System.Drawing.Point(354, 142);
            this.txtEditar.Name = "txtEditar";
            this.txtEditar.Size = new System.Drawing.Size(100, 20);
            this.txtEditar.TabIndex = 21;
            // 
            // txtAgregar
            // 
            this.txtAgregar.Location = new System.Drawing.Point(54, 138);
            this.txtAgregar.Name = "txtAgregar";
            this.txtAgregar.Size = new System.Drawing.Size(100, 20);
            this.txtAgregar.TabIndex = 20;
            // 
            // dgvPersonas
            // 
            this.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonas.Location = new System.Drawing.Point(183, 215);
            this.dgvPersonas.Name = "dgvPersonas";
            this.dgvPersonas.Size = new System.Drawing.Size(344, 197);
            this.dgvPersonas.TabIndex = 19;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(543, 168);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(103, 23);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar persona";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(307, 168);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(103, 23);
            this.btnEditar.TabIndex = 17;
            this.btnEditar.Text = "Editar persona";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(63, 168);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(70, 23);
            this.btnCrear.TabIndex = 16;
            this.btnCrear.Text = "Agregar";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // imgAtras
            // 
            this.imgAtras.Image = global::almacenamientoDeDatos.Properties.Resources.icons8_atrás_96;
            this.imgAtras.Location = new System.Drawing.Point(6, 12);
            this.imgAtras.Name = "imgAtras";
            this.imgAtras.Size = new System.Drawing.Size(46, 39);
            this.imgAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgAtras.TabIndex = 15;
            this.imgAtras.TabStop = false;
            this.imgAtras.Click += new System.EventHandler(this.imgAtras_Click);
            // 
            // lblTituloCSV
            // 
            this.lblTituloCSV.AutoSize = true;
            this.lblTituloCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCSV.Location = new System.Drawing.Point(210, 30);
            this.lblTituloCSV.Name = "lblTituloCSV";
            this.lblTituloCSV.Size = new System.Drawing.Size(317, 31);
            this.lblTituloCSV.TabIndex = 14;
            this.lblTituloCSV.Text = "CRUD con archivos CSV";
            // 
            // frmCsv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 441);
            this.Controls.Add(this.lblAgregar);
            this.Controls.Add(this.lblEliminar);
            this.Controls.Add(this.lblNuevoNombre);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblEditarId);
            this.Controls.Add(this.txtEliminar);
            this.Controls.Add(this.txtEditar);
            this.Controls.Add(this.txtAgregar);
            this.Controls.Add(this.dgvPersonas);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.imgAtras);
            this.Controls.Add(this.lblTituloCSV);
            this.Name = "frmCsv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "csv";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAtras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAgregar;
        private System.Windows.Forms.Label lblEliminar;
        private System.Windows.Forms.Label lblNuevoNombre;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblEditarId;
        private System.Windows.Forms.TextBox txtEliminar;
        private System.Windows.Forms.TextBox txtEditar;
        private System.Windows.Forms.TextBox txtAgregar;
        private System.Windows.Forms.DataGridView dgvPersonas;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.PictureBox imgAtras;
        private System.Windows.Forms.Label lblTituloCSV;
    }
}