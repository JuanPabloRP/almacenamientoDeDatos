namespace almacenamientoDeDatos
{
    partial class frmTxt
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
            this.lblTituloTxt = new System.Windows.Forms.Label();
            this.imgAtras = new System.Windows.Forms.PictureBox();
            this.btnCrear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgAtras)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloTxt
            // 
            this.lblTituloTxt.AutoSize = true;
            this.lblTituloTxt.Location = new System.Drawing.Point(306, 27);
            this.lblTituloTxt.Name = "lblTituloTxt";
            this.lblTituloTxt.Size = new System.Drawing.Size(136, 13);
            this.lblTituloTxt.TabIndex = 0;
            this.lblTituloTxt.Text = "CRUD con archivos planos";
            // 
            // imgAtras
            // 
            this.imgAtras.Location = new System.Drawing.Point(12, 12);
            this.imgAtras.Name = "imgAtras";
            this.imgAtras.Size = new System.Drawing.Size(79, 50);
            this.imgAtras.TabIndex = 1;
            this.imgAtras.TabStop = false;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(77, 190);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 2;
            this.btnCrear.Text = "Crear txt";
            this.btnCrear.UseVisualStyleBackColor = true;
            // 
            // frmTxt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.imgAtras);
            this.Controls.Add(this.lblTituloTxt);
            this.Name = "frmTxt";
            this.Text = "txt";
            ((System.ComponentModel.ISupportInitialize)(this.imgAtras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloTxt;
        private System.Windows.Forms.PictureBox imgAtras;
        private System.Windows.Forms.Button btnCrear;
    }
}