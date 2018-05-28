namespace EMC1
{
    partial class edit_spr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(edit_spr));
            this.dataSetEMC11 = new EMC1.DataSetEMC1();
            this.employessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetEMC11BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new EMC1.DataSetEMC1TableAdapters.EmployeTableAdapter();
            this.employeeTableAdapter1 = new EMC1.DataSetEMC1TableAdapters.EmployeTableAdapter();
            this.contrTableAdapter = new EMC1.DataSetEMC1TableAdapters.ContrTableAdapter();
            this.storageTableAdapter = new EMC1.DataSetEMC1TableAdapters.StorageTableAdapter();
            this.materialTableAdapter = new EMC1.DataSetEMC1TableAdapters.MaterialTableAdapter();
            this.jobTypeTableAdapter = new EMC1.DataSetEMC1TableAdapters.JobTypeTableAdapter();
            this.jobs = new System.Windows.Forms.TabPage();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.material = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ed_izm = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.eDIZMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storage = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.telefoneDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kontr = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employess = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpEdIzm = new System.Windows.Forms.TabPage();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.nameedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.unitTableAdapter = new EMC1.DataSetEMC1TableAdapters.UnitTableAdapter();
            this.nameDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEMC11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employessBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEMC11BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobTypeBindingSource)).BeginInit();
            this.jobs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.material.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDIZMBindingSource)).BeginInit();
            this.storage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.kontr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.employess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpEdIzm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSetEMC11
            // 
            this.dataSetEMC11.DataSetName = "DataSetEMC1";
            this.dataSetEMC11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employessBindingSource
            // 
            this.employessBindingSource.DataMember = "employess";
            this.employessBindingSource.DataSource = this.dataSetEMC11BindingSource;
            // 
            // dataSetEMC11BindingSource
            // 
            this.dataSetEMC11BindingSource.DataSource = this.dataSetEMC11;
            this.dataSetEMC11BindingSource.Position = 0;
            // 
            // kontrBindingSource
            // 
            this.contrBindingSource.DataMember = "kontr";
            this.contrBindingSource.DataSource = this.dataSetEMC11BindingSource;
            // 
            // storageBindingSource
            // 
            this.storageBindingSource.DataMember = "storage";
            this.storageBindingSource.DataSource = this.dataSetEMC11BindingSource;
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataMember = "material";
            this.materialBindingSource.DataSource = this.dataSetEMC11BindingSource;
            // 
            // jobsBindingSource
            // 
            this.jobTypeBindingSource.DataMember = "jobs";
            this.jobTypeBindingSource.DataSource = this.dataSetEMC11BindingSource;
            // 
            // employessTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // employessTableAdapter1
            // 
            this.employeeTableAdapter1.ClearBeforeFill = true;
            // 
            // kontrTableAdapter
            // 
            this.contrTableAdapter.ClearBeforeFill = true;
            // 
            // storageTableAdapter
            // 
            this.storageTableAdapter.ClearBeforeFill = true;
            // 
            // materialTableAdapter
            // 
            this.materialTableAdapter.ClearBeforeFill = true;
            // 
            // jobsTableAdapter
            // 
            this.jobTypeTableAdapter.ClearBeforeFill = true;
            // 
            // jobs
            // 
            this.jobs.Controls.Add(this.dataGridView5);
            this.jobs.Location = new System.Drawing.Point(4, 22);
            this.jobs.Name = "jobs";
            this.jobs.Padding = new System.Windows.Forms.Padding(3);
            this.jobs.Size = new System.Drawing.Size(559, 355);
            this.jobs.TabIndex = 4;
            this.jobs.Text = "Виды работ";
            this.jobs.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn3});
            this.dataGridView5.DataSource = this.jobTypeBindingSource;
            this.dataGridView5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView5.Location = new System.Drawing.Point(3, 3);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(553, 349);
            this.dataGridView5.TabIndex = 0;
            // 
            // material
            // 
            this.material.Controls.Add(this.dataGridView4);
            this.material.Location = new System.Drawing.Point(4, 22);
            this.material.Name = "material";
            this.material.Padding = new System.Windows.Forms.Padding(3);
            this.material.Size = new System.Drawing.Size(559, 355);
            this.material.TabIndex = 3;
            this.material.Text = "Материалы";
            this.material.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn2,
            this.ed_izm});
            this.dataGridView4.DataSource = this.materialBindingSource;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(3, 3);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(553, 349);
            this.dataGridView4.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "Наименование";
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            // 
            // ed_izm
            // 
            this.ed_izm.DataPropertyName = "id_ed";
            this.ed_izm.DataSource = this.eDIZMBindingSource;
            this.ed_izm.DisplayMember = "full_name";
            this.ed_izm.HeaderText = "ед.";
            this.ed_izm.Name = "ed_izm";
            this.ed_izm.ValueMember = "id_ed";
            // 
            // eDIZMBindingSource
            // 
            this.eDIZMBindingSource.DataMember = "ED_IZM";
            this.eDIZMBindingSource.DataSource = this.dataSetEMC11BindingSource;
            // 
            // storage
            // 
            this.storage.Controls.Add(this.dataGridView3);
            this.storage.Location = new System.Drawing.Point(4, 22);
            this.storage.Name = "storage";
            this.storage.Padding = new System.Windows.Forms.Padding(3);
            this.storage.Size = new System.Drawing.Size(559, 355);
            this.storage.TabIndex = 2;
            this.storage.Text = "Склады";
            this.storage.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.cityDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn,
            this.emp,
            this.telefoneDataGridViewTextBoxColumn2});
            this.dataGridView3.DataSource = this.storageBindingSource;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(553, 349);
            this.dataGridView3.TabIndex = 0;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Наименование";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            this.cityDataGridViewTextBoxColumn.HeaderText = "Город";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "Улица";
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            // 
            // emp
            // 
            this.emp.DataPropertyName = "id_emp";
            this.emp.DataSource = this.employessBindingSource;
            this.emp.DisplayMember = "fio";
            this.emp.HeaderText = "Ответственный за склад";
            this.emp.Name = "emp";
            this.emp.ValueMember = "id_emp";
            // 
            // telefoneDataGridViewTextBoxColumn2
            // 
            this.telefoneDataGridViewTextBoxColumn2.DataPropertyName = "telefone";
            this.telefoneDataGridViewTextBoxColumn2.HeaderText = "Контактный телефон";
            this.telefoneDataGridViewTextBoxColumn2.Name = "telefoneDataGridViewTextBoxColumn2";
            // 
            // kontr
            // 
            this.kontr.Controls.Add(this.dataGridView2);
            this.kontr.Location = new System.Drawing.Point(4, 22);
            this.kontr.Name = "kontr";
            this.kontr.Padding = new System.Windows.Forms.Padding(3);
            this.kontr.Size = new System.Drawing.Size(559, 355);
            this.kontr.TabIndex = 1;
            this.kontr.Text = "Поставщики";
            this.kontr.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn1,
            this.adressDataGridViewTextBoxColumn,
            this.contactnameDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.contrBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(553, 349);
            this.dataGridView2.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // telefoneDataGridViewTextBoxColumn1
            // 
            this.telefoneDataGridViewTextBoxColumn1.DataPropertyName = "telefone";
            this.telefoneDataGridViewTextBoxColumn1.HeaderText = "Телефон";
            this.telefoneDataGridViewTextBoxColumn1.Name = "telefoneDataGridViewTextBoxColumn1";
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            // 
            // contactnameDataGridViewTextBoxColumn
            // 
            this.contactnameDataGridViewTextBoxColumn.DataPropertyName = "contactname";
            this.contactnameDataGridViewTextBoxColumn.HeaderText = "Контактное лицо";
            this.contactnameDataGridViewTextBoxColumn.Name = "contactnameDataGridViewTextBoxColumn";
            // 
            // employess
            // 
            this.employess.Controls.Add(this.dataGridView1);
            this.employess.Location = new System.Drawing.Point(4, 22);
            this.employess.Name = "employess";
            this.employess.Padding = new System.Windows.Forms.Padding(3);
            this.employess.Size = new System.Drawing.Size(559, 355);
            this.employess.TabIndex = 0;
            this.employess.Text = "Должности";
            this.employess.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idempDataGridViewTextBoxColumn,
            this.staffDataGridViewTextBoxColumn,
            this.fioDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employessBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(553, 349);
            this.dataGridView1.TabIndex = 0;
            // 
            // idempDataGridViewTextBoxColumn
            // 
            this.idempDataGridViewTextBoxColumn.DataPropertyName = "id_emp";
            this.idempDataGridViewTextBoxColumn.HeaderText = "";
            this.idempDataGridViewTextBoxColumn.Name = "idempDataGridViewTextBoxColumn";
            this.idempDataGridViewTextBoxColumn.ReadOnly = true;
            this.idempDataGridViewTextBoxColumn.Visible = false;
            // 
            // staffDataGridViewTextBoxColumn
            // 
            this.staffDataGridViewTextBoxColumn.DataPropertyName = "staff";
            this.staffDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.staffDataGridViewTextBoxColumn.Name = "staffDataGridViewTextBoxColumn";
            this.staffDataGridViewTextBoxColumn.ToolTipText = "Должность";
            // 
            // fioDataGridViewTextBoxColumn
            // 
            this.fioDataGridViewTextBoxColumn.DataPropertyName = "fio";
            this.fioDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fioDataGridViewTextBoxColumn.Name = "fioDataGridViewTextBoxColumn";
            this.fioDataGridViewTextBoxColumn.ToolTipText = "ФИО";
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ToolTipText = "Телефон";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.employess);
            this.tabControl1.Controls.Add(this.kontr);
            this.tabControl1.Controls.Add(this.storage);
            this.tabControl1.Controls.Add(this.material);
            this.tabControl1.Controls.Add(this.jobs);
            this.tabControl1.Controls.Add(this.tpEdIzm);
            this.tabControl1.Location = new System.Drawing.Point(12, 37);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(567, 381);
            this.tabControl1.TabIndex = 0;
            // 
            // tpEdIzm
            // 
            this.tpEdIzm.Controls.Add(this.dataGridView6);
            this.tpEdIzm.Location = new System.Drawing.Point(4, 22);
            this.tpEdIzm.Name = "tpEdIzm";
            this.tpEdIzm.Padding = new System.Windows.Forms.Padding(3);
            this.tpEdIzm.Size = new System.Drawing.Size(559, 355);
            this.tpEdIzm.TabIndex = 5;
            this.tpEdIzm.Text = "Еденицы измерения";
            this.tpEdIzm.UseVisualStyleBackColor = true;
            // 
            // dataGridView6
            // 
            this.dataGridView6.AutoGenerateColumns = false;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameedDataGridViewTextBoxColumn,
            this.fullnameDataGridViewTextBoxColumn});
            this.dataGridView6.DataSource = this.eDIZMBindingSource;
            this.dataGridView6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView6.Location = new System.Drawing.Point(3, 3);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.Size = new System.Drawing.Size(553, 349);
            this.dataGridView6.TabIndex = 0;
            // 
            // nameedDataGridViewTextBoxColumn
            // 
            this.nameedDataGridViewTextBoxColumn.DataPropertyName = "name_ed";
            this.nameedDataGridViewTextBoxColumn.HeaderText = "Короткое наименование";
            this.nameedDataGridViewTextBoxColumn.Name = "nameedDataGridViewTextBoxColumn";
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "full_name";
            this.fullnameDataGridViewTextBoxColumn.HeaderText = "Полное наименование";
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(581, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 57);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // eD_IZMTableAdapter
            // 
            this.unitTableAdapter.ClearBeforeFill = true;
            // 
            // nameDataGridViewTextBoxColumn3
            // 
            this.nameDataGridViewTextBoxColumn3.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn3.HeaderText = "Наименование";
            this.nameDataGridViewTextBoxColumn3.Name = "nameDataGridViewTextBoxColumn3";
            // 
            // edit_spr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 446);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Name = "edit_spr";
            this.Text = "Справочники";
            this.Load += new System.EventHandler(this.edit_spr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEMC11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employessBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEMC11BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobTypeBindingSource)).EndInit();
            this.jobs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.material.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDIZMBindingSource)).EndInit();
            this.storage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.kontr.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.employess.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpEdIzm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSetEMC1 dataSetEMC11;
        private System.Windows.Forms.BindingSource dataSetEMC11BindingSource;
        private System.Windows.Forms.BindingSource employessBindingSource;
        private DataSetEMC1TableAdapters.EmployeTableAdapter employeeTableAdapter;
        private DataSetEMC1TableAdapters.EmployeTableAdapter employeeTableAdapter1;
        private System.Windows.Forms.BindingSource contrBindingSource;
        private DataSetEMC1TableAdapters.ContrTableAdapter contrTableAdapter;
        private System.Windows.Forms.BindingSource storageBindingSource;
        private DataSetEMC1TableAdapters.StorageTableAdapter storageTableAdapter;
        private System.Windows.Forms.BindingSource materialBindingSource;
        private DataSetEMC1TableAdapters.MaterialTableAdapter materialTableAdapter;
        private System.Windows.Forms.BindingSource jobTypeBindingSource;
        private DataSetEMC1TableAdapters.JobTypeTableAdapter jobTypeTableAdapter;
        private System.Windows.Forms.TabPage jobs;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.TabPage material;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.TabPage storage;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TabPage kontr;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage employess;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idempDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource eDIZMBindingSource;
        private DataSetEMC1TableAdapters.UnitTableAdapter unitTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn ed_izm;
        private System.Windows.Forms.TabPage tpEdIzm;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn emp;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn3;
    }
}