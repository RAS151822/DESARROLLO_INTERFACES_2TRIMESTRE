namespace ButtonRas
{
    partial class ButtonRas
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ButtonRas));
            this.buttonRasnew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRasnew
            // 
            this.buttonRasnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRasnew.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRasnew.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRasnew.Image = ((System.Drawing.Image)(resources.GetObject("buttonRasnew.Image")));
            this.buttonRasnew.Location = new System.Drawing.Point(3, 0);
            this.buttonRasnew.Name = "buttonRasnew";
            this.buttonRasnew.Size = new System.Drawing.Size(138, 63);
            this.buttonRasnew.TabIndex = 0;
            this.buttonRasnew.Text = "ASIENTO";
            this.buttonRasnew.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonRasnew.UseVisualStyleBackColor = true;
            this.buttonRasnew.Click += new System.EventHandler(this.buttonRasnew_Click);
            // 
            // ButtonRas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonRasnew);
            this.Name = "ButtonRas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRasnew;
    }
}
