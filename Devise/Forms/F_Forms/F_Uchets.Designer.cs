
namespace Devise
{
    partial class F_Uchets
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dostupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDRegDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deviseDataSet = new Devise.DeviseDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BTN_Dob = new System.Windows.Forms.Button();
            this.BTN_Dell = new System.Windows.Forms.Button();
            this.BTN_Red = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDSotrudnicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otzhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDRegDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewSotrudnicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.regTableAdapter = new Devise.DeviseDataSetTableAdapters.RegTableAdapter();
            this.view_SotrudnicTableAdapter = new Devise.DeviseDataSetTableAdapters.View_SotrudnicTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviseDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSotrudnicBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-16, -11);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(9);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(923, 488);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loginDataGridViewTextBoxColumn,
            this.porolDataGridViewTextBoxColumn,
            this.dostupDataGridViewTextBoxColumn,
            this.iDRegDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.regBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(9, 9);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(905, 226);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Логин";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            // 
            // porolDataGridViewTextBoxColumn
            // 
            this.porolDataGridViewTextBoxColumn.DataPropertyName = "Porol";
            this.porolDataGridViewTextBoxColumn.HeaderText = "Пароль";
            this.porolDataGridViewTextBoxColumn.Name = "porolDataGridViewTextBoxColumn";
            // 
            // dostupDataGridViewTextBoxColumn
            // 
            this.dostupDataGridViewTextBoxColumn.DataPropertyName = "Dostup";
            this.dostupDataGridViewTextBoxColumn.HeaderText = "Уровень доступа";
            this.dostupDataGridViewTextBoxColumn.Name = "dostupDataGridViewTextBoxColumn";
            // 
            // iDRegDataGridViewTextBoxColumn
            // 
            this.iDRegDataGridViewTextBoxColumn.DataPropertyName = "ID_Reg";
            this.iDRegDataGridViewTextBoxColumn.HeaderText = "ID_Reg";
            this.iDRegDataGridViewTextBoxColumn.Name = "iDRegDataGridViewTextBoxColumn";
            this.iDRegDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDRegDataGridViewTextBoxColumn.Visible = false;
            // 
            // regBindingSource
            // 
            this.regBindingSource.DataMember = "Reg";
            this.regBindingSource.DataSource = this.deviseDataSet;
            // 
            // deviseDataSet
            // 
            this.deviseDataSet.DataSetName = "DeviseDataSet";
            this.deviseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(9, 253);
            this.panel1.Margin = new System.Windows.Forms.Padding(9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 226);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.dataGridView2, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(905, 226);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.BTN_Dob, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BTN_Dell, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.BTN_Red, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00015F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00016F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00015F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99953F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(440, 214);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // BTN_Dob
            // 
            this.BTN_Dob.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Dob.Location = new System.Drawing.Point(6, 6);
            this.BTN_Dob.Margin = new System.Windows.Forms.Padding(6);
            this.BTN_Dob.Name = "BTN_Dob";
            this.BTN_Dob.Size = new System.Drawing.Size(428, 41);
            this.BTN_Dob.TabIndex = 0;
            this.BTN_Dob.Text = "Добавить";
            this.BTN_Dob.UseVisualStyleBackColor = true;
            this.BTN_Dob.Click += new System.EventHandler(this.BTN_Dob_Click);
            // 
            // BTN_Dell
            // 
            this.BTN_Dell.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Dell.Location = new System.Drawing.Point(6, 112);
            this.BTN_Dell.Margin = new System.Windows.Forms.Padding(6);
            this.BTN_Dell.Name = "BTN_Dell";
            this.BTN_Dell.Size = new System.Drawing.Size(428, 41);
            this.BTN_Dell.TabIndex = 2;
            this.BTN_Dell.Text = "Удалить";
            this.BTN_Dell.UseVisualStyleBackColor = true;
            this.BTN_Dell.Click += new System.EventHandler(this.BTN_Dell_Click);
            // 
            // BTN_Red
            // 
            this.BTN_Red.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Red.Location = new System.Drawing.Point(6, 59);
            this.BTN_Red.Margin = new System.Windows.Forms.Padding(6);
            this.BTN_Red.Name = "BTN_Red";
            this.BTN_Red.Size = new System.Drawing.Size(428, 41);
            this.BTN_Red.TabIndex = 1;
            this.BTN_Red.Text = "Редактировать";
            this.BTN_Red.UseVisualStyleBackColor = true;
            this.BTN_Red.Click += new System.EventHandler(this.BTN_Red_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(6, 165);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(428, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "История входа";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSotrudnicDataGridViewTextBoxColumn,
            this.fIODataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.familiaDataGridViewTextBoxColumn,
            this.imiaDataGridViewTextBoxColumn,
            this.otzhDataGridViewTextBoxColumn,
            this.iDRegDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.viewSotrudnicBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(455, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(447, 220);
            this.dataGridView2.TabIndex = 4;
            // 
            // iDSotrudnicDataGridViewTextBoxColumn
            // 
            this.iDSotrudnicDataGridViewTextBoxColumn.DataPropertyName = "ID_Sotrudnic";
            this.iDSotrudnicDataGridViewTextBoxColumn.HeaderText = "ID_Sotrudnic";
            this.iDSotrudnicDataGridViewTextBoxColumn.Name = "iDSotrudnicDataGridViewTextBoxColumn";
            this.iDSotrudnicDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDSotrudnicDataGridViewTextBoxColumn.Visible = false;
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
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefonDataGridViewTextBoxColumn.Visible = false;
            // 
            // familiaDataGridViewTextBoxColumn
            // 
            this.familiaDataGridViewTextBoxColumn.DataPropertyName = "Familia";
            this.familiaDataGridViewTextBoxColumn.HeaderText = "Familia";
            this.familiaDataGridViewTextBoxColumn.Name = "familiaDataGridViewTextBoxColumn";
            this.familiaDataGridViewTextBoxColumn.ReadOnly = true;
            this.familiaDataGridViewTextBoxColumn.Visible = false;
            // 
            // imiaDataGridViewTextBoxColumn
            // 
            this.imiaDataGridViewTextBoxColumn.DataPropertyName = "Imia";
            this.imiaDataGridViewTextBoxColumn.HeaderText = "Imia";
            this.imiaDataGridViewTextBoxColumn.Name = "imiaDataGridViewTextBoxColumn";
            this.imiaDataGridViewTextBoxColumn.ReadOnly = true;
            this.imiaDataGridViewTextBoxColumn.Visible = false;
            // 
            // otzhDataGridViewTextBoxColumn
            // 
            this.otzhDataGridViewTextBoxColumn.DataPropertyName = "Otzh";
            this.otzhDataGridViewTextBoxColumn.HeaderText = "Otzh";
            this.otzhDataGridViewTextBoxColumn.Name = "otzhDataGridViewTextBoxColumn";
            this.otzhDataGridViewTextBoxColumn.ReadOnly = true;
            this.otzhDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDRegDataGridViewTextBoxColumn1
            // 
            this.iDRegDataGridViewTextBoxColumn1.DataPropertyName = "ID_Reg";
            this.iDRegDataGridViewTextBoxColumn1.HeaderText = "ID_Reg";
            this.iDRegDataGridViewTextBoxColumn1.Name = "iDRegDataGridViewTextBoxColumn1";
            this.iDRegDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDRegDataGridViewTextBoxColumn1.Visible = false;
            // 
            // viewSotrudnicBindingSource
            // 
            this.viewSotrudnicBindingSource.DataMember = "View_Sotrudnic";
            this.viewSotrudnicBindingSource.DataSource = this.deviseDataSet;
            // 
            // regTableAdapter
            // 
            this.regTableAdapter.ClearBeforeFill = true;
            // 
            // view_SotrudnicTableAdapter
            // 
            this.view_SotrudnicTableAdapter.ClearBeforeFill = true;
            // 
            // F_Uchets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 473);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(913, 512);
            this.Name = "F_Uchets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Уровень доступа";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.F_Uchets_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviseDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSotrudnicBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button BTN_Dob;
        private System.Windows.Forms.Button BTN_Dell;
        private System.Windows.Forms.Button BTN_Red;
        private DeviseDataSet deviseDataSet;
        private System.Windows.Forms.BindingSource regBindingSource;
        private DeviseDataSetTableAdapters.RegTableAdapter regTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn porolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dostupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDRegDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource viewSotrudnicBindingSource;
        private DeviseDataSetTableAdapters.View_SotrudnicTableAdapter view_SotrudnicTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSotrudnicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otzhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDRegDataGridViewTextBoxColumn1;
    }
}