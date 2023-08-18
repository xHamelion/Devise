
namespace Devise
{
    partial class F_InternetUser
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDInternetUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewInternetUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deviseDataSet = new Devise.DeviseDataSet();
            this.PDF = new System.Windows.Forms.Button();
            this.Exel = new System.Windows.Forms.Button();
            this.BTN_Dob = new System.Windows.Forms.Button();
            this.BTN_Dell = new System.Windows.Forms.Button();
            this.BTN_Red = new System.Windows.Forms.Button();
            this.view_InternetUserTableAdapter = new Devise.DeviseDataSetTableAdapters.View_InternetUserTableAdapter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewInternetUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviseDataSet)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDInternetUserDataGridViewTextBoxColumn,
            this.fIODataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.eMailDataGridViewTextBoxColumn,
            this.familiaDataGridViewTextBoxColumn,
            this.imiaDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.passDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.viewInternetUserBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-2, -3);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1025, 241);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDInternetUserDataGridViewTextBoxColumn
            // 
            this.iDInternetUserDataGridViewTextBoxColumn.DataPropertyName = "ID_InternetUser";
            this.iDInternetUserDataGridViewTextBoxColumn.HeaderText = "ID_InternetUser";
            this.iDInternetUserDataGridViewTextBoxColumn.Name = "iDInternetUserDataGridViewTextBoxColumn";
            this.iDInternetUserDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDInternetUserDataGridViewTextBoxColumn.Visible = false;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            this.fIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // eMailDataGridViewTextBoxColumn
            // 
            this.eMailDataGridViewTextBoxColumn.DataPropertyName = "eMail";
            this.eMailDataGridViewTextBoxColumn.HeaderText = "Электронная почта";
            this.eMailDataGridViewTextBoxColumn.Name = "eMailDataGridViewTextBoxColumn";
            // 
            // familiaDataGridViewTextBoxColumn
            // 
            this.familiaDataGridViewTextBoxColumn.DataPropertyName = "Familia";
            this.familiaDataGridViewTextBoxColumn.HeaderText = "Familia";
            this.familiaDataGridViewTextBoxColumn.Name = "familiaDataGridViewTextBoxColumn";
            this.familiaDataGridViewTextBoxColumn.Visible = false;
            // 
            // imiaDataGridViewTextBoxColumn
            // 
            this.imiaDataGridViewTextBoxColumn.DataPropertyName = "Imia";
            this.imiaDataGridViewTextBoxColumn.HeaderText = "Imia";
            this.imiaDataGridViewTextBoxColumn.Name = "imiaDataGridViewTextBoxColumn";
            this.imiaDataGridViewTextBoxColumn.Visible = false;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Логин";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            // 
            // passDataGridViewTextBoxColumn
            // 
            this.passDataGridViewTextBoxColumn.DataPropertyName = "Pass";
            this.passDataGridViewTextBoxColumn.HeaderText = "Пароль";
            this.passDataGridViewTextBoxColumn.Name = "passDataGridViewTextBoxColumn";
            // 
            // viewInternetUserBindingSource
            // 
            this.viewInternetUserBindingSource.DataMember = "View_InternetUser";
            this.viewInternetUserBindingSource.DataSource = this.deviseDataSet;
            // 
            // deviseDataSet
            // 
            this.deviseDataSet.DataSetName = "DeviseDataSet";
            this.deviseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PDF
            // 
            this.PDF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PDF.Location = new System.Drawing.Point(520, 176);
            this.PDF.Margin = new System.Windows.Forms.Padding(8);
            this.PDF.Name = "PDF";
            this.PDF.Size = new System.Drawing.Size(497, 70);
            this.PDF.TabIndex = 104;
            this.PDF.Text = "Экспорт в PDF";
            this.PDF.UseVisualStyleBackColor = true;
            this.PDF.Click += new System.EventHandler(this.PDF_Click);
            // 
            // Exel
            // 
            this.Exel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Exel.Location = new System.Drawing.Point(8, 176);
            this.Exel.Margin = new System.Windows.Forms.Padding(8);
            this.Exel.Name = "Exel";
            this.Exel.Size = new System.Drawing.Size(496, 70);
            this.Exel.TabIndex = 103;
            this.Exel.Text = "Экспорт в Exel";
            this.Exel.UseVisualStyleBackColor = true;
            this.Exel.Click += new System.EventHandler(this.Exel_Click);
            // 
            // BTN_Dob
            // 
            this.BTN_Dob.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_Dob.Location = new System.Drawing.Point(520, 8);
            this.BTN_Dob.Margin = new System.Windows.Forms.Padding(8);
            this.BTN_Dob.Name = "BTN_Dob";
            this.BTN_Dob.Size = new System.Drawing.Size(497, 68);
            this.BTN_Dob.TabIndex = 102;
            this.BTN_Dob.Text = "Добавить";
            this.BTN_Dob.UseVisualStyleBackColor = true;
            this.BTN_Dob.Click += new System.EventHandler(this.BTN_Dob_Click);
            // 
            // BTN_Dell
            // 
            this.BTN_Dell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_Dell.Location = new System.Drawing.Point(8, 92);
            this.BTN_Dell.Margin = new System.Windows.Forms.Padding(8);
            this.BTN_Dell.Name = "BTN_Dell";
            this.BTN_Dell.Size = new System.Drawing.Size(496, 68);
            this.BTN_Dell.TabIndex = 101;
            this.BTN_Dell.Text = "Удалить";
            this.BTN_Dell.UseVisualStyleBackColor = true;
            this.BTN_Dell.Click += new System.EventHandler(this.BTN_Dell_Click);
            // 
            // BTN_Red
            // 
            this.BTN_Red.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_Red.Location = new System.Drawing.Point(8, 8);
            this.BTN_Red.Margin = new System.Windows.Forms.Padding(8);
            this.BTN_Red.Name = "BTN_Red";
            this.BTN_Red.Size = new System.Drawing.Size(496, 68);
            this.BTN_Red.TabIndex = 100;
            this.BTN_Red.Text = "Редактировать";
            this.BTN_Red.UseVisualStyleBackColor = true;
            this.BTN_Red.Click += new System.EventHandler(this.BTN_Red_Click);
            // 
            // view_InternetUserTableAdapter
            // 
            this.view_InternetUserTableAdapter.ClearBeforeFill = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.BTN_Red, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PDF, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.BTN_Dob, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BTN_Dell, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Exel, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-2, 243);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1025, 254);
            this.tableLayoutPanel1.TabIndex = 105;
            // 
            // F_InternetUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 497);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(1034, 536);
            this.Name = "F_InternetUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Интернет покупатели";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.F_InternetUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewInternetUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviseDataSet)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button PDF;
        private System.Windows.Forms.Button Exel;
        private System.Windows.Forms.Button BTN_Dob;
        private System.Windows.Forms.Button BTN_Dell;
        private System.Windows.Forms.Button BTN_Red;
        private DeviseDataSet deviseDataSet;
        private System.Windows.Forms.BindingSource viewInternetUserBindingSource;
        private DeviseDataSetTableAdapters.View_InternetUserTableAdapter view_InternetUserTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDInternetUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passDataGridViewTextBoxColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}