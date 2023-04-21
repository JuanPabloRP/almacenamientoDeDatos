namespace almacenamientoDeDatos
{
    partial class frmInicial
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnTxt = new System.Windows.Forms.Button();
            this.btnCsv = new System.Windows.Forms.Button();
            this.btnRtf = new System.Windows.Forms.Button();
            this.btnXml = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(44, 26);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(326, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Almacenamiento de datos";
            // 
            // btnTxt
            // 
            this.btnTxt.BackColor = System.Drawing.Color.White;
            this.btnTxt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTxt.Location = new System.Drawing.Point(85, 118);
            this.btnTxt.Name = "btnTxt";
            this.btnTxt.Size = new System.Drawing.Size(75, 23);
            this.btnTxt.TabIndex = 1;
            this.btnTxt.Text = "TXT";
            this.btnTxt.UseVisualStyleBackColor = false;
            this.btnTxt.Click += new System.EventHandler(this.btnTxt_Click);
            // 
            // btnCsv
            // 
            this.btnCsv.BackColor = System.Drawing.Color.White;
            this.btnCsv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCsv.Location = new System.Drawing.Point(84, 190);
            this.btnCsv.Name = "btnCsv";
            this.btnCsv.Size = new System.Drawing.Size(75, 23);
            this.btnCsv.TabIndex = 2;
            this.btnCsv.Text = "CSV";
            this.btnCsv.UseVisualStyleBackColor = false;
            this.btnCsv.Click += new System.EventHandler(this.btnCsv_Click);
            // 
            // btnRtf
            // 
            this.btnRtf.BackColor = System.Drawing.Color.White;
            this.btnRtf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRtf.Location = new System.Drawing.Point(244, 190);
            this.btnRtf.Name = "btnRtf";
            this.btnRtf.Size = new System.Drawing.Size(75, 23);
            this.btnRtf.TabIndex = 3;
            this.btnRtf.Text = "RTF";
            this.btnRtf.UseVisualStyleBackColor = false;
            this.btnRtf.Click += new System.EventHandler(this.btnRtf_Click);
            // 
            // btnXml
            // 
            this.btnXml.BackColor = System.Drawing.Color.White;
            this.btnXml.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXml.Location = new System.Drawing.Point(244, 118);
            this.btnXml.Name = "btnXml";
            this.btnXml.Size = new System.Drawing.Size(75, 23);
            this.btnXml.TabIndex = 4;
            this.btnXml.Text = "XML";
            this.btnXml.UseVisualStyleBackColor = false;
            this.btnXml.Click += new System.EventHandler(this.btnXml_Click);
            // 
            // frmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 297);
            this.Controls.Add(this.btnXml);
            this.Controls.Add(this.btnRtf);
            this.Controls.Add(this.btnCsv);
            this.Controls.Add(this.btnTxt);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Página inicial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnTxt;
        private System.Windows.Forms.Button btnCsv;
        private System.Windows.Forms.Button btnRtf;
        private System.Windows.Forms.Button btnXml;
    }
}

