namespace Liebre_y_tortuga2
{
    partial class Form1
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
            this.txtPista = new System.Windows.Forms.TextBox();
            this.btnCarrera = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPista
            // 
            this.txtPista.Location = new System.Drawing.Point(38, 87);
            this.txtPista.Multiline = true;
            this.txtPista.Name = "txtPista";
            this.txtPista.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPista.Size = new System.Drawing.Size(303, 205);
            this.txtPista.TabIndex = 0;
            // 
            // btnCarrera
            // 
            this.btnCarrera.Location = new System.Drawing.Point(71, 48);
            this.btnCarrera.Name = "btnCarrera";
            this.btnCarrera.Size = new System.Drawing.Size(133, 23);
            this.btnCarrera.TabIndex = 1;
            this.btnCarrera.Text = "Comenzar carrera";
            this.btnCarrera.UseVisualStyleBackColor = true;
            this.btnCarrera.Click += new System.EventHandler(this.btnCarrera_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 347);
            this.Controls.Add(this.btnCarrera);
            this.Controls.Add(this.txtPista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPista;
        private System.Windows.Forms.Button btnCarrera;
    }
}

