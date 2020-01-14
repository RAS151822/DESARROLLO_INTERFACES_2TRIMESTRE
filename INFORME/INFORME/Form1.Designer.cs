namespace INFORME
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.worldDataSet = new INFORME.worldDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cityTableAdapter = new INFORME.worldDataSetTableAdapters.cityTableAdapter();
            this.worldDataSet1 = new INFORME.worldDataSet1();
            this.countrylanguageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countrylanguageTableAdapter = new INFORME.worldDataSet1TableAdapters.countrylanguageTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countrylanguageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataMember = "city";
            this.cityBindingSource.DataSource = this.worldDataSet;
            // 
            // worldDataSet
            // 
            this.worldDataSet.DataSetName = "worldDataSet";
            this.worldDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.cityBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.countrylanguageBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "INFORME.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(798, 449);
            this.reportViewer1.TabIndex = 0;
            // 
            // cityTableAdapter
            // 
            this.cityTableAdapter.ClearBeforeFill = true;
            // 
            // worldDataSet1
            // 
            this.worldDataSet1.DataSetName = "worldDataSet1";
            this.worldDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // countrylanguageBindingSource
            // 
            this.countrylanguageBindingSource.DataMember = "countrylanguage";
            this.countrylanguageBindingSource.DataSource = this.worldDataSet1;
            // 
            // countrylanguageTableAdapter
            // 
            this.countrylanguageTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countrylanguageBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private worldDataSet worldDataSet;
        private worldDataSetTableAdapters.cityTableAdapter cityTableAdapter;
        private worldDataSet1 worldDataSet1;
        private System.Windows.Forms.BindingSource countrylanguageBindingSource;
        private worldDataSet1TableAdapters.countrylanguageTableAdapter countrylanguageTableAdapter;
    }
}

