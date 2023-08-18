
namespace Devise
{
    partial class F_Sost_Nakladnoi
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
            this.BTN_Dob = new System.Windows.Forms.Button();
            this.BTN_Dell = new System.Windows.Forms.Button();
            this.BTN_Red = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDNakladnaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTovarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPostavhickDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDSotrudnicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPodTipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.podTipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tovarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naimenovanieOrganizDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIOSotrudnicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPostavkiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kollDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.hranimViewSostNakladnaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deviseDataSet = new Devise.DeviseDataSet();
            this.hranim_View_Sost_NakladnaTableAdapter = new Devise.DeviseDataSetTableAdapters.Hranim_View_Sost_NakladnaTableAdapter();
            this.tableAdapterManager = new Devise.DeviseDataSetTableAdapters.TableAdapterManager();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.opisanieRichTextBox = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_spravka = new System.Windows.Forms.Button();
            this.CB_Nomer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_Fio_sotr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_Fio_Pok = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hranimViewSostNakladnaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PDF
            // 
            this.PDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PDF.Location = new System.Drawing.Point(23, 352);
            this.PDF.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.PDF.Name = "PDF";
            this.PDF.Size = new System.Drawing.Size(280, 35);
            this.PDF.TabIndex = 74;
            this.PDF.Text = "Экспорт в PDF";
            this.PDF.UseVisualStyleBackColor = true;
            this.PDF.Click += new System.EventHandler(this.PDF_Click);
            // 
            // Exel
            // 
            this.Exel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Exel.Location = new System.Drawing.Point(23, 301);
            this.Exel.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Exel.Name = "Exel";
            this.Exel.Size = new System.Drawing.Size(280, 35);
            this.Exel.TabIndex = 73;
            this.Exel.Text = "Экспорт в Exel";
            this.Exel.UseVisualStyleBackColor = true;
            this.Exel.Click += new System.EventHandler(this.Exel_Click);
            // 
            // BTN_Dob
            // 
            this.BTN_Dob.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTN_Dob.Location = new System.Drawing.Point(23, 198);
            this.BTN_Dob.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.BTN_Dob.Name = "BTN_Dob";
            this.BTN_Dob.Size = new System.Drawing.Size(280, 35);
            this.BTN_Dob.TabIndex = 72;
            this.BTN_Dob.Text = "Добавить";
            this.BTN_Dob.UseVisualStyleBackColor = true;
            this.BTN_Dob.Click += new System.EventHandler(this.BTN_Dob_Click);
            // 
            // BTN_Dell
            // 
            this.BTN_Dell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTN_Dell.Location = new System.Drawing.Point(23, 249);
            this.BTN_Dell.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.BTN_Dell.Name = "BTN_Dell";
            this.BTN_Dell.Size = new System.Drawing.Size(280, 35);
            this.BTN_Dell.TabIndex = 71;
            this.BTN_Dell.Text = "Удалить";
            this.BTN_Dell.UseVisualStyleBackColor = true;
            this.BTN_Dell.Click += new System.EventHandler(this.BTN_Dell_Click);
            // 
            // BTN_Red
            // 
            this.BTN_Red.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTN_Red.Location = new System.Drawing.Point(23, 150);
            this.BTN_Red.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.BTN_Red.Name = "BTN_Red";
            this.BTN_Red.Size = new System.Drawing.Size(280, 35);
            this.BTN_Red.TabIndex = 70;
            this.BTN_Red.Text = "Редактировать";
            this.BTN_Red.UseVisualStyleBackColor = true;
            this.BTN_Red.Click += new System.EventHandler(this.BTN_Red_Click);
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
            this.iDNakladnaDataGridViewTextBoxColumn,
            this.iDTovarDataGridViewTextBoxColumn,
            this.iDPostavhickDataGridViewTextBoxColumn,
            this.iDSotrudnicDataGridViewTextBoxColumn,
            this.iDPodTipDataGridViewTextBoxColumn,
            this.iDTipDataGridViewTextBoxColumn,
            this.tipDataGridViewTextBoxColumn,
            this.podTipDataGridViewTextBoxColumn,
            this.tovarDataGridViewTextBoxColumn,
            this.opisanieDataGridViewTextBoxColumn,
            this.naimenovanieOrganizDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.fIOSotrudnicDataGridViewTextBoxColumn,
            this.dataPostavkiDataGridViewTextBoxColumn,
            this.kollDataGridViewTextBoxColumn,
            this.zenaDataGridViewTextBoxColumn,
            this.summaDataGridViewTextBoxColumn,
            this.imageDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.hranimViewSostNakladnaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-4, -3);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1314, 138);
            this.dataGridView1.TabIndex = 69;
            // 
            // iDNakladnaDataGridViewTextBoxColumn
            // 
            this.iDNakladnaDataGridViewTextBoxColumn.DataPropertyName = "ID_Nakladna";
            this.iDNakladnaDataGridViewTextBoxColumn.HeaderText = "Код накладной";
            this.iDNakladnaDataGridViewTextBoxColumn.Name = "iDNakladnaDataGridViewTextBoxColumn";
            this.iDNakladnaDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDTovarDataGridViewTextBoxColumn
            // 
            this.iDTovarDataGridViewTextBoxColumn.DataPropertyName = "ID_Tovar";
            this.iDTovarDataGridViewTextBoxColumn.HeaderText = "Код товара";
            this.iDTovarDataGridViewTextBoxColumn.Name = "iDTovarDataGridViewTextBoxColumn";
            this.iDTovarDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDPostavhickDataGridViewTextBoxColumn
            // 
            this.iDPostavhickDataGridViewTextBoxColumn.DataPropertyName = "ID_Postavhick";
            this.iDPostavhickDataGridViewTextBoxColumn.HeaderText = "Код поставшика";
            this.iDPostavhickDataGridViewTextBoxColumn.Name = "iDPostavhickDataGridViewTextBoxColumn";
            this.iDPostavhickDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDSotrudnicDataGridViewTextBoxColumn
            // 
            this.iDSotrudnicDataGridViewTextBoxColumn.DataPropertyName = "ID_Sotrudnic";
            this.iDSotrudnicDataGridViewTextBoxColumn.HeaderText = "Код сотрудника";
            this.iDSotrudnicDataGridViewTextBoxColumn.Name = "iDSotrudnicDataGridViewTextBoxColumn";
            this.iDSotrudnicDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDPodTipDataGridViewTextBoxColumn
            // 
            this.iDPodTipDataGridViewTextBoxColumn.DataPropertyName = "ID_PodTip";
            this.iDPodTipDataGridViewTextBoxColumn.HeaderText = "Код подтипа товара";
            this.iDPodTipDataGridViewTextBoxColumn.Name = "iDPodTipDataGridViewTextBoxColumn";
            this.iDPodTipDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDTipDataGridViewTextBoxColumn
            // 
            this.iDTipDataGridViewTextBoxColumn.DataPropertyName = "ID_Tip";
            this.iDTipDataGridViewTextBoxColumn.HeaderText = "Код типа товара";
            this.iDTipDataGridViewTextBoxColumn.Name = "iDTipDataGridViewTextBoxColumn";
            this.iDTipDataGridViewTextBoxColumn.Visible = false;
            // 
            // tipDataGridViewTextBoxColumn
            // 
            this.tipDataGridViewTextBoxColumn.DataPropertyName = "Tip";
            this.tipDataGridViewTextBoxColumn.HeaderText = "Тип товара";
            this.tipDataGridViewTextBoxColumn.Name = "tipDataGridViewTextBoxColumn";
            // 
            // podTipDataGridViewTextBoxColumn
            // 
            this.podTipDataGridViewTextBoxColumn.DataPropertyName = "PodTip";
            this.podTipDataGridViewTextBoxColumn.HeaderText = "Подтип товара";
            this.podTipDataGridViewTextBoxColumn.Name = "podTipDataGridViewTextBoxColumn";
            // 
            // tovarDataGridViewTextBoxColumn
            // 
            this.tovarDataGridViewTextBoxColumn.DataPropertyName = "Tovar";
            this.tovarDataGridViewTextBoxColumn.HeaderText = "Товар";
            this.tovarDataGridViewTextBoxColumn.Name = "tovarDataGridViewTextBoxColumn";
            // 
            // opisanieDataGridViewTextBoxColumn
            // 
            this.opisanieDataGridViewTextBoxColumn.DataPropertyName = "Opisanie";
            this.opisanieDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.opisanieDataGridViewTextBoxColumn.Name = "opisanieDataGridViewTextBoxColumn";
            this.opisanieDataGridViewTextBoxColumn.Visible = false;
            // 
            // naimenovanieOrganizDataGridViewTextBoxColumn
            // 
            this.naimenovanieOrganizDataGridViewTextBoxColumn.DataPropertyName = "Naimenovanie_Organiz";
            this.naimenovanieOrganizDataGridViewTextBoxColumn.HeaderText = "Поставшик";
            this.naimenovanieOrganizDataGridViewTextBoxColumn.Name = "naimenovanieOrganizDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Телефон поставшика";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // fIOSotrudnicDataGridViewTextBoxColumn
            // 
            this.fIOSotrudnicDataGridViewTextBoxColumn.DataPropertyName = "FIO_Sotrudnic";
            this.fIOSotrudnicDataGridViewTextBoxColumn.HeaderText = "ФИО сотрудника на приеме";
            this.fIOSotrudnicDataGridViewTextBoxColumn.Name = "fIOSotrudnicDataGridViewTextBoxColumn";
            this.fIOSotrudnicDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataPostavkiDataGridViewTextBoxColumn
            // 
            this.dataPostavkiDataGridViewTextBoxColumn.DataPropertyName = "Data_Postavki";
            this.dataPostavkiDataGridViewTextBoxColumn.HeaderText = "Дата поставки";
            this.dataPostavkiDataGridViewTextBoxColumn.Name = "dataPostavkiDataGridViewTextBoxColumn";
            this.dataPostavkiDataGridViewTextBoxColumn.Visible = false;
            // 
            // kollDataGridViewTextBoxColumn
            // 
            this.kollDataGridViewTextBoxColumn.DataPropertyName = "Koll";
            this.kollDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.kollDataGridViewTextBoxColumn.Name = "kollDataGridViewTextBoxColumn";
            // 
            // zenaDataGridViewTextBoxColumn
            // 
            this.zenaDataGridViewTextBoxColumn.DataPropertyName = "Zena";
            this.zenaDataGridViewTextBoxColumn.HeaderText = "Цена за шт.";
            this.zenaDataGridViewTextBoxColumn.Name = "zenaDataGridViewTextBoxColumn";
            // 
            // summaDataGridViewTextBoxColumn
            // 
            this.summaDataGridViewTextBoxColumn.DataPropertyName = "Summa";
            this.summaDataGridViewTextBoxColumn.HeaderText = "Сумма по товару";
            this.summaDataGridViewTextBoxColumn.Name = "summaDataGridViewTextBoxColumn";
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "Image";
            this.imageDataGridViewImageColumn.HeaderText = "Изображение";
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            this.imageDataGridViewImageColumn.Visible = false;
            // 
            // hranimViewSostNakladnaBindingSource
            // 
            this.hranimViewSostNakladnaBindingSource.DataMember = "Hranim_View_Sost_Nakladna";
            this.hranimViewSostNakladnaBindingSource.DataSource = this.deviseDataSet;
            // 
            // deviseDataSet
            // 
            this.deviseDataSet.DataSetName = "DeviseDataSet";
            this.deviseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hranim_View_Sost_NakladnaTableAdapter
            // 
            this.hranim_View_Sost_NakladnaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.HablonTableAdapter = null;
            this.tableAdapterManager.HistoryTableAdapter = null;
            this.tableAdapterManager.InternetUserTableAdapter = null;
            this.tableAdapterManager.J_PostuplTableAdapter = null;
            this.tableAdapterManager.J_VibitTableAdapter = null;
            this.tableAdapterManager.Naklad_ProdagTableAdapter = null;
            this.tableAdapterManager.NakladnaTableAdapter = null;
            this.tableAdapterManager.PodTipTableAdapter = null;
            this.tableAdapterManager.PokupTableAdapter = null;
            this.tableAdapterManager.PostavhickTableAdapter = null;
            this.tableAdapterManager.RegTableAdapter = null;
            this.tableAdapterManager.SkladTableAdapter = null;
            this.tableAdapterManager.Sost_Naklad_ProdagTableAdapter = null;
            this.tableAdapterManager.Sost_NakladnaTableAdapter = null;
            this.tableAdapterManager.Sostav_PartiiTableAdapter = null;
            this.tableAdapterManager.Sostav_Postupl_NakladTableAdapter = null;
            this.tableAdapterManager.Sostav_Vibitie_NakladTableAdapter = null;
            this.tableAdapterManager.SotrudnicTableAdapter = null;
            this.tableAdapterManager.TipTableAdapter = null;
            this.tableAdapterManager.TovarTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Devise.DeviseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imagePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.hranimViewSostNakladnaBindingSource, "Image", true));
            this.imagePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagePictureBox.Location = new System.Drawing.Point(302, 5);
            this.imagePictureBox.Margin = new System.Windows.Forms.Padding(5);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(228, 318);
            this.imagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePictureBox.TabIndex = 75;
            this.imagePictureBox.TabStop = false;
            // 
            // opisanieRichTextBox
            // 
            this.opisanieRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.opisanieRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hranimViewSostNakladnaBindingSource, "Opisanie", true));
            this.opisanieRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.opisanieRichTextBox.Location = new System.Drawing.Point(5, 5);
            this.opisanieRichTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.opisanieRichTextBox.Name = "opisanieRichTextBox";
            this.opisanieRichTextBox.ReadOnly = true;
            this.opisanieRichTextBox.Size = new System.Drawing.Size(287, 318);
            this.opisanieRichTextBox.TabIndex = 76;
            this.opisanieRichTextBox.Text = "";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_spravka);
            this.panel1.Controls.Add(this.CB_Nomer);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CB_Fio_sotr);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CB_Fio_Pok);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(384, 145);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 341);
            this.panel1.TabIndex = 98;
            // 
            // btn_spravka
            // 
            this.btn_spravka.Location = new System.Drawing.Point(120, 291);
            this.btn_spravka.Margin = new System.Windows.Forms.Padding(5);
            this.btn_spravka.Name = "btn_spravka";
            this.btn_spravka.Size = new System.Drawing.Size(125, 35);
            this.btn_spravka.TabIndex = 101;
            this.btn_spravka.Text = "Справка";
            this.btn_spravka.UseVisualStyleBackColor = true;
            this.btn_spravka.Click += new System.EventHandler(this.btn_spravka_Click);
            // 
            // CB_Nomer
            // 
            this.CB_Nomer.Location = new System.Drawing.Point(9, 150);
            this.CB_Nomer.Margin = new System.Windows.Forms.Padding(5);
            this.CB_Nomer.Name = "CB_Nomer";
            this.CB_Nomer.Size = new System.Drawing.Size(347, 29);
            this.CB_Nomer.TabIndex = 100;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 21);
            this.label3.TabIndex = 99;
            this.label3.Text = "Наименование товара";
            // 
            // CB_Fio_sotr
            // 
            this.CB_Fio_sotr.Location = new System.Drawing.Point(9, 91);
            this.CB_Fio_sotr.Margin = new System.Windows.Forms.Padding(5);
            this.CB_Fio_sotr.Name = "CB_Fio_sotr";
            this.CB_Fio_sotr.Size = new System.Drawing.Size(347, 29);
            this.CB_Fio_sotr.TabIndex = 98;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 21);
            this.label2.TabIndex = 97;
            this.label2.Text = "Подтип товара";
            // 
            // CB_Fio_Pok
            // 
            this.CB_Fio_Pok.Location = new System.Drawing.Point(9, 28);
            this.CB_Fio_Pok.Margin = new System.Windows.Forms.Padding(5);
            this.CB_Fio_Pok.Name = "CB_Fio_Pok";
            this.CB_Fio_Pok.Size = new System.Drawing.Size(347, 29);
            this.CB_Fio_Pok.TabIndex = 96;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 95;
            this.label1.Text = "Тип товара";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(7, 243);
            this.button3.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(349, 35);
            this.button3.TabIndex = 94;
            this.button3.Text = "Очистить фильтр";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 196);
            this.button2.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(349, 35);
            this.button2.TabIndex = 93;
            this.button2.Text = "Фильтровать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.61735F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.38265F));
            this.tableLayoutPanel1.Controls.Add(this.opisanieRichTextBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.imagePictureBox, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(775, 145);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(535, 328);
            this.tableLayoutPanel1.TabIndex = 99;
            // 
            // F_Sost_Nakladnoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 491);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PDF);
            this.Controls.Add(this.Exel);
            this.Controls.Add(this.BTN_Dob);
            this.Controls.Add(this.BTN_Dell);
            this.Controls.Add(this.BTN_Red);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(1317, 530);
            this.Name = "F_Sost_Nakladnoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Состав накладной";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.F_Sost_Nakladnoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hranimViewSostNakladnaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PDF;
        private System.Windows.Forms.Button Exel;
        private System.Windows.Forms.Button BTN_Dob;
        private System.Windows.Forms.Button BTN_Dell;
        private System.Windows.Forms.Button BTN_Red;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource hranimViewSostNakladnaBindingSource;
        private DeviseDataSet deviseDataSet;
        private DeviseDataSetTableAdapters.Hranim_View_Sost_NakladnaTableAdapter hranim_View_Sost_NakladnaTableAdapter;
        private DeviseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.RichTextBox opisanieRichTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDNakladnaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTovarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPostavhickDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSotrudnicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPodTipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn podTipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tovarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn naimenovanieOrganizDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIOSotrudnicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPostavkiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kollDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox CB_Nomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CB_Fio_sotr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CB_Fio_Pok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_spravka;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}