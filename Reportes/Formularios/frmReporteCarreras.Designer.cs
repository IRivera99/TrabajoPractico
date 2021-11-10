
namespace WindowsFormsApp2.Formularios
{
    partial class frmReporteCarreras
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dataTable1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dSCarreras1 = new WindowsFormsApp2.Reportes.DSCarreras();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dSCarreras = new WindowsFormsApp2.Reportes.DSCarreras();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter = new WindowsFormsApp2.Reportes.DSCarrerasTableAdapters.DataTable1TableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCarreras1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCarreras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTable1BindingSource1
            // 
            this.dataTable1BindingSource1.DataMember = "DataTable1";
            this.dataTable1BindingSource1.DataSource = this.dSCarreras1;
            // 
            // dSCarreras1
            // 
            this.dSCarreras1.DataSetName = "DSCarreras";
            this.dSCarreras1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(190)))), ((int)(((byte)(227)))));
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewer1.Font = new System.Drawing.Font("Quicksand", 10F);
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.dataTable1BindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp2.Reportes.rptCarreras2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 59);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(845, 302);
            this.reportViewer1.TabIndex = 0;
            // 
            // dSCarreras
            // 
            this.dSCarreras.DataSetName = "DSCarreras";
            this.dSCarreras.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.dSCarreras;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand Medium", 20F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(290, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listado de carreras";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Quicksand Medium", 10F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(744, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmReporteCarreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(99)))), ((int)(((byte)(184)))));
            this.ClientSize = new System.Drawing.Size(845, 428);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReporteCarreras";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carreras";
            this.Load += new System.EventHandler(this.frmReporteCarreras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCarreras1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCarreras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Reportes.DSCarreras dSCarreras;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private Reportes.DSCarrerasTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private Reportes.DSCarreras dSCarreras1;
        private System.Windows.Forms.BindingSource dataTable1BindingSource1;
    }
}