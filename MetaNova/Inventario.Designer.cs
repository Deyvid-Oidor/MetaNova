namespace MetaNova
{
    partial class Inventario
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
            this.pnlFormInventario = new System.Windows.Forms.Panel();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEliminarPieza = new System.Windows.Forms.Button();
            this.btnGuardarRefaccion = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtCantidadDisponible = new System.Windows.Forms.TextBox();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreRefaccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpiarRefaccion = new System.Windows.Forms.Button();
            this.pnlListadoInventario = new System.Windows.Forms.Panel();
            this.pnlFormInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFormInventario
            // 
            this.pnlFormInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.pnlFormInventario.Controls.Add(this.dgvInventario);
            this.pnlFormInventario.Controls.Add(this.label3);
            this.pnlFormInventario.Controls.Add(this.btnEliminarPieza);
            this.pnlFormInventario.Controls.Add(this.btnGuardarRefaccion);
            this.pnlFormInventario.Controls.Add(this.btnModificar);
            this.pnlFormInventario.Controls.Add(this.txtCantidadDisponible);
            this.pnlFormInventario.Controls.Add(this.txtPrecioUnitario);
            this.pnlFormInventario.Controls.Add(this.label5);
            this.pnlFormInventario.Controls.Add(this.label4);
            this.pnlFormInventario.Controls.Add(this.txtNombreRefaccion);
            this.pnlFormInventario.Controls.Add(this.label2);
            this.pnlFormInventario.Controls.Add(this.label1);
            this.pnlFormInventario.Controls.Add(this.btnLimpiarRefaccion);
            this.pnlFormInventario.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlFormInventario.Location = new System.Drawing.Point(0, 0);
            this.pnlFormInventario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlFormInventario.Name = "pnlFormInventario";
            this.pnlFormInventario.Size = new System.Drawing.Size(1406, 924);
            this.pnlFormInventario.TabIndex = 0;
            // 
            // dgvInventario
            // 
            this.dgvInventario.BackgroundColor = System.Drawing.Color.White;
            this.dgvInventario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column4});
            this.dgvInventario.EnableHeadersVisualStyles = false;
            this.dgvInventario.Location = new System.Drawing.Point(56, 772);
            this.dgvInventario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.RowHeadersWidth = 51;
            this.dgvInventario.RowTemplate.Height = 24;
            this.dgvInventario.Size = new System.Drawing.Size(845, 110);
            this.dgvInventario.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IdRefaccion";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Nombre";
            this.Column2.HeaderText = "Nombre de Refacción";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "PrecioUnitario";
            this.Column5.HeaderText = "Precio Unitario";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "CantDisponible";
            this.Column4.HeaderText = "Stock Actual";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.label3.Location = new System.Drawing.Point(428, 690);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(316, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "CATÁLOGO Y STOCK DE REFACCIONES";
            // 
            // btnEliminarPieza
            // 
            this.btnEliminarPieza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminarPieza.ForeColor = System.Drawing.Color.White;
            this.btnEliminarPieza.Location = new System.Drawing.Point(246, 522);
            this.btnEliminarPieza.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminarPieza.Name = "btnEliminarPieza";
            this.btnEliminarPieza.Size = new System.Drawing.Size(188, 64);
            this.btnEliminarPieza.TabIndex = 6;
            this.btnEliminarPieza.Text = "Eliminar Pieza";
            this.btnEliminarPieza.UseVisualStyleBackColor = false;
            this.btnEliminarPieza.Click += new System.EventHandler(this.btnEliminarPieza_Click);
            // 
            // btnGuardarRefaccion
            // 
            this.btnGuardarRefaccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(216)))));
            this.btnGuardarRefaccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarRefaccion.FlatAppearance.BorderSize = 0;
            this.btnGuardarRefaccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarRefaccion.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarRefaccion.ForeColor = System.Drawing.Color.White;
            this.btnGuardarRefaccion.Location = new System.Drawing.Point(218, 421);
            this.btnGuardarRefaccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardarRefaccion.Name = "btnGuardarRefaccion";
            this.btnGuardarRefaccion.Size = new System.Drawing.Size(287, 52);
            this.btnGuardarRefaccion.TabIndex = 9;
            this.btnGuardarRefaccion.Text = "Guardar / Registrar";
            this.btnGuardarRefaccion.UseVisualStyleBackColor = false;
            this.btnGuardarRefaccion.Click += new System.EventHandler(this.btnGuardarRefaccion_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(566, 420);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(165, 64);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Editar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtCantidadDisponible
            // 
            this.txtCantidadDisponible.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.txtCantidadDisponible.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.txtCantidadDisponible.Location = new System.Drawing.Point(384, 322);
            this.txtCantidadDisponible.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCantidadDisponible.Name = "txtCantidadDisponible";
            this.txtCantidadDisponible.Size = new System.Drawing.Size(360, 26);
            this.txtCantidadDisponible.TabIndex = 8;
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.txtPrecioUnitario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.txtPrecioUnitario.Location = new System.Drawing.Point(405, 238);
            this.txtPrecioUnitario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.Size = new System.Drawing.Size(360, 26);
            this.txtPrecioUnitario.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.label5.Location = new System.Drawing.Point(507, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Stock (Cantidad):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.label4.Location = new System.Drawing.Point(518, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Precio Unitario ($):";
            // 
            // txtNombreRefaccion
            // 
            this.txtNombreRefaccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.txtNombreRefaccion.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreRefaccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.txtNombreRefaccion.Location = new System.Drawing.Point(405, 125);
            this.txtNombreRefaccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombreRefaccion.Name = "txtNombreRefaccion";
            this.txtNombreRefaccion.Size = new System.Drawing.Size(360, 35);
            this.txtNombreRefaccion.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.label2.Location = new System.Drawing.Point(489, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de la refacción / pieza:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.label1.Location = new System.Drawing.Point(505, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestión de Refacción";
            // 
            // btnLimpiarRefaccion
            // 
            this.btnLimpiarRefaccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.btnLimpiarRefaccion.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarRefaccion.Location = new System.Drawing.Point(542, 522);
            this.btnLimpiarRefaccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLimpiarRefaccion.Name = "btnLimpiarRefaccion";
            this.btnLimpiarRefaccion.Size = new System.Drawing.Size(287, 59);
            this.btnLimpiarRefaccion.TabIndex = 10;
            this.btnLimpiarRefaccion.Text = "Limpiar Campos";
            this.btnLimpiarRefaccion.UseVisualStyleBackColor = false;
            this.btnLimpiarRefaccion.Click += new System.EventHandler(this.btnLimpiarRefaccion_Click);
            // 
            // pnlListadoInventario
            // 
            this.pnlListadoInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.pnlListadoInventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlListadoInventario.Location = new System.Drawing.Point(1406, 0);
            this.pnlListadoInventario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlListadoInventario.Name = "pnlListadoInventario";
            this.pnlListadoInventario.Size = new System.Drawing.Size(123, 924);
            this.pnlListadoInventario.TabIndex = 1;
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1529, 924);
            this.Controls.Add(this.pnlListadoInventario);
            this.Controls.Add(this.pnlFormInventario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Inventario_FormClosed);
            this.Load += new System.EventHandler(this.Inventario_Load);
            this.pnlFormInventario.ResumeLayout(false);
            this.pnlFormInventario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormInventario;
        private System.Windows.Forms.TextBox txtNombreRefaccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardarRefaccion;
        private System.Windows.Forms.TextBox txtCantidadDisponible;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlListadoInventario;
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnLimpiarRefaccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnEliminarPieza;
    }
}