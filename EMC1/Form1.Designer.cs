namespace EMC1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sharedDataSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetEMC1 = new EMC1.DataSetEMC1();
            this.but_out_mat = new System.Windows.Forms.Button();
            this.but_in_mat = new System.Windows.Forms.Button();
            this.but_give_job = new System.Windows.Forms.Button();
            this.but_edit_spr = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.storageTableAdapter = new EMC1.DataSetEMC1TableAdapters.StorageTableAdapter();
            this.storedTableAdapter = new EMC1.DataSetEMC1TableAdapters.StoredTableAdapter();
            this.lblUser = new System.Windows.Forms.Label();
            this.storageIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceStrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharedDataSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEMC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 71);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(136, 465);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mat,
            this.count,
            this.storageIdDataGridViewTextBoxColumn,
            this.materialIdDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn,
            this.balanceStrDataGridViewTextBoxColumn,
            this.materialNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.storedBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(208, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(558, 465);
            this.dataGridView1.TabIndex = 1;
            // 
            // mat
            // 
            this.mat.DataPropertyName = "MaterialName";
            this.mat.FillWeight = 118.018F;
            this.mat.HeaderText = "Материал";
            this.mat.Name = "mat";
            this.mat.ReadOnly = true;
            // 
            // count
            // 
            this.count.DataPropertyName = "BalanceStr";
            this.count.FillWeight = 118.018F;
            this.count.HeaderText = "Остаток";
            this.count.Name = "count";
            this.count.ReadOnly = true;
            // 
            // storedBindingSource
            // 
            this.storedBindingSource.DataMember = "FK_Stored_Storage";
            this.storedBindingSource.DataSource = this.storageBindingSource;
            // 
            // storageBindingSource
            // 
            this.storageBindingSource.DataMember = "Storage";
            this.storageBindingSource.DataSource = this.sharedDataSource;
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
            // but_out_mat
            // 
            this.but_out_mat.Location = new System.Drawing.Point(771, 102);
            this.but_out_mat.Name = "but_out_mat";
            this.but_out_mat.Size = new System.Drawing.Size(133, 23);
            this.but_out_mat.TabIndex = 2;
            this.but_out_mat.Text = "Отпуск материала";
            this.but_out_mat.UseVisualStyleBackColor = true;
            this.but_out_mat.Click += new System.EventHandler(this.but_out_mat_Click);
            // 
            // but_in_mat
            // 
            this.but_in_mat.Location = new System.Drawing.Point(772, 71);
            this.but_in_mat.Name = "but_in_mat";
            this.but_in_mat.Size = new System.Drawing.Size(133, 23);
            this.but_in_mat.TabIndex = 3;
            this.but_in_mat.Text = "Прием материала";
            this.but_in_mat.UseVisualStyleBackColor = true;
            this.but_in_mat.Click += new System.EventHandler(this.btInMatClick);
            // 
            // but_give_job
            // 
            this.but_give_job.Location = new System.Drawing.Point(772, 131);
            this.but_give_job.Name = "but_give_job";
            this.but_give_job.Size = new System.Drawing.Size(132, 23);
            this.but_give_job.TabIndex = 4;
            this.but_give_job.Text = "Дать задание ";
            this.but_give_job.UseVisualStyleBackColor = true;
            this.but_give_job.Click += new System.EventHandler(this.btGiveJobClick);
            // 
            // but_edit_spr
            // 
            this.but_edit_spr.Location = new System.Drawing.Point(771, 160);
            this.but_edit_spr.Name = "but_edit_spr";
            this.but_edit_spr.Size = new System.Drawing.Size(132, 23);
            this.but_edit_spr.TabIndex = 6;
            this.but_edit_spr.Text = "Справочники";
            this.but_edit_spr.UseVisualStyleBackColor = true;
            this.but_edit_spr.Click += new System.EventHandler(this.btSPrClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Склад";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Остатки материала на складе";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(2, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 10;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.storageBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(15, 71);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(190, 465);
            this.dataGridView2.TabIndex = 11;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Склад";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(771, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Отчеты";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(796, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "О программе";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // storageTableAdapter
            // 
            this.storageTableAdapter.ClearBeforeFill = true;
            // 
            // storedTableAdapter
            // 
            this.storedTableAdapter.ClearBeforeFill = true;
            // 
            // lblUser
            // 
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUser.Location = new System.Drawing.Point(0, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(919, 23);
            this.lblUser.TabIndex = 14;
            this.lblUser.Text = "Пользователь";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // storageIdDataGridViewTextBoxColumn
            // 
            this.storageIdDataGridViewTextBoxColumn.DataPropertyName = "StorageId";
            this.storageIdDataGridViewTextBoxColumn.HeaderText = "StorageId";
            this.storageIdDataGridViewTextBoxColumn.Name = "storageIdDataGridViewTextBoxColumn";
            this.storageIdDataGridViewTextBoxColumn.ReadOnly = true;
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
            // balanceStrDataGridViewTextBoxColumn
            // 
            this.balanceStrDataGridViewTextBoxColumn.DataPropertyName = "BalanceStr";
            this.balanceStrDataGridViewTextBoxColumn.HeaderText = "BalanceStr";
            this.balanceStrDataGridViewTextBoxColumn.Name = "balanceStrDataGridViewTextBoxColumn";
            this.balanceStrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materialNameDataGridViewTextBoxColumn
            // 
            this.materialNameDataGridViewTextBoxColumn.DataPropertyName = "MaterialName";
            this.materialNameDataGridViewTextBoxColumn.HeaderText = "MaterialName";
            this.materialNameDataGridViewTextBoxColumn.Name = "materialNameDataGridViewTextBoxColumn";
            this.materialNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 542);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but_edit_spr);
            this.Controls.Add(this.but_give_job);
            this.Controls.Add(this.but_in_mat);
            this.Controls.Add(this.but_out_mat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "ЭМС-1 ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharedDataSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEMC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button but_out_mat;
        private System.Windows.Forms.Button but_in_mat;
        private System.Windows.Forms.Button but_give_job;
        private System.Windows.Forms.Button but_edit_spr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private DataSetEMC1TableAdapters.StorageTableAdapter storageTableAdapter;
        private System.Windows.Forms.BindingSource storageBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource sharedDataSource;
        private DataSetEMC1 dataSetEMC1;
        private DataSetEMC1TableAdapters.StoredTableAdapter storedTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource storedBindingSource;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn mat;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn storageIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceStrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialNameDataGridViewTextBoxColumn;
    }
}

