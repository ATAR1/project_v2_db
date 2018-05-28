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
            this.balanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetEMC1 = new EMC1.DataSetEMC1();
            this.but_out_mat = new System.Windows.Forms.Button();
            this.but_in_mat = new System.Windows.Forms.Button();
            this.but_give_job = new System.Windows.Forms.Button();
            this.but_edit_spr = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.storageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.storageTableAdapter = new EMC1.DataSetEMC1TableAdapters.storageTableAdapter();
            //this.balanceTableAdapter = new EMC1.DataSetEMC1TableAdapters.BalanceTableAdapter();
            this.tableAdapterManager = new EMC1.DataSetEMC1TableAdapters.TableAdapterManager();
            this.mat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEMC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 65);
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
            this.count});
            this.dataGridView1.DataSource = this.balanceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(208, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(558, 465);
            this.dataGridView1.TabIndex = 1;
            // 
            // balanceBindingSource
            // 
            //this.balanceBindingSource.DataMember = "Balance";
            //this.balanceBindingSource.DataSource = this.dataSetEMC1;
            // 
            // dataSetEMC1
            // 
            this.dataSetEMC1.DataSetName = "DataSetEMC1";
            this.dataSetEMC1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // but_out_mat
            // 
            this.but_out_mat.Location = new System.Drawing.Point(771, 96);
            this.but_out_mat.Name = "but_out_mat";
            this.but_out_mat.Size = new System.Drawing.Size(133, 23);
            this.but_out_mat.TabIndex = 2;
            this.but_out_mat.Text = "Отпуск материала";
            this.but_out_mat.UseVisualStyleBackColor = true;
            this.but_out_mat.Click += new System.EventHandler(this.but_out_mat_Click);
            // 
            // but_in_mat
            // 
            this.but_in_mat.Location = new System.Drawing.Point(772, 65);
            this.but_in_mat.Name = "but_in_mat";
            this.but_in_mat.Size = new System.Drawing.Size(133, 23);
            this.but_in_mat.TabIndex = 3;
            this.but_in_mat.Text = "Прием материала";
            this.but_in_mat.UseVisualStyleBackColor = true;
            this.but_in_mat.Click += new System.EventHandler(this.btInMatClick);
            // 
            // but_give_job
            // 
            this.but_give_job.Location = new System.Drawing.Point(772, 125);
            this.but_give_job.Name = "but_give_job";
            this.but_give_job.Size = new System.Drawing.Size(132, 23);
            this.but_give_job.TabIndex = 4;
            this.but_give_job.Text = "Дать задание ";
            this.but_give_job.UseVisualStyleBackColor = true;
            this.but_give_job.Click += new System.EventHandler(this.btGiveJobClick);
            // 
            // but_edit_spr
            // 
            this.but_edit_spr.Location = new System.Drawing.Point(771, 154);
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
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Склад";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Остатки материала на складе";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
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
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.storageBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(15, 65);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(190, 465);
            this.dataGridView2.TabIndex = 11;
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // storageBindingSource
            // 
            this.storageBindingSource.DataMember = "storage";
            this.storageBindingSource.DataSource = this.dataSetEMC1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(771, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Отчеты";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(798, 12);
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
            // balanceTableAdapter
            // 
            //this.balanceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.ED_IZMTableAdapter = null;
            this.tableAdapterManager.employessTableAdapter = null;
            this.tableAdapterManager.jobsTableAdapter = null;
            this.tableAdapterManager.kontrTableAdapter = null;
            this.tableAdapterManager.materialTableAdapter = null;
            this.tableAdapterManager.planjobTableAdapter = null;
            this.tableAdapterManager.storage_nalTableAdapter = null;
            this.tableAdapterManager.storageTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = EMC1.DataSetEMC1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.user_roleTableAdapter = null;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // mat
            // 
            this.mat.DataPropertyName = "name";
            this.mat.FillWeight = 118.018F;
            this.mat.HeaderText = "Материал";
            this.mat.Name = "mat";
            this.mat.ReadOnly = true;
            // 
            // count
            // 
            this.count.DataPropertyName = "balance";
            this.count.FillWeight = 118.018F;
            this.count.HeaderText = "Остаток";
            this.count.Name = "count";
            this.count.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Склад";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "ЭМС-1 ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEMC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetEMC1 dataSetEMC1;
        private System.Windows.Forms.Button but_out_mat;
        private System.Windows.Forms.Button but_in_mat;
        private System.Windows.Forms.Button but_give_job;
        private System.Windows.Forms.Button but_edit_spr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private DataSetEMC1TableAdapters.storageTableAdapter storageTableAdapter;
        private System.Windows.Forms.BindingSource storageBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource balanceBindingSource;
        //private DataSetEMC1TableAdapters.BalanceTableAdapter balanceTableAdapter;
        private DataSetEMC1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn mat;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}

