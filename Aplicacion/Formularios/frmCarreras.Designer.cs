
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudAño)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignaturas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIdCarrera
            // 
            this.lblIdCarrera.AutoSize = true;
            this.lblIdCarrera.Font = new System.Drawing.Font("Quicksand Medium", 15.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIdCarrera.ForeColor = System.Drawing.Color.White;
            this.lblIdCarrera.Location = new System.Drawing.Point(167, 1);
            this.lblIdCarrera.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdCarrera.Name = "lblIdCarrera";
            this.lblIdCarrera.Size = new System.Drawing.Size(210, 31);
            this.lblIdCarrera.TabIndex = 1;
            this.lblIdCarrera.Text = "Datos de la Carrera";
            // 
            // lblNomCarrera
            // 
            this.lblNomCarrera.AutoSize = true;
            this.lblNomCarrera.Font = new System.Drawing.Font("Quicksand", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNomCarrera.ForeColor = System.Drawing.Color.White;
            this.lblNomCarrera.Location = new System.Drawing.Point(60, 32);
            this.lblNomCarrera.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomCarrera.Name = "lblNomCarrera";
            this.lblNomCarrera.Size = new System.Drawing.Size(62, 21);
            this.lblNomCarrera.TabIndex = 2;
            this.lblNomCarrera.Text = "Nombre";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Font = new System.Drawing.Font("Quicksand", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAño.ForeColor = System.Drawing.Color.White;
            this.lblAño.Location = new System.Drawing.Point(87, 140);
            this.lblAño.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(35, 21);
            this.lblAño.TabIndex = 3;
            this.lblAño.Text = "Año";
            // 
            // lblAsignatura
            // 
            this.lblAsignatura.AutoSize = true;
            this.lblAsignatura.Font = new System.Drawing.Font("Quicksand", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAsignatura.ForeColor = System.Drawing.Color.White;
            this.lblAsignatura.Location = new System.Drawing.Point(42, 104);
            this.lblAsignatura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAsignatura.Name = "lblAsignatura";
            this.lblAsignatura.Size = new System.Drawing.Size(80, 21);
            this.lblAsignatura.TabIndex = 4;
            this.lblAsignatura.Text = "Asignatura";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Quicksand", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.Location = new System.Drawing.Point(130, 29);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(388, 24);
            this.txtNombre.TabIndex = 0;
            // 
            // cboAsignatura
            // 
            this.cboAsignatura.Font = new System.Drawing.Font("Quicksand", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboAsignatura.FormattingEnabled = true;
            this.cboAsignatura.Location = new System.Drawing.Point(131, 101);
            this.cboAsignatura.Margin = new System.Windows.Forms.Padding(4);
            this.cboAsignatura.Name = "cboAsignatura";
            this.cboAsignatura.Size = new System.Drawing.Size(387, 27);
            this.cboAsignatura.TabIndex = 2;
            // 
            // rbt1C
            // 
            this.rbt1C.AutoSize = true;
            this.rbt1C.Font = new System.Drawing.Font("Quicksand", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbt1C.ForeColor = System.Drawing.Color.White;
            this.rbt1C.Location = new System.Drawing.Point(343, 137);
            this.rbt1C.Margin = new System.Windows.Forms.Padding(4);
            this.rbt1C.Name = "rbt1C";
            this.rbt1C.Size = new System.Drawing.Size(134, 25);
            this.rbt1C.TabIndex = 4;
            this.rbt1C.TabStop = true;
            this.rbt1C.Text = "1er Cuatrimestre";
            this.rbt1C.UseVisualStyleBackColor = true;
            // 
            // rbt2C
            // 
            this.rbt2C.AutoSize = true;
            this.rbt2C.Font = new System.Drawing.Font("Quicksand", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbt2C.ForeColor = System.Drawing.Color.White;
            this.rbt2C.Location = new System.Drawing.Point(343, 165);
            this.rbt2C.Margin = new System.Windows.Forms.Padding(4);
            this.rbt2C.Name = "rbt2C";
            this.rbt2C.Size = new System.Drawing.Size(140, 25);
            this.rbt2C.TabIndex = 5;
            this.rbt2C.TabStop = true;
            this.rbt2C.Text = "2do Cuatrimestre";
            this.rbt2C.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Quicksand", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(175, 220);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(182, 29);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar Asignatura";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblCuatrimestre
            // 
            this.lblCuatrimestre.AutoSize = true;
            this.lblCuatrimestre.Font = new System.Drawing.Font("Quicksand", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCuatrimestre.ForeColor = System.Drawing.Color.White;
            this.lblCuatrimestre.Location = new System.Drawing.Point(226, 140);
            this.lblCuatrimestre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCuatrimestre.Name = "lblCuatrimestre";
            this.lblCuatrimestre.Size = new System.Drawing.Size(94, 21);
            this.lblCuatrimestre.TabIndex = 11;
            this.lblCuatrimestre.Text = "Cuatrimestre";
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Quicksand", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(282, 474);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(92, 28);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Quicksand", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(158, 474);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 28);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // nudAño
            // 
            this.nudAño.Font = new System.Drawing.Font("Quicksand", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudAño.Location = new System.Drawing.Point(131, 138);
            this.nudAño.Margin = new System.Windows.Forms.Padding(4);
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
            this.nudAño.Size = new System.Drawing.Size(58, 24);
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
            this.lblTitulo.Font = new System.Drawing.Font("Quicksand", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(11, 68);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(111, 21);
            this.lblTitulo.TabIndex = 15;
            this.lblTitulo.Text = "Título Otorgado";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Quicksand", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTitulo.Location = new System.Drawing.Point(130, 65);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(388, 24);
            this.txtTitulo.TabIndex = 1;
            // 
            // rbtAnual
            // 
            this.rbtAnual.AutoSize = true;
            this.rbtAnual.Font = new System.Drawing.Font("Quicksand", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtAnual.ForeColor = System.Drawing.Color.White;
            this.rbtAnual.Location = new System.Drawing.Point(343, 193);
            this.rbtAnual.Margin = new System.Windows.Forms.Padding(4);
            this.rbtAnual.Name = "rbtAnual";
            this.rbtAnual.Size = new System.Drawing.Size(64, 25);
            this.rbtAnual.TabIndex = 6;
            this.rbtAnual.TabStop = true;
            this.rbtAnual.Text = "Anual";
            this.rbtAnual.UseVisualStyleBackColor = true;
            // 
            // lstCarreras
            // 
            this.lstCarreras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(125)))), ((int)(((byte)(192)))));
            this.lstCarreras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstCarreras.Font = new System.Drawing.Font("Quicksand", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstCarreras.ForeColor = System.Drawing.Color.White;
            this.lstCarreras.FormattingEnabled = true;
            this.lstCarreras.HorizontalScrollbar = true;
            this.lstCarreras.ItemHeight = 19;
            this.lstCarreras.Location = new System.Drawing.Point(1, 13);
            this.lstCarreras.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstCarreras.Name = "lstCarreras";
            this.lstCarreras.ScrollAlwaysVisible = true;
            this.lstCarreras.Size = new System.Drawing.Size(276, 399);
            this.lstCarreras.Sorted = true;
            this.lstCarreras.TabIndex = 10;
            this.lstCarreras.SelectedIndexChanged += new System.EventHandler(this.lstCarreras_SelectedIndexChanged);
            this.lstCarreras.LostFocus += new System.EventHandler(this.lstCarreras_LostFocus);
            // 
            // btnModificar
            // 
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Quicksand", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(38, 417);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(92, 38);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.FlatAppearance.BorderSize = 0;
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.Font = new System.Drawing.Font("Quicksand", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQuitar.ForeColor = System.Drawing.Color.White;
            this.btnQuitar.Location = new System.Drawing.Point(146, 417);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(92, 38);
            this.btnQuitar.TabIndex = 12;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // dgvAsignaturas
            // 
            this.dgvAsignaturas.AllowUserToAddRows = false;
            this.dgvAsignaturas.AllowUserToDeleteRows = false;
            this.dgvAsignaturas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(190)))), ((int)(((byte)(227)))));
            this.dgvAsignaturas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAsignaturas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(108)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Quicksand", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(125)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAsignaturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAsignaturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsignaturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.nombre,
            this.año,
            this.cuatrimestre,
            this.quitar});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Quicksand", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAsignaturas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAsignaturas.Location = new System.Drawing.Point(13, 260);
            this.dgvAsignaturas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAsignaturas.Name = "dgvAsignaturas";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Quicksand", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAsignaturas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAsignaturas.RowHeadersVisible = false;
            this.dgvAsignaturas.Size = new System.Drawing.Size(507, 206);
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
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.Width = 270;
            // 
            // año
            // 
            this.año.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.año.DefaultCellStyle = dataGridViewCellStyle2;
            this.año.HeaderText = "Año";
            this.año.Name = "año";
            this.año.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.año.Width = 60;
            // 
            // cuatrimestre
            // 
            this.cuatrimestre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cuatrimestre.HeaderText = "Cuatrimestre";
            this.cuatrimestre.Name = "cuatrimestre";
            this.cuatrimestre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.cuatrimestre.Width = 119;
            // 
            // quitar
            // 
            this.quitar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.quitar.HeaderText = "Quitar";
            this.quitar.Name = "quitar";
            this.quitar.Text = "Quitar";
            this.quitar.UseColumnTextForButtonValue = true;
            this.quitar.Width = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand Medium", 15.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(588, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 31);
            this.label1.TabIndex = 22;
            this.label1.Text = "Lista de Carreras";
            // 
            // btnVolver
            // 
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Quicksand Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(545, 495);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(274, 39);
            this.btnVolver.TabIndex = 23;
            this.btnVolver.Text = "Volver al Menú Principal";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(125)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.lblAsignatura);
            this.groupBox1.Controls.Add(this.lblNomCarrera);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.dgvAsignaturas);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.cboAsignatura);
            this.groupBox1.Controls.Add(this.lblTitulo);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.txtTitulo);
            this.groupBox1.Controls.Add(this.lblAño);
            this.groupBox1.Controls.Add(this.rbtAnual);
            this.groupBox1.Controls.Add(this.rbt1C);
            this.groupBox1.Controls.Add(this.nudAño);
            this.groupBox1.Controls.Add(this.rbt2C);
            this.groupBox1.Controls.Add(this.lblCuatrimestre);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(6, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(532, 513);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(125)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.lstCarreras);
            this.groupBox2.Controls.Add(this.btnModificar);
            this.groupBox2.Controls.Add(this.btnQuitar);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(543, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 463);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            // 
            // frmCarreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(99)))), ((int)(((byte)(184)))));
            this.ClientSize = new System.Drawing.Size(825, 542);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblIdCarrera);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Quicksand", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCarreras";
            this.ShowIcon = false;
            this.Text = "Gestor de Carreras";
            this.Load += new System.EventHandler(this.Alta_Carreras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAño)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignaturas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn año;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuatrimestre;
        private System.Windows.Forms.DataGridViewButtonColumn quitar;
    }
}