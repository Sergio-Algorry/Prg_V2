namespace Prg_V2.FE
{
    partial class frmInicio
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
            this.btIncremeto = new System.Windows.Forms.Button();
            this.lblSalida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btIncremeto
            // 
            this.btIncremeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIncremeto.Location = new System.Drawing.Point(21, 12);
            this.btIncremeto.Name = "btIncremeto";
            this.btIncremeto.Size = new System.Drawing.Size(43, 23);
            this.btIncremeto.TabIndex = 0;
            this.btIncremeto.Text = "++";
            this.btIncremeto.UseVisualStyleBackColor = true;
            this.btIncremeto.Click += new System.EventHandler(this.btIncremeto_Click);
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalida.Location = new System.Drawing.Point(94, 15);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(17, 17);
            this.lblSalida.TabIndex = 1;
            this.lblSalida.Text = "0";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 57);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.btIncremeto);
            this.Name = "frmInicio";
            this.Text = "Formulario inicial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btIncremeto;
        private System.Windows.Forms.Label lblSalida;
    }
}

