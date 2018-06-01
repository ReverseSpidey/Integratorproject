namespace AppDesktop
{
    partial class frmApp
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
            this.ppnlHeader = new System.Windows.Forms.Panel();
            this.lblBoleto = new System.Windows.Forms.Label();
            this.lblReserva = new System.Windows.Forms.Label();
            this.lblSesión = new System.Windows.Forms.Label();
            this.picTicktekt = new System.Windows.Forms.PictureBox();
            this.picReserva = new System.Windows.Forms.PictureBox();
            this.picUsuario = new System.Windows.Forms.PictureBox();
            this.pnlName = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pnlCerrar = new System.Windows.Forms.Panel();
            this.LBLmINIMI = new System.Windows.Forms.Label();
            this.lblCerrar = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnl_Contenedor = new System.Windows.Forms.Panel();
            this.ppnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTicktekt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReserva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
            this.pnlName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.pnlCerrar.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // ppnlHeader
            // 
            this.ppnlHeader.BackColor = System.Drawing.Color.Turquoise;
            this.ppnlHeader.Controls.Add(this.lblBoleto);
            this.ppnlHeader.Controls.Add(this.lblReserva);
            this.ppnlHeader.Controls.Add(this.lblSesión);
            this.ppnlHeader.Controls.Add(this.picTicktekt);
            this.ppnlHeader.Controls.Add(this.picReserva);
            this.ppnlHeader.Controls.Add(this.picUsuario);
            this.ppnlHeader.Controls.Add(this.pnlName);
            this.ppnlHeader.Controls.Add(this.pnlCerrar);
            this.ppnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.ppnlHeader.Location = new System.Drawing.Point(0, 0);
            this.ppnlHeader.Name = "ppnlHeader";
            this.ppnlHeader.Size = new System.Drawing.Size(875, 104);
            this.ppnlHeader.TabIndex = 0;
            // 
            // lblBoleto
            // 
            this.lblBoleto.AutoSize = true;
            this.lblBoleto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBoleto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoleto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblBoleto.Location = new System.Drawing.Point(223, 26);
            this.lblBoleto.Name = "lblBoleto";
            this.lblBoleto.Size = new System.Drawing.Size(114, 17);
            this.lblBoleto.TabIndex = 7;
            this.lblBoleto.Text = "Comprar boleto";
            this.lblBoleto.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblBoleto.MouseLeave += new System.EventHandler(this.lblBoleto_MouseLeave);
            this.lblBoleto.MouseHover += new System.EventHandler(this.lblBoleto_MouseHover);
            this.lblBoleto.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblBoleto_MouseMove);
            // 
            // lblReserva
            // 
            this.lblReserva.AutoSize = true;
            this.lblReserva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblReserva.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReserva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblReserva.Location = new System.Drawing.Point(385, 26);
            this.lblReserva.Name = "lblReserva";
            this.lblReserva.Size = new System.Drawing.Size(84, 17);
            this.lblReserva.TabIndex = 6;
            this.lblReserva.Text = "Ver reservas";
            this.lblReserva.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblReserva.MouseLeave += new System.EventHandler(this.lblReserva_MouseLeave);
            this.lblReserva.MouseHover += new System.EventHandler(this.lblReserva_MouseHover);
            this.lblReserva.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblReserva_MouseMove);
            // 
            // lblSesión
            // 
            this.lblSesión.AutoSize = true;
            this.lblSesión.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSesión.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSesión.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblSesión.Location = new System.Drawing.Point(528, 26);
            this.lblSesión.Name = "lblSesión";
            this.lblSesión.Size = new System.Drawing.Size(103, 17);
            this.lblSesión.TabIndex = 5;
            this.lblSesión.Text = "Modificar perfil";
            this.lblSesión.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblSesión.Click += new System.EventHandler(this.lblSesión_Click);
            this.lblSesión.MouseLeave += new System.EventHandler(this.lblSesión_MouseLeave);
            this.lblSesión.MouseHover += new System.EventHandler(this.lblSesión_MouseHover);
            this.lblSesión.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblSesión_MouseMove);
            // 
            // picTicktekt
            // 
            this.picTicktekt.Image = global::AppDesktop.Properties.Resources.Ticket2;
            this.picTicktekt.Location = new System.Drawing.Point(250, 46);
            this.picTicktekt.Name = "picTicktekt";
            this.picTicktekt.Size = new System.Drawing.Size(55, 52);
            this.picTicktekt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTicktekt.TabIndex = 5;
            this.picTicktekt.TabStop = false;
            this.picTicktekt.MouseLeave += new System.EventHandler(this.picTicktekt_MouseLeave);
            this.picTicktekt.MouseHover += new System.EventHandler(this.picTicktekt_MouseHover);
            this.picTicktekt.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picTicktekt_MouseMove);
            // 
            // picReserva
            // 
            this.picReserva.Image = global::AppDesktop.Properties.Resources.Detective_50px;
            this.picReserva.Location = new System.Drawing.Point(400, 46);
            this.picReserva.Name = "picReserva";
            this.picReserva.Size = new System.Drawing.Size(55, 52);
            this.picReserva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picReserva.TabIndex = 4;
            this.picReserva.TabStop = false;
            this.picReserva.MouseLeave += new System.EventHandler(this.picReserva_MouseLeave);
            this.picReserva.MouseHover += new System.EventHandler(this.picReserva_MouseHover);
            this.picReserva.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picReserva_MouseMove);
            // 
            // picUsuario
            // 
            this.picUsuario.Image = global::AppDesktop.Properties.Resources.usuario;
            this.picUsuario.Location = new System.Drawing.Point(597, 52);
            this.picUsuario.Name = "picUsuario";
            this.picUsuario.Size = new System.Drawing.Size(55, 52);
            this.picUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUsuario.TabIndex = 3;
            this.picUsuario.TabStop = false;
            this.picUsuario.MouseLeave += new System.EventHandler(this.picUsuario_MouseLeave);
            this.picUsuario.MouseHover += new System.EventHandler(this.picUsuario_MouseHover);
            this.picUsuario.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picUsuario_MouseMove);
            // 
            // pnlName
            // 
            this.pnlName.Controls.Add(this.lblTitle);
            this.pnlName.Controls.Add(this.pictureBox5);
            this.pnlName.Location = new System.Drawing.Point(12, 6);
            this.pnlName.Name = "pnlName";
            this.pnlName.Size = new System.Drawing.Size(115, 23);
            this.pnlName.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblTitle.Location = new System.Drawing.Point(27, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(89, 16);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "FRIENDWARE";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox5.Image = global::AppDesktop.Properties.Resources.logo5;
            this.pictureBox5.Location = new System.Drawing.Point(0, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(27, 23);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // pnlCerrar
            // 
            this.pnlCerrar.Controls.Add(this.LBLmINIMI);
            this.pnlCerrar.Controls.Add(this.lblCerrar);
            this.pnlCerrar.Location = new System.Drawing.Point(713, 3);
            this.pnlCerrar.Name = "pnlCerrar";
            this.pnlCerrar.Size = new System.Drawing.Size(162, 26);
            this.pnlCerrar.TabIndex = 2;
            // 
            // LBLmINIMI
            // 
            this.LBLmINIMI.AutoSize = true;
            this.LBLmINIMI.Dock = System.Windows.Forms.DockStyle.Right;
            this.LBLmINIMI.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLmINIMI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LBLmINIMI.Location = new System.Drawing.Point(119, 0);
            this.LBLmINIMI.Name = "LBLmINIMI";
            this.LBLmINIMI.Size = new System.Drawing.Size(20, 23);
            this.LBLmINIMI.TabIndex = 4;
            this.LBLmINIMI.Text = "_";
            this.LBLmINIMI.Click += new System.EventHandler(this.LBLmINIMI_Click);
            this.LBLmINIMI.MouseLeave += new System.EventHandler(this.LBLmINIMI_MouseLeave);
            this.LBLmINIMI.MouseHover += new System.EventHandler(this.LBLmINIMI_MouseHover);
            this.LBLmINIMI.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LBLmINIMI_MouseMove);
            // 
            // lblCerrar
            // 
            this.lblCerrar.AutoSize = true;
            this.lblCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCerrar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblCerrar.Location = new System.Drawing.Point(139, 0);
            this.lblCerrar.Name = "lblCerrar";
            this.lblCerrar.Size = new System.Drawing.Size(23, 23);
            this.lblCerrar.TabIndex = 3;
            this.lblCerrar.Text = "X";
            this.lblCerrar.Click += new System.EventHandler(this.lblCerrar_Click);
            this.lblCerrar.MouseLeave += new System.EventHandler(this.lblCerrar_MouseLeave);
            this.lblCerrar.MouseHover += new System.EventHandler(this.lblCerrar_MouseHover);
            this.lblCerrar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblCerrar_MouseMove);
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.MediumTurquoise;
            this.pnlBody.Controls.Add(this.pnl_Contenedor);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlBody.Location = new System.Drawing.Point(0, 104);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(875, 383);
            this.pnlBody.TabIndex = 1;
            // 
            // pnl_Contenedor
            // 
            this.pnl_Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Contenedor.Location = new System.Drawing.Point(0, 0);
            this.pnl_Contenedor.Name = "pnl_Contenedor";
            this.pnl_Contenedor.Size = new System.Drawing.Size(875, 383);
            this.pnl_Contenedor.TabIndex = 0;
            // 
            // frmApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 487);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.ppnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmApp";
            this.Text = "App";
            this.ppnlHeader.ResumeLayout(false);
            this.ppnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTicktekt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReserva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).EndInit();
            this.pnlName.ResumeLayout(false);
            this.pnlName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.pnlCerrar.ResumeLayout(false);
            this.pnlCerrar.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ppnlHeader;
        private System.Windows.Forms.Panel pnlBody;
        private Imagenes.UserControl1 UcInicio;
        private Imagenes.UserControl1 ucConfiguracion;
        private System.Windows.Forms.Panel pnlCerrar;
        private System.Windows.Forms.Label LBLmINIMI;
        private System.Windows.Forms.Label lblCerrar;
        private Imagenes.UserControl1 ucUser;
        private System.Windows.Forms.Label lblSesión;
        private System.Windows.Forms.Panel pnlName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel pnl_Contenedor;
        private System.Windows.Forms.PictureBox picUsuario;
        private System.Windows.Forms.PictureBox picTicktekt;
        private System.Windows.Forms.PictureBox picReserva;
        private System.Windows.Forms.Label lblBoleto;
        private System.Windows.Forms.Label lblReserva;
    }
}

