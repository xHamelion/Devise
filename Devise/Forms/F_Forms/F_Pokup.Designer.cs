
namespace Devise
{
    partial class F_Pokup
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
            this.iDPokupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otzhestvoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewPokupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deviseDataSet = new Devise.DeviseDataSet();
            this.PDF = new System.Windows.Forms.Button();
            this.Exel = new System.Windows.Forms.Button();
            this.BTN_Dob = new System.Windows.Forms.Button();
            this.BTN_Dell = new System.Windows.Forms.Button();
            this.BTN_Red = new System.Windows.Forms.Button();
            this.view_PokupTableAdapter = new Devise.DeviseDataSetTableAdapters.View_PokupTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CB_Fio_sotr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_Fio_Pok = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_spravka = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPokupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviseDataSet)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.iDPokupDataGridViewTextBoxColumn,
            this.fIODataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.familiaDataGridViewTextBoxColumn,
            this.imiaDataGridViewTextBoxColumn,
            this.otzhestvoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.viewPokupBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-5, -4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(999, 84);
            this.dataGridView1.TabIndex = 65;
            // 
            // iDPokupDataGridViewTextBoxColumn
            // 
            this.iDPokupDataGridViewTextBoxColumn.DataPropertyName = "ID_Pokup";
            this.iDPokupDataGridViewTextBoxColumn.HeaderText = "Код покупателя";
            this.iDPokupDataGridViewTextBoxColumn.Name = "iDPokupDataGridViewTextBoxColumn";
            this.iDPokupDataGridViewTextBoxColumn.ReadOnly = true;
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
            // otzhestvoDataGridViewTextBoxColumn
            // 
            this.otzhestvoDataGridViewTextBoxColumn.DataPropertyName = "Otzhestvo";
            this.otzhestvoDataGridViewTextBoxColumn.HeaderText = "Otzhestvo";
            this.otzhestvoDataGridViewTextBoxColumn.Name = "otzhestvoDataGridViewTextBoxColumn";
            this.otzhestvoDataGridViewTextBoxColumn.Visible = false;
            // 
            // viewPokupBindingSource
            // 
            this.viewPokupBindingSource.DataMember = "View_Pokup";
            this.viewPokupBindingSource.DataSource = this.deviseDataSet;
            // 
            // deviseDataSet
            // 
            this.deviseDataSet.DataSetName = "DeviseDataSet";
            this.deviseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PDF
            // 
            this.PDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PDF.Location = new System.Drawing.Point(11, 393);
            this.PDF.Margin = new System.Windows.Forms.Padding(8);
            this.PDF.Name = "PDF";
            this.PDF.Size = new System.Drawing.Size(280, 60);
            this.PDF.TabIndex = 70;
            this.PDF.Text = "Экспорт в PDF";
            this.PDF.UseVisualStyleBackColor = true;
            this.PDF.Click += new System.EventHandler(this.PDF_Click);
            // 
            // Exel
            // 
            this.Exel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Exel.Location = new System.Drawing.Point(11, 317);
            this.Exel.Margin = new System.Windows.Forms.Padding(8);
            this.Exel.Name = "Exel";
            this.Exel.Size = new System.Drawing.Size(280, 60);
            this.Exel.TabIndex = 69;
            this.Exel.Text = "Экспорт в Exel";
            this.Exel.UseVisualStyleBackColor = true;
            this.Exel.Click += new System.EventHandler(this.Exel_Click);
            // 
            // BTN_Dob
            // 
            this.BTN_Dob.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTN_Dob.Location = new System.Drawing.Point(11, 166);
            this.BTN_Dob.Margin = new System.Windows.Forms.Padding(8);
            this.BTN_Dob.Name = "BTN_Dob";
            this.BTN_Dob.Size = new System.Drawing.Size(280, 60);
            this.BTN_Dob.TabIndex = 68;
            this.BTN_Dob.Text = "Добавить";
            this.BTN_Dob.UseVisualStyleBackColor = true;
            this.BTN_Dob.Click += new System.EventHandler(this.BTN_Dob_Click);
            // 
            // BTN_Dell
            // 
            this.BTN_Dell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTN_Dell.Location = new System.Drawing.Point(11, 241);
            this.BTN_Dell.Margin = new System.Windows.Forms.Padding(8);
            this.BTN_Dell.Name = "BTN_Dell";
            this.BTN_Dell.Size = new System.Drawing.Size(280, 60);
            this.BTN_Dell.TabIndex = 67;
            this.BTN_Dell.Text = "Удалить";
            this.BTN_Dell.UseVisualStyleBackColor = true;
            this.BTN_Dell.Click += new System.EventHandler(this.BTN_Dell_Click);
            // 
            // BTN_Red
            // 
            this.BTN_Red.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTN_Red.Location = new System.Drawing.Point(11, 91);
            this.BTN_Red.Margin = new System.Windows.Forms.Padding(8);
            this.BTN_Red.Name = "BTN_Red";
            this.BTN_Red.Size = new System.Drawing.Size(280, 60);
            this.BTN_Red.TabIndex = 66;
            this.BTN_Red.Text = "Редактировать";
            this.BTN_Red.UseVisualStyleBackColor = true;
            this.BTN_Red.Click += new System.EventHandler(this.BTN_Red_Click);
            // 
            // view_PokupTableAdapter
            // 
            this.view_PokupTableAdapter.ClearBeforeFill = true;
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
            this.panel1.Location = new System.Drawing.Point(349, 91);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 361);
            this.panel1.TabIndex = 99;
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
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 97;
            this.label2.Text = "Телефон";
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
            this.label1.Size = new System.Drawing.Size(51, 21);
            this.label1.TabIndex = 95;
            this.label1.Text = "ФИО";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Location = new System.Drawing.Point(8, 271);
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
            this.button2.Location = new System.Drawing.Point(8, 195);
            this.button2.Margin = new System.Windows.Forms.Padding(8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(348, 60);
            this.button2.TabIndex = 93;
            this.button2.Text = "Фильтровать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_spravka
            // 
            this.btn_spravka.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_spravka.Location = new System.Drawing.Point(840, 410);
            this.btn_spravka.Margin = new System.Windows.Forms.Padding(5);
            this.btn_spravka.Name = "btn_spravka";
            this.btn_spravka.Size = new System.Drawing.Size(125, 37);
            this.btn_spravka.TabIndex = 101;
            this.btn_spravka.Text = "Справка";
            this.btn_spravka.UseVisualStyleBackColor = true;
            this.btn_spravka.Click += new System.EventHandler(this.btn_spravka_Click);
            // 
            // F_Pokup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 465);
            this.Controls.Add(this.btn_spravka);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PDF);
            this.Controls.Add(this.Exel);
            this.Controls.Add(this.BTN_Dob);
            this.Controls.Add(this.BTN_Dell);
            this.Controls.Add(this.BTN_Red);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(1001, 504);
            this.Name = "F_Pokup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Покупатели";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_Pokup_FormClosed);
            this.Load += new System.EventHandler(this.F_Pokup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPokupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviseDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button PDF;
        private System.Windows.Forms.Button Exel;
        private System.Windows.Forms.Button BTN_Dob;
        private System.Windows.Forms.Button BTN_Dell;
        private System.Windows.Forms.Button BTN_Red;
        private DeviseDataSet deviseDataSet;
        private System.Windows.Forms.BindingSource viewPokupBindingSource;
        private DeviseDataSetTableAdapters.View_PokupTableAdapter view_PokupTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPokupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otzhestvoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox CB_Fio_sotr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CB_Fio_Pok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_spravka;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}