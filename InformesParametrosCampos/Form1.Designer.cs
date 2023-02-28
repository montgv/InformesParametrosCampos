namespace InformesParametrosCampos
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
            this.clientesCochesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetConcesionario = new InformesParametrosCampos.DataSetConcesionario();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lbBuscadorMarca = new System.Windows.Forms.Label();
            this.tbMarcaBuscar = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.clientesCochesTableAdapter = new InformesParametrosCampos.DataSetConcesionarioTableAdapters.ClientesCochesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.clientesCochesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetConcesionario)).BeginInit();
            this.SuspendLayout();
            // 
            // clientesCochesBindingSource
            // 
            this.clientesCochesBindingSource.DataMember = "ClientesCoches";
            this.clientesCochesBindingSource.DataSource = this.dataSetConcesionario;
            // 
            // dataSetConcesionario
            // 
            this.dataSetConcesionario.DataSetName = "DataSetConcesionario";
            this.dataSetConcesionario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.clientesCochesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "InformesParametrosCampos.ReportClientesCoches.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(23, 94);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(917, 368);
            this.reportViewer1.TabIndex = 0;
            // 
            // lbBuscadorMarca
            // 
            this.lbBuscadorMarca.AutoSize = true;
            this.lbBuscadorMarca.Location = new System.Drawing.Point(34, 39);
            this.lbBuscadorMarca.Name = "lbBuscadorMarca";
            this.lbBuscadorMarca.Size = new System.Drawing.Size(142, 20);
            this.lbBuscadorMarca.TabIndex = 1;
            this.lbBuscadorMarca.Text = "Buscar por Marca: ";
            // 
            // tbMarcaBuscar
            // 
            this.tbMarcaBuscar.Location = new System.Drawing.Point(193, 33);
            this.tbMarcaBuscar.Name = "tbMarcaBuscar";
            this.tbMarcaBuscar.Size = new System.Drawing.Size(240, 26);
            this.tbMarcaBuscar.TabIndex = 2;
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(504, 29);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(126, 40);
            this.btBuscar.TabIndex = 3;
            this.btBuscar.Text = "BUSCAR";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // clientesCochesTableAdapter
            // 
            this.clientesCochesTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 491);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.tbMarcaBuscar);
            this.Controls.Add(this.lbBuscadorMarca);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientesCochesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetConcesionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label lbBuscadorMarca;
        private System.Windows.Forms.TextBox tbMarcaBuscar;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.BindingSource clientesCochesBindingSource;
        private DataSetConcesionario dataSetConcesionario;
        private DataSetConcesionarioTableAdapters.ClientesCochesTableAdapter clientesCochesTableAdapter;
    }
}

