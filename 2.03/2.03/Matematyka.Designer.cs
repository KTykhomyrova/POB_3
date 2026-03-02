namespace _2._03
{
    partial class Matematyka
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonMath = new System.Windows.Forms.Button();
            this.buttonGeo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMath
            // 
            this.buttonMath.Location = new System.Drawing.Point(86, 91);
            this.buttonMath.Name = "buttonMath";
            this.buttonMath.Size = new System.Drawing.Size(75, 23);
            this.buttonMath.TabIndex = 0;
            this.buttonMath.Text = "Matematyka";
            this.buttonMath.UseVisualStyleBackColor = true;
            this.buttonMath.Click += new System.EventHandler(this.buttonMath_Click);
            // 
            // buttonGeo
            // 
            this.buttonGeo.Location = new System.Drawing.Point(233, 91);
            this.buttonGeo.Name = "buttonGeo";
            this.buttonGeo.Size = new System.Drawing.Size(75, 23);
            this.buttonGeo.TabIndex = 1;
            this.buttonGeo.Text = "Geometria";
            this.buttonGeo.UseVisualStyleBackColor = true;
            this.buttonGeo.Click += new System.EventHandler(this.buttonGeo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGeo);
            this.Controls.Add(this.buttonMath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMath;
        private System.Windows.Forms.Button buttonGeo;
    }
}

