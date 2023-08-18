
namespace Devise.Forms
{
    partial class F_History_Avtorization
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
            this.iDHistoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDRegDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dostupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataVhodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namePKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deviseDataSet = new Devise.DeviseDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.view_HistoryTableAdapter = new Devise.DeviseDataSetTableAdapters.View_HistoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviseDataSet)).BeginInit();
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
            this.iDHistoryDataGridViewTextBoxColumn,
            this.iDRegDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.porolDataGridViewTextBoxColumn,
            this.dostupDataGridViewTextBoxColumn,
            this.dataVhodDataGridViewTextBoxColumn,
            this.iPDataGridViewTextBoxColumn,
            this.namePKDataGridViewTextBoxColumn,
            this.FIO});
            this.dataGridView1.DataSource = this.viewHistoryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-5, -2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1045, 363);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDHistoryDataGridViewTextBoxColumn
            // 
            this.iDHistoryDataGridViewTextBoxColumn.DataPropertyName = "ID_History";
            this.iDHistoryDataGridViewTextBoxColumn.HeaderText = "ID_History";
            this.iDHistoryDataGridViewTextBoxColumn.Name = "iDHistoryDataGridViewTextBoxColumn";
            this.iDHistoryDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDRegDataGridViewTextBoxColumn
            // 
            this.iDRegDataGridViewTextBoxColumn.DataPropertyName = "ID_Reg";
            this.iDRegDataGridViewTextBoxColumn.HeaderText = "ID_Reg";
            this.iDRegDataGridViewTextBoxColumn.Name = "iDRegDataGridViewTextBoxColumn";
            this.iDRegDataGridViewTextBoxColumn.Visible = false;
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
            // dataVhodDataGridViewTextBoxColumn
            // 
            this.dataVhodDataGridViewTextBoxColumn.DataPropertyName = "Data_Vhod";
            this.dataVhodDataGridViewTextBoxColumn.HeaderText = "Дата входа";
            this.dataVhodDataGridViewTextBoxColumn.Name = "dataVhodDataGridViewTextBoxColumn";
            // 
            // iPDataGridViewTextBoxColumn
            // 
            this.iPDataGridViewTextBoxColumn.DataPropertyName = "IP";
            this.iPDataGridViewTextBoxColumn.HeaderText = "IP";
            this.iPDataGridViewTextBoxColumn.Name = "iPDataGridViewTextBoxColumn";
            // 
            // namePKDataGridViewTextBoxColumn
            // 
            this.namePKDataGridViewTextBoxColumn.DataPropertyName = "Name_PK";
            this.namePKDataGridViewTextBoxColumn.HeaderText = "Имя ПК";
            this.namePKDataGridViewTextBoxColumn.Name = "namePKDataGridViewTextBoxColumn";
            // 
            // FIO
            // 
            this.FIO.DataPropertyName = "FIO";
            this.FIO.HeaderText = "ФИО";
            this.FIO.Name = "FIO";
            // 
            // viewHistoryBindingSource
            // 
            this.viewHistoryBindingSource.DataMember = "View_History";
            this.viewHistoryBindingSource.DataSource = this.deviseDataSet;
            // 
            // deviseDataSet
            // 
            this.deviseDataSet.DataSetName = "DeviseDataSet";
            this.deviseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(14, 371);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1009, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // view_HistoryTableAdapter
            // 
            this.view_HistoryTableAdapter.ClearBeforeFill = true;
            // 
            // F_History_Avtorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 435);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(1053, 474);
            this.Name = "F_History_Avtorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "История входа";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.F_History_Avtorization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private DeviseDataSet deviseDataSet;
        private System.Windows.Forms.BindingSource viewHistoryBindingSource;
        private DeviseDataSetTableAdapters.View_HistoryTableAdapter view_HistoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDHistoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDRegDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn porolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dostupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataVhodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namePKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIO;
    }
}