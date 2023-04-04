namespace Lab03
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
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.txtBaseDatos = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.Servidor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkAutenticacion = new System.Windows.Forms.CheckBox();
            this.btnConectar = new System.Windows.Forms.Button();
<<<<<<< HEAD
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.btnPersonas = new System.Windows.Forms.Button();
            this.btnEstado = new System.Windows.Forms.Button();
=======
            this.btnEstado = new System.Windows.Forms.Button();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.btnPersona = new System.Windows.Forms.Button();
>>>>>>> 58ac058fc7ba572ffc32b68ad96f9f0cf7905b99
            this.SuspendLayout();
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(32, 44);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(221, 20);
            this.txtServidor.TabIndex = 0;
            // 
            // txtBaseDatos
            // 
            this.txtBaseDatos.Location = new System.Drawing.Point(28, 118);
            this.txtBaseDatos.Name = "txtBaseDatos";
            this.txtBaseDatos.Size = new System.Drawing.Size(225, 20);
            this.txtBaseDatos.TabIndex = 1;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(306, 44);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(221, 20);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(306, 118);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(221, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Servidor
            // 
            this.Servidor.AutoSize = true;
            this.Servidor.Location = new System.Drawing.Point(29, 19);
            this.Servidor.Name = "Servidor";
            this.Servidor.Size = new System.Drawing.Size(46, 13);
            this.Servidor.TabIndex = 4;
            this.Servidor.Text = "Servidor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Base de datos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Contraseña";
            // 
            // chkAutenticacion
            // 
            this.chkAutenticacion.AutoSize = true;
            this.chkAutenticacion.Checked = true;
            this.chkAutenticacion.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutenticacion.Location = new System.Drawing.Point(32, 158);
            this.chkAutenticacion.Name = "chkAutenticacion";
            this.chkAutenticacion.Size = new System.Drawing.Size(91, 17);
            this.chkAutenticacion.TabIndex = 8;
            this.chkAutenticacion.Text = "Autenticacion";
            this.chkAutenticacion.UseVisualStyleBackColor = true;
            this.chkAutenticacion.CheckedChanged += new System.EventHandler(this.chkAutenticacion_CheckedChanged);
            // 
            // btnConectar
            // 
<<<<<<< HEAD
            this.btnConectar.Location = new System.Drawing.Point(116, 316);
=======
            this.btnConectar.Location = new System.Drawing.Point(122, 194);
>>>>>>> 58ac058fc7ba572ffc32b68ad96f9f0cf7905b99
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(99, 23);
            this.btnConectar.TabIndex = 9;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
<<<<<<< HEAD
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Location = new System.Drawing.Point(328, 316);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(101, 23);
            this.btnDesconectar.TabIndex = 11;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // btnPersonas
            // 
            this.btnPersonas.Location = new System.Drawing.Point(221, 360);
            this.btnPersonas.Name = "btnPersonas";
            this.btnPersonas.Size = new System.Drawing.Size(97, 23);
            this.btnPersonas.TabIndex = 12;
            this.btnPersonas.Text = "Personas";
            this.btnPersonas.UseVisualStyleBackColor = true;
            // 
            // btnEstado
            // 
            this.btnEstado.Location = new System.Drawing.Point(223, 316);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(99, 23);
            this.btnEstado.TabIndex = 13;
            this.btnEstado.Text = "Estado";
            this.btnEstado.UseVisualStyleBackColor = true;
            this.btnEstado.Click += new System.EventHandler(this.btnEstado_Click);
=======
            // 
            // btnEstado
            // 
            this.btnEstado.Location = new System.Drawing.Point(227, 194);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(97, 23);
            this.btnEstado.TabIndex = 10;
            this.btnEstado.Text = "Estado";
            this.btnEstado.UseVisualStyleBackColor = true;
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Enabled = false;
            this.btnDesconectar.Location = new System.Drawing.Point(330, 194);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(101, 23);
            this.btnDesconectar.TabIndex = 11;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            // 
            // btnPersona
            // 
            this.btnPersona.Location = new System.Drawing.Point(227, 232);
            this.btnPersona.Name = "btnPersona";
            this.btnPersona.Size = new System.Drawing.Size(97, 23);
            this.btnPersona.TabIndex = 12;
            this.btnPersona.Text = "Personas";
            this.btnPersona.UseVisualStyleBackColor = true;
>>>>>>> 58ac058fc7ba572ffc32b68ad96f9f0cf7905b99
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEstado);
            this.Controls.Add(this.btnPersonas);
            this.Controls.Add(this.btnDesconectar);
=======
            this.ClientSize = new System.Drawing.Size(559, 284);
            this.Controls.Add(this.btnPersona);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.btnEstado);
>>>>>>> 58ac058fc7ba572ffc32b68ad96f9f0cf7905b99
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.chkAutenticacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Servidor);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtBaseDatos);
            this.Controls.Add(this.txtServidor);
            this.Name = "Form1";
            this.Text = "Conexion a un origen de datos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.TextBox txtBaseDatos;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label Servidor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkAutenticacion;
        private System.Windows.Forms.Button btnConectar;
<<<<<<< HEAD
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Button btnPersonas;
        private System.Windows.Forms.Button btnEstado;
=======
        private System.Windows.Forms.Button btnEstado;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Button btnPersona;
>>>>>>> 58ac058fc7ba572ffc32b68ad96f9f0cf7905b99
    }
}

