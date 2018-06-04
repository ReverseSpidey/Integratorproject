namespace AppDesktop.GUI
{
    partial class MenuAdministrador
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
            this.pan = new System.Windows.Forms.Panel();
            this.panellfet = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelcine = new System.Windows.Forms.Panel();
            this.btnDatos = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnSalas = new System.Windows.Forms.Button();
            this.btnPelicula = new System.Windows.Forms.Button();
            this.pan.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan
            // 
            this.pan.Controls.Add(this.panellfet);
            this.pan.Controls.Add(this.btnDatos);
            this.pan.Controls.Add(this.btnUsuarios);
            this.pan.Controls.Add(this.btnSalas);
            this.pan.Controls.Add(this.btnPelicula);
            this.pan.Controls.Add(this.panel3);
            this.pan.Dock = System.Windows.Forms.DockStyle.Left;
            this.pan.Location = new System.Drawing.Point(0, 0);
            this.pan.Name = "pan";
            this.pan.Size = new System.Drawing.Size(133, 657);
            this.pan.TabIndex = 0;
            // 
            // panellfet
            // 
            this.panellfet.BackColor = System.Drawing.Color.Yellow;
            this.panellfet.Location = new System.Drawing.Point(123, 117);
            this.panellfet.Name = "panellfet";
            this.panellfet.Size = new System.Drawing.Size(10, 74);
            this.panellfet.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Yellow;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(133, 67);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, -34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 117);
            this.label1.TabIndex = 0;
            this.label1.Text = "m";
            // 
            // panelcine
            // 
            this.panelcine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelcine.Location = new System.Drawing.Point(139, 65);
            this.panelcine.Name = "panelcine";
            this.panelcine.Size = new System.Drawing.Size(897, 592);
            this.panelcine.TabIndex = 0;
            this.panelcine.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelcine_MouseMove);
            // 
            // btnDatos
            // 
            this.btnDatos.FlatAppearance.BorderSize = 0;
            this.btnDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDatos.ForeColor = System.Drawing.Color.White;
            this.btnDatos.Image = global::AppDesktop.Properties.Resources.Ciudades;
            this.btnDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatos.Location = new System.Drawing.Point(0, 505);
            this.btnDatos.Name = "btnDatos";
            this.btnDatos.Size = new System.Drawing.Size(133, 71);
            this.btnDatos.TabIndex = 4;
            this.btnDatos.Text = "Datos";
            this.btnDatos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDatos.UseVisualStyleBackColor = true;
            this.btnDatos.Click += new System.EventHandler(this.btnDatos_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Image = global::AppDesktop.Properties.Resources.Empleado;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(3, 370);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(133, 71);
            this.btnUsuarios.TabIndex = 3;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnSalas
            // 
            this.btnSalas.FlatAppearance.BorderSize = 0;
            this.btnSalas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSalas.ForeColor = System.Drawing.Color.White;
            this.btnSalas.Image = global::AppDesktop.Properties.Resources.Sala;
            this.btnSalas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalas.Location = new System.Drawing.Point(3, 246);
            this.btnSalas.Name = "btnSalas";
            this.btnSalas.Size = new System.Drawing.Size(133, 71);
            this.btnSalas.TabIndex = 2;
            this.btnSalas.Text = "Salas";
            this.btnSalas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalas.UseVisualStyleBackColor = true;
            this.btnSalas.Click += new System.EventHandler(this.btnSalas_Click);
            // 
            // btnPelicula
            // 
            this.btnPelicula.FlatAppearance.BorderSize = 0;
            this.btnPelicula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPelicula.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPelicula.ForeColor = System.Drawing.Color.White;
            this.btnPelicula.Image = global::AppDesktop.Properties.Resources.Flash;
            this.btnPelicula.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPelicula.Location = new System.Drawing.Point(0, 120);
            this.btnPelicula.Name = "btnPelicula";
            this.btnPelicula.Size = new System.Drawing.Size(133, 71);
            this.btnPelicula.TabIndex = 1;
            this.btnPelicula.Text = "Peliculas";
            this.btnPelicula.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPelicula.UseVisualStyleBackColor = true;
            this.btnPelicula.Click += new System.EventHandler(this.button1_Click);
            // 
            // MenuAdministrador
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1039, 657);
            this.Controls.Add(this.panelcine);
            this.Controls.Add(this.pan);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuAdministrador";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MenuAdministrador_MouseMove);
            this.pan.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan;
        private System.Windows.Forms.Button btnPelicula;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDatos;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnSalas;
        private System.Windows.Forms.Panel panelcine;
        private System.Windows.Forms.Panel panellfet;
    }
}