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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtManoObra = new System.Windows.Forms.TextBox();
            this.btnQuitarRefaccion = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAgregarRefaccion = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvDetalleServicio = new System.Windows.Forms.DataGridView();
            this.Nombre_Refacción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.cmbTecnico = new System.Windows.Forms.ComboBox();
            this.cmbTipoServicio = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEquipo = new System.Windows.Forms.ComboBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDerecho = new System.Windows.Forms.Panel();
            this.btnEliminarServicios = new System.Windows.Forms.Button();
            this.btnActualizarServicios = new System.Windows.Forms.Button();
            this.dgvServiciosActivos = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlTotales = new System.Windows.Forms.Panel();
            this.btnGuardarOrden = new System.Windows.Forms.Button();
            this.lbTotalPagar = new System.Windows.Forms.Label();
            this.lbCostoManoObra = new System.Windows.Forms.Label();
            this.lbSumaRefacciones = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Equipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleServicio)).BeginInit();
            this.pnlDerecho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiciosActivos)).BeginInit();
            this.pnlTotales.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.panel1.Controls.Add(this.txtManoObra);
            this.panel1.Controls.Add(this.btnQuitarRefaccion);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnAgregarRefaccion);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dgvDetalleServicio);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmbEstado);
            this.panel1.Controls.Add(this.cmbTecnico);
            this.panel1.Controls.Add(this.cmbTipoServicio);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbEquipo);
            this.panel1.Controls.Add(this.cmbCliente);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 916);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtManoObra
            // 
            this.txtManoObra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.txtManoObra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.txtManoObra.Location = new System.Drawing.Point(228, 255);
            this.txtManoObra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtManoObra.Name = "txtManoObra";
            this.txtManoObra.Size = new System.Drawing.Size(235, 26);
            this.txtManoObra.TabIndex = 14;
            this.txtManoObra.TextChanged += new System.EventHandler(this.txtCostoManoObra_TextChanged);
            // 
            // btnQuitarRefaccion
            // 
            this.btnQuitarRefaccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.btnQuitarRefaccion.FlatAppearance.BorderSize = 0;
            this.btnQuitarRefaccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarRefaccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.btnQuitarRefaccion.Location = new System.Drawing.Point(341, 639);
            this.btnQuitarRefaccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQuitarRefaccion.Name = "btnQuitarRefaccion";
            this.btnQuitarRefaccion.Size = new System.Drawing.Size(179, 51);
            this.btnQuitarRefaccion.TabIndex = 3;
            this.btnQuitarRefaccion.Text = "Quitar";
            this.btnQuitarRefaccion.UseVisualStyleBackColor = false;
            this.btnQuitarRefaccion.Click += new System.EventHandler(this.btnQuitarRefaccion_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.label8.Location = new System.Drawing.Point(6, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Costo Mano de Obra:";
            // 
            // btnAgregarRefaccion
            // 
            this.btnAgregarRefaccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(216)))));
            this.btnAgregarRefaccion.FlatAppearance.BorderSize = 0;
            this.btnAgregarRefaccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarRefaccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.btnAgregarRefaccion.Location = new System.Drawing.Point(37, 639);
            this.btnAgregarRefaccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregarRefaccion.Name = "btnAgregarRefaccion";
            this.btnAgregarRefaccion.Size = new System.Drawing.Size(192, 51);
            this.btnAgregarRefaccion.TabIndex = 2;
            this.btnAgregarRefaccion.Text = "Agregar Refacción";
            this.btnAgregarRefaccion.UseVisualStyleBackColor = false;
            this.btnAgregarRefaccion.Click += new System.EventHandler(this.btnAgregarRefaccion_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.label7.Location = new System.Drawing.Point(55, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Estado Inicial:";
            // 
            // dgvDetalleServicio
            // 
            this.dgvDetalleServicio.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.dgvDetalleServicio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleServicio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetalleServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleServicio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre_Refacción,
            this.Column1,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalleServicio.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetalleServicio.EnableHeadersVisualStyles = false;
            this.dgvDetalleServicio.Location = new System.Drawing.Point(9, 480);
            this.dgvDetalleServicio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDetalleServicio.Name = "dgvDetalleServicio";
            this.dgvDetalleServicio.RowHeadersWidth = 51;
            this.dgvDetalleServicio.RowTemplate.Height = 24;
            this.dgvDetalleServicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleServicio.Size = new System.Drawing.Size(626, 152);
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.label9.Location = new System.Drawing.Point(138, 456);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "INSUMOS Y COSTOS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.label6.Location = new System.Drawing.Point(14, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Técnico Responsable:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.label5.Location = new System.Drawing.Point(34, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tipo de Servicio:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.cmbEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Pendiente",
            "En Reparación",
            "Reparado",
            "Entregado",
            "Cancelado"});
            this.cmbEstado.Location = new System.Drawing.Point(228, 340);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(276, 28);
            this.cmbEstado.TabIndex = 8;
            // 
            // cmbTecnico
            // 
            this.cmbTecnico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.cmbTecnico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.cmbTecnico.FormattingEnabled = true;
            this.cmbTecnico.Location = new System.Drawing.Point(255, 290);
            this.cmbTecnico.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTecnico.Name = "cmbTecnico";
            this.cmbTecnico.Size = new System.Drawing.Size(208, 28);
            this.cmbTecnico.TabIndex = 7;
            this.cmbTecnico.SelectedIndexChanged += new System.EventHandler(this.cmbUsuario_SelectedIndexChanged);
            // 
            // cmbTipoServicio
            // 
            this.cmbTipoServicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.cmbTipoServicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.cmbTipoServicio.FormattingEnabled = true;
            this.cmbTipoServicio.Items.AddRange(new object[] {
            "Cambio de Pantalla",
            "Cambio de Batería",
            "Reparación de Purto de Carga",
            "Mantenimiento por Humedad",
            "Reparación de Cámara",
            "Actualización de Software / Liberación"});
            this.cmbTipoServicio.Location = new System.Drawing.Point(255, 218);
            this.cmbTipoServicio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTipoServicio.Name = "cmbTipoServicio";
            this.cmbTipoServicio.Size = new System.Drawing.Size(195, 28);
            this.cmbTipoServicio.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.label3.Location = new System.Drawing.Point(21, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Seleccionar Equipo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.label2.Location = new System.Drawing.Point(15, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seleccionar Cliente:";
            // 
            // cmbEquipo
            // 
            this.cmbEquipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.cmbEquipo.FormattingEnabled = true;
            this.cmbEquipo.Location = new System.Drawing.Point(214, 152);
            this.cmbEquipo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbEquipo.Name = "cmbEquipo";
            this.cmbEquipo.Size = new System.Drawing.Size(276, 28);
            this.cmbEquipo.TabIndex = 2;
            // 
            // cmbCliente
            // 
            this.cmbCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.cmbCliente.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(214, 106);
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
            this.label1.Size = new System.Drawing.Size(224, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "DATOS DEL SERVICIO";
            // 
            // pnlDerecho
            // 
            this.pnlDerecho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.pnlDerecho.Controls.Add(this.btnEliminarServicios);
            this.pnlDerecho.Controls.Add(this.btnActualizarServicios);
            this.pnlDerecho.Controls.Add(this.dgvServiciosActivos);
            this.pnlDerecho.Controls.Add(this.label4);
            this.pnlDerecho.Controls.Add(this.pnlTotales);
            this.pnlDerecho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDerecho.Location = new System.Drawing.Point(645, 0);
            this.pnlDerecho.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlDerecho.Name = "pnlDerecho";
            this.pnlDerecho.Size = new System.Drawing.Size(722, 916);
            this.pnlDerecho.TabIndex = 1;
            this.pnlDerecho.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDerecho_Paint);
            // 
            // btnEliminarServicios
            // 
            this.btnEliminarServicios.FlatAppearance.BorderSize = 0;
            this.btnEliminarServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarServicios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.btnEliminarServicios.Location = new System.Drawing.Point(402, 761);
            this.btnEliminarServicios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminarServicios.Name = "btnEliminarServicios";
            this.btnEliminarServicios.Size = new System.Drawing.Size(84, 29);
            this.btnEliminarServicios.TabIndex = 8;
            this.btnEliminarServicios.Text = "Eliminar";
            this.btnEliminarServicios.UseVisualStyleBackColor = true;
            this.btnEliminarServicios.Click += new System.EventHandler(this.btnEliminarServicios_Click);
            // 
            // btnActualizarServicios
            // 
            this.btnActualizarServicios.FlatAppearance.BorderSize = 0;
            this.btnActualizarServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarServicios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.btnActualizarServicios.Location = new System.Drawing.Point(84, 761);
            this.btnActualizarServicios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnActualizarServicios.Name = "btnActualizarServicios";
            this.btnActualizarServicios.Size = new System.Drawing.Size(201, 49);
            this.btnActualizarServicios.TabIndex = 7;
            this.btnActualizarServicios.Text = "Actualizar / Modificar";
            this.btnActualizarServicios.UseVisualStyleBackColor = true;
            this.btnActualizarServicios.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvServiciosActivos
            // 
            this.dgvServiciosActivos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvServiciosActivos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvServiciosActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiciosActivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Cliente,
            this.Equipo,
            this.Estatus,
            this.Total});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvServiciosActivos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvServiciosActivos.Location = new System.Drawing.Point(44, 522);
            this.dgvServiciosActivos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvServiciosActivos.Name = "dgvServiciosActivos";
            this.dgvServiciosActivos.RowHeadersWidth = 51;
            this.dgvServiciosActivos.RowTemplate.Height = 24;
            this.dgvServiciosActivos.Size = new System.Drawing.Size(595, 188);
            this.dgvServiciosActivos.TabIndex = 6;
            this.dgvServiciosActivos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServiciosActivos_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.label4.Location = new System.Drawing.Point(116, 480);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "LISTADO DE SERVICIOS ACTIVOS";
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
            this.pnlTotales.Location = new System.Drawing.Point(28, 38);
            this.pnlTotales.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTotales.Name = "pnlTotales";
            this.pnlTotales.Size = new System.Drawing.Size(611, 395);
            this.pnlTotales.TabIndex = 4;
            // 
            // btnGuardarOrden
            // 
            this.btnGuardarOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(216)))));
            this.btnGuardarOrden.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarOrden.FlatAppearance.BorderSize = 0;
            this.btnGuardarOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarOrden.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarOrden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.btnGuardarOrden.Location = new System.Drawing.Point(155, 312);
            this.btnGuardarOrden.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardarOrden.Name = "btnGuardarOrden";
            this.btnGuardarOrden.Size = new System.Drawing.Size(309, 58);
            this.btnGuardarOrden.TabIndex = 7;
            this.btnGuardarOrden.Text = "GUARDAR";
            this.btnGuardarOrden.UseVisualStyleBackColor = false;
            this.btnGuardarOrden.Click += new System.EventHandler(this.btnGuardarOrden_Click);
            // 
            // lbTotalPagar
            // 
            this.lbTotalPagar.AutoSize = true;
            this.lbTotalPagar.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPagar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.lbTotalPagar.Location = new System.Drawing.Point(241, 206);
            this.lbTotalPagar.Name = "lbTotalPagar";
            this.lbTotalPagar.Size = new System.Drawing.Size(105, 45);
            this.lbTotalPagar.TabIndex = 6;
            this.lbTotalPagar.Text = "$0.00";
            // 
            // lbCostoManoObra
            // 
            this.lbCostoManoObra.AutoSize = true;
            this.lbCostoManoObra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.lbCostoManoObra.Location = new System.Drawing.Point(245, 156);
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
            this.lbSumaRefacciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
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
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.label13.Location = new System.Drawing.Point(96, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 20);
            this.label13.TabIndex = 3;
            this.label13.Text = "RESUMEN:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.label12.Location = new System.Drawing.Point(53, 221);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "TOTAL A PAGAR;";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.label11.Location = new System.Drawing.Point(56, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Mano de Obra:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.label10.Location = new System.Drawing.Point(53, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Refacciones:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(221, 181);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(8, 26);
            this.textBox1.TabIndex = 8;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "IdServicio";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "NombreCliente";
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.MinimumWidth = 6;
            this.Cliente.Name = "Cliente";
            this.Cliente.Width = 125;
            // 
            // Equipo
            // 
            this.Equipo.DataPropertyName = "IdEquipo";
            this.Equipo.HeaderText = "Equipo";
            this.Equipo.MinimumWidth = 6;
            this.Equipo.Name = "Equipo";
            this.Equipo.Width = 125;
            // 
            // Estatus
            // 
            this.Estatus.DataPropertyName = "NombreEstado";
            this.Estatus.HeaderText = "Estatus";
            this.Estatus.MinimumWidth = 6;
            this.Estatus.Name = "Estatus";
            this.Estatus.Width = 125;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "CostoManoObra";
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.Width = 125;
            // 
            // Servicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1367, 916);
            this.Controls.Add(this.pnlDerecho);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Servicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servicio";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Servicio_FormClosed);
            this.Load += new System.EventHandler(this.Servicio_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleServicio)).EndInit();
            this.pnlDerecho.ResumeLayout(false);
            this.pnlDerecho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiciosActivos)).EndInit();
            this.pnlTotales.ResumeLayout(false);
            this.pnlTotales.PerformLayout();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtManoObra;
        private System.Windows.Forms.Panel pnlDerecho;
        private System.Windows.Forms.DataGridView dgvDetalleServicio;
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
        private System.Windows.Forms.DataGridView dgvServiciosActivos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEliminarServicios;
        private System.Windows.Forms.Button btnActualizarServicios;
        private System.Windows.Forms.Button btnQuitarRefaccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Equipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}