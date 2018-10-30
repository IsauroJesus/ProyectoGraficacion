namespace Proy_Final_v1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Cuadro = new System.Windows.Forms.PictureBox();
            this.bnQuitar = new System.Windows.Forms.Button();
            this.bnPoner = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Cuadro)).BeginInit();
            this.SuspendLayout();
            // 
            // Cuadro
            // 
            this.Cuadro.Image = global::Proy_Final_v1.Properties.Resources.Mickey_Mouse;
            this.Cuadro.Location = new System.Drawing.Point(2, -1);
            this.Cuadro.Name = "Cuadro";
            this.Cuadro.Size = new System.Drawing.Size(1280, 720);
            this.Cuadro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Cuadro.TabIndex = 0;
            this.Cuadro.TabStop = false;
            this.Cuadro.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // bnQuitar
            // 
            this.bnQuitar.Location = new System.Drawing.Point(12, -1);
            this.bnQuitar.Name = "bnQuitar";
            this.bnQuitar.Size = new System.Drawing.Size(67, 45);
            this.bnQuitar.TabIndex = 1;
            this.bnQuitar.Text = "Quitar Dibujo";
            this.bnQuitar.UseVisualStyleBackColor = true;
            this.bnQuitar.Click += new System.EventHandler(this.bnQuitar_Click);
            // 
            // bnPoner
            // 
            this.bnPoner.Location = new System.Drawing.Point(85, 1);
            this.bnPoner.Name = "bnPoner";
            this.bnPoner.Size = new System.Drawing.Size(67, 43);
            this.bnPoner.TabIndex = 2;
            this.bnPoner.Text = "Poner Dibujo";
            this.bnPoner.UseVisualStyleBackColor = true;
            this.bnPoner.Click += new System.EventHandler(this.bnPoner_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1292, 731);
            this.Controls.Add(this.bnPoner);
            this.Controls.Add(this.bnQuitar);
            this.Controls.Add(this.Cuadro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.Cuadro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Cuadro;
        private System.Windows.Forms.Button bnQuitar;
        private System.Windows.Forms.Button bnPoner;
    }
}

