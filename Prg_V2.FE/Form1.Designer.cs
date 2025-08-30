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
            this.btIncremetoAntes = new System.Windows.Forms.Button();
            this.lblYAntesInicio = new System.Windows.Forms.Label();
            this.btIncrementoDespues = new System.Windows.Forms.Button();
            this.lblYDespuesInicio = new System.Windows.Forms.Label();
            this.lblXDespuesInicio = new System.Windows.Forms.Label();
            this.lblXAntesInicio = new System.Windows.Forms.Label();
            this.lblYDespuesFin = new System.Windows.Forms.Label();
            this.lblYAntesFin = new System.Windows.Forms.Label();
            this.lblXDespuesFin = new System.Windows.Forms.Label();
            this.lblXantesFin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btIncremetoAntes
            // 
            this.btIncremetoAntes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIncremetoAntes.Location = new System.Drawing.Point(263, 56);
            this.btIncremetoAntes.Name = "btIncremetoAntes";
            this.btIncremetoAntes.Size = new System.Drawing.Size(67, 40);
            this.btIncremetoAntes.TabIndex = 0;
            this.btIncremetoAntes.Text = "++ X";
            this.btIncremetoAntes.UseVisualStyleBackColor = true;
            this.btIncremetoAntes.Click += new System.EventHandler(this.btIncremetoAntes_Click);
            // 
            // lblYAntesInicio
            // 
            this.lblYAntesInicio.AutoSize = true;
            this.lblYAntesInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYAntesInicio.Location = new System.Drawing.Point(134, 68);
            this.lblYAntesInicio.Name = "lblYAntesInicio";
            this.lblYAntesInicio.Size = new System.Drawing.Size(17, 17);
            this.lblYAntesInicio.TabIndex = 1;
            this.lblYAntesInicio.Text = "0";
            // 
            // btIncrementoDespues
            // 
            this.btIncrementoDespues.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIncrementoDespues.Location = new System.Drawing.Point(263, 110);
            this.btIncrementoDespues.Name = "btIncrementoDespues";
            this.btIncrementoDespues.Size = new System.Drawing.Size(67, 40);
            this.btIncrementoDespues.TabIndex = 2;
            this.btIncrementoDespues.Text = "X ++";
            this.btIncrementoDespues.UseVisualStyleBackColor = true;
            this.btIncrementoDespues.Click += new System.EventHandler(this.btIncrementoDespues_Click);
            // 
            // lblYDespuesInicio
            // 
            this.lblYDespuesInicio.AutoSize = true;
            this.lblYDespuesInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYDespuesInicio.Location = new System.Drawing.Point(134, 122);
            this.lblYDespuesInicio.Name = "lblYDespuesInicio";
            this.lblYDespuesInicio.Size = new System.Drawing.Size(17, 17);
            this.lblYDespuesInicio.TabIndex = 3;
            this.lblYDespuesInicio.Text = "0";
            // 
            // lblXDespuesInicio
            // 
            this.lblXDespuesInicio.AutoSize = true;
            this.lblXDespuesInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXDespuesInicio.Location = new System.Drawing.Point(170, 122);
            this.lblXDespuesInicio.Name = "lblXDespuesInicio";
            this.lblXDespuesInicio.Size = new System.Drawing.Size(17, 17);
            this.lblXDespuesInicio.TabIndex = 5;
            this.lblXDespuesInicio.Text = "0";
            // 
            // lblXAntesInicio
            // 
            this.lblXAntesInicio.AutoSize = true;
            this.lblXAntesInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXAntesInicio.Location = new System.Drawing.Point(170, 68);
            this.lblXAntesInicio.Name = "lblXAntesInicio";
            this.lblXAntesInicio.Size = new System.Drawing.Size(17, 17);
            this.lblXAntesInicio.TabIndex = 4;
            this.lblXAntesInicio.Text = "0";
            // 
            // lblYDespuesFin
            // 
            this.lblYDespuesFin.AutoSize = true;
            this.lblYDespuesFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYDespuesFin.Location = new System.Drawing.Point(387, 122);
            this.lblYDespuesFin.Name = "lblYDespuesFin";
            this.lblYDespuesFin.Size = new System.Drawing.Size(17, 17);
            this.lblYDespuesFin.TabIndex = 7;
            this.lblYDespuesFin.Text = "0";
            // 
            // lblYAntesFin
            // 
            this.lblYAntesFin.AutoSize = true;
            this.lblYAntesFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYAntesFin.Location = new System.Drawing.Point(387, 68);
            this.lblYAntesFin.Name = "lblYAntesFin";
            this.lblYAntesFin.Size = new System.Drawing.Size(17, 17);
            this.lblYAntesFin.TabIndex = 6;
            this.lblYAntesFin.Text = "0";
            // 
            // lblXDespuesFin
            // 
            this.lblXDespuesFin.AutoSize = true;
            this.lblXDespuesFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXDespuesFin.Location = new System.Drawing.Point(424, 122);
            this.lblXDespuesFin.Name = "lblXDespuesFin";
            this.lblXDespuesFin.Size = new System.Drawing.Size(17, 17);
            this.lblXDespuesFin.TabIndex = 9;
            this.lblXDespuesFin.Text = "0";
            // 
            // lblXantesFin
            // 
            this.lblXantesFin.AutoSize = true;
            this.lblXantesFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXantesFin.Location = new System.Drawing.Point(424, 68);
            this.lblXantesFin.Name = "lblXantesFin";
            this.lblXantesFin.Size = new System.Drawing.Size(17, 17);
            this.lblXantesFin.TabIndex = 8;
            this.lblXantesFin.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Variables antes de operar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(334, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Variables despues de operar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(134, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Y       X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(388, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Y       X";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 209);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblXDespuesFin);
            this.Controls.Add(this.lblXantesFin);
            this.Controls.Add(this.lblYDespuesFin);
            this.Controls.Add(this.lblYAntesFin);
            this.Controls.Add(this.lblXDespuesInicio);
            this.Controls.Add(this.lblXAntesInicio);
            this.Controls.Add(this.lblYDespuesInicio);
            this.Controls.Add(this.btIncrementoDespues);
            this.Controls.Add(this.lblYAntesInicio);
            this.Controls.Add(this.btIncremetoAntes);
            this.Name = "frmInicio";
            this.Text = "Formulario inicial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btIncremetoAntes;
        private System.Windows.Forms.Label lblYAntesInicio;
        private System.Windows.Forms.Button btIncrementoDespues;
        private System.Windows.Forms.Label lblYDespuesInicio;
        private System.Windows.Forms.Label lblXDespuesInicio;
        private System.Windows.Forms.Label lblXAntesInicio;
        private System.Windows.Forms.Label lblYDespuesFin;
        private System.Windows.Forms.Label lblYAntesFin;
        private System.Windows.Forms.Label lblXDespuesFin;
        private System.Windows.Forms.Label lblXantesFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

