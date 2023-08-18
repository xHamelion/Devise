
namespace Devise
{
    partial class F_J_Vibit
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PDF = new System.Windows.Forms.Button();
            this.Exel = new System.Windows.Forms.Button();
            this.BTN_Dell = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDPokupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDNakladProdagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDSotrudnicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIOPokupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIOSotrudnicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataVibitiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dostavkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaObhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewJVibitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deviseDataSet = new Devise.DeviseDataSet();
            this.view_J_VibitTableAdapter = new Devise.DeviseDataSetTableAdapters.View_J_VibitTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CB_Fio_sotr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_Fio_Pok = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewJVibitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviseDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(346, 144);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(278, 29);
            this.textBox1.TabIndex = 93;
            this.textBox1.Text = "***";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PDF
            // 
            this.PDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PDF.Location = new System.Drawing.Point(25, 264);
            this.PDF.Margin = new System.Windows.Forms.Padding(8);
            this.PDF.Name = "PDF";
            this.PDF.Size = new System.Drawing.Size(280, 60);
            this.PDF.TabIndex = 91;
            this.PDF.Text = "Экспорт в PDF";
            this.PDF.UseVisualStyleBackColor = true;
            this.PDF.Click += new System.EventHandler(this.PDF_Click);
            // 
            // Exel
            // 
            this.Exel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Exel.Location = new System.Drawing.Point(25, 189);
            this.Exel.Margin = new System.Windows.Forms.Padding(8);
            this.Exel.Name = "Exel";
            this.Exel.Size = new System.Drawing.Size(280, 60);
            this.Exel.TabIndex = 90;
            this.Exel.Text = "Экспорт в Exel";
            this.Exel.UseVisualStyleBackColor = true;
            this.Exel.Click += new System.EventHandler(this.Exel_Click);
            // 
            // BTN_Dell
            // 
            this.BTN_Dell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTN_Dell.Location = new System.Drawing.Point(25, 113);
            this.BTN_Dell.Margin = new System.Windows.Forms.Padding(8);
            this.BTN_Dell.Name = "BTN_Dell";
            this.BTN_Dell.Size = new System.Drawing.Size(280, 60);
            this.BTN_Dell.TabIndex = 89;
            this.BTN_Dell.Text = "Удалить";
            this.BTN_Dell.UseVisualStyleBackColor = true;
            this.BTN_Dell.Click += new System.EventHandler(this.BTN_Dell_Click);
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
            this.iDPokupDataGridViewTextBoxColumn,
            this.iDNakladProdagDataGridViewTextBoxColumn,
            this.iDSotrudnicDataGridViewTextBoxColumn,
            this.fIOPokupDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.fIOSotrudnicDataGridViewTextBoxColumn,
            this.dataVibitiaDataGridViewTextBoxColumn,
            this.nomerDataGridViewTextBoxColumn,
            this.summaDataGridViewTextBoxColumn,
            this.dostavkaDataGridViewTextBoxColumn,
            this.summaObhDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.viewJVibitBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-6, -4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1281, 94);
            this.dataGridView1.TabIndex = 88;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // iDPokupDataGridViewTextBoxColumn
            // 
            this.iDPokupDataGridViewTextBoxColumn.DataPropertyName = "ID_Pokup";
            this.iDPokupDataGridViewTextBoxColumn.HeaderText = "Код покупателя";
            this.iDPokupDataGridViewTextBoxColumn.Name = "iDPokupDataGridViewTextBoxColumn";
            this.iDPokupDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDNakladProdagDataGridViewTextBoxColumn
            // 
            this.iDNakladProdagDataGridViewTextBoxColumn.DataPropertyName = "ID_Naklad_Prodag";
            this.iDNakladProdagDataGridViewTextBoxColumn.HeaderText = "Код накладной";
            this.iDNakladProdagDataGridViewTextBoxColumn.Name = "iDNakladProdagDataGridViewTextBoxColumn";
            this.iDNakladProdagDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDSotrudnicDataGridViewTextBoxColumn
            // 
            this.iDSotrudnicDataGridViewTextBoxColumn.DataPropertyName = "ID_Sotrudnic";
            this.iDSotrudnicDataGridViewTextBoxColumn.HeaderText = "Код сотрудника";
            this.iDSotrudnicDataGridViewTextBoxColumn.Name = "iDSotrudnicDataGridViewTextBoxColumn";
            this.iDSotrudnicDataGridViewTextBoxColumn.Visible = false;
            // 
            // fIOPokupDataGridViewTextBoxColumn
            // 
            this.fIOPokupDataGridViewTextBoxColumn.DataPropertyName = "FIO_Pokup";
            this.fIOPokupDataGridViewTextBoxColumn.HeaderText = "ФИО покупателя";
            this.fIOPokupDataGridViewTextBoxColumn.Name = "fIOPokupDataGridViewTextBoxColumn";
            this.fIOPokupDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Телефон покупателя";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // fIOSotrudnicDataGridViewTextBoxColumn
            // 
            this.fIOSotrudnicDataGridViewTextBoxColumn.DataPropertyName = "FIO_Sotrudnic";
            this.fIOSotrudnicDataGridViewTextBoxColumn.HeaderText = "ФИО сотрудника";
            this.fIOSotrudnicDataGridViewTextBoxColumn.Name = "fIOSotrudnicDataGridViewTextBoxColumn";
            this.fIOSotrudnicDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataVibitiaDataGridViewTextBoxColumn
            // 
            this.dataVibitiaDataGridViewTextBoxColumn.DataPropertyName = "Data_Vibitia";
            this.dataVibitiaDataGridViewTextBoxColumn.HeaderText = "Дата продажи";
            this.dataVibitiaDataGridViewTextBoxColumn.Name = "dataVibitiaDataGridViewTextBoxColumn";
            // 
            // nomerDataGridViewTextBoxColumn
            // 
            this.nomerDataGridViewTextBoxColumn.DataPropertyName = "Nomer";
            this.nomerDataGridViewTextBoxColumn.HeaderText = "Накладная";
            this.nomerDataGridViewTextBoxColumn.Name = "nomerDataGridViewTextBoxColumn";
            // 
            // summaDataGridViewTextBoxColumn
            // 
            this.summaDataGridViewTextBoxColumn.DataPropertyName = "Summa";
            this.summaDataGridViewTextBoxColumn.HeaderText = "Сумма по товам";
            this.summaDataGridViewTextBoxColumn.Name = "summaDataGridViewTextBoxColumn";
            // 
            // dostavkaDataGridViewTextBoxColumn
            // 
            this.dostavkaDataGridViewTextBoxColumn.DataPropertyName = "Dostavka";
            this.dostavkaDataGridViewTextBoxColumn.HeaderText = "Доставка";
            this.dostavkaDataGridViewTextBoxColumn.Name = "dostavkaDataGridViewTextBoxColumn";
            // 
            // summaObhDataGridViewTextBoxColumn
            // 
            this.summaObhDataGridViewTextBoxColumn.DataPropertyName = "Summa_Obh";
            this.summaObhDataGridViewTextBoxColumn.HeaderText = "Сумма по заказу";
            this.summaObhDataGridViewTextBoxColumn.Name = "summaObhDataGridViewTextBoxColumn";
            // 
            // viewJVibitBindingSource
            // 
            this.viewJVibitBindingSource.DataMember = "View_J_Vibit";
            this.viewJVibitBindingSource.DataSource = this.deviseDataSet;
            // 
            // deviseDataSet
            // 
            this.deviseDataSet.DataSetName = "DeviseDataSet";
            this.deviseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_J_VibitTableAdapter
            // 
            this.view_J_VibitTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.CB_Fio_sotr);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CB_Fio_Pok);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(676, 100);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 281);
            this.panel1.TabIndex = 98;
            // 
            // CB_Fio_sotr
            // 
            this.CB_Fio_sotr.Location = new System.Drawing.Point(8, 90);
            this.CB_Fio_sotr.Margin = new System.Windows.Forms.Padding(5);
            this.CB_Fio_sotr.Name = "CB_Fio_sotr";
            this.CB_Fio_sotr.Size = new System.Drawing.Size(346, 29);
            this.CB_Fio_sotr.TabIndex = 98;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 97;
            this.label2.Text = "Накладная";
            // 
            // CB_Fio_Pok
            // 
            this.CB_Fio_Pok.Location = new System.Drawing.Point(8, 27);
            this.CB_Fio_Pok.Margin = new System.Windows.Forms.Padding(5);
            this.CB_Fio_Pok.Name = "CB_Fio_Pok";
            this.CB_Fio_Pok.Size = new System.Drawing.Size(346, 29);
            this.CB_Fio_Pok.TabIndex = 96;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 21);
            this.label1.TabIndex = 95;
            this.label1.Text = "ФИО покупателя";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Location = new System.Drawing.Point(8, 212);
            this.button3.Margin = new System.Windows.Forms.Padding(8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(348, 60);
            this.button3.TabIndex = 94;
            this.button3.Text = "Очистить фильтр";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(8, 136);
            this.button2.Margin = new System.Windows.Forms.Padding(8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(348, 60);
            this.button2.TabIndex = 93;
            this.button2.Text = "Фильтровать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.Location = new System.Drawing.Point(346, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 26);
            this.label3.TabIndex = 99;
            this.label3.Text = "Сумма";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // F_J_Vibit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 402);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PDF);
            this.Controls.Add(this.Exel);
            this.Controls.Add(this.BTN_Dell);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(1211, 441);
            this.Name = "F_J_Vibit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Журнал выбытия";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.F_J_Vibit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewJVibitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviseDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button PDF;
        private System.Windows.Forms.Button Exel;
        private System.Windows.Forms.Button BTN_Dell;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DeviseDataSet deviseDataSet;
        private System.Windows.Forms.BindingSource viewJVibitBindingSource;
        private DeviseDataSetTableAdapters.View_J_VibitTableAdapter view_J_VibitTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox CB_Fio_sotr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CB_Fio_Pok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPokupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDNakladProdagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSotrudnicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIOPokupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIOSotrudnicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataVibitiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dostavkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaObhDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
    }
}