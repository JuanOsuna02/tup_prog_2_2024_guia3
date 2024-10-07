namespace ejercicio2_guia3
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
            this.btnPresup = new System.Windows.Forms.Button();
            this.btnAgregarPro = new System.Windows.Forms.Button();
            this.btnVerPres = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPresup
            // 
            this.btnPresup.Location = new System.Drawing.Point(49, 37);
            this.btnPresup.Name = "btnPresup";
            this.btnPresup.Size = new System.Drawing.Size(169, 53);
            this.btnPresup.TabIndex = 0;
            this.btnPresup.Text = "Iniciar Presupuesto";
            this.btnPresup.UseVisualStyleBackColor = true;
            this.btnPresup.Click += new System.EventHandler(this.btnPresup_Click);
            // 
            // btnAgregarPro
            // 
            this.btnAgregarPro.Location = new System.Drawing.Point(49, 122);
            this.btnAgregarPro.Name = "btnAgregarPro";
            this.btnAgregarPro.Size = new System.Drawing.Size(169, 53);
            this.btnAgregarPro.TabIndex = 1;
            this.btnAgregarPro.Text = "Agregar Producto";
            this.btnAgregarPro.UseVisualStyleBackColor = true;
            this.btnAgregarPro.Click += new System.EventHandler(this.btnAgregarPro_Click);
            // 
            // btnVerPres
            // 
            this.btnVerPres.Location = new System.Drawing.Point(49, 237);
            this.btnVerPres.Name = "btnVerPres";
            this.btnVerPres.Size = new System.Drawing.Size(169, 53);
            this.btnVerPres.TabIndex = 2;
            this.btnVerPres.Text = "Ver Presupuesto";
            this.btnVerPres.UseVisualStyleBackColor = true;
            this.btnVerPres.Click += new System.EventHandler(this.btnVerPres_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(49, 338);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(169, 53);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(487, 89);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 13);
            this.lblNombre.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Direccion";
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Location = new System.Drawing.Point(487, 162);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(0, 13);
            this.lbDireccion.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbDireccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnVerPres);
            this.Controls.Add(this.btnAgregarPro);
            this.Controls.Add(this.btnPresup);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPresup;
        private System.Windows.Forms.Button btnAgregarPro;
        private System.Windows.Forms.Button btnVerPres;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lbDireccion;
        public System.Windows.Forms.Label lblNombre;
    }
}

