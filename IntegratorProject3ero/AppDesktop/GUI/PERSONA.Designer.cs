﻿namespace AppDesktop.GUI
{
    partial class frm_PERSONA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_PERSONA));
            this.picCerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mxtNombre = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCancelar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pciMinimizar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pciMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // picCerrar
            // 
            this.picCerrar.Image = global::AppDesktop.Properties.Resources.icon_cerrar2;
            this.picCerrar.Location = new System.Drawing.Point(773, 12);
            this.picCerrar.Name = "picCerrar";
            this.picCerrar.Size = new System.Drawing.Size(15, 15);
            this.picCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCerrar.TabIndex = 9;
            this.picCerrar.TabStop = false;
            this.picCerrar.Click += new System.EventHandler(this.picCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(98, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "NOMBRE(S)";
            // 
            // mxtNombre
            // 
            this.mxtNombre.Location = new System.Drawing.Point(217, 100);
            this.mxtNombre.Mask = "??????????????????????????????????????????????????????????????";
            this.mxtNombre.Name = "mxtNombre";
            this.mxtNombre.PromptChar = ' ';
            this.mxtNombre.Size = new System.Drawing.Size(212, 20);
            this.mxtNombre.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(97, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "DIRECCIÓN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(69, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "TELÉFONO CASA";
            // 
            // btnGuardar
            // 
            this.btnGuardar.ActiveBorderThickness = 1;
            this.btnGuardar.ActiveCornerRadius = 20;
            this.btnGuardar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnGuardar.ActiveForecolor = System.Drawing.Color.White;
            this.btnGuardar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.ButtonText = "Guardar";
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnGuardar.IdleBorderThickness = 1;
            this.btnGuardar.IdleCornerRadius = 20;
            this.btnGuardar.IdleFillColor = System.Drawing.Color.White;
            this.btnGuardar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnGuardar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnGuardar.Location = new System.Drawing.Point(553, 458);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(83, 41);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(46, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "TELÉFONO OFICINA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(593, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 21);
            this.label5.TabIndex = 19;
            this.label5.Text = "EMAIL";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(560, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 21);
            this.label6.TabIndex = 21;
            this.label6.Text = "CONTRASEÑA";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(512, 214);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 20);
            this.textBox1.TabIndex = 22;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(512, 271);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(212, 20);
            this.textBox2.TabIndex = 23;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(512, 329);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(212, 20);
            this.textBox3.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(508, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(226, 21);
            this.label7.TabIndex = 25;
            this.label7.Text = "CONFIRMAR CONTRASEÑA";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(217, 280);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(212, 20);
            this.textBox4.TabIndex = 26;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(217, 340);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(212, 20);
            this.textBox5.TabIndex = 27;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(217, 400);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(212, 20);
            this.textBox6.TabIndex = 28;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(217, 160);
            this.maskedTextBox1.Mask = "??????????????????????????????????????????????????????????????";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.PromptChar = ' ';
            this.maskedTextBox1.Size = new System.Drawing.Size(212, 20);
            this.maskedTextBox1.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(98, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 21);
            this.label8.TabIndex = 29;
            this.label8.Text = "A.PATERNO";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(217, 220);
            this.maskedTextBox2.Mask = "??????????????????????????????????????????????????????????????";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.PromptChar = ' ';
            this.maskedTextBox2.Size = new System.Drawing.Size(212, 20);
            this.maskedTextBox2.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(89, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 21);
            this.label9.TabIndex = 31;
            this.label9.Text = "A.MATERNO";
            // 
            // btnCancelar
            // 
            this.btnCancelar.ActiveBorderThickness = 1;
            this.btnCancelar.ActiveCornerRadius = 20;
            this.btnCancelar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnCancelar.ActiveForecolor = System.Drawing.Color.White;
            this.btnCancelar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.ButtonText = "Cancelar";
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnCancelar.IdleBorderThickness = 1;
            this.btnCancelar.IdleCornerRadius = 20;
            this.btnCancelar.IdleFillColor = System.Drawing.Color.White;
            this.btnCancelar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnCancelar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnCancelar.Location = new System.Drawing.Point(660, 458);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 41);
            this.btnCancelar.TabIndex = 33;
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(512, 143);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(212, 20);
            this.textBox7.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(583, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 21);
            this.label10.TabIndex = 34;
            this.label10.Text = "USUARIO";
            // 
            // pciMinimizar
            // 
            this.pciMinimizar.Image = global::AppDesktop.Properties.Resources.icon_minimizar;
            this.pciMinimizar.Location = new System.Drawing.Point(752, 12);
            this.pciMinimizar.Name = "pciMinimizar";
            this.pciMinimizar.Size = new System.Drawing.Size(15, 15);
            this.pciMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pciMinimizar.TabIndex = 36;
            this.pciMinimizar.TabStop = false;
            this.pciMinimizar.Click += new System.EventHandler(this.pciMinimizar_Click);
            // 
            // frm_PERSONA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(817, 530);
            this.Controls.Add(this.pciMinimizar);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mxtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picCerrar);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_PERSONA";
            this.Text = "PERSONA";
            this.Load += new System.EventHandler(this.PERSONA_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PERSONA_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pciMinimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mxtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGuardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancelar;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pciMinimizar;
    }
}