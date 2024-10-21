namespace tarjeta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.txtNumeroTarjeta = new System.Windows.Forms.Label();
            this.txtApellidoNombre = new System.Windows.Forms.Label();
            this.txtVencimiento = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.Label();
            this.txtCodigoVerificacion = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(50, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(401, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Confirmar Compra";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNumeroTarjeta
            // 
            this.txtNumeroTarjeta.AccessibleName = "numeroTarjeta";
            this.txtNumeroTarjeta.AutoSize = true;
            this.txtNumeroTarjeta.Location = new System.Drawing.Point(154, 52);
            this.txtNumeroTarjeta.Name = "txtNumeroTarjeta";
            this.txtNumeroTarjeta.Size = new System.Drawing.Size(82, 13);
            this.txtNumeroTarjeta.TabIndex = 1;
            this.txtNumeroTarjeta.Text = "Numero  tarjeta:";
            // 
            // txtApellidoNombre
            // 
            this.txtApellidoNombre.AutoSize = true;
            this.txtApellidoNombre.Location = new System.Drawing.Point(156, 118);
            this.txtApellidoNombre.Name = "txtApellidoNombre";
            this.txtApellidoNombre.Size = new System.Drawing.Size(95, 13);
            this.txtApellidoNombre.TabIndex = 2;
            this.txtApellidoNombre.Text = "Apellido / Nombre:";
            // 
            // txtVencimiento
            // 
            this.txtVencimiento.AutoSize = true;
            this.txtVencimiento.Location = new System.Drawing.Point(154, 246);
            this.txtVencimiento.Name = "txtVencimiento";
            this.txtVencimiento.Size = new System.Drawing.Size(68, 13);
            this.txtVencimiento.TabIndex = 3;
            this.txtVencimiento.Text = "Vencimiento:";
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.Location = new System.Drawing.Point(154, 177);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(35, 13);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Text = "Email:";
            // 
            // txtCodigoVerificacion
            // 
            this.txtCodigoVerificacion.AutoSize = true;
            this.txtCodigoVerificacion.Location = new System.Drawing.Point(266, 246);
            this.txtCodigoVerificacion.Name = "txtCodigoVerificacion";
            this.txtCodigoVerificacion.Size = new System.Drawing.Size(104, 13);
            this.txtCodigoVerificacion.TabIndex = 5;
            this.txtCodigoVerificacion.Text = "Codigo Verificacion: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(157, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(157, 145);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(201, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(157, 262);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(84, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(157, 203);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(201, 20);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(269, 262);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(89, 20);
            this.textBox5.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 450);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtCodigoVerificacion);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtVencimiento);
            this.Controls.Add(this.txtApellidoNombre);
            this.Controls.Add(this.txtNumeroTarjeta);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Facturacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txtNumeroTarjeta;
        private System.Windows.Forms.Label txtApellidoNombre;
        private System.Windows.Forms.Label txtVencimiento;
        private System.Windows.Forms.Label txtEmail;
        private System.Windows.Forms.Label txtCodigoVerificacion;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
    }
}

