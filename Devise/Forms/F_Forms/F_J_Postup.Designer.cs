
namespace Devise
{
    partial class F_J_Postup
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
            this.PDF = new System.Windows.Forms.Button();
            this.Exel = new System.Windows.Forms.Button();
            this.BTN_Dell = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDPostavhickDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDNakladnaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDSotrudnicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naimenovanieOrganizDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPostavkiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewJPostuplBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deviseDataSet = new Devise.DeviseDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.view_J_PostuplTableAdapter = new Devise.DeviseDataSetTableAdapters.View_J_PostuplTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CB_Nomer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_Fio_sotr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_Fio_Pok = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewJPostuplBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviseDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PDF
            // 
            this.PDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PDF.Location = new System.Drawing.Point(22, 299);
            this.PDF.Margin = new System.Windows.Forms.Padding(8);
            this.PDF.Name = "PDF";
            this.PDF.Size = new System.Drawing.Size(280, 60);
            this.PDF.TabIndex = 79;
            this.PDF.Text = "Экспорт в PDF";
            this.PDF.UseVisualStyleBackColor = true;
            this.PDF.Click += new System.EventHandler(this.PDF_Click);
            // 
            // Exel
            // 
            this.Exel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Exel.Location = new System.Drawing.Point(22, 223);
            this.Exel.Margin = new System.Windows.Forms.Padding(8);
            this.Exel.Name = "Exel";
            this.Exel.Size = new System.Drawing.Size(280, 60);
            this.Exel.TabIndex = 78;
            this.Exel.Text = "Экспорт в Exel";
            this.Exel.UseVisualStyleBackColor = true;
            this.Exel.Click += new System.EventHandler(this.Exel_Click);
            // 
            // BTN_Dell
            // 
            this.BTN_Dell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTN_Dell.Location = new System.Drawing.Point(22, 147);
            this.BTN_Dell.Margin = new System.Windows.Forms.Padding(8);
            this.BTN_Dell.Name = "BTN_Dell";
            this.BTN_Dell.Size = new System.Drawing.Size(280, 60);
            this.BTN_Dell.TabIndex = 77;
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
            this.iDPostavhickDataGridViewTextBoxColumn,
            this.iDNakladnaDataGridViewTextBoxColumn,
            this.iDSotrudnicDataGridViewTextBoxColumn,
            this.naimenovanieOrganizDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.fIODataGridViewTextBoxColumn,
            this.dataPostavkiDataGridViewTextBoxColumn,
            this.nomerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.viewJPostuplBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-3, -3);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1267, 139);
            this.dataGridView1.TabIndex = 76;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // iDPostavhickDataGridViewTextBoxColumn
            // 
            this.iDPostavhickDataGridViewTextBoxColumn.DataPropertyName = "ID_Postavhick";
            this.iDPostavhickDataGridViewTextBoxColumn.HeaderText = "Код поставшика";
            this.iDPostavhickDataGridViewTextBoxColumn.Name = "iDPostavhickDataGridViewTextBoxColumn";
            this.iDPostavhickDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDNakladnaDataGridViewTextBoxColumn
            // 
            this.iDNakladnaDataGridViewTextBoxColumn.DataPropertyName = "ID_Nakladna";
            this.iDNakladnaDataGridViewTextBoxColumn.HeaderText = "Код накладной";
            this.iDNakladnaDataGridViewTextBoxColumn.Name = "iDNakladnaDataGridViewTextBoxColumn";
            this.iDNakladnaDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDSotrudnicDataGridViewTextBoxColumn
            // 
            this.iDSotrudnicDataGridViewTextBoxColumn.DataPropertyName = "ID_Sotrudnic";
            this.iDSotrudnicDataGridViewTextBoxColumn.HeaderText = "Код сотрудника";
            this.iDSotrudnicDataGridViewTextBoxColumn.Name = "iDSotrudnicDataGridViewTextBoxColumn";
            this.iDSotrudnicDataGridViewTextBoxColumn.Visible = false;
            // 
            // naimenovanieOrganizDataGridViewTextBoxColumn
            // 
            this.naimenovanieOrganizDataGridViewTextBoxColumn.DataPropertyName = "Naimenovanie_Organiz";
            this.naimenovanieOrganizDataGridViewTextBoxColumn.HeaderText = "Наименование организации";
            this.naimenovanieOrganizDataGridViewTextBoxColumn.Name = "naimenovanieOrganizDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Телефон организации";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "ФИО сотрудника";
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            this.fIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataPostavkiDataGridViewTextBoxColumn
            // 
            this.dataPostavkiDataGridViewTextBoxColumn.DataPropertyName = "Data_Postavki";
            this.dataPostavkiDataGridViewTextBoxColumn.HeaderText = "Дата поставки";
            this.dataPostavkiDataGridViewTextBoxColumn.Name = "dataPostavkiDataGridViewTextBoxColumn";
            // 
            // nomerDataGridViewTextBoxColumn
            // 
            this.nomerDataGridViewTextBoxColumn.DataPropertyName = "Nomer";
            this.nomerDataGridViewTextBoxColumn.HeaderText = "Номер накладной";
            this.nomerDataGridViewTextBoxColumn.Name = "nomerDataGridViewTextBoxColumn";
            // 
            // viewJPostuplBindingSource
            // 
            this.viewJPostuplBindingSource.DataMember = "View_J_Postupl";
            this.viewJPostuplBindingSource.DataSource = this.deviseDataSet;
            // 
            // deviseDataSet
            // 
            this.deviseDataSet.DataSetName = "DeviseDataSet";
            this.deviseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(507, 147);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 21);
            this.label1.TabIndex = 86;
            this.label1.Text = "Сумма по поставке";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(452, 172);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(266, 29);
            this.textBox1.TabIndex = 85;
            this.textBox1.Text = "***";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // view_J_PostuplTableAdapter
            // 
            this.view_J_PostuplTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.CB_Nomer);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CB_Fio_sotr);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CB_Fio_Pok);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(836, 147);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 364);
            this.panel1.TabIndex = 98;
            // 
            // CB_Nomer
            // 
            this.CB_Nomer.Location = new System.Drawing.Point(8, 150);
            this.CB_Nomer.Margin = new System.Windows.Forms.Padding(5);
            this.CB_Nomer.Name = "CB_Nomer";
            this.CB_Nomer.Size = new System.Drawing.Size(346, 29);
            this.CB_Nomer.TabIndex = 100;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 21);
            this.label3.TabIndex = 99;
            this.label3.Text = "ФИО сотрудника";
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
            this.label2.Size = new System.Drawing.Size(185, 21);
            this.label2.TabIndex = 97;
            this.label2.Text = "Телефон организации";
            // 
            // CB_Fio_Pok
            // 
            this.CB_Fio_Pok.Location = new System.Drawing.Point(8, 27);
            this.CB_Fio_Pok.Margin = new System.Windows.Forms.Padding(5);
            this.CB_Fio_Pok.Name = "CB_Fio_Pok";
            this.CB_Fio_Pok.Size = new System.Drawing.Size(346, 29);
            this.CB_Fio_Pok.TabIndex = 96;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 2);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 21);
            this.label4.TabIndex = 95;
            this.label4.Text = "Наименование организации";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Location = new System.Drawing.Point(8, 275);
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
            this.button2.Location = new System.Drawing.Point(8, 199);
            this.button2.Margin = new System.Windows.Forms.Padding(8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(348, 60);
            this.button2.TabIndex = 93;
            this.button2.Text = "Фильтровать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // F_J_Postup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 519);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PDF);
            this.Controls.Add(this.Exel);
            this.Controls.Add(this.BTN_Dell);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(1279, 558);
            this.Name = "F_J_Postup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Журнал поступления";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_J_Postup_FormClosed);
            this.Load += new System.EventHandler(this.F_J_Postup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewJPostuplBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviseDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button PDF;
        private System.Windows.Forms.Button Exel;
        private System.Windows.Forms.Button BTN_Dell;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private DeviseDataSet deviseDataSet;
        private System.Windows.Forms.BindingSource viewJPostuplBindingSource;
        private DeviseDataSetTableAdapters.View_J_PostuplTableAdapter view_J_PostuplTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPostavhickDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDNakladnaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSotrudnicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn naimenovanieOrganizDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPostavkiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox CB_Nomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CB_Fio_sotr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CB_Fio_Pok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}