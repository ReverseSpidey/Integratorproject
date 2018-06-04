namespace AppDesktop.GUI
{
    partial class Datos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Datos));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.dgvEstado = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnGuardarEstado = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnModificarEstado = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnEliminarEstado = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnLimpiarEstado = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnConsultarEstado = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstado)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(518, 347);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvEstado);
            this.tabPage1.Controls.Add(this.txtEstado);
            this.tabPage1.Controls.Add(this.btnGuardarEstado);
            this.tabPage1.Controls.Add(this.btnModificarEstado);
            this.tabPage1.Controls.Add(this.btnEliminarEstado);
            this.tabPage1.Controls.Add(this.btnLimpiarEstado);
            this.tabPage1.Controls.Add(this.btnConsultarEstado);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(510, 321);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Estado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(510, 321);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ciudad";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(510, 321);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sucursal";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(134, 58);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(187, 20);
            this.txtEstado.TabIndex = 5;
            // 
            // dgvEstado
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvEstado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEstado.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvEstado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEstado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEstado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstado.DoubleBuffered = true;
            this.dgvEstado.EnableHeadersVisualStyles = false;
            this.dgvEstado.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgvEstado.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgvEstado.Location = new System.Drawing.Point(68, 100);
            this.dgvEstado.Name = "dgvEstado";
            this.dgvEstado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEstado.Size = new System.Drawing.Size(365, 145);
            this.dgvEstado.TabIndex = 6;
            // 
            // btnGuardarEstado
            // 
            this.btnGuardarEstado.ActiveBorderThickness = 1;
            this.btnGuardarEstado.ActiveCornerRadius = 20;
            this.btnGuardarEstado.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnGuardarEstado.ActiveForecolor = System.Drawing.Color.White;
            this.btnGuardarEstado.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnGuardarEstado.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardarEstado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardarEstado.BackgroundImage")));
            this.btnGuardarEstado.ButtonText = "Guardar";
            this.btnGuardarEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarEstado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarEstado.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnGuardarEstado.IdleBorderThickness = 1;
            this.btnGuardarEstado.IdleCornerRadius = 20;
            this.btnGuardarEstado.IdleFillColor = System.Drawing.Color.White;
            this.btnGuardarEstado.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnGuardarEstado.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnGuardarEstado.Location = new System.Drawing.Point(34, 264);
            this.btnGuardarEstado.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuardarEstado.Name = "btnGuardarEstado";
            this.btnGuardarEstado.Size = new System.Drawing.Size(88, 34);
            this.btnGuardarEstado.TabIndex = 4;
            this.btnGuardarEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnModificarEstado
            // 
            this.btnModificarEstado.ActiveBorderThickness = 1;
            this.btnModificarEstado.ActiveCornerRadius = 20;
            this.btnModificarEstado.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnModificarEstado.ActiveForecolor = System.Drawing.Color.White;
            this.btnModificarEstado.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnModificarEstado.BackColor = System.Drawing.Color.Transparent;
            this.btnModificarEstado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificarEstado.BackgroundImage")));
            this.btnModificarEstado.ButtonText = "Modificar";
            this.btnModificarEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarEstado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarEstado.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnModificarEstado.IdleBorderThickness = 1;
            this.btnModificarEstado.IdleCornerRadius = 20;
            this.btnModificarEstado.IdleFillColor = System.Drawing.Color.White;
            this.btnModificarEstado.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnModificarEstado.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnModificarEstado.Location = new System.Drawing.Point(152, 264);
            this.btnModificarEstado.Margin = new System.Windows.Forms.Padding(5);
            this.btnModificarEstado.Name = "btnModificarEstado";
            this.btnModificarEstado.Size = new System.Drawing.Size(88, 34);
            this.btnModificarEstado.TabIndex = 3;
            this.btnModificarEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEliminarEstado
            // 
            this.btnEliminarEstado.ActiveBorderThickness = 1;
            this.btnEliminarEstado.ActiveCornerRadius = 20;
            this.btnEliminarEstado.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnEliminarEstado.ActiveForecolor = System.Drawing.Color.White;
            this.btnEliminarEstado.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnEliminarEstado.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarEstado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminarEstado.BackgroundImage")));
            this.btnEliminarEstado.ButtonText = "Eliminar";
            this.btnEliminarEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarEstado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEstado.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnEliminarEstado.IdleBorderThickness = 1;
            this.btnEliminarEstado.IdleCornerRadius = 20;
            this.btnEliminarEstado.IdleFillColor = System.Drawing.Color.White;
            this.btnEliminarEstado.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnEliminarEstado.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnEliminarEstado.Location = new System.Drawing.Point(266, 264);
            this.btnEliminarEstado.Margin = new System.Windows.Forms.Padding(5);
            this.btnEliminarEstado.Name = "btnEliminarEstado";
            this.btnEliminarEstado.Size = new System.Drawing.Size(88, 34);
            this.btnEliminarEstado.TabIndex = 2;
            this.btnEliminarEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLimpiarEstado
            // 
            this.btnLimpiarEstado.ActiveBorderThickness = 1;
            this.btnLimpiarEstado.ActiveCornerRadius = 20;
            this.btnLimpiarEstado.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnLimpiarEstado.ActiveForecolor = System.Drawing.Color.White;
            this.btnLimpiarEstado.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnLimpiarEstado.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiarEstado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiarEstado.BackgroundImage")));
            this.btnLimpiarEstado.ButtonText = "Limpiar";
            this.btnLimpiarEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarEstado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarEstado.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnLimpiarEstado.IdleBorderThickness = 1;
            this.btnLimpiarEstado.IdleCornerRadius = 20;
            this.btnLimpiarEstado.IdleFillColor = System.Drawing.Color.White;
            this.btnLimpiarEstado.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnLimpiarEstado.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnLimpiarEstado.Location = new System.Drawing.Point(381, 264);
            this.btnLimpiarEstado.Margin = new System.Windows.Forms.Padding(5);
            this.btnLimpiarEstado.Name = "btnLimpiarEstado";
            this.btnLimpiarEstado.Size = new System.Drawing.Size(88, 34);
            this.btnLimpiarEstado.TabIndex = 1;
            this.btnLimpiarEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConsultarEstado
            // 
            this.btnConsultarEstado.ActiveBorderThickness = 1;
            this.btnConsultarEstado.ActiveCornerRadius = 20;
            this.btnConsultarEstado.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnConsultarEstado.ActiveForecolor = System.Drawing.Color.White;
            this.btnConsultarEstado.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnConsultarEstado.BackColor = System.Drawing.Color.Transparent;
            this.btnConsultarEstado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConsultarEstado.BackgroundImage")));
            this.btnConsultarEstado.ButtonText = "Consultar";
            this.btnConsultarEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarEstado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarEstado.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnConsultarEstado.IdleBorderThickness = 1;
            this.btnConsultarEstado.IdleCornerRadius = 20;
            this.btnConsultarEstado.IdleFillColor = System.Drawing.Color.White;
            this.btnConsultarEstado.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnConsultarEstado.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnConsultarEstado.Location = new System.Drawing.Point(329, 50);
            this.btnConsultarEstado.Margin = new System.Windows.Forms.Padding(5);
            this.btnConsultarEstado.Name = "btnConsultarEstado";
            this.btnConsultarEstado.Size = new System.Drawing.Size(88, 34);
            this.btnConsultarEstado.TabIndex = 0;
            this.btnConsultarEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(556, 371);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Datos";
            this.Text = "Datos";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGuardarEstado;
        private Bunifu.Framework.UI.BunifuThinButton2 btnModificarEstado;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEliminarEstado;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLimpiarEstado;
        private Bunifu.Framework.UI.BunifuThinButton2 btnConsultarEstado;
        private System.Windows.Forms.TextBox txtEstado;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvEstado;
    }
}