
namespace Devise
{
    partial class F_D_R_Sost_Nakladnoi
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
            this.TB_Summa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NUP_Koll = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_Zena = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CB_Tovar = new System.Windows.Forms.ComboBox();
            this.viewTovarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deviseDataSet = new Devise.DeviseDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_Red_Save = new System.Windows.Forms.Button();
            this.view_TovarTableAdapter = new Devise.DeviseDataSetTableAdapters.View_TovarTableAdapter();
            this.tableAdapterManager = new Devise.DeviseDataSetTableAdapters.TableAdapterManager();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.opisanieRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.viewPodTipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.tipTableAdapter = new Devise.DeviseDataSetTableAdapters.TipTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.view_PodTipTableAdapter = new Devise.DeviseDataSetTableAdapters.View_PodTipTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NUP_Koll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewTovarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewPodTipBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_Summa
            // 
            this.TB_Summa.Location = new System.Drawing.Point(14, 219);
            this.TB_Summa.Margin = new System.Windows.Forms.Padding(5);
            this.TB_Summa.Name = "TB_Summa";
            this.TB_Summa.ReadOnly = true;
            this.TB_Summa.Size = new System.Drawing.Size(518, 29);
            this.TB_Summa.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 192);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 21);
            this.label6.TabIndex = 57;
            this.label6.Text = "Сумма";
            // 
            // NUP_Koll
            // 
            this.NUP_Koll.Location = new System.Drawing.Point(14, 96);
            this.NUP_Koll.Margin = new System.Windows.Forms.Padding(5);
            this.NUP_Koll.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NUP_Koll.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUP_Koll.Name = "NUP_Koll";
            this.NUP_Koll.Size = new System.Drawing.Size(520, 29);
            this.NUP_Koll.TabIndex = 56;
            this.NUP_Koll.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUP_Koll.ValueChanged += new System.EventHandler(this.NUP_Koll_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 70);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 21);
            this.label5.TabIndex = 55;
            this.label5.Text = "Количество";
            // 
            // TB_Zena
            // 
            this.TB_Zena.Location = new System.Drawing.Point(14, 156);
            this.TB_Zena.Margin = new System.Windows.Forms.Padding(5);
            this.TB_Zena.Name = "TB_Zena";
            this.TB_Zena.Size = new System.Drawing.Size(518, 29);
            this.TB_Zena.TabIndex = 52;
            this.TB_Zena.TextChanged += new System.EventHandler(this.TB_Zena_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 21);
            this.label4.TabIndex = 51;
            this.label4.Text = "Цена";
            // 
            // CB_Tovar
            // 
            this.CB_Tovar.DataSource = this.viewTovarBindingSource;
            this.CB_Tovar.DisplayMember = "Tovar";
            this.CB_Tovar.FormattingEnabled = true;
            this.CB_Tovar.Location = new System.Drawing.Point(14, 38);
            this.CB_Tovar.Margin = new System.Windows.Forms.Padding(5);
            this.CB_Tovar.Name = "CB_Tovar";
            this.CB_Tovar.Size = new System.Drawing.Size(478, 29);
            this.CB_Tovar.TabIndex = 49;
            this.CB_Tovar.ValueMember = "ID_Tovar";
            // 
            // viewTovarBindingSource
            // 
            this.viewTovarBindingSource.DataMember = "View_Tovar";
            this.viewTovarBindingSource.DataSource = this.deviseDataSet;
            // 
            // deviseDataSet
            // 
            this.deviseDataSet.DataSetName = "DeviseDataSet";
            this.deviseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 48;
            this.label2.Text = "Товар";
            // 
            // BTN_Red_Save
            // 
            this.BTN_Red_Save.Location = new System.Drawing.Point(14, 265);
            this.BTN_Red_Save.Margin = new System.Windows.Forms.Padding(8);
            this.BTN_Red_Save.Name = "BTN_Red_Save";
            this.BTN_Red_Save.Size = new System.Drawing.Size(520, 43);
            this.BTN_Red_Save.TabIndex = 46;
            this.BTN_Red_Save.Text = "button1";
            this.BTN_Red_Save.UseVisualStyleBackColor = true;
            this.BTN_Red_Save.Click += new System.EventHandler(this.BTN_Red_Save_Click);
            // 
            // view_TovarTableAdapter
            // 
            this.view_TovarTableAdapter.ClearBeforeFill = true;
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
            this.imagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.viewTovarBindingSource, "Image", true));
            this.imagePictureBox.Location = new System.Drawing.Point(952, 38);
            this.imagePictureBox.Margin = new System.Windows.Forms.Padding(5);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(307, 271);
            this.imagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePictureBox.TabIndex = 59;
            this.imagePictureBox.TabStop = false;
            // 
            // opisanieRichTextBox
            // 
            this.opisanieRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.opisanieRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viewTovarBindingSource, "Opisanie", true));
            this.opisanieRichTextBox.Location = new System.Drawing.Point(14, 344);
            this.opisanieRichTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.opisanieRichTextBox.Name = "opisanieRichTextBox";
            this.opisanieRichTextBox.ReadOnly = true;
            this.opisanieRichTextBox.Size = new System.Drawing.Size(1246, 257);
            this.opisanieRichTextBox.TabIndex = 60;
            this.opisanieRichTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 318);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 61;
            this.label1.Text = "Описание";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(546, 38);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 271);
            this.panel1.TabIndex = 62;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 168);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(346, 29);
            this.textBox1.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 143);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 21);
            this.label8.TabIndex = 56;
            this.label8.Text = "Товар";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(227, 206);
            this.button2.Margin = new System.Windows.Forms.Padding(8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 43);
            this.button2.TabIndex = 55;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 206);
            this.button1.Margin = new System.Windows.Forms.Padding(8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 43);
            this.button1.TabIndex = 54;
            this.button1.Text = "Фильтровать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.viewPodTipBindingSource;
            this.comboBox2.DisplayMember = "PodTip";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(26, 102);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(5);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(346, 29);
            this.comboBox2.TabIndex = 53;
            this.comboBox2.ValueMember = "ID_PodTip";
            // 
            // viewPodTipBindingSource
            // 
            this.viewPodTipBindingSource.DataMember = "View_PodTip";
            this.viewPodTipBindingSource.DataSource = this.deviseDataSet;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 76);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 21);
            this.label7.TabIndex = 52;
            this.label7.Text = "Подтип товара";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tipBindingSource;
            this.comboBox1.DisplayMember = "Tip";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(26, 38);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(346, 29);
            this.comboBox1.TabIndex = 51;
            this.comboBox1.ValueMember = "ID_Tip";
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // tipBindingSource
            // 
            this.tipBindingSource.DataMember = "Tip";
            this.tipBindingSource.DataSource = this.deviseDataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 50;
            this.label3.Text = "Тип товара";
            // 
            // tipTableAdapter
            // 
            this.tipTableAdapter.ClearBeforeFill = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(542, 12);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 21);
            this.label9.TabIndex = 58;
            this.label9.Text = "Фильтрация";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(946, 12);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 21);
            this.label10.TabIndex = 63;
            this.label10.Text = "Фотография";
            // 
            // view_PodTipTableAdapter
            // 
            this.view_PodTipTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(502, 38);
            this.button4.Margin = new System.Windows.Forms.Padding(5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(30, 29);
            this.button4.TabIndex = 64;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // F_D_R_Sost_Nakladnoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 615);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.opisanieRichTextBox);
            this.Controls.Add(this.imagePictureBox);
            this.Controls.Add(this.TB_Summa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NUP_Koll);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_Zena);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CB_Tovar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTN_Red_Save);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(1289, 654);
            this.MinimumSize = new System.Drawing.Size(1289, 654);
            this.Name = "F_D_R_Sost_Nakladnoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_D_R_Sost_Nakladnoi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_D_R_Sost_Nakladnoi_FormClosed);
            this.Load += new System.EventHandler(this.F_D_R_Sost_Nakladnoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUP_Koll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewTovarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewPodTipBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox TB_Summa;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.NumericUpDown NUP_Koll;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox TB_Zena;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox CB_Tovar;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button BTN_Red_Save;
        private DeviseDataSet deviseDataSet;
        private System.Windows.Forms.BindingSource viewTovarBindingSource;
        private DeviseDataSetTableAdapters.View_TovarTableAdapter view_TovarTableAdapter;
        private DeviseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.RichTextBox opisanieRichTextBox;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource tipBindingSource;
        private DeviseDataSetTableAdapters.TipTableAdapter tipTableAdapter;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource viewPodTipBindingSource;
        private DeviseDataSetTableAdapters.View_PodTipTableAdapter view_PodTipTableAdapter;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
    }
}