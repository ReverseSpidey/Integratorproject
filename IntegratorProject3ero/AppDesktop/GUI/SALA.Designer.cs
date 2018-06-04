namespace AppDesktop.GUI
{
    partial class SALA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SALA));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnGuardarTipo = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnModificarTipo = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnEliminarTipo = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnLimpiarTipo = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dgvTipo = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txtTipoSala = new System.Windows.Forms.TextBox();
            this.btnConsultarTipo = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(518, 347);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(510, 321);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sala";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnGuardarTipo);
            this.tabPage2.Controls.Add(this.btnModificarTipo);
            this.tabPage2.Controls.Add(this.btnEliminarTipo);
            this.tabPage2.Controls.Add(this.btnLimpiarTipo);
            this.tabPage2.Controls.Add(this.dgvTipo);
            this.tabPage2.Controls.Add(this.txtTipoSala);
            this.tabPage2.Controls.Add(this.btnConsultarTipo);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(510, 321);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tipo sala";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnGuardarTipo
            // 
            this.btnGuardarTipo.ActiveBorderThickness = 1;
            this.btnGuardarTipo.ActiveCornerRadius = 20;
            this.btnGuardarTipo.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnGuardarTipo.ActiveForecolor = System.Drawing.Color.White;
            this.btnGuardarTipo.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnGuardarTipo.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardarTipo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardarTipo.BackgroundImage")));
            this.btnGuardarTipo.ButtonText = "Guardar";
            this.btnGuardarTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarTipo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarTipo.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnGuardarTipo.IdleBorderThickness = 1;
            this.btnGuardarTipo.IdleCornerRadius = 20;
            this.btnGuardarTipo.IdleFillColor = System.Drawing.Color.White;
            this.btnGuardarTipo.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnGuardarTipo.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnGuardarTipo.Location = new System.Drawing.Point(34, 264);
            this.btnGuardarTipo.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuardarTipo.Name = "btnGuardarTipo";
            this.btnGuardarTipo.Size = new System.Drawing.Size(88, 34);
            this.btnGuardarTipo.TabIndex = 6;
            this.btnGuardarTipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnModificarTipo
            // 
            this.btnModificarTipo.ActiveBorderThickness = 1;
            this.btnModificarTipo.ActiveCornerRadius = 20;
            this.btnModificarTipo.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnModificarTipo.ActiveForecolor = System.Drawing.Color.White;
            this.btnModificarTipo.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnModificarTipo.BackColor = System.Drawing.Color.Transparent;
            this.btnModificarTipo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificarTipo.BackgroundImage")));
            this.btnModificarTipo.ButtonText = "Modificar";
            this.btnModificarTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarTipo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarTipo.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnModificarTipo.IdleBorderThickness = 1;
            this.btnModificarTipo.IdleCornerRadius = 20;
            this.btnModificarTipo.IdleFillColor = System.Drawing.Color.White;
            this.btnModificarTipo.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnModificarTipo.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnModificarTipo.Location = new System.Drawing.Point(152, 264);
            this.btnModificarTipo.Margin = new System.Windows.Forms.Padding(5);
            this.btnModificarTipo.Name = "btnModificarTipo";
            this.btnModificarTipo.Size = new System.Drawing.Size(88, 34);
            this.btnModificarTipo.TabIndex = 5;
            this.btnModificarTipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEliminarTipo
            // 
            this.btnEliminarTipo.ActiveBorderThickness = 1;
            this.btnEliminarTipo.ActiveCornerRadius = 20;
            this.btnEliminarTipo.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnEliminarTipo.ActiveForecolor = System.Drawing.Color.White;
            this.btnEliminarTipo.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnEliminarTipo.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarTipo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminarTipo.BackgroundImage")));
            this.btnEliminarTipo.ButtonText = "Eliminar";
            this.btnEliminarTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarTipo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTipo.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnEliminarTipo.IdleBorderThickness = 1;
            this.btnEliminarTipo.IdleCornerRadius = 20;
            this.btnEliminarTipo.IdleFillColor = System.Drawing.Color.White;
            this.btnEliminarTipo.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnEliminarTipo.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnEliminarTipo.Location = new System.Drawing.Point(266, 264);
            this.btnEliminarTipo.Margin = new System.Windows.Forms.Padding(5);
            this.btnEliminarTipo.Name = "btnEliminarTipo";
            this.btnEliminarTipo.Size = new System.Drawing.Size(88, 34);
            this.btnEliminarTipo.TabIndex = 4;
            this.btnEliminarTipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLimpiarTipo
            // 
            this.btnLimpiarTipo.ActiveBorderThickness = 1;
            this.btnLimpiarTipo.ActiveCornerRadius = 20;
            this.btnLimpiarTipo.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnLimpiarTipo.ActiveForecolor = System.Drawing.Color.White;
            this.btnLimpiarTipo.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnLimpiarTipo.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiarTipo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiarTipo.BackgroundImage")));
            this.btnLimpiarTipo.ButtonText = "Limpiar";
            this.btnLimpiarTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarTipo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarTipo.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnLimpiarTipo.IdleBorderThickness = 1;
            this.btnLimpiarTipo.IdleCornerRadius = 20;
            this.btnLimpiarTipo.IdleFillColor = System.Drawing.Color.White;
            this.btnLimpiarTipo.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnLimpiarTipo.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnLimpiarTipo.Location = new System.Drawing.Point(381, 264);
            this.btnLimpiarTipo.Margin = new System.Windows.Forms.Padding(5);
            this.btnLimpiarTipo.Name = "btnLimpiarTipo";
            this.btnLimpiarTipo.Size = new System.Drawing.Size(88, 34);
            this.btnLimpiarTipo.TabIndex = 3;
            this.btnLimpiarTipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvTipo
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvTipo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTipo.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvTipo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTipo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTipo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipo.DoubleBuffered = true;
            this.dgvTipo.EnableHeadersVisualStyles = false;
            this.dgvTipo.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgvTipo.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgvTipo.Location = new System.Drawing.Point(68, 100);
            this.dgvTipo.Name = "dgvTipo";
            this.dgvTipo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTipo.Size = new System.Drawing.Size(365, 145);
            this.dgvTipo.TabIndex = 2;
            // 
            // txtTipoSala
            // 
            this.txtTipoSala.Location = new System.Drawing.Point(134, 58);
            this.txtTipoSala.Name = "txtTipoSala";
            this.txtTipoSala.Size = new System.Drawing.Size(187, 20);
            this.txtTipoSala.TabIndex = 1;
            // 
            // btnConsultarTipo
            // 
            this.btnConsultarTipo.ActiveBorderThickness = 1;
            this.btnConsultarTipo.ActiveCornerRadius = 20;
            this.btnConsultarTipo.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnConsultarTipo.ActiveForecolor = System.Drawing.Color.White;
            this.btnConsultarTipo.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnConsultarTipo.BackColor = System.Drawing.Color.Transparent;
            this.btnConsultarTipo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConsultarTipo.BackgroundImage")));
            this.btnConsultarTipo.ButtonText = "Consultar";
            this.btnConsultarTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarTipo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarTipo.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnConsultarTipo.IdleBorderThickness = 1;
            this.btnConsultarTipo.IdleCornerRadius = 20;
            this.btnConsultarTipo.IdleFillColor = System.Drawing.Color.White;
            this.btnConsultarTipo.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnConsultarTipo.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnConsultarTipo.Location = new System.Drawing.Point(329, 50);
            this.btnConsultarTipo.Margin = new System.Windows.Forms.Padding(5);
            this.btnConsultarTipo.Name = "btnConsultarTipo";
            this.btnConsultarTipo.Size = new System.Drawing.Size(88, 34);
            this.btnConsultarTipo.TabIndex = 0;
            this.btnConsultarTipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SALA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(556, 371);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SALA";
            this.Text = "SALA";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnConsultarTipo;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvTipo;
        private System.Windows.Forms.TextBox txtTipoSala;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGuardarTipo;
        private Bunifu.Framework.UI.BunifuThinButton2 btnModificarTipo;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEliminarTipo;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLimpiarTipo;
    }
}