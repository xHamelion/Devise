
namespace Devise
{
    partial class F_Setings
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.deviseDataSet = new Devise.DeviseDataSet();
            this.viewSkladBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_SkladTableAdapter = new Devise.DeviseDataSetTableAdapters.View_SkladTableAdapter();
            this.iDSkladDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTovarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPodTipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.podTipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tovarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kollDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.srednZenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSkladBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.Location = new System.Drawing.Point(14, 36);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(5);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(414, 29);
            this.numericUpDown1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Наценка в %";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(14, 285);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(414, 116);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Строка подключения";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 407);
            this.button1.MaximumSize = new System.Drawing.Size(414, 41);
            this.button1.MinimumSize = new System.Drawing.Size(414, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(414, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ограничение на время сеанса";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown2.Location = new System.Drawing.Point(14, 96);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(5);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(414, 29);
            this.numericUpDown2.TabIndex = 5;
            this.numericUpDown2.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSkladDataGridViewTextBoxColumn,
            this.iDTovarDataGridViewTextBoxColumn,
            this.iDPodTipDataGridViewTextBoxColumn,
            this.iDTipDataGridViewTextBoxColumn,
            this.tipDataGridViewTextBoxColumn,
            this.podTipDataGridViewTextBoxColumn,
            this.tovarDataGridViewTextBoxColumn,
            this.opisanieDataGridViewTextBoxColumn,
            this.kollDataGridViewTextBoxColumn,
            this.srednZenaDataGridViewTextBoxColumn,
            this.imageDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.viewSkladBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(322, 348);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(10, 10);
            this.dataGridView1.TabIndex = 6;
            // 
            // deviseDataSet
            // 
            this.deviseDataSet.DataSetName = "DeviseDataSet";
            this.deviseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // iDSkladDataGridViewTextBoxColumn
            // 
            this.iDSkladDataGridViewTextBoxColumn.DataPropertyName = "ID_Sklad";
            this.iDSkladDataGridViewTextBoxColumn.HeaderText = "ID_Sklad";
            this.iDSkladDataGridViewTextBoxColumn.Name = "iDSkladDataGridViewTextBoxColumn";
            // 
            // iDTovarDataGridViewTextBoxColumn
            // 
            this.iDTovarDataGridViewTextBoxColumn.DataPropertyName = "ID_Tovar";
            this.iDTovarDataGridViewTextBoxColumn.HeaderText = "ID_Tovar";
            this.iDTovarDataGridViewTextBoxColumn.Name = "iDTovarDataGridViewTextBoxColumn";
            // 
            // iDPodTipDataGridViewTextBoxColumn
            // 
            this.iDPodTipDataGridViewTextBoxColumn.DataPropertyName = "ID_PodTip";
            this.iDPodTipDataGridViewTextBoxColumn.HeaderText = "ID_PodTip";
            this.iDPodTipDataGridViewTextBoxColumn.Name = "iDPodTipDataGridViewTextBoxColumn";
            // 
            // iDTipDataGridViewTextBoxColumn
            // 
            this.iDTipDataGridViewTextBoxColumn.DataPropertyName = "ID_Tip";
            this.iDTipDataGridViewTextBoxColumn.HeaderText = "ID_Tip";
            this.iDTipDataGridViewTextBoxColumn.Name = "iDTipDataGridViewTextBoxColumn";
            // 
            // tipDataGridViewTextBoxColumn
            // 
            this.tipDataGridViewTextBoxColumn.DataPropertyName = "Tip";
            this.tipDataGridViewTextBoxColumn.HeaderText = "Tip";
            this.tipDataGridViewTextBoxColumn.Name = "tipDataGridViewTextBoxColumn";
            // 
            // podTipDataGridViewTextBoxColumn
            // 
            this.podTipDataGridViewTextBoxColumn.DataPropertyName = "PodTip";
            this.podTipDataGridViewTextBoxColumn.HeaderText = "PodTip";
            this.podTipDataGridViewTextBoxColumn.Name = "podTipDataGridViewTextBoxColumn";
            // 
            // tovarDataGridViewTextBoxColumn
            // 
            this.tovarDataGridViewTextBoxColumn.DataPropertyName = "Tovar";
            this.tovarDataGridViewTextBoxColumn.HeaderText = "Tovar";
            this.tovarDataGridViewTextBoxColumn.Name = "tovarDataGridViewTextBoxColumn";
            // 
            // opisanieDataGridViewTextBoxColumn
            // 
            this.opisanieDataGridViewTextBoxColumn.DataPropertyName = "Opisanie";
            this.opisanieDataGridViewTextBoxColumn.HeaderText = "Opisanie";
            this.opisanieDataGridViewTextBoxColumn.Name = "opisanieDataGridViewTextBoxColumn";
            // 
            // kollDataGridViewTextBoxColumn
            // 
            this.kollDataGridViewTextBoxColumn.DataPropertyName = "Koll";
            this.kollDataGridViewTextBoxColumn.HeaderText = "Koll";
            this.kollDataGridViewTextBoxColumn.Name = "kollDataGridViewTextBoxColumn";
            // 
            // srednZenaDataGridViewTextBoxColumn
            // 
            this.srednZenaDataGridViewTextBoxColumn.DataPropertyName = "Sredn_Zena";
            this.srednZenaDataGridViewTextBoxColumn.HeaderText = "Sredn_Zena";
            this.srednZenaDataGridViewTextBoxColumn.Name = "srednZenaDataGridViewTextBoxColumn";
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "Image";
            this.imageDataGridViewImageColumn.HeaderText = "Image";
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Скидка для пенсионеров";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown3.Location = new System.Drawing.Point(14, 156);
            this.numericUpDown3.Margin = new System.Windows.Forms.Padding(5);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(414, 29);
            this.numericUpDown3.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Иная скидка";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown4.Location = new System.Drawing.Point(14, 217);
            this.numericUpDown4.Margin = new System.Windows.Forms.Padding(5);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(414, 29);
            this.numericUpDown4.TabIndex = 5;
            // 
            // F_Setings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 460);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(456, 373);
            this.Name = "F_Setings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.F_Setings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSkladBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.NumericUpDown numericUpDown1;
        public System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DeviseDataSet deviseDataSet;
        private System.Windows.Forms.BindingSource viewSkladBindingSource;
        private DeviseDataSetTableAdapters.View_SkladTableAdapter view_SkladTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSkladDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTovarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPodTipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn podTipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tovarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kollDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn srednZenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.NumericUpDown numericUpDown4;
    }
}