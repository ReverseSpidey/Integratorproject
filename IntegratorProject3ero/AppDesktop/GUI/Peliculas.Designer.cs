namespace AppDesktop.GUI
{
    partial class Peliculas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Peliculas));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtClasificacion = new System.Windows.Forms.TextBox();
            this.dgvClasificacion = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dgvSubtitulos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txtSubtitulos = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.dgvGenero = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnLimpiarGenero = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnEliminarGenero = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnModificarGenero = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnGuardarGenero = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnConsultarGenero = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnConsultarClasificacion = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnLimpiarClasificacion = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnElminarClasificacion = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnGuardarClasificacion = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnModificarClasificacion = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnLimpiarSubtitulos = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnEliminarSubtitulos = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnModificarSubtitulos = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton25 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnGuardarSubtitulos = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasificacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubtitulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenero)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
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
            this.tabPage1.Text = "Pelicula";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvGenero);
            this.tabPage2.Controls.Add(this.txtGenero);
            this.tabPage2.Controls.Add(this.btnLimpiarGenero);
            this.tabPage2.Controls.Add(this.btnEliminarGenero);
            this.tabPage2.Controls.Add(this.btnModificarGenero);
            this.tabPage2.Controls.Add(this.btnGuardarGenero);
            this.tabPage2.Controls.Add(this.btnConsultarGenero);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(510, 321);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Género";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnConsultarClasificacion);
            this.tabPage3.Controls.Add(this.dgvClasificacion);
            this.tabPage3.Controls.Add(this.btnLimpiarClasificacion);
            this.tabPage3.Controls.Add(this.btnElminarClasificacion);
            this.tabPage3.Controls.Add(this.btnGuardarClasificacion);
            this.tabPage3.Controls.Add(this.btnModificarClasificacion);
            this.tabPage3.Controls.Add(this.txtClasificacion);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(510, 321);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Clasificación";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnLimpiarSubtitulos);
            this.tabPage4.Controls.Add(this.btnEliminarSubtitulos);
            this.tabPage4.Controls.Add(this.btnModificarSubtitulos);
            this.tabPage4.Controls.Add(this.bunifuThinButton25);
            this.tabPage4.Controls.Add(this.btnGuardarSubtitulos);
            this.tabPage4.Controls.Add(this.txtSubtitulos);
            this.tabPage4.Controls.Add(this.dgvSubtitulos);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(510, 321);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Subtitulos";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtClasificacion
            // 
            this.txtClasificacion.Location = new System.Drawing.Point(134, 58);
            this.txtClasificacion.Name = "txtClasificacion";
            this.txtClasificacion.Size = new System.Drawing.Size(187, 20);
            this.txtClasificacion.TabIndex = 0;
            this.txtClasificacion.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgvClasificacion
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvClasificacion.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClasificacion.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvClasificacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClasificacion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClasificacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvClasificacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClasificacion.DoubleBuffered = true;
            this.dgvClasificacion.EnableHeadersVisualStyles = false;
            this.dgvClasificacion.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgvClasificacion.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgvClasificacion.Location = new System.Drawing.Point(68, 100);
            this.dgvClasificacion.Name = "dgvClasificacion";
            this.dgvClasificacion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvClasificacion.Size = new System.Drawing.Size(365, 145);
            this.dgvClasificacion.TabIndex = 5;
            // 
            // dgvSubtitulos
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvSubtitulos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSubtitulos.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvSubtitulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSubtitulos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubtitulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSubtitulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubtitulos.DoubleBuffered = true;
            this.dgvSubtitulos.EnableHeadersVisualStyles = false;
            this.dgvSubtitulos.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgvSubtitulos.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgvSubtitulos.Location = new System.Drawing.Point(68, 100);
            this.dgvSubtitulos.Name = "dgvSubtitulos";
            this.dgvSubtitulos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSubtitulos.Size = new System.Drawing.Size(365, 145);
            this.dgvSubtitulos.TabIndex = 0;
            // 
            // txtSubtitulos
            // 
            this.txtSubtitulos.Location = new System.Drawing.Point(134, 58);
            this.txtSubtitulos.Name = "txtSubtitulos";
            this.txtSubtitulos.Size = new System.Drawing.Size(187, 20);
            this.txtSubtitulos.TabIndex = 1;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(134, 58);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(187, 20);
            this.txtGenero.TabIndex = 0;
            // 
            // dgvGenero
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvGenero.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGenero.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvGenero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGenero.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGenero.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGenero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGenero.DoubleBuffered = true;
            this.dgvGenero.EnableHeadersVisualStyles = false;
            this.dgvGenero.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgvGenero.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgvGenero.Location = new System.Drawing.Point(68, 100);
            this.dgvGenero.Name = "dgvGenero";
            this.dgvGenero.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvGenero.Size = new System.Drawing.Size(365, 145);
            this.dgvGenero.TabIndex = 6;
            // 
            // btnLimpiarGenero
            // 
            this.btnLimpiarGenero.ActiveBorderThickness = 1;
            this.btnLimpiarGenero.ActiveCornerRadius = 20;
            this.btnLimpiarGenero.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnLimpiarGenero.ActiveForecolor = System.Drawing.Color.White;
            this.btnLimpiarGenero.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnLimpiarGenero.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiarGenero.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiarGenero.BackgroundImage")));
            this.btnLimpiarGenero.ButtonText = "Limpiar";
            this.btnLimpiarGenero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarGenero.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarGenero.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnLimpiarGenero.IdleBorderThickness = 1;
            this.btnLimpiarGenero.IdleCornerRadius = 20;
            this.btnLimpiarGenero.IdleFillColor = System.Drawing.Color.White;
            this.btnLimpiarGenero.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnLimpiarGenero.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnLimpiarGenero.Location = new System.Drawing.Point(381, 264);
            this.btnLimpiarGenero.Margin = new System.Windows.Forms.Padding(5);
            this.btnLimpiarGenero.Name = "btnLimpiarGenero";
            this.btnLimpiarGenero.Size = new System.Drawing.Size(88, 34);
            this.btnLimpiarGenero.TabIndex = 5;
            this.btnLimpiarGenero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEliminarGenero
            // 
            this.btnEliminarGenero.ActiveBorderThickness = 1;
            this.btnEliminarGenero.ActiveCornerRadius = 20;
            this.btnEliminarGenero.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnEliminarGenero.ActiveForecolor = System.Drawing.Color.White;
            this.btnEliminarGenero.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnEliminarGenero.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarGenero.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminarGenero.BackgroundImage")));
            this.btnEliminarGenero.ButtonText = "Eliminar";
            this.btnEliminarGenero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarGenero.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarGenero.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnEliminarGenero.IdleBorderThickness = 1;
            this.btnEliminarGenero.IdleCornerRadius = 20;
            this.btnEliminarGenero.IdleFillColor = System.Drawing.Color.White;
            this.btnEliminarGenero.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnEliminarGenero.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnEliminarGenero.Location = new System.Drawing.Point(266, 264);
            this.btnEliminarGenero.Margin = new System.Windows.Forms.Padding(5);
            this.btnEliminarGenero.Name = "btnEliminarGenero";
            this.btnEliminarGenero.Size = new System.Drawing.Size(88, 34);
            this.btnEliminarGenero.TabIndex = 4;
            this.btnEliminarGenero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnModificarGenero
            // 
            this.btnModificarGenero.ActiveBorderThickness = 1;
            this.btnModificarGenero.ActiveCornerRadius = 20;
            this.btnModificarGenero.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnModificarGenero.ActiveForecolor = System.Drawing.Color.White;
            this.btnModificarGenero.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnModificarGenero.BackColor = System.Drawing.Color.Transparent;
            this.btnModificarGenero.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificarGenero.BackgroundImage")));
            this.btnModificarGenero.ButtonText = "Modificar";
            this.btnModificarGenero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarGenero.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarGenero.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnModificarGenero.IdleBorderThickness = 1;
            this.btnModificarGenero.IdleCornerRadius = 20;
            this.btnModificarGenero.IdleFillColor = System.Drawing.Color.White;
            this.btnModificarGenero.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnModificarGenero.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnModificarGenero.Location = new System.Drawing.Point(152, 264);
            this.btnModificarGenero.Margin = new System.Windows.Forms.Padding(5);
            this.btnModificarGenero.Name = "btnModificarGenero";
            this.btnModificarGenero.Size = new System.Drawing.Size(88, 34);
            this.btnModificarGenero.TabIndex = 3;
            this.btnModificarGenero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGuardarGenero
            // 
            this.btnGuardarGenero.ActiveBorderThickness = 1;
            this.btnGuardarGenero.ActiveCornerRadius = 20;
            this.btnGuardarGenero.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnGuardarGenero.ActiveForecolor = System.Drawing.Color.White;
            this.btnGuardarGenero.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnGuardarGenero.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardarGenero.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardarGenero.BackgroundImage")));
            this.btnGuardarGenero.ButtonText = "Guardar";
            this.btnGuardarGenero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarGenero.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarGenero.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnGuardarGenero.IdleBorderThickness = 1;
            this.btnGuardarGenero.IdleCornerRadius = 20;
            this.btnGuardarGenero.IdleFillColor = System.Drawing.Color.White;
            this.btnGuardarGenero.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnGuardarGenero.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnGuardarGenero.Location = new System.Drawing.Point(34, 264);
            this.btnGuardarGenero.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuardarGenero.Name = "btnGuardarGenero";
            this.btnGuardarGenero.Size = new System.Drawing.Size(88, 34);
            this.btnGuardarGenero.TabIndex = 2;
            this.btnGuardarGenero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConsultarGenero
            // 
            this.btnConsultarGenero.ActiveBorderThickness = 1;
            this.btnConsultarGenero.ActiveCornerRadius = 20;
            this.btnConsultarGenero.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnConsultarGenero.ActiveForecolor = System.Drawing.Color.White;
            this.btnConsultarGenero.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnConsultarGenero.BackColor = System.Drawing.Color.Transparent;
            this.btnConsultarGenero.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConsultarGenero.BackgroundImage")));
            this.btnConsultarGenero.ButtonText = "Consultar";
            this.btnConsultarGenero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarGenero.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarGenero.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnConsultarGenero.IdleBorderThickness = 1;
            this.btnConsultarGenero.IdleCornerRadius = 20;
            this.btnConsultarGenero.IdleFillColor = System.Drawing.Color.White;
            this.btnConsultarGenero.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnConsultarGenero.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnConsultarGenero.Location = new System.Drawing.Point(329, 50);
            this.btnConsultarGenero.Margin = new System.Windows.Forms.Padding(5);
            this.btnConsultarGenero.Name = "btnConsultarGenero";
            this.btnConsultarGenero.Size = new System.Drawing.Size(88, 34);
            this.btnConsultarGenero.TabIndex = 1;
            this.btnConsultarGenero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConsultarClasificacion
            // 
            this.btnConsultarClasificacion.ActiveBorderThickness = 1;
            this.btnConsultarClasificacion.ActiveCornerRadius = 20;
            this.btnConsultarClasificacion.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnConsultarClasificacion.ActiveForecolor = System.Drawing.Color.White;
            this.btnConsultarClasificacion.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnConsultarClasificacion.BackColor = System.Drawing.Color.Transparent;
            this.btnConsultarClasificacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConsultarClasificacion.BackgroundImage")));
            this.btnConsultarClasificacion.ButtonText = "Consultar";
            this.btnConsultarClasificacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarClasificacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarClasificacion.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnConsultarClasificacion.IdleBorderThickness = 1;
            this.btnConsultarClasificacion.IdleCornerRadius = 20;
            this.btnConsultarClasificacion.IdleFillColor = System.Drawing.Color.White;
            this.btnConsultarClasificacion.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnConsultarClasificacion.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnConsultarClasificacion.Location = new System.Drawing.Point(329, 50);
            this.btnConsultarClasificacion.Margin = new System.Windows.Forms.Padding(5);
            this.btnConsultarClasificacion.Name = "btnConsultarClasificacion";
            this.btnConsultarClasificacion.Size = new System.Drawing.Size(88, 34);
            this.btnConsultarClasificacion.TabIndex = 6;
            this.btnConsultarClasificacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConsultarClasificacion.Click += new System.EventHandler(this.btnConsultarClasificacion_Click);
            // 
            // btnLimpiarClasificacion
            // 
            this.btnLimpiarClasificacion.ActiveBorderThickness = 1;
            this.btnLimpiarClasificacion.ActiveCornerRadius = 20;
            this.btnLimpiarClasificacion.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnLimpiarClasificacion.ActiveForecolor = System.Drawing.Color.White;
            this.btnLimpiarClasificacion.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnLimpiarClasificacion.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiarClasificacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiarClasificacion.BackgroundImage")));
            this.btnLimpiarClasificacion.ButtonText = "Limpiar";
            this.btnLimpiarClasificacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarClasificacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarClasificacion.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnLimpiarClasificacion.IdleBorderThickness = 1;
            this.btnLimpiarClasificacion.IdleCornerRadius = 20;
            this.btnLimpiarClasificacion.IdleFillColor = System.Drawing.Color.White;
            this.btnLimpiarClasificacion.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnLimpiarClasificacion.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnLimpiarClasificacion.Location = new System.Drawing.Point(381, 264);
            this.btnLimpiarClasificacion.Margin = new System.Windows.Forms.Padding(5);
            this.btnLimpiarClasificacion.Name = "btnLimpiarClasificacion";
            this.btnLimpiarClasificacion.Size = new System.Drawing.Size(88, 34);
            this.btnLimpiarClasificacion.TabIndex = 4;
            this.btnLimpiarClasificacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnElminarClasificacion
            // 
            this.btnElminarClasificacion.ActiveBorderThickness = 1;
            this.btnElminarClasificacion.ActiveCornerRadius = 20;
            this.btnElminarClasificacion.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnElminarClasificacion.ActiveForecolor = System.Drawing.Color.White;
            this.btnElminarClasificacion.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnElminarClasificacion.BackColor = System.Drawing.Color.Transparent;
            this.btnElminarClasificacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnElminarClasificacion.BackgroundImage")));
            this.btnElminarClasificacion.ButtonText = "Eliminar";
            this.btnElminarClasificacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnElminarClasificacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElminarClasificacion.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnElminarClasificacion.IdleBorderThickness = 1;
            this.btnElminarClasificacion.IdleCornerRadius = 20;
            this.btnElminarClasificacion.IdleFillColor = System.Drawing.Color.White;
            this.btnElminarClasificacion.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnElminarClasificacion.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnElminarClasificacion.Location = new System.Drawing.Point(266, 264);
            this.btnElminarClasificacion.Margin = new System.Windows.Forms.Padding(5);
            this.btnElminarClasificacion.Name = "btnElminarClasificacion";
            this.btnElminarClasificacion.Size = new System.Drawing.Size(88, 34);
            this.btnElminarClasificacion.TabIndex = 3;
            this.btnElminarClasificacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGuardarClasificacion
            // 
            this.btnGuardarClasificacion.ActiveBorderThickness = 1;
            this.btnGuardarClasificacion.ActiveCornerRadius = 20;
            this.btnGuardarClasificacion.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnGuardarClasificacion.ActiveForecolor = System.Drawing.Color.White;
            this.btnGuardarClasificacion.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnGuardarClasificacion.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardarClasificacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardarClasificacion.BackgroundImage")));
            this.btnGuardarClasificacion.ButtonText = "Guardar";
            this.btnGuardarClasificacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarClasificacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarClasificacion.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnGuardarClasificacion.IdleBorderThickness = 1;
            this.btnGuardarClasificacion.IdleCornerRadius = 20;
            this.btnGuardarClasificacion.IdleFillColor = System.Drawing.Color.White;
            this.btnGuardarClasificacion.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnGuardarClasificacion.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnGuardarClasificacion.Location = new System.Drawing.Point(34, 264);
            this.btnGuardarClasificacion.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuardarClasificacion.Name = "btnGuardarClasificacion";
            this.btnGuardarClasificacion.Size = new System.Drawing.Size(88, 34);
            this.btnGuardarClasificacion.TabIndex = 2;
            this.btnGuardarClasificacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnModificarClasificacion
            // 
            this.btnModificarClasificacion.ActiveBorderThickness = 1;
            this.btnModificarClasificacion.ActiveCornerRadius = 20;
            this.btnModificarClasificacion.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnModificarClasificacion.ActiveForecolor = System.Drawing.Color.White;
            this.btnModificarClasificacion.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnModificarClasificacion.BackColor = System.Drawing.Color.Transparent;
            this.btnModificarClasificacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificarClasificacion.BackgroundImage")));
            this.btnModificarClasificacion.ButtonText = "Modificar";
            this.btnModificarClasificacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarClasificacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarClasificacion.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnModificarClasificacion.IdleBorderThickness = 1;
            this.btnModificarClasificacion.IdleCornerRadius = 20;
            this.btnModificarClasificacion.IdleFillColor = System.Drawing.Color.White;
            this.btnModificarClasificacion.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnModificarClasificacion.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnModificarClasificacion.Location = new System.Drawing.Point(152, 264);
            this.btnModificarClasificacion.Margin = new System.Windows.Forms.Padding(5);
            this.btnModificarClasificacion.Name = "btnModificarClasificacion";
            this.btnModificarClasificacion.Size = new System.Drawing.Size(88, 34);
            this.btnModificarClasificacion.TabIndex = 1;
            this.btnModificarClasificacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLimpiarSubtitulos
            // 
            this.btnLimpiarSubtitulos.ActiveBorderThickness = 1;
            this.btnLimpiarSubtitulos.ActiveCornerRadius = 20;
            this.btnLimpiarSubtitulos.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnLimpiarSubtitulos.ActiveForecolor = System.Drawing.Color.White;
            this.btnLimpiarSubtitulos.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnLimpiarSubtitulos.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiarSubtitulos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiarSubtitulos.BackgroundImage")));
            this.btnLimpiarSubtitulos.ButtonText = "Limpiar";
            this.btnLimpiarSubtitulos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarSubtitulos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarSubtitulos.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnLimpiarSubtitulos.IdleBorderThickness = 1;
            this.btnLimpiarSubtitulos.IdleCornerRadius = 20;
            this.btnLimpiarSubtitulos.IdleFillColor = System.Drawing.Color.White;
            this.btnLimpiarSubtitulos.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnLimpiarSubtitulos.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnLimpiarSubtitulos.Location = new System.Drawing.Point(381, 264);
            this.btnLimpiarSubtitulos.Margin = new System.Windows.Forms.Padding(5);
            this.btnLimpiarSubtitulos.Name = "btnLimpiarSubtitulos";
            this.btnLimpiarSubtitulos.Size = new System.Drawing.Size(88, 34);
            this.btnLimpiarSubtitulos.TabIndex = 9;
            this.btnLimpiarSubtitulos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEliminarSubtitulos
            // 
            this.btnEliminarSubtitulos.ActiveBorderThickness = 1;
            this.btnEliminarSubtitulos.ActiveCornerRadius = 20;
            this.btnEliminarSubtitulos.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnEliminarSubtitulos.ActiveForecolor = System.Drawing.Color.White;
            this.btnEliminarSubtitulos.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnEliminarSubtitulos.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarSubtitulos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminarSubtitulos.BackgroundImage")));
            this.btnEliminarSubtitulos.ButtonText = "Eliminar";
            this.btnEliminarSubtitulos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarSubtitulos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarSubtitulos.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnEliminarSubtitulos.IdleBorderThickness = 1;
            this.btnEliminarSubtitulos.IdleCornerRadius = 20;
            this.btnEliminarSubtitulos.IdleFillColor = System.Drawing.Color.White;
            this.btnEliminarSubtitulos.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnEliminarSubtitulos.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnEliminarSubtitulos.Location = new System.Drawing.Point(266, 264);
            this.btnEliminarSubtitulos.Margin = new System.Windows.Forms.Padding(5);
            this.btnEliminarSubtitulos.Name = "btnEliminarSubtitulos";
            this.btnEliminarSubtitulos.Size = new System.Drawing.Size(88, 34);
            this.btnEliminarSubtitulos.TabIndex = 8;
            this.btnEliminarSubtitulos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnModificarSubtitulos
            // 
            this.btnModificarSubtitulos.ActiveBorderThickness = 1;
            this.btnModificarSubtitulos.ActiveCornerRadius = 20;
            this.btnModificarSubtitulos.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnModificarSubtitulos.ActiveForecolor = System.Drawing.Color.White;
            this.btnModificarSubtitulos.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnModificarSubtitulos.BackColor = System.Drawing.Color.Transparent;
            this.btnModificarSubtitulos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificarSubtitulos.BackgroundImage")));
            this.btnModificarSubtitulos.ButtonText = "Modificar";
            this.btnModificarSubtitulos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarSubtitulos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarSubtitulos.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnModificarSubtitulos.IdleBorderThickness = 1;
            this.btnModificarSubtitulos.IdleCornerRadius = 20;
            this.btnModificarSubtitulos.IdleFillColor = System.Drawing.Color.White;
            this.btnModificarSubtitulos.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnModificarSubtitulos.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnModificarSubtitulos.Location = new System.Drawing.Point(152, 264);
            this.btnModificarSubtitulos.Margin = new System.Windows.Forms.Padding(5);
            this.btnModificarSubtitulos.Name = "btnModificarSubtitulos";
            this.btnModificarSubtitulos.Size = new System.Drawing.Size(88, 34);
            this.btnModificarSubtitulos.TabIndex = 7;
            this.btnModificarSubtitulos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuThinButton25
            // 
            this.bunifuThinButton25.ActiveBorderThickness = 1;
            this.bunifuThinButton25.ActiveCornerRadius = 20;
            this.bunifuThinButton25.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton25.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton25.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton25.BackColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton25.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton25.BackgroundImage")));
            this.bunifuThinButton25.ButtonText = "Consultar";
            this.bunifuThinButton25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton25.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton25.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton25.IdleBorderThickness = 1;
            this.bunifuThinButton25.IdleCornerRadius = 20;
            this.bunifuThinButton25.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton25.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton25.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton25.Location = new System.Drawing.Point(329, 50);
            this.bunifuThinButton25.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton25.Name = "bunifuThinButton25";
            this.bunifuThinButton25.Size = new System.Drawing.Size(88, 34);
            this.bunifuThinButton25.TabIndex = 6;
            this.bunifuThinButton25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGuardarSubtitulos
            // 
            this.btnGuardarSubtitulos.ActiveBorderThickness = 1;
            this.btnGuardarSubtitulos.ActiveCornerRadius = 20;
            this.btnGuardarSubtitulos.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnGuardarSubtitulos.ActiveForecolor = System.Drawing.Color.White;
            this.btnGuardarSubtitulos.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnGuardarSubtitulos.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardarSubtitulos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardarSubtitulos.BackgroundImage")));
            this.btnGuardarSubtitulos.ButtonText = "Guardar";
            this.btnGuardarSubtitulos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarSubtitulos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarSubtitulos.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnGuardarSubtitulos.IdleBorderThickness = 1;
            this.btnGuardarSubtitulos.IdleCornerRadius = 20;
            this.btnGuardarSubtitulos.IdleFillColor = System.Drawing.Color.White;
            this.btnGuardarSubtitulos.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnGuardarSubtitulos.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnGuardarSubtitulos.Location = new System.Drawing.Point(34, 264);
            this.btnGuardarSubtitulos.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuardarSubtitulos.Name = "btnGuardarSubtitulos";
            this.btnGuardarSubtitulos.Size = new System.Drawing.Size(88, 34);
            this.btnGuardarSubtitulos.TabIndex = 5;
            this.btnGuardarSubtitulos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Peliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(556, 371);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Peliculas";
            this.Text = "Peliculas";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasificacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubtitulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenero)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtClasificacion;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLimpiarClasificacion;
        private Bunifu.Framework.UI.BunifuThinButton2 btnElminarClasificacion;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGuardarClasificacion;
        private Bunifu.Framework.UI.BunifuThinButton2 btnModificarClasificacion;
        private Bunifu.Framework.UI.BunifuThinButton2 btnConsultarClasificacion;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvClasificacion;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton25;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGuardarSubtitulos;
        private System.Windows.Forms.TextBox txtSubtitulos;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvSubtitulos;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLimpiarSubtitulos;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEliminarSubtitulos;
        private Bunifu.Framework.UI.BunifuThinButton2 btnModificarSubtitulos;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvGenero;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLimpiarGenero;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEliminarGenero;
        private Bunifu.Framework.UI.BunifuThinButton2 btnModificarGenero;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGuardarGenero;
        private Bunifu.Framework.UI.BunifuThinButton2 btnConsultarGenero;
        private System.Windows.Forms.TextBox txtGenero;
    }
}