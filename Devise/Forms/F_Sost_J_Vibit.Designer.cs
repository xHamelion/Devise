
namespace Devise
{
    partial class F_Sost_J_Vibit
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
            this.iDNakladProdagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTovarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPodTipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.podTipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tovarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kollDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.hranimSostJVibitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deviseDataSet = new Devise.DeviseDataSet();
            this.hranim_Sost_J_VibitTableAdapter = new Devise.DeviseDataSetTableAdapters.Hranim_Sost_J_VibitTableAdapter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.opisanieRichTextBox = new System.Windows.Forms.RichTextBox();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tableAdapterManager = new Devise.DeviseDataSetTableAdapters.TableAdapterManager();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDSkladDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTovarDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPodTipDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTipDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.podTipDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tovarDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisanieDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kollDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.srednZenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.viewSkladBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_SkladTableAdapter = new Devise.DeviseDataSetTableAdapters.View_SkladTableAdapter();
            this.btn_spravka = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hranimSostJVibitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviseDataSet)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSkladBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDNakladProdagDataGridViewTextBoxColumn,
            this.iDTovarDataGridViewTextBoxColumn,
            this.iDPodTipDataGridViewTextBoxColumn,
            this.iDTipDataGridViewTextBoxColumn,
            this.tipDataGridViewTextBoxColumn,
            this.podTipDataGridViewTextBoxColumn,
            this.tovarDataGridViewTextBoxColumn,
            this.opisanieDataGridViewTextBoxColumn,
            this.kollDataGridViewTextBoxColumn,
            this.zenaDataGridViewTextBoxColumn,
            this.summaDataGridViewTextBoxColumn,
            this.imageDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.hranimSostJVibitBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1316, 258);
            this.dataGridView1.TabIndex = 1;
            // 
            // iDNakladProdagDataGridViewTextBoxColumn
            // 
            this.iDNakladProdagDataGridViewTextBoxColumn.DataPropertyName = "ID_Naklad_Prodag";
            this.iDNakladProdagDataGridViewTextBoxColumn.HeaderText = "Код накладной";
            this.iDNakladProdagDataGridViewTextBoxColumn.Name = "iDNakladProdagDataGridViewTextBoxColumn";
            // 
            // iDTovarDataGridViewTextBoxColumn
            // 
            this.iDTovarDataGridViewTextBoxColumn.DataPropertyName = "ID_Tovar";
            this.iDTovarDataGridViewTextBoxColumn.HeaderText = "Код товара";
            this.iDTovarDataGridViewTextBoxColumn.Name = "iDTovarDataGridViewTextBoxColumn";
            // 
            // iDPodTipDataGridViewTextBoxColumn
            // 
            this.iDPodTipDataGridViewTextBoxColumn.DataPropertyName = "ID_PodTip";
            this.iDPodTipDataGridViewTextBoxColumn.HeaderText = "Код подтипа";
            this.iDPodTipDataGridViewTextBoxColumn.Name = "iDPodTipDataGridViewTextBoxColumn";
            // 
            // iDTipDataGridViewTextBoxColumn
            // 
            this.iDTipDataGridViewTextBoxColumn.DataPropertyName = "ID_Tip";
            this.iDTipDataGridViewTextBoxColumn.HeaderText = "Код типа";
            this.iDTipDataGridViewTextBoxColumn.Name = "iDTipDataGridViewTextBoxColumn";
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
            this.zenaDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.zenaDataGridViewTextBoxColumn.Name = "zenaDataGridViewTextBoxColumn";
            // 
            // summaDataGridViewTextBoxColumn
            // 
            this.summaDataGridViewTextBoxColumn.DataPropertyName = "Summa";
            this.summaDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.summaDataGridViewTextBoxColumn.Name = "summaDataGridViewTextBoxColumn";
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "Image";
            this.imageDataGridViewImageColumn.HeaderText = "Изображение";
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            this.imageDataGridViewImageColumn.Visible = false;
            // 
            // hranimSostJVibitBindingSource
            // 
            this.hranimSostJVibitBindingSource.DataMember = "Hranim_Sost_J_Vibit";
            this.hranimSostJVibitBindingSource.DataSource = this.deviseDataSet;
            // 
            // deviseDataSet
            // 
            this.deviseDataSet.DataSetName = "DeviseDataSet";
            this.deviseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hranim_Sost_J_VibitTableAdapter
            // 
            this.hranim_Sost_J_VibitTableAdapter.ClearBeforeFill = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-1, -2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1322, 529);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel2.Controls.Add(this.opisanieRichTextBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.imagePictureBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 267);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 259F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1316, 259);
            this.tableLayoutPanel2.TabIndex = 3;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // opisanieRichTextBox
            // 
            this.opisanieRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hranimSostJVibitBindingSource, "Opisanie", true));
            this.opisanieRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.opisanieRichTextBox.Location = new System.Drawing.Point(3, 3);
            this.opisanieRichTextBox.Name = "opisanieRichTextBox";
            this.opisanieRichTextBox.Size = new System.Drawing.Size(604, 253);
            this.opisanieRichTextBox.TabIndex = 5;
            this.opisanieRichTextBox.Text = "";
            this.opisanieRichTextBox.TextChanged += new System.EventHandler(this.opisanieRichTextBox_TextChanged);
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.hranimSostJVibitBindingSource, "Image", true));
            this.imagePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagePictureBox.Location = new System.Drawing.Point(613, 3);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(604, 253);
            this.imagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imagePictureBox.TabIndex = 4;
            this.imagePictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1223, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 253);
            this.button1.TabIndex = 6;
            this.button1.Text = "Возврат";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.HablonTableAdapter = null;
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
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSkladDataGridViewTextBoxColumn,
            this.iDTovarDataGridViewTextBoxColumn1,
            this.iDPodTipDataGridViewTextBoxColumn1,
            this.iDTipDataGridViewTextBoxColumn1,
            this.tipDataGridViewTextBoxColumn1,
            this.podTipDataGridViewTextBoxColumn1,
            this.tovarDataGridViewTextBoxColumn1,
            this.opisanieDataGridViewTextBoxColumn1,
            this.kollDataGridViewTextBoxColumn1,
            this.srednZenaDataGridViewTextBoxColumn,
            this.imageDataGridViewImageColumn1});
            this.dataGridView2.DataSource = this.viewSkladBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(1191, 49);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(37, 316);
            this.dataGridView2.TabIndex = 85;
            // 
            // iDSkladDataGridViewTextBoxColumn
            // 
            this.iDSkladDataGridViewTextBoxColumn.DataPropertyName = "ID_Sklad";
            this.iDSkladDataGridViewTextBoxColumn.HeaderText = "ID_Sklad";
            this.iDSkladDataGridViewTextBoxColumn.Name = "iDSkladDataGridViewTextBoxColumn";
            // 
            // iDTovarDataGridViewTextBoxColumn1
            // 
            this.iDTovarDataGridViewTextBoxColumn1.DataPropertyName = "ID_Tovar";
            this.iDTovarDataGridViewTextBoxColumn1.HeaderText = "ID_Tovar";
            this.iDTovarDataGridViewTextBoxColumn1.Name = "iDTovarDataGridViewTextBoxColumn1";
            // 
            // iDPodTipDataGridViewTextBoxColumn1
            // 
            this.iDPodTipDataGridViewTextBoxColumn1.DataPropertyName = "ID_PodTip";
            this.iDPodTipDataGridViewTextBoxColumn1.HeaderText = "ID_PodTip";
            this.iDPodTipDataGridViewTextBoxColumn1.Name = "iDPodTipDataGridViewTextBoxColumn1";
            // 
            // iDTipDataGridViewTextBoxColumn1
            // 
            this.iDTipDataGridViewTextBoxColumn1.DataPropertyName = "ID_Tip";
            this.iDTipDataGridViewTextBoxColumn1.HeaderText = "ID_Tip";
            this.iDTipDataGridViewTextBoxColumn1.Name = "iDTipDataGridViewTextBoxColumn1";
            // 
            // tipDataGridViewTextBoxColumn1
            // 
            this.tipDataGridViewTextBoxColumn1.DataPropertyName = "Tip";
            this.tipDataGridViewTextBoxColumn1.HeaderText = "Tip";
            this.tipDataGridViewTextBoxColumn1.Name = "tipDataGridViewTextBoxColumn1";
            // 
            // podTipDataGridViewTextBoxColumn1
            // 
            this.podTipDataGridViewTextBoxColumn1.DataPropertyName = "PodTip";
            this.podTipDataGridViewTextBoxColumn1.HeaderText = "PodTip";
            this.podTipDataGridViewTextBoxColumn1.Name = "podTipDataGridViewTextBoxColumn1";
            // 
            // tovarDataGridViewTextBoxColumn1
            // 
            this.tovarDataGridViewTextBoxColumn1.DataPropertyName = "Tovar";
            this.tovarDataGridViewTextBoxColumn1.HeaderText = "Tovar";
            this.tovarDataGridViewTextBoxColumn1.Name = "tovarDataGridViewTextBoxColumn1";
            // 
            // opisanieDataGridViewTextBoxColumn1
            // 
            this.opisanieDataGridViewTextBoxColumn1.DataPropertyName = "Opisanie";
            this.opisanieDataGridViewTextBoxColumn1.HeaderText = "Opisanie";
            this.opisanieDataGridViewTextBoxColumn1.Name = "opisanieDataGridViewTextBoxColumn1";
            // 
            // kollDataGridViewTextBoxColumn1
            // 
            this.kollDataGridViewTextBoxColumn1.DataPropertyName = "Koll";
            this.kollDataGridViewTextBoxColumn1.HeaderText = "Koll";
            this.kollDataGridViewTextBoxColumn1.Name = "kollDataGridViewTextBoxColumn1";
            // 
            // srednZenaDataGridViewTextBoxColumn
            // 
            this.srednZenaDataGridViewTextBoxColumn.DataPropertyName = "Sredn_Zena";
            this.srednZenaDataGridViewTextBoxColumn.HeaderText = "Sredn_Zena";
            this.srednZenaDataGridViewTextBoxColumn.Name = "srednZenaDataGridViewTextBoxColumn";
            // 
            // imageDataGridViewImageColumn1
            // 
            this.imageDataGridViewImageColumn1.DataPropertyName = "Image";
            this.imageDataGridViewImageColumn1.HeaderText = "Image";
            this.imageDataGridViewImageColumn1.Name = "imageDataGridViewImageColumn1";
            // 
            // viewSkladBindingSource
            // 
            this.viewSkladBindingSource.DataMember = "View_Sklad";
            this.viewSkladBindingSource.DataSource = this.deviseDataSet;
            // 
            // view_SkladTableAdapter
            // 
            this.view_SkladTableAdapter.ClearBeforeFill = true;
            // 
            // btn_spravka
            // 
            this.btn_spravka.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_spravka.Location = new System.Drawing.Point(1233, 498);
            this.btn_spravka.Name = "btn_spravka";
            this.btn_spravka.Size = new System.Drawing.Size(75, 23);
            this.btn_spravka.TabIndex = 101;
            this.btn_spravka.Text = "Справка";
            this.btn_spravka.UseVisualStyleBackColor = true;
            this.btn_spravka.Click += new System.EventHandler(this.btn_spravka_Click);
            // 
            // F_Sost_J_Vibit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 524);
            this.Controls.Add(this.btn_spravka);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "F_Sost_J_Vibit";
            this.Text = "Состав продажи";
            this.Load += new System.EventHandler(this.F_Sost_J_Vibit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hranimSostJVibitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviseDataSet)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSkladBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource hranimSostJVibitBindingSource;
        private DeviseDataSet deviseDataSet;
        private DeviseDataSetTableAdapters.Hranim_Sost_J_VibitTableAdapter hranim_Sost_J_VibitTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RichTextBox opisanieRichTextBox;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private DeviseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource viewSkladBindingSource;
        private DeviseDataSetTableAdapters.View_SkladTableAdapter view_SkladTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSkladDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTovarDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPodTipDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTipDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn podTipDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tovarDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisanieDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kollDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn srednZenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn1;
        private System.Windows.Forms.Button btn_spravka;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDNakladProdagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTovarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPodTipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn podTipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tovarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kollDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
    }
}