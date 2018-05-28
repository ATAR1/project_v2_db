namespace EMC1
{
    partial class REP_NARYAD
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetEMC1 = new EMC1.DataSetEMC1();
            this.gET_REP_NARYADBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.gET_REP_NARYADTableAdapter = new EMC1.DataSetEMC1TableAdapters.GET_REP_NARYADTableAdapter();
            this.tableAdapterManager = new EMC1.DataSetEMC1TableAdapters.TableAdapterManager();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEMC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_REP_NARYADBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 36);
            this.panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Запланировано",
            "Выдано"});
            this.comboBox1.Location = new System.Drawing.Point(613, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(527, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Статус наряда:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 36);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(754, 433);
            this.reportViewer1.TabIndex = 1;
            // 
            // dataSetEMC1
            // 
            this.dataSetEMC1.DataSetName = "DataSetEMC1";
            this.dataSetEMC1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gET_REP_NARYADBindingSource
            // 
            this.gET_REP_NARYADBindingSource.DataMember = "GET_REP_NARYAD";
            this.gET_REP_NARYADBindingSource.DataSource = this.dataSetEMC1;
            // 
            // gET_REP_NARYADTableAdapter
            // 
            //this.gET_REP_NARYADTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.EmployeTableAdapter = null;
            this.tableAdapterManager.JobTypeTableAdapter = null;
            this.tableAdapterManager.ContrTableAdapter = null;
            this.tableAdapterManager.MaterialTableAdapter = null;
            this.tableAdapterManager.JobTableAdapter = null;
            this.tableAdapterManager.StoredTableAdapter = null;
            this.tableAdapterManager.StorageTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = EMC1.DataSetEMC1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserRoleTableAdapter = null;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // REP_NARYAD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 469);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Name = "REP_NARYAD";
            this.Text = "Отчет по нарядам";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEMC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_REP_NARYADBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSetEMC1 dataSetEMC1;
        private System.Windows.Forms.BindingSource gET_REP_NARYADBindingSource;
        //private DataSetEMC1TableAdapters.GET_REP_NARYADTableAdapter gET_REP_NARYADTableAdapter;
        private DataSetEMC1TableAdapters.TableAdapterManager tableAdapterManager;
    }
}