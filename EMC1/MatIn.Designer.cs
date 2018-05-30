namespace EMC1
{
    partial class MatIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatIn));
            this.cmbMat = new System.Windows.Forms.ComboBox();
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sharedDataSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetEMC1 = new EMC1.DataSetEMC1();
            this.label1 = new System.Windows.Forms.Label();
            this.materialTableAdapter = new EMC1.DataSetEMC1TableAdapters.MaterialTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbStorage = new System.Windows.Forms.ComboBox();
            this.storageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storageTableAdapter = new EMC1.DataSetEMC1TableAdapters.StorageTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.txbCol = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.contrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contrTableAdapter = new EMC1.DataSetEMC1TableAdapters.ContrTableAdapter();
            this.storedTableAdapter1 = new EMC1.DataSetEMC1TableAdapters.StoredTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.unitTableAdapter1 = new EMC1.DataSetEMC1TableAdapters.UnitTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharedDataSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEMC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMat
            // 
            this.cmbMat.DataSource = this.materialBindingSource;
            this.cmbMat.DisplayMember = "name";
            this.cmbMat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMat.FormattingEnabled = true;
            this.cmbMat.Location = new System.Drawing.Point(124, 41);
            this.cmbMat.Name = "cmbMat";
            this.cmbMat.Size = new System.Drawing.Size(205, 21);
            this.cmbMat.TabIndex = 0;
            this.cmbMat.ValueMember = "id_mat";
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataMember = "Material";
            this.materialBindingSource.DataSource = this.sharedDataSource;
            // 
            // sharedDataSource
            // 
            this.sharedDataSource.DataSource = this.dataSetEMC1;
            this.sharedDataSource.Position = 0;
            // 
            // dataSetEMC1
            // 
            this.dataSetEMC1.DataSetName = "DataSetEMC1";
            this.dataSetEMC1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выбрать материал:";
            // 
            // materialTableAdapter
            // 
            this.materialTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Выбрать склад:";
            // 
            // cmbStorage
            // 
            this.cmbStorage.DataSource = this.storageBindingSource;
            this.cmbStorage.DisplayMember = "name";
            this.cmbStorage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStorage.FormattingEnabled = true;
            this.cmbStorage.Location = new System.Drawing.Point(124, 70);
            this.cmbStorage.Name = "cmbStorage";
            this.cmbStorage.Size = new System.Drawing.Size(205, 21);
            this.cmbStorage.TabIndex = 3;
            this.cmbStorage.ValueMember = "id_storage";
            // 
            // storageBindingSource
            // 
            this.storageBindingSource.DataMember = "Storage";
            this.storageBindingSource.DataSource = this.sharedDataSource;
            // 
            // storageTableAdapter
            // 
            this.storageTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Количество:";
            // 
            // txbCol
            // 
            this.txbCol.Location = new System.Drawing.Point(124, 98);
            this.txbCol.Name = "txbCol";
            this.txbCol.Size = new System.Drawing.Size(165, 20);
            this.txbCol.TabIndex = 5;
            this.txbCol.Text = "0";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(226, 124);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(103, 23);
            this.btSave.TabIndex = 6;
            this.btSave.Text = "Сохранить";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(124, 124);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(96, 23);
            this.btCancel.TabIndex = 7;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Поставщик:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.contrBindingSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(124, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(205, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.ValueMember = "Id";
            // 
            // contrBindingSource
            // 
            this.contrBindingSource.DataMember = "Contr";
            this.contrBindingSource.DataSource = this.sharedDataSource;
            // 
            // contrTableAdapter
            // 
            this.contrTableAdapter.ClearBeforeFill = true;
            // 
            // storedTableAdapter1
            // 
            this.storedTableAdapter1.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(393, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 151);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // unitTableAdapter1
            // 
            this.unitTableAdapter1.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialBindingSource, "UnitShortName", true));
            this.label4.Location = new System.Drawing.Point(296, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 13;
            // 
            // MatIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 175);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.txbCol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbStorage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MatIn";
            this.Text = "Прием материала на склад";
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharedDataSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEMC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMat;
        private System.Windows.Forms.Label label1;
        private DataSetEMC1 dataSetEMC1;
        private System.Windows.Forms.BindingSource materialBindingSource;
        private DataSetEMC1TableAdapters.MaterialTableAdapter materialTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbStorage;
        private System.Windows.Forms.BindingSource storageBindingSource;
        private DataSetEMC1TableAdapters.StorageTableAdapter storageTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbCol;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btCancel;
        
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource contrBindingSource;
        private DataSetEMC1TableAdapters.ContrTableAdapter contrTableAdapter;
        private DataSetEMC1TableAdapters.StoredTableAdapter storedTableAdapter1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DataSetEMC1TableAdapters.UnitTableAdapter unitTableAdapter1;
        private System.Windows.Forms.BindingSource sharedDataSource;
        private System.Windows.Forms.Label label4;
    }
}