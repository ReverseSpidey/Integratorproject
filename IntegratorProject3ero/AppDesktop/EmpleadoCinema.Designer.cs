namespace AppDesktop
{
    partial class EmpleadoCinema
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelcine = new System.Windows.Forms.Panel();
            this.panellfet = new System.Windows.Forms.Panel();
            this.layout_Contenido = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlCompra = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.btnPelicula = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.layout_Contenido.SuspendLayout();
            this.pnlCompra.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(10)))), ((int)(((byte)(18)))));
            this.panel1.Controls.Add(this.layout_Contenido);
            this.panel1.Controls.Add(this.panellfet);
            this.panel1.Controls.Add(this.btnPelicula);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 657);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(72)))), ((int)(((byte)(21)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(171, 67);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, -34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 117);
            this.label1.TabIndex = 0;
            this.label1.Text = "m";
            // 
            // panelcine
            // 
            this.panelcine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(10)))), ((int)(((byte)(18)))));
            this.panelcine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelcine.Location = new System.Drawing.Point(144, 67);
            this.panelcine.Name = "panelcine";
            this.panelcine.Size = new System.Drawing.Size(902, 590);
            this.panelcine.TabIndex = 1;
            // 
            // panellfet
            // 
            this.panellfet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(72)))), ((int)(((byte)(21)))));
            this.panellfet.Location = new System.Drawing.Point(132, 123);
            this.panellfet.Name = "panellfet";
            this.panellfet.Size = new System.Drawing.Size(10, 74);
            this.panellfet.TabIndex = 4;
            // 
            // layout_Contenido
            // 
            this.layout_Contenido.Controls.Add(this.pnlCompra);
            this.layout_Contenido.Controls.Add(this.button10);
            this.layout_Contenido.Location = new System.Drawing.Point(3, 196);
            this.layout_Contenido.Name = "layout_Contenido";
            this.layout_Contenido.Size = new System.Drawing.Size(158, 458);
            this.layout_Contenido.TabIndex = 1;
            // 
            // pnlCompra
            // 
            this.pnlCompra.Controls.Add(this.button8);
            this.pnlCompra.Controls.Add(this.button9);
            this.pnlCompra.Location = new System.Drawing.Point(3, 3);
            this.pnlCompra.Name = "pnlCompra";
            this.pnlCompra.Size = new System.Drawing.Size(136, 76);
            this.pnlCompra.TabIndex = 1;
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(-3, 36);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(127, 30);
            this.button8.TabIndex = 1;
            this.button8.Text = "Realizadas";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(0, 0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(127, 30);
            this.button9.TabIndex = 0;
            this.button9.Text = "Nueva";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Image = global::AppDesktop.Properties.Resources.Empleado;
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Location = new System.Drawing.Point(3, 85);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(133, 71);
            this.button10.TabIndex = 3;
            this.button10.Text = "Usuarios";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // btnPelicula
            // 
            this.btnPelicula.FlatAppearance.BorderSize = 0;
            this.btnPelicula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPelicula.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.btnPelicula.ForeColor = System.Drawing.Color.White;
            this.btnPelicula.Image = global::AppDesktop.Properties.Resources.ticket_32;
            this.btnPelicula.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPelicula.Location = new System.Drawing.Point(3, 123);
            this.btnPelicula.Name = "btnPelicula";
            this.btnPelicula.Size = new System.Drawing.Size(139, 71);
            this.btnPelicula.TabIndex = 3;
            this.btnPelicula.Text = "Ventas de boleto";
            this.btnPelicula.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPelicula.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPelicula.UseVisualStyleBackColor = true;
            this.btnPelicula.Click += new System.EventHandler(this.btnPelicula_Click);
            // 
            // EmpleadoCinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(10)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1039, 657);
            this.Controls.Add(this.panelcine);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmpleadoCinema";
            this.Text = "EmpleadoCinema";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.layout_Contenido.ResumeLayout(false);
            this.pnlCompra.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelcine;
        private System.Windows.Forms.Button btnPelicula;
        private System.Windows.Forms.Panel panellfet;
        private System.Windows.Forms.FlowLayoutPanel layout_Contenido;
        private System.Windows.Forms.Panel pnlCompra;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
    }
}