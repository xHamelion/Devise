
namespace Devise
{
    partial class F_Sklad_Postupl
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDNakladaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.hranimSostavPatiiSkladBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deviseDataSet = new Devise.DeviseDataSet();
            this.hranim_Sostav_Patii_SkladTableAdapter = new Devise.DeviseDataSetTableAdapters.Hranim_Sostav_Patii_SkladTableAdapter();
            this.tableAdapterManager = new Devise.DeviseDataSetTableAdapters.TableAdapterManager();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.opisanieRichTextBox = new System.Windows.Forms.RichTextBox();
            this.btn_spravka = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hranimSostavPatiiSkladBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // PDF
            // 
            this.PDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PDF.Location = new System.Drawing.Point(24, 442);
            this.PDF.Margin = new System.Windows.Forms.Padding(8);
            this.PDF.Name = "PDF";
            this.PDF.Size = new System.Drawing.Size(270, 60);
            this.PDF.TabIndex = 86;
            this.PDF.Text = "Экспорт в PDF";
            this.PDF.UseVisualStyleBackColor = true;
            this.PDF.Click += new System.EventHandler(this.PDF_Click);
            // 
            // Exel
            // 
            this.Exel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Exel.Location = new System.Drawing.Point(24, 367);
            this.Exel.Margin = new System.Windows.Forms.Padding(8);
            this.Exel.Name = "Exel";
            this.Exel.Size = new System.Drawing.Size(270, 60);
            this.Exel.TabIndex = 85;
            this.Exel.Text = "Экспорт в Exel";
            this.Exel.UseVisualStyleBackColor = true;
            this.Exel.Click += new System.EventHandler(this.Exel_Click);
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
            this.iDNakladaDataGridViewTextBoxColumn,
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
            this.dataGridView1.DataSource = this.hranimSostavPatiiSkladBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-8, -2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1334, 344);
            this.dataGridView1.TabIndex = 84;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // iDNakladaDataGridViewTextBoxColumn
            // 
            this.iDNakladaDataGridViewTextBoxColumn.DataPropertyName = "ID_Naklada";
            this.iDNakladaDataGridViewTextBoxColumn.HeaderText = "Код накладной";
            this.iDNakladaDataGridViewTextBoxColumn.Name = "iDNakladaDataGridViewTextBoxColumn";
            this.iDNakladaDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDTovarDataGridViewTextBoxColumn
            // 
            this.iDTovarDataGridViewTextBoxColumn.DataPropertyName = "ID_Tovar";
            this.iDTovarDataGridViewTextBoxColumn.HeaderText = "Код товара";
            this.iDTovarDataGridViewTextBoxColumn.Name = "iDTovarDataGridViewTextBoxColumn";
            this.iDTovarDataGridViewTextBoxColumn.Visible = false;
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
            this.podTipDataGridViewTextBoxColumn.HeaderText = "Подтипа товара";
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
            // hranimSostavPatiiSkladBindingSource
            // 
            this.hranimSostavPatiiSkladBindingSource.DataMember = "Hranim_Sostav_Patii_Sklad";
            this.hranimSostavPatiiSkladBindingSource.DataSource = this.deviseDataSet;
            // 
            // deviseDataSet
            // 
            this.deviseDataSet.DataSetName = "DeviseDataSet";
            this.deviseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hranim_Sostav_Patii_SkladTableAdapter
            // 
            this.hranim_Sostav_Patii_SkladTableAdapter.ClearBeforeFill = true;
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
            this.imagePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.imagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.hranimSostavPatiiSkladBindingSource, "Image", true));
            this.imagePictureBox.Location = new System.Drawing.Point(893, 337);
            this.imagePictureBox.Margin = new System.Windows.Forms.Padding(5);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(210, 204);
            this.imagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePictureBox.TabIndex = 87;
            this.imagePictureBox.TabStop = false;
            // 
            // opisanieRichTextBox
            // 
            this.opisanieRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.opisanieRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.opisanieRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hranimSostavPatiiSkladBindingSource, "Opisanie", true));
            this.opisanieRichTextBox.Location = new System.Drawing.Point(306, 337);
            this.opisanieRichTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.opisanieRichTextBox.Name = "opisanieRichTextBox";
            this.opisanieRichTextBox.ReadOnly = true;
            this.opisanieRichTextBox.Size = new System.Drawing.Size(577, 203);
            this.opisanieRichTextBox.TabIndex = 88;
            this.opisanieRichTextBox.Text = "";
            // 
            // btn_spravka
            // 
            this.btn_spravka.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_spravka.Location = new System.Drawing.Point(90, 505);
            this.btn_spravka.Margin = new System.Windows.Forms.Padding(5);
            this.btn_spravka.Name = "btn_spravka";
            this.btn_spravka.Size = new System.Drawing.Size(125, 37);
            this.btn_spravka.TabIndex = 101;
            this.btn_spravka.Text = "Справка";
            this.btn_spravka.UseVisualStyleBackColor = true;
            this.btn_spravka.Click += new System.EventHandler(this.btn_spravka_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1113, 337);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(212, 204);
            this.tableLayoutPanel1.TabIndex = 102;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(202, 194);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.numericUpDown1, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(5, 102);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(192, 87);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.AutoSize = true;
            this.numericUpDown1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDown1.Location = new System.Drawing.Point(5, 26);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(5);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(182, 29);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Количество";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(5, 41);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 51);
            this.button1.TabIndex = 6;
            this.button1.Text = "Списание";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // F_Sklad_Postupl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 541);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_spravka);
            this.Controls.Add(this.imagePictureBox);
            this.Controls.Add(this.PDF);
            this.Controls.Add(this.Exel);
            this.Controls.Add(this.opisanieRichTextBox);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(1212, 473);
            this.Name = "F_Sklad_Postupl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Товары по поставкам";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.F_Sklad_Postupl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hranimSostavPatiiSkladBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PDF;
        private System.Windows.Forms.Button Exel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource hranimSostavPatiiSkladBindingSource;
        private DeviseDataSet deviseDataSet;
        private DeviseDataSetTableAdapters.Hranim_Sostav_Patii_SkladTableAdapter hranim_Sostav_Patii_SkladTableAdapter;
        private DeviseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.RichTextBox opisanieRichTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDNakladaDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.Button btn_spravka;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}