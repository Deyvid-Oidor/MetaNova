namespace MetaNova
{
    partial class Servicio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtManoObra = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.cmbTecnico = new System.Windows.Forms.ComboBox();
            this.cmbTipoServicio = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEquipo = new System.Windows.Forms.ComboBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDerecho = new System.Windows.Forms.Panel();
            this.pnlTotales = new System.Windows.Forms.Panel();
            this.btnGuardarOrden = new System.Windows.Forms.Button();
            this.lbTotalPagar = new System.Windows.Forms.Label();
            this.lbCostoManoObra = new System.Windows.Forms.Label();
            this.lbSumaRefacciones = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnQuitarRefaccion = new System.Windows.Forms.Button();
            this.btnAgregarRefaccion = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvDetalleServicio = new System.Windows.Forms.DataGridView();
            this.Nombre_Refacción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.pnlDerecho.SuspendLayout();
            this.pnlTotales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleServicio)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtManoObra);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmbEstado);
            this.panel1.Controls.Add(this.cmbTecnico);
            this.panel1.Controls.Add(this.cmbTipoServicio);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbEquipo);
            this.panel1.Controls.Add(this.cmbCliente);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 841);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtManoObra
            // 
            this.txtManoObra.Location = new System.Drawing.Point(214, 586);
            this.txtManoObra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtManoObra.Name = "txtManoObra";
            this.txtManoObra.Size = new System.Drawing.Size(235, 26);
            this.txtManoObra.TabIndex = 14;
            this.txtManoObra.TextChanged += new System.EventHandler(this.txtCostoManoObra_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 586);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Costo Mano de Obra:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 520);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Estado Inicial:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Técnico Responsable:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 456);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tipo de Servicio:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Pendiente",
            "En Reparación",
            "Reparado",
            "Entregado",
            "Cancelado"});
            this.cmbEstado.Location = new System.Drawing.Point(173, 520);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(276, 28);
            this.cmbEstado.TabIndex = 8;
            // 
            // cmbTecnico
            // 
            this.cmbTecnico.FormattingEnabled = true;
            this.cmbTecnico.Location = new System.Drawing.Point(228, 390);
            this.cmbTecnico.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTecnico.Name = "cmbTecnico";
            this.cmbTecnico.Size = new System.Drawing.Size(208, 28);
            this.cmbTecnico.TabIndex = 7;
            this.cmbTecnico.SelectedIndexChanged += new System.EventHandler(this.cmbUsuario_SelectedIndexChanged);
            // 
            // cmbTipoServicio
            // 
            this.cmbTipoServicio.FormattingEnabled = true;
            this.cmbTipoServicio.Items.AddRange(new object[] {
            "Cambio de Pantalla",
            "Cambio de Batería",
            "Reparación de Purto de Carga",
            "Mantenimiento por Humedad",
            "Reparación de Cámara",
            "Actualización de Software / Liberación"});
            this.cmbTipoServicio.Location = new System.Drawing.Point(228, 456);
            this.cmbTipoServicio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTipoServicio.Name = "cmbTipoServicio";
            this.cmbTipoServicio.Size = new System.Drawing.Size(195, 28);
            this.cmbTipoServicio.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.label4.Location = new System.Drawing.Point(57, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(347, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "2. Datos del Servicio o Reparación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Equipo;";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cliente:";
            // 
            // cmbEquipo
            // 
            this.cmbEquipo.FormattingEnabled = true;
            this.cmbEquipo.Location = new System.Drawing.Point(172, 242);
            this.cmbEquipo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbEquipo.Name = "cmbEquipo";
            this.cmbEquipo.Size = new System.Drawing.Size(276, 28);
            this.cmbEquipo.TabIndex = 2;
            // 
            // cmbCliente
            // 
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(172, 160);
            this.cmbCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(276, 36);
            this.cmbCliente.TabIndex = 1;
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.label1.Location = new System.Drawing.Point(86, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. Selección de Equipo";
            // 
            // pnlDerecho
            // 
            this.pnlDerecho.Controls.Add(this.pnlTotales);
            this.pnlDerecho.Controls.Add(this.btnQuitarRefaccion);
            this.pnlDerecho.Controls.Add(this.btnAgregarRefaccion);
            this.pnlDerecho.Controls.Add(this.label9);
            this.pnlDerecho.Controls.Add(this.dgvDetalleServicio);
            this.pnlDerecho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDerecho.Location = new System.Drawing.Point(566, 0);
            this.pnlDerecho.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlDerecho.Name = "pnlDerecho";
            this.pnlDerecho.Size = new System.Drawing.Size(801, 841);
            this.pnlDerecho.TabIndex = 1;
            this.pnlDerecho.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDerecho_Paint);
            // 
            // pnlTotales
            // 
            this.pnlTotales.Controls.Add(this.btnGuardarOrden);
            this.pnlTotales.Controls.Add(this.lbTotalPagar);
            this.pnlTotales.Controls.Add(this.lbCostoManoObra);
            this.pnlTotales.Controls.Add(this.lbSumaRefacciones);
            this.pnlTotales.Controls.Add(this.label13);
            this.pnlTotales.Controls.Add(this.label12);
            this.pnlTotales.Controls.Add(this.label11);
            this.pnlTotales.Controls.Add(this.label10);
            this.pnlTotales.Location = new System.Drawing.Point(29, 415);
            this.pnlTotales.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTotales.Name = "pnlTotales";
            this.pnlTotales.Size = new System.Drawing.Size(716, 422);
            this.pnlTotales.TabIndex = 4;
            // 
            // btnGuardarOrden
            // 
            this.btnGuardarOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnGuardarOrden.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarOrden.FlatAppearance.BorderSize = 0;
            this.btnGuardarOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarOrden.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarOrden.ForeColor = System.Drawing.Color.White;
            this.btnGuardarOrden.Location = new System.Drawing.Point(206, 354);
            this.btnGuardarOrden.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardarOrden.Name = "btnGuardarOrden";
            this.btnGuardarOrden.Size = new System.Drawing.Size(309, 58);
            this.btnGuardarOrden.TabIndex = 7;
            this.btnGuardarOrden.Text = "GUARDAR";
            this.btnGuardarOrden.UseVisualStyleBackColor = false;
            // 
            // lbTotalPagar
            // 
            this.lbTotalPagar.AutoSize = true;
            this.lbTotalPagar.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPagar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lbTotalPagar.Location = new System.Drawing.Point(241, 258);
            this.lbTotalPagar.Name = "lbTotalPagar";
            this.lbTotalPagar.Size = new System.Drawing.Size(105, 45);
            this.lbTotalPagar.TabIndex = 6;
            this.lbTotalPagar.Text = "$0.00";
            // 
            // lbCostoManoObra
            // 
            this.lbCostoManoObra.AutoSize = true;
            this.lbCostoManoObra.Location = new System.Drawing.Point(249, 189);
            this.lbCostoManoObra.Name = "lbCostoManoObra";
            this.lbCostoManoObra.Size = new System.Drawing.Size(49, 20);
            this.lbCostoManoObra.TabIndex = 5;
            this.lbCostoManoObra.Text = "$0.00";
            this.lbCostoManoObra.TextChanged += new System.EventHandler(this.lbCostoManoObra_Click);
            this.lbCostoManoObra.Click += new System.EventHandler(this.lbCostoManoObra_Click_2);
            // 
            // lbSumaRefacciones
            // 
            this.lbSumaRefacciones.AutoSize = true;
            this.lbSumaRefacciones.Location = new System.Drawing.Point(249, 95);
            this.lbSumaRefacciones.Name = "lbSumaRefacciones";
            this.lbSumaRefacciones.Size = new System.Drawing.Size(49, 20);
            this.lbSumaRefacciones.TabIndex = 4;
            this.lbSumaRefacciones.Text = "$0.00";
            this.lbSumaRefacciones.Click += new System.EventHandler(this.lbSumaRefacciones_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(245, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 20);
            this.label13.TabIndex = 3;
            this.label13.Text = "Resumen Total";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(56, 279);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "TOTAL A PAGAR;";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(53, 198);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Mano de Obra:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(53, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Refacciones:";
            // 
            // btnQuitarRefaccion
            // 
            this.btnQuitarRefaccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnQuitarRefaccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarRefaccion.ForeColor = System.Drawing.Color.White;
            this.btnQuitarRefaccion.Location = new System.Drawing.Point(462, 312);
            this.btnQuitarRefaccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQuitarRefaccion.Name = "btnQuitarRefaccion";
            this.btnQuitarRefaccion.Size = new System.Drawing.Size(179, 51);
            this.btnQuitarRefaccion.TabIndex = 3;
            this.btnQuitarRefaccion.Text = "Quitar";
            this.btnQuitarRefaccion.UseVisualStyleBackColor = false;
            this.btnQuitarRefaccion.Click += new System.EventHandler(this.btnQuitarRefaccion_Click);
            // 
            // btnAgregarRefaccion
            // 
            this.btnAgregarRefaccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnAgregarRefaccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarRefaccion.ForeColor = System.Drawing.Color.White;
            this.btnAgregarRefaccion.Location = new System.Drawing.Point(146, 312);
            this.btnAgregarRefaccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregarRefaccion.Name = "btnAgregarRefaccion";
            this.btnAgregarRefaccion.Size = new System.Drawing.Size(192, 51);
            this.btnAgregarRefaccion.TabIndex = 2;
            this.btnAgregarRefaccion.Text = "Agregar Refacción";
            this.btnAgregarRefaccion.UseVisualStyleBackColor = false;
            this.btnAgregarRefaccion.Click += new System.EventHandler(this.btnAgregarRefaccion_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(246, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(264, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "3. Insumos y Refacciones Utilizados";
            // 
            // dgvDetalleServicio
            // 
            this.dgvDetalleServicio.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetalleServicio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleServicio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetalleServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleServicio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre_Refacción,
            this.Column1,
            this.Column3,
            this.Column4});
            this.dgvDetalleServicio.EnableHeadersVisualStyles = false;
            this.dgvDetalleServicio.Location = new System.Drawing.Point(86, 138);
            this.dgvDetalleServicio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDetalleServicio.Name = "dgvDetalleServicio";
            this.dgvDetalleServicio.RowHeadersWidth = 51;
            this.dgvDetalleServicio.RowTemplate.Height = 24;
            this.dgvDetalleServicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleServicio.Size = new System.Drawing.Size(626, 153);
            this.dgvDetalleServicio.TabIndex = 0;
            this.dgvDetalleServicio.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalleServicio_CellValueChanged);
            // 
            // Nombre_Refacción
            // 
            this.Nombre_Refacción.HeaderText = "Nombre Refacción";
            this.Nombre_Refacción.MinimumWidth = 6;
            this.Nombre_Refacción.Name = "Nombre_Refacción";
            this.Nombre_Refacción.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Cantidad";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Unitario";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Subtotal";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(221, 181);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(8, 26);
            this.textBox1.TabIndex = 8;
            // 
            // Servicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1367, 841);
            this.Controls.Add(this.pnlDerecho);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Servicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servicio";
            this.Load += new System.EventHandler(this.Servicio_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlDerecho.ResumeLayout(false);
            this.pnlDerecho.PerformLayout();
            this.pnlTotales.ResumeLayout(false);
            this.pnlTotales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleServicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEquipo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.ComboBox cmbTecnico;
        private System.Windows.Forms.ComboBox cmbTipoServicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtManoObra;
        private System.Windows.Forms.Panel pnlDerecho;
        private System.Windows.Forms.DataGridView dgvDetalleServicio;
        private System.Windows.Forms.Button btnQuitarRefaccion;
        private System.Windows.Forms.Button btnAgregarRefaccion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlTotales;
        private System.Windows.Forms.Label lbTotalPagar;
        private System.Windows.Forms.Label lbCostoManoObra;
        private System.Windows.Forms.Label lbSumaRefacciones;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnGuardarOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Refacción;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox textBox1;
    }
}