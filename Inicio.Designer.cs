namespace Asadero_Pollitos_En_Fuga
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.lblbnvnd = new System.Windows.Forms.Label();
            this.btnComenzar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblbnvnd
            // 
            this.lblbnvnd.AutoSize = true;
            this.lblbnvnd.BackColor = System.Drawing.Color.Black;
            this.lblbnvnd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblbnvnd.Font = new System.Drawing.Font("Modern No. 20", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbnvnd.ForeColor = System.Drawing.Color.SeaShell;
            this.lblbnvnd.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblbnvnd.Location = new System.Drawing.Point(21, 513);
            this.lblbnvnd.Name = "lblbnvnd";
            this.lblbnvnd.Size = new System.Drawing.Size(844, 67);
            this.lblbnvnd.TabIndex = 0;
            this.lblbnvnd.Text = "Bienvenido a nuestro asadero!!";
            this.lblbnvnd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblbnvnd.Click += new System.EventHandler(this.lblbnvnd_Click);
            // 
            // btnComenzar
            // 
            this.btnComenzar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComenzar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComenzar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComenzar.Location = new System.Drawing.Point(980, 513);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(279, 67);
            this.btnComenzar.TabIndex = 1;
            this.btnComenzar.Text = "Comenzar";
            this.btnComenzar.UseVisualStyleBackColor = true;
            this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Asadero_Pollitos_En_Fuga.Properties.Resources.Fondo_para_inicio;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.btnComenzar);
            this.Controls.Add(this.lblbnvnd);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asadero Pollitos En Fuga";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblbnvnd;
        private System.Windows.Forms.Button btnComenzar;
    }
}

