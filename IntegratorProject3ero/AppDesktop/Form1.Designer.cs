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
            this.pnlCerrar = new System.Windows.Forms.Panel();
            this.lblSesión = new System.Windows.Forms.Label();
            this.ucUser = new Imagenes.UserControl1();
            this.LBLmINIMI = new System.Windows.Forms.Label();
            this.lblCerrar = new System.Windows.Forms.Label();
            this.ucConfiguracion = new Imagenes.UserControl1();
            this.UcInicio = new Imagenes.UserControl1();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.ppnlHeader.SuspendLayout();
            this.pnlCerrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ucUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucConfiguracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UcInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // ppnlHeader
            // 
            this.ppnlHeader.BackColor = System.Drawing.Color.Turquoise;
            this.ppnlHeader.Controls.Add(this.pnlCerrar);
            this.ppnlHeader.Controls.Add(this.ucConfiguracion);
            this.ppnlHeader.Controls.Add(this.UcInicio);
            this.ppnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.ppnlHeader.Location = new System.Drawing.Point(0, 0);
            this.ppnlHeader.Name = "ppnlHeader";
            this.ppnlHeader.Size = new System.Drawing.Size(875, 104);
            this.ppnlHeader.TabIndex = 0;
            // 
            // pnlCerrar
            // 
            this.pnlCerrar.Controls.Add(this.lblSesión);
            this.pnlCerrar.Controls.Add(this.ucUser);
            this.pnlCerrar.Controls.Add(this.LBLmINIMI);
            this.pnlCerrar.Controls.Add(this.lblCerrar);
            this.pnlCerrar.Location = new System.Drawing.Point(713, 3);
            this.pnlCerrar.Name = "pnlCerrar";
            this.pnlCerrar.Size = new System.Drawing.Size(162, 26);
            this.pnlCerrar.TabIndex = 2;
            // 
            // lblSesión
            // 
            this.lblSesión.AutoSize = true;
            this.lblSesión.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSesión.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblSesión.Location = new System.Drawing.Point(31, 9);
            this.lblSesión.Name = "lblSesión";
            this.lblSesión.Size = new System.Drawing.Size(89, 17);
            this.lblSesión.TabIndex = 5;
            this.lblSesión.Text = "Iniciar Sesión";
            this.lblSesión.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblSesión.MouseLeave += new System.EventHandler(this.lblSesión_MouseLeave);
            this.lblSesión.MouseHover += new System.EventHandler(this.lblSesión_MouseHover);
            this.lblSesión.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblSesión_MouseMove);
            // 
            // ucUser
            // 
            this.ucUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.ucUser.Image = global::AppDesktop.Properties.Resources.UserNormal;
            this.ucUser.Location = new System.Drawing.Point(0, 0);
            this.ucUser.Name = "ucUser";
            this.ucUser.Size = new System.Drawing.Size(36, 26);
            this.ucUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ucUser.TabIndex = 3;
            this.ucUser.TabStop = false;
            this.ucUser.MouseLeave += new System.EventHandler(this.userControl11_MouseLeave);
            this.ucUser.MouseHover += new System.EventHandler(this.userControl11_MouseHover);
            this.ucUser.MouseMove += new System.Windows.Forms.MouseEventHandler(this.userControl11_MouseMove);
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
            // ucConfiguracion
            // 
            this.ucConfiguracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucConfiguracion.Image = global::AppDesktop.Properties.Resources.SettingsNormal;
            this.ucConfiguracion.Location = new System.Drawing.Point(820, 48);
            this.ucConfiguracion.Name = "ucConfiguracion";
            this.ucConfiguracion.Size = new System.Drawing.Size(43, 41);
            this.ucConfiguracion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ucConfiguracion.TabIndex = 1;
            this.ucConfiguracion.TabStop = false;
            this.ucConfiguracion.MouseLeave += new System.EventHandler(this.ucConfiguracion_MouseLeave);
            this.ucConfiguracion.MouseHover += new System.EventHandler(this.ucConfiguracion_MouseHover);
            this.ucConfiguracion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ucConfiguracion_MouseMove);
            // 
            // UcInicio
            // 
            this.UcInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UcInicio.Image = global::AppDesktop.Properties.Resources.HomeNormal;
            this.UcInicio.Location = new System.Drawing.Point(12, 48);
            this.UcInicio.Name = "UcInicio";
            this.UcInicio.Size = new System.Drawing.Size(43, 41);
            this.UcInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UcInicio.TabIndex = 0;
            this.UcInicio.TabStop = false;
            this.UcInicio.MouseLeave += new System.EventHandler(this.UcInicio_MouseLeave);
            this.UcInicio.MouseHover += new System.EventHandler(this.UcInicio_MouseHover);
            this.UcInicio.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UcInicio_MouseMove);
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.MediumTurquoise;
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlBody.Location = new System.Drawing.Point(0, 104);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(875, 383);
            this.pnlBody.TabIndex = 1;
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
            this.pnlCerrar.ResumeLayout(false);
            this.pnlCerrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ucUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucConfiguracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UcInicio)).EndInit();
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
    }
}

