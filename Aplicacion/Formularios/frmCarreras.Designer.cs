
namespace Aplicacion.Formularios
{
    partial class frmCarreras
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
            this.lblIdCarrera = new System.Windows.Forms.Label();
            this.lblNomCarrera = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            this.lblAsignatura = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cboAsignatura = new System.Windows.Forms.ComboBox();
            this.rbt1C = new System.Windows.Forms.RadioButton();
            this.rbt2C = new System.Windows.Forms.RadioButton();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblCuatrimestre = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.nudAño = new System.Windows.Forms.NumericUpDown();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.rbtAnual = new System.Windows.Forms.RadioButton();
            this.lstCarreras = new System.Windows.Forms.ListBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.dgvAsignaturas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuatrimestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quitar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAño)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignaturas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdCarrera
            // 
            this.lblIdCarrera.AutoSize = true;
            this.lblIdCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIdCarrera.Location = new System.Drawing.Point(46, 22);
            this.lblIdCarrera.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdCarrera.Name = "lblIdCarrera";
            this.lblIdCarrera.Size = new System.Drawing.Size(88, 25);
            this.lblIdCarrera.TabIndex = 1;
            this.lblIdCarrera.Text = "Carreras";
            // 
            // lblNomCarrera
            // 
            this.lblNomCarrera.AutoSize = true;
            this.lblNomCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNomCarrera.Location = new System.Drawing.Point(48, 73);
            this.lblNomCarrera.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomCarrera.Name = "lblNomCarrera";
            this.lblNomCarrera.Size = new System.Drawing.Size(58, 17);
            this.lblNomCarrera.TabIndex = 2;
            this.lblNomCarrera.Text = "Nombre";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAño.Location = new System.Drawing.Point(48, 204);
            this.lblAño.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(33, 17);
            this.lblAño.TabIndex = 3;
            this.lblAño.Text = "Año";
            // 
            // lblAsignatura
            // 
            this.lblAsignatura.AutoSize = true;
            this.lblAsignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAsignatura.Location = new System.Drawing.Point(48, 162);
            this.lblAsignatura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAsignatura.Name = "lblAsignatura";
            this.lblAsignatura.Size = new System.Drawing.Size(76, 17);
            this.lblAsignatura.TabIndex = 4;
            this.lblAsignatura.Text = "Asignatura";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.Location = new System.Drawing.Point(180, 69);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(391, 23);
            this.txtNombre.TabIndex = 0;
            // 
            // cboAsignatura
            // 
            this.cboAsignatura.FormattingEnabled = true;
            this.cboAsignatura.Location = new System.Drawing.Point(180, 159);
            this.cboAsignatura.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboAsignatura.Name = "cboAsignatura";
            this.cboAsignatura.Size = new System.Drawing.Size(391, 23);
            this.cboAsignatura.TabIndex = 2;
            // 
            // rbt1C
            // 
            this.rbt1C.AutoSize = true;
            this.rbt1C.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbt1C.Location = new System.Drawing.Point(415, 202);
            this.rbt1C.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbt1C.Name = "rbt1C";
            this.rbt1C.Size = new System.Drawing.Size(131, 21);
            this.rbt1C.TabIndex = 4;
            this.rbt1C.TabStop = true;
            this.rbt1C.Text = "1er Cuatrimestre";
            this.rbt1C.UseVisualStyleBackColor = true;
            // 
            // rbt2C
            // 
            this.rbt2C.AutoSize = true;
            this.rbt2C.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbt2C.Location = new System.Drawing.Point(415, 234);
            this.rbt2C.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbt2C.Name = "rbt2C";
            this.rbt2C.Size = new System.Drawing.Size(134, 21);
            this.rbt2C.TabIndex = 5;
            this.rbt2C.TabStop = true;
            this.rbt2C.Text = "2do Cuatrimestre";
            this.rbt2C.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.Location = new System.Drawing.Point(214, 313);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(182, 32);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar Asignatura";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblCuatrimestre
            // 
            this.lblCuatrimestre.AutoSize = true;
            this.lblCuatrimestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCuatrimestre.Location = new System.Drawing.Point(293, 204);
            this.lblCuatrimestre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCuatrimestre.Name = "lblCuatrimestre";
            this.lblCuatrimestre.Size = new System.Drawing.Size(88, 17);
            this.lblCuatrimestre.TabIndex = 11;
            this.lblCuatrimestre.Text = "Cuatrimestre";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.Location = new System.Drawing.Point(324, 631);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(92, 32);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(201, 631);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 32);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // nudAño
            // 
            this.nudAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudAño.Location = new System.Drawing.Point(180, 201);
            this.nudAño.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nudAño.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudAño.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAño.Name = "nudAño";
            this.nudAño.Size = new System.Drawing.Size(58, 23);
            this.nudAño.TabIndex = 3;
            this.nudAño.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(48, 117);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(107, 17);
            this.lblTitulo.TabIndex = 15;
            this.lblTitulo.Text = "Título Otorgado";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTitulo.Location = new System.Drawing.Point(180, 113);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(391, 23);
            this.txtTitulo.TabIndex = 1;
            // 
            // rbtAnual
            // 
            this.rbtAnual.AutoSize = true;
            this.rbtAnual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtAnual.Location = new System.Drawing.Point(415, 267);
            this.rbtAnual.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbtAnual.Name = "rbtAnual";
            this.rbtAnual.Size = new System.Drawing.Size(62, 21);
            this.rbtAnual.TabIndex = 6;
            this.rbtAnual.TabStop = true;
            this.rbtAnual.Text = "Anual";
            this.rbtAnual.UseVisualStyleBackColor = true;
            // 
            // lstCarreras
            // 
            this.lstCarreras.FormattingEnabled = true;
            this.lstCarreras.ItemHeight = 15;
            this.lstCarreras.Location = new System.Drawing.Point(605, 69);
            this.lstCarreras.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstCarreras.Name = "lstCarreras";
            this.lstCarreras.Size = new System.Drawing.Size(446, 259);
            this.lstCarreras.Sorted = true;
            this.lstCarreras.TabIndex = 10;
            this.lstCarreras.SelectedIndexChanged += new System.EventHandler(this.lstCarreras_SelectedIndexChanged);
            this.lstCarreras.LostFocus += new System.EventHandler(this.lstCarreras_LostFocus);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModificar.Location = new System.Drawing.Point(719, 348);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(92, 32);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQuitar.Location = new System.Drawing.Point(852, 348);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(92, 32);
            this.btnQuitar.TabIndex = 12;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // dgvAsignaturas
            // 
            this.dgvAsignaturas.AllowUserToAddRows = false;
            this.dgvAsignaturas.AllowUserToDeleteRows = false;
            this.dgvAsignaturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsignaturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.nombre,
            this.año,
            this.cuatrimestre,
            this.quitar});
            this.dgvAsignaturas.Location = new System.Drawing.Point(14, 374);
            this.dgvAsignaturas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvAsignaturas.Name = "dgvAsignaturas";
            this.dgvAsignaturas.Size = new System.Drawing.Size(580, 239);
            this.dgvAsignaturas.TabIndex = 21;
            this.dgvAsignaturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsignaturas_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Visible = false;
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.Width = 76;
            // 
            // año
            // 
            this.año.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.año.DefaultCellStyle = dataGridViewCellStyle1;
            this.año.HeaderText = "Año";
            this.año.Name = "año";
            this.año.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.año.Width = 54;
            // 
            // cuatrimestre
            // 
            this.cuatrimestre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cuatrimestre.HeaderText = "Cuatrimestre";
            this.cuatrimestre.Name = "cuatrimestre";
            this.cuatrimestre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // quitar
            // 
            this.quitar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.quitar.HeaderText = "Quitar";
            this.quitar.Name = "quitar";
            this.quitar.Text = "Quitar";
            this.quitar.UseColumnTextForButtonValue = true;
            this.quitar.Width = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(748, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Lista de Carreras";
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVolver.Location = new System.Drawing.Point(909, 609);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(142, 54);
            this.btnVolver.TabIndex = 23;
            this.btnVolver.Text = "Volver al Menú Principal";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmCarreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 677);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAsignaturas);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lstCarreras);
            this.Controls.Add(this.rbtAnual);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.nudAño);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblCuatrimestre);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.rbt2C);
            this.Controls.Add(this.rbt1C);
            this.Controls.Add(this.cboAsignatura);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblAsignatura);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.lblNomCarrera);
            this.Controls.Add(this.lblIdCarrera);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmCarreras";
            this.Text = "Nueva Carrera";
            this.Load += new System.EventHandler(this.Alta_Carreras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAño)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignaturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblIdCarrera;
        private System.Windows.Forms.Label lblNomCarrera;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.Label lblAsignatura;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cboAsignatura;
        private System.Windows.Forms.RadioButton rbt1C;
        private System.Windows.Forms.RadioButton rbt2C;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblCuatrimestre;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.NumericUpDown nudAño;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.RadioButton rbtAnual;
        private System.Windows.Forms.ListBox lstCarreras;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.DataGridView dgvAsignaturas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn año;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuatrimestre;
        private System.Windows.Forms.DataGridViewButtonColumn quitar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVolver;
    }
}