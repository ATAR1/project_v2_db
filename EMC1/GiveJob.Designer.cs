namespace EMC1
{
    partial class GiveJob
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
            EMC1.DataSetEMC1 dataSetEMC1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiveJob));
            this.label1 = new System.Windows.Forms.Label();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbJobs = new System.Windows.Forms.ComboBox();
            this.jobTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sharedDataSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobTypeTableAdapter = new EMC1.DataSetEMC1TableAdapters.JobTypeTableAdapter();
            this.btOk = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbEmpl = new System.Windows.Forms.ComboBox();
            this.employessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeTableAdapter = new EMC1.DataSetEMC1TableAdapters.EmployeTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            dataSetEMC1 = new EMC1.DataSetEMC1();
            ((System.ComponentModel.ISupportInitialize)(dataSetEMC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharedDataSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employessBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSetEMC1
            // 
            dataSetEMC1.DataSetName = "DataSetEMC1";
            dataSetEMC1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата:";
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(82, 19);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(180, 20);
            this.dtp.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Вид работы:";
            // 
            // cmbJobs
            // 
            this.cmbJobs.DataSource = this.jobTypeBindingSource;
            this.cmbJobs.DisplayMember = "Name";
            this.cmbJobs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJobs.FormattingEnabled = true;
            this.cmbJobs.Location = new System.Drawing.Point(82, 63);
            this.cmbJobs.Name = "cmbJobs";
            this.cmbJobs.Size = new System.Drawing.Size(180, 21);
            this.cmbJobs.TabIndex = 5;
            this.cmbJobs.ValueMember = "Id";
            // 
            // jobTypeBindingSource
            // 
            this.jobTypeBindingSource.DataMember = "JobType";
            this.jobTypeBindingSource.DataSource = this.sharedDataSource;
            // 
            // sharedDataSource
            // 
            this.sharedDataSource.DataSource = dataSetEMC1;
            this.sharedDataSource.Position = 0;
            // 
            // jobTypeTableAdapter
            // 
            this.jobTypeTableAdapter.ClearBeforeFill = true;
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(178, 154);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(71, 23);
            this.btOk.TabIndex = 6;
            this.btOk.Text = "Сохранить";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(82, 154);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(77, 23);
            this.btCancel.TabIndex = 7;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Бригадир:";
            // 
            // cmbEmpl
            // 
            this.cmbEmpl.DataSource = this.employessBindingSource;
            this.cmbEmpl.DisplayMember = "FullName";
            this.cmbEmpl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpl.FormattingEnabled = true;
            this.cmbEmpl.Location = new System.Drawing.Point(82, 104);
            this.cmbEmpl.Name = "cmbEmpl";
            this.cmbEmpl.Size = new System.Drawing.Size(180, 21);
            this.cmbEmpl.TabIndex = 9;
            this.cmbEmpl.ValueMember = "Id";
            // 
            // employessBindingSource
            // 
            this.employessBindingSource.DataMember = "Employee";
            this.employessBindingSource.DataSource = this.sharedDataSource;
            // 
            // employeTableAdapter
            // 
            this.employeTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(280, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 137);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // GiveJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 193);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbEmpl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.cmbJobs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GiveJob";
            this.Text = "Задание";
            ((System.ComponentModel.ISupportInitialize)(dataSetEMC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharedDataSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employessBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbJobs;
        private System.Windows.Forms.BindingSource jobTypeBindingSource;
        private DataSetEMC1TableAdapters.JobTypeTableAdapter jobTypeTableAdapter;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbEmpl;
        private System.Windows.Forms.BindingSource employessBindingSource;
        private DataSetEMC1TableAdapters.EmployeTableAdapter employeTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource sharedDataSource;
    }
}