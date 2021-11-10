
namespace WindowsFormsApp2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAsignaturas = new System.Windows.Forms.Button();
            this.btnCarreras = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reportes UTN";
            // 
            // btnAsignaturas
            // 
            this.btnAsignaturas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(125)))), ((int)(((byte)(192)))));
            this.btnAsignaturas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAsignaturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignaturas.Font = new System.Drawing.Font("Quicksand Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignaturas.ForeColor = System.Drawing.Color.White;
            this.btnAsignaturas.Location = new System.Drawing.Point(53, 102);
            this.btnAsignaturas.Name = "btnAsignaturas";
            this.btnAsignaturas.Size = new System.Drawing.Size(116, 37);
            this.btnAsignaturas.TabIndex = 1;
            this.btnAsignaturas.Text = "Asignaturas";
            this.btnAsignaturas.UseVisualStyleBackColor = false;
            this.btnAsignaturas.Click += new System.EventHandler(this.btnAsignaturas_Click);
            // 
            // btnCarreras
            // 
            this.btnCarreras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(125)))), ((int)(((byte)(192)))));
            this.btnCarreras.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCarreras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarreras.Font = new System.Drawing.Font("Quicksand Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarreras.ForeColor = System.Drawing.Color.White;
            this.btnCarreras.Location = new System.Drawing.Point(53, 171);
            this.btnCarreras.Name = "btnCarreras";
            this.btnCarreras.Size = new System.Drawing.Size(116, 37);
            this.btnCarreras.TabIndex = 2;
            this.btnCarreras.Text = "Carreras";
            this.btnCarreras.UseVisualStyleBackColor = false;
            this.btnCarreras.Click += new System.EventHandler(this.btnCarreras_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Quicksand Medium", 10F);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(131, 255);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 40);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(99)))), ((int)(((byte)(184)))));
            this.ClientSize = new System.Drawing.Size(223, 298);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCarreras);
            this.Controls.Add(this.btnAsignaturas);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAsignaturas;
        private System.Windows.Forms.Button btnCarreras;
        private System.Windows.Forms.Button btnSalir;
    }
}

