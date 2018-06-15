namespace AppDesktop.GUI
{
    partial class HorariosGUI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnElegir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Hora_ini = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_peli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_funcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHorarios = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 41);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(163, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 27);
            this.label3.TabIndex = 61;
            this.label3.Text = "Horarios";
            // 
            // btnElegir
            // 
            this.btnElegir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(72)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.btnElegir.DefaultCellStyle = dataGridViewCellStyle1;
            this.btnElegir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElegir.HeaderText = "";
            this.btnElegir.Name = "btnElegir";
            this.btnElegir.ReadOnly = true;
            this.btnElegir.Text = "Elegir";
            this.btnElegir.UseColumnTextForButtonValue = true;
            this.btnElegir.Width = 76;
            // 
            // Hora_ini
            // 
            this.Hora_ini.DataPropertyName = "Hora_ini";
            this.Hora_ini.HeaderText = "Horario";
            this.Hora_ini.Name = "Hora_ini";
            this.Hora_ini.ReadOnly = true;
            // 
            // nombre_peli
            // 
            this.nombre_peli.DataPropertyName = "nombre_peli";
            this.nombre_peli.HeaderText = "Película";
            this.nombre_peli.Name = "nombre_peli";
            this.nombre_peli.ReadOnly = true;
            // 
            // cod_sala
            // 
            this.cod_sala.DataPropertyName = "cod_sala";
            this.cod_sala.HeaderText = "Sala";
            this.cod_sala.Name = "cod_sala";
            this.cod_sala.ReadOnly = true;
            // 
            // ID_funcion
            // 
            this.ID_funcion.DataPropertyName = "ID_funcion";
            this.ID_funcion.HeaderText = "ID Funcion";
            this.ID_funcion.Name = "ID_funcion";
            this.ID_funcion.ReadOnly = true;
            // 
            // dgvHorarios
            // 
            this.dgvHorarios.AllowUserToAddRows = false;
            this.dgvHorarios.AllowUserToDeleteRows = false;
            this.dgvHorarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_funcion,
            this.cod_sala,
            this.nombre_peli,
            this.Hora_ini,
            this.btnElegir});
            this.dgvHorarios.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvHorarios.Location = new System.Drawing.Point(0, 37);
            this.dgvHorarios.Name = "dgvHorarios";
            this.dgvHorarios.ReadOnly = true;
            this.dgvHorarios.Size = new System.Drawing.Size(425, 164);
            this.dgvHorarios.TabIndex = 0;
            this.dgvHorarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHorarios_CellContentClick);
            // 
            // HorariosGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(10)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(425, 201);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvHorarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HorariosGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HorariosGUI";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewButtonColumn btnElegir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora_ini;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_peli;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_sala;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_funcion;
        private System.Windows.Forms.DataGridView dgvHorarios;
    }
}