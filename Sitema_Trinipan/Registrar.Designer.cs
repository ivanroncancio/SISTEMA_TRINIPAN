﻿namespace Sitema_Trinipan
{
    partial class Registrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registrar));
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TexBox_id = new LibreriaDLL.ErrorTexBox();
            this.TexBox_Nombre = new LibreriaDLL.ErrorTexBox();
            this.TexBox_Cuenta = new LibreriaDLL.ErrorTexBox();
            this.TexBox_Contrasena = new LibreriaDLL.ErrorTexBox();
            this.TexBox_ConfiContrasena = new LibreriaDLL.ErrorTexBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.AutoSize = true;
            this.btn_Guardar.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.Location = new System.Drawing.Point(194, 411);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(132, 43);
            this.btn_Guardar.TabIndex = 36;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Elephant", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(196, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(434, 41);
            this.label6.TabIndex = 35;
            this.label6.Text = "Registrar Administrador";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(601, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 30);
            this.button1.TabIndex = 34;
            this.button1.Text = "Seleccionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(558, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 23);
            this.label5.TabIndex = 32;
            this.label5.Text = "Confirmar cont...:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 23);
            this.label4.TabIndex = 31;
            this.label4.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 23);
            this.label3.TabIndex = 30;
            this.label3.Text = "Cuenta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 29;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "ID:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TexBox_id
            // 
            this.TexBox_id.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TexBox_id.Location = new System.Drawing.Point(193, 104);
            this.TexBox_id.Name = "TexBox_id";
            this.TexBox_id.Size = new System.Drawing.Size(295, 26);
            this.TexBox_id.TabIndex = 41;
            this.TexBox_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TexBox_id.Validar = true;
            this.TexBox_id.ValidarNumeros = true;
            // 
            // TexBox_Nombre
            // 
            this.TexBox_Nombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TexBox_Nombre.Location = new System.Drawing.Point(193, 155);
            this.TexBox_Nombre.Name = "TexBox_Nombre";
            this.TexBox_Nombre.Size = new System.Drawing.Size(296, 26);
            this.TexBox_Nombre.TabIndex = 40;
            this.TexBox_Nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TexBox_Nombre.Validar = true;
            this.TexBox_Nombre.ValidarNumeros = false;
            // 
            // TexBox_Cuenta
            // 
            this.TexBox_Cuenta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TexBox_Cuenta.Location = new System.Drawing.Point(193, 205);
            this.TexBox_Cuenta.Name = "TexBox_Cuenta";
            this.TexBox_Cuenta.Size = new System.Drawing.Size(295, 26);
            this.TexBox_Cuenta.TabIndex = 39;
            this.TexBox_Cuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TexBox_Cuenta.Validar = true;
            this.TexBox_Cuenta.ValidarNumeros = false;
            // 
            // TexBox_Contrasena
            // 
            this.TexBox_Contrasena.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TexBox_Contrasena.Location = new System.Drawing.Point(193, 256);
            this.TexBox_Contrasena.Name = "TexBox_Contrasena";
            this.TexBox_Contrasena.Size = new System.Drawing.Size(296, 26);
            this.TexBox_Contrasena.TabIndex = 38;
            this.TexBox_Contrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TexBox_Contrasena.Validar = true;
            this.TexBox_Contrasena.ValidarNumeros = false;
            // 
            // TexBox_ConfiContrasena
            // 
            this.TexBox_ConfiContrasena.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TexBox_ConfiContrasena.Location = new System.Drawing.Point(194, 308);
            this.TexBox_ConfiContrasena.Name = "TexBox_ConfiContrasena";
            this.TexBox_ConfiContrasena.Size = new System.Drawing.Size(295, 26);
            this.TexBox_ConfiContrasena.TabIndex = 37;
            this.TexBox_ConfiContrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TexBox_ConfiContrasena.Validar = true;
            this.TexBox_ConfiContrasena.ValidarNumeros = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(116, 89);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            // 
            // Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(805, 472);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.TexBox_id);
            this.Controls.Add(this.TexBox_Nombre);
            this.Controls.Add(this.TexBox_Cuenta);
            this.Controls.Add(this.TexBox_Contrasena);
            this.Controls.Add(this.TexBox_ConfiContrasena);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(821, 511);
            this.MinimumSize = new System.Drawing.Size(821, 511);
            this.Name = "Registrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private LibreriaDLL.ErrorTexBox TexBox_ConfiContrasena;
        private LibreriaDLL.ErrorTexBox TexBox_Contrasena;
        private LibreriaDLL.ErrorTexBox TexBox_Cuenta;
        private LibreriaDLL.ErrorTexBox TexBox_Nombre;
        public System.Windows.Forms.ErrorProvider errorProvider1;
        private LibreriaDLL.ErrorTexBox TexBox_id;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}