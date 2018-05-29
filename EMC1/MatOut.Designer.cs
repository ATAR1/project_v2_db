namespace EMC1
{
    partial class MatOut
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
            System.Windows.Forms.Label id_matLabel;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.BindingSource outMaterialBindingSource;
            EMC1.DataSetEMC1 dataSetEMC1;
            this.jobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sharedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbStorage = new System.Windows.Forms.ComboBox();
            this.storageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btAdd = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txbCol = new System.Windows.Forms.TextBox();
            this.gET_CURENT_STORAGEDataGridView = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Количеество = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.full_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.storedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbJob = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.jobTableAdapter = new EMC1.DataSetEMC1TableAdapters.JobTableAdapter();
            this.outMaterialTableAdapter = new EMC1.DataSetEMC1TableAdapters.OutMaterialTableAdapter();
            this.storageTableAdapter = new EMC1.DataSetEMC1TableAdapters.StorageTableAdapter();
            this.storedTableAdapter = new EMC1.DataSetEMC1TableAdapters.StoredTableAdapter();
            this.tableAdapterManager = new EMC1.DataSetEMC1TableAdapters.TableAdapterManager();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storemanIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storageIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recipientIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            id_matLabel = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            outMaterialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            dataSetEMC1 = new EMC1.DataSetEMC1();
            ((System.ComponentModel.ISupportInitialize)(outMaterialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dataSetEMC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_CURENT_STORAGEDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storedBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // id_matLabel
            // 
            id_matLabel.AutoSize = true;
            id_matLabel.Location = new System.Drawing.Point(19, 137);
            id_matLabel.Name = "id_matLabel";
            id_matLabel.Size = new System.Drawing.Size(60, 13);
            id_matLabel.TabIndex = 11;
            id_matLabel.Text = "Материал:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(27, 182);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(52, 13);
            label5.TabIndex = 20;
            label5.Text = "Остатки:";
            // 
            // outMaterialBindingSource
            // 
            outMaterialBindingSource.DataMember = "FK_OutMaterial_Job";
            outMaterialBindingSource.DataSource = this.jobBindingSource;
            // 
            // jobBindingSource
            // 
            this.jobBindingSource.DataMember = "Job";
            this.jobBindingSource.DataSource = this.sharedBindingSource;
            // 
            // sharedBindingSource
            // 
            this.sharedBindingSource.DataSource = dataSetEMC1;
            this.sharedBindingSource.Position = 0;
            // 
            // dataSetEMC1
            // 
            dataSetEMC1.DataSetName = "DataSetEMC1";
            dataSetEMC1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата:";
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(85, 20);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(121, 20);
            this.dtp.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Наряд:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Склад:";
            // 
            // cmbStorage
            // 
            this.cmbStorage.DataSource = this.storageBindingSource;
            this.cmbStorage.DisplayMember = "Name";
            this.cmbStorage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStorage.FormattingEnabled = true;
            this.cmbStorage.Location = new System.Drawing.Point(85, 95);
            this.cmbStorage.Name = "cmbStorage";
            this.cmbStorage.Size = new System.Drawing.Size(121, 21);
            this.cmbStorage.TabIndex = 5;
            this.cmbStorage.ValueMember = "Id";
            // 
            // storageBindingSource
            // 
            this.storageBindingSource.DataMember = "Storage";
            this.storageBindingSource.DataSource = this.sharedBindingSource;
            // 
            // btAdd
            // 
            this.btAdd.Image = global::EMC1.Properties.Resources.add;
            this.btAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAdd.Location = new System.Drawing.Point(235, 21);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(95, 23);
            this.btAdd.TabIndex = 6;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btOut_Click);
            // 
            // btDelete
            // 
            this.btDelete.Image = global::EMC1.Properties.Resources.remove;
            this.btDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDelete.Location = new System.Drawing.Point(235, 59);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(95, 23);
            this.btDelete.TabIndex = 7;
            this.btDelete.Text = "Удалить";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Количество:";
            // 
            // txbCol
            // 
            this.txbCol.Location = new System.Drawing.Point(85, 213);
            this.txbCol.Name = "txbCol";
            this.txbCol.Size = new System.Drawing.Size(121, 20);
            this.txbCol.TabIndex = 9;
            // 
            // gET_CURENT_STORAGEDataGridView
            // 
            this.gET_CURENT_STORAGEDataGridView.AllowUserToAddRows = false;
            this.gET_CURENT_STORAGEDataGridView.AllowUserToDeleteRows = false;
            this.gET_CURENT_STORAGEDataGridView.AutoGenerateColumns = false;
            this.gET_CURENT_STORAGEDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gET_CURENT_STORAGEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gET_CURENT_STORAGEDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.Количеество,
            this.full_name,
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.materialIdDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn,
            this.storemanIdDataGridViewTextBoxColumn,
            this.jobIdDataGridViewTextBoxColumn,
            this.storageIdDataGridViewTextBoxColumn,
            this.recipientIdDataGridViewTextBoxColumn});
            this.gET_CURENT_STORAGEDataGridView.DataSource = outMaterialBindingSource;
            this.gET_CURENT_STORAGEDataGridView.Location = new System.Drawing.Point(361, 20);
            this.gET_CURENT_STORAGEDataGridView.Name = "gET_CURENT_STORAGEDataGridView";
            this.gET_CURENT_STORAGEDataGridView.ReadOnly = true;
            this.gET_CURENT_STORAGEDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gET_CURENT_STORAGEDataGridView.Size = new System.Drawing.Size(413, 220);
            this.gET_CURENT_STORAGEDataGridView.TabIndex = 11;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.name.DataPropertyName = "MaterialId";
            this.name.Frozen = true;
            this.name.HeaderText = "Материал";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // Количеество
            // 
            this.Количеество.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Количеество.DataPropertyName = "Count";
            this.Количеество.Frozen = true;
            this.Количеество.HeaderText = "Кол-во";
            this.Количеество.Name = "Количеество";
            this.Количеество.ReadOnly = true;
            // 
            // full_name
            // 
            this.full_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.full_name.DataPropertyName = "MaterialId";
            this.full_name.Frozen = true;
            this.full_name.HeaderText = "ед. изм. ";
            this.full_name.Name = "full_name";
            this.full_name.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(715, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.DataSource = this.storedBindingSource;
            this.cmbMaterial.DisplayMember = "MaterialId";
            this.cmbMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(86, 137);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(121, 21);
            this.cmbMaterial.TabIndex = 18;
            this.cmbMaterial.ValueMember = "MaterialId";
            // 
            // storedBindingSource
            // 
            this.storedBindingSource.DataMember = "FK_Stored_Storage";
            this.storedBindingSource.DataSource = this.storageBindingSource;
            // 
            // cmbJob
            // 
            this.cmbJob.DataSource = this.jobBindingSource;
            this.cmbJob.DisplayMember = "Id";
            this.cmbJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJob.FormattingEnabled = true;
            this.cmbJob.Location = new System.Drawing.Point(85, 56);
            this.cmbJob.Name = "cmbJob";
            this.cmbJob.Size = new System.Drawing.Size(121, 21);
            this.cmbJob.TabIndex = 22;
            this.cmbJob.ValueMember = "Id";
            // 
            // button2
            // 
            this.button2.Image = global::EMC1.Properties.Resources.save_16;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(608, 350);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storedBindingSource, "Count", true));
            this.label6.Location = new System.Drawing.Point(85, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "0";
            // 
            // jobTableAdapter
            // 
            this.jobTableAdapter.ClearBeforeFill = true;
            // 
            // outMaterialTableAdapter
            // 
            this.outMaterialTableAdapter.ClearBeforeFill = true;
            // 
            // storageTableAdapter
            // 
            this.storageTableAdapter.ClearBeforeFill = true;
            // 
            // storedTableAdapter
            // 
            this.storedTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.ContrTableAdapter = null;
            this.tableAdapterManager.EmployeTableAdapter = null;
            this.tableAdapterManager.InMaterialTableAdapter = null;
            this.tableAdapterManager.JobTableAdapter = null;
            this.tableAdapterManager.JobTypeTableAdapter = null;
            this.tableAdapterManager.MaterialTableAdapter = null;
            this.tableAdapterManager.OutMaterialTableAdapter = null;
            this.tableAdapterManager.StorageTableAdapter = null;
            this.tableAdapterManager.StoredTableAdapter = null;
            this.tableAdapterManager.UnitTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = EMC1.DataSetEMC1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserRoleTableAdapter = null;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materialIdDataGridViewTextBoxColumn
            // 
            this.materialIdDataGridViewTextBoxColumn.DataPropertyName = "MaterialId";
            this.materialIdDataGridViewTextBoxColumn.HeaderText = "MaterialId";
            this.materialIdDataGridViewTextBoxColumn.Name = "materialIdDataGridViewTextBoxColumn";
            this.materialIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Count";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // storemanIdDataGridViewTextBoxColumn
            // 
            this.storemanIdDataGridViewTextBoxColumn.DataPropertyName = "StoremanId";
            this.storemanIdDataGridViewTextBoxColumn.HeaderText = "StoremanId";
            this.storemanIdDataGridViewTextBoxColumn.Name = "storemanIdDataGridViewTextBoxColumn";
            this.storemanIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jobIdDataGridViewTextBoxColumn
            // 
            this.jobIdDataGridViewTextBoxColumn.DataPropertyName = "JobId";
            this.jobIdDataGridViewTextBoxColumn.HeaderText = "JobId";
            this.jobIdDataGridViewTextBoxColumn.Name = "jobIdDataGridViewTextBoxColumn";
            this.jobIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // storageIdDataGridViewTextBoxColumn
            // 
            this.storageIdDataGridViewTextBoxColumn.DataPropertyName = "StorageId";
            this.storageIdDataGridViewTextBoxColumn.HeaderText = "StorageId";
            this.storageIdDataGridViewTextBoxColumn.Name = "storageIdDataGridViewTextBoxColumn";
            this.storageIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // recipientIdDataGridViewTextBoxColumn
            // 
            this.recipientIdDataGridViewTextBoxColumn.DataPropertyName = "RecipientId";
            this.recipientIdDataGridViewTextBoxColumn.HeaderText = "RecipientId";
            this.recipientIdDataGridViewTextBoxColumn.Name = "recipientIdDataGridViewTextBoxColumn";
            this.recipientIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MatOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 397);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmbJob);
            this.Controls.Add(label5);
            this.Controls.Add(this.cmbMaterial);
            this.Controls.Add(this.button1);
            this.Controls.Add(id_matLabel);
            this.Controls.Add(this.gET_CURENT_STORAGEDataGridView);
            this.Controls.Add(this.txbCol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.cmbStorage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MatOut";
            this.Text = "Выдача материала";
            this.Load += new System.EventHandler(this.MatOut_Load);
            ((System.ComponentModel.ISupportInitialize)(outMaterialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dataSetEMC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_CURENT_STORAGEDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storedBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbStorage;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbCol;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.ComboBox cmbJob;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView gET_CURENT_STORAGEDataGridView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource jobBindingSource;
        private DataSetEMC1TableAdapters.JobTableAdapter jobTableAdapter;
        private DataSetEMC1TableAdapters.TableAdapterManager tableAdapterManager;
        private DataSetEMC1TableAdapters.OutMaterialTableAdapter outMaterialTableAdapter;
        private DataSetEMC1TableAdapters.StorageTableAdapter storageTableAdapter;
        private System.Windows.Forms.BindingSource storageBindingSource;
        private DataSetEMC1TableAdapters.StoredTableAdapter storedTableAdapter;
        private System.Windows.Forms.BindingSource storedBindingSource;
        private System.Windows.Forms.BindingSource sharedBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn planJobIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Количеество;
        private System.Windows.Forms.DataGridViewTextBoxColumn full_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storemanIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storageIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recipientIdDataGridViewTextBoxColumn;
    }
}