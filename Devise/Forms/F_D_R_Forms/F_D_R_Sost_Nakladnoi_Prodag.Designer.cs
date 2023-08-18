
namespace Devise
{
    partial class F_D_R_Sost_Nakladnoi_Prodag
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
            System.Windows.Forms.Label sredn_ZenaLabel;
            System.Windows.Forms.Label label7;
            this.TB_Summa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NUP_Koll = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_Zena = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CB_Tovar = new System.Windows.Forms.ComboBox();
            this.viewSkladBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deviseDataSet = new Devise.DeviseDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_Red_Save = new System.Windows.Forms.Button();
            this.view_SkladTableAdapter = new Devise.DeviseDataSetTableAdapters.View_SkladTableAdapter();
            this.tableAdapterManager = new Devise.DeviseDataSetTableAdapters.TableAdapterManager();
            this.opisanieRichTextBox = new System.Windows.Forms.RichTextBox();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.sredn_ZenaLabel2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipTableAdapter = new Devise.DeviseDataSetTableAdapters.TipTableAdapter();
            this.viewPodTipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_PodTipTableAdapter = new Devise.DeviseDataSetTableAdapters.View_PodTipTableAdapter();
            sredn_ZenaLabel = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUP_Koll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSkladBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPodTipBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sredn_ZenaLabel
            // 
            sredn_ZenaLabel.Location = new System.Drawing.Point(17, 384);
            sredn_ZenaLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            sredn_ZenaLabel.Name = "sredn_ZenaLabel";
            sredn_ZenaLabel.Size = new System.Drawing.Size(202, 24);
            sredn_ZenaLabel.TabIndex = 68;
            sredn_ZenaLabel.Text = "Средняя цена за 1 ед.";
            sredn_ZenaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Location = new System.Drawing.Point(229, 384);
            label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(218, 50);
            label7.TabIndex = 76;
            label7.Text = "Рекомендованная цена за 1 ед.\r\nС наценкой";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_Summa
            // 
            this.TB_Summa.Enabled = false;
            this.TB_Summa.Location = new System.Drawing.Point(19, 215);
            this.TB_Summa.Margin = new System.Windows.Forms.Padding(5);
            this.TB_Summa.Name = "TB_Summa";
            this.TB_Summa.Size = new System.Drawing.Size(428, 29);
            this.TB_Summa.TabIndex = 69;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 190);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 21);
            this.label6.TabIndex = 67;
            this.label6.Text = "Сумма";
            // 
            // NUP_Koll
            // 
            this.NUP_Koll.Location = new System.Drawing.Point(20, 104);
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
            this.NUP_Koll.Size = new System.Drawing.Size(430, 29);
            this.NUP_Koll.TabIndex = 66;
            this.NUP_Koll.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUP_Koll.ValueChanged += new System.EventHandler(this.NUP_Koll_ValueChanged);
            this.NUP_Koll.TabIndexChanged += new System.EventHandler(this.TB_Zena_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 21);
            this.label5.TabIndex = 65;
            this.label5.Text = "Количество";
            // 
            // TB_Zena
            // 
            this.TB_Zena.Location = new System.Drawing.Point(20, 161);
            this.TB_Zena.Margin = new System.Windows.Forms.Padding(5);
            this.TB_Zena.Name = "TB_Zena";
            this.TB_Zena.Size = new System.Drawing.Size(428, 29);
            this.TB_Zena.TabIndex = 64;
            this.TB_Zena.TextChanged += new System.EventHandler(this.TB_Zena_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 21);
            this.label4.TabIndex = 63;
            this.label4.Text = "Цена";
            // 
            // CB_Tovar
            // 
            this.CB_Tovar.DataSource = this.viewSkladBindingSource;
            this.CB_Tovar.DisplayMember = "Tovar";
            this.CB_Tovar.FormattingEnabled = true;
            this.CB_Tovar.Location = new System.Drawing.Point(20, 47);
            this.CB_Tovar.Margin = new System.Windows.Forms.Padding(5);
            this.CB_Tovar.Name = "CB_Tovar";
            this.CB_Tovar.Size = new System.Drawing.Size(428, 29);
            this.CB_Tovar.TabIndex = 62;
            this.CB_Tovar.ValueMember = "ID_Tovar";
            this.CB_Tovar.SelectedIndexChanged += new System.EventHandler(this.CB_Tovar_SelectedIndexChanged);
            // 
            // viewSkladBindingSource
            // 
            this.viewSkladBindingSource.DataMember = "View_Sklad";
            this.viewSkladBindingSource.DataSource = this.deviseDataSet;
            // 
            // deviseDataSet
            // 
            this.deviseDataSet.DataSetName = "DeviseDataSet";
            this.deviseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 61;
            this.label2.Text = "Товар";
            // 
            // BTN_Red_Save
            // 
            this.BTN_Red_Save.Location = new System.Drawing.Point(17, 531);
            this.BTN_Red_Save.Margin = new System.Windows.Forms.Padding(8);
            this.BTN_Red_Save.Name = "BTN_Red_Save";
            this.BTN_Red_Save.Size = new System.Drawing.Size(430, 55);
            this.BTN_Red_Save.TabIndex = 60;
            this.BTN_Red_Save.Text = "button1";
            this.BTN_Red_Save.UseVisualStyleBackColor = true;
            this.BTN_Red_Save.Click += new System.EventHandler(this.BTN_Red_Save_Click);
            // 
            // view_SkladTableAdapter
            // 
            this.view_SkladTableAdapter.ClearBeforeFill = true;
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
            // opisanieRichTextBox
            // 
            this.opisanieRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viewSkladBindingSource, "Opisanie", true));
            this.opisanieRichTextBox.Location = new System.Drawing.Point(464, 47);
            this.opisanieRichTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.opisanieRichTextBox.Name = "opisanieRichTextBox";
            this.opisanieRichTextBox.ReadOnly = true;
            this.opisanieRichTextBox.Size = new System.Drawing.Size(396, 258);
            this.opisanieRichTextBox.TabIndex = 71;
            this.opisanieRichTextBox.Text = "";
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.viewSkladBindingSource, "Image", true));
            this.imagePictureBox.Location = new System.Drawing.Point(870, 47);
            this.imagePictureBox.Margin = new System.Windows.Forms.Padding(5);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(288, 258);
            this.imagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePictureBox.TabIndex = 72;
            this.imagePictureBox.TabStop = false;
            // 
            // sredn_ZenaLabel2
            // 
            this.sredn_ZenaLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viewSkladBindingSource, "Sredn_Zena", true));
            this.sredn_ZenaLabel2.Location = new System.Drawing.Point(22, 434);
            this.sredn_ZenaLabel2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.sredn_ZenaLabel2.Name = "sredn_ZenaLabel2";
            this.sredn_ZenaLabel2.Size = new System.Drawing.Size(196, 37);
            this.sredn_ZenaLabel2.TabIndex = 73;
            this.sredn_ZenaLabel2.Text = "***";
            this.sredn_ZenaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sredn_ZenaLabel2.TextChanged += new System.EventHandler(this.sredn_ZenaLabel2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(458, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 74;
            this.label1.Text = "Описание";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(865, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 21);
            this.label3.TabIndex = 75;
            this.label3.Text = "Изображение";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(233, 434);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(214, 37);
            this.label8.TabIndex = 78;
            this.label8.Text = "***";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.TextChanged += new System.EventHandler(this.label8_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(59, 252);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(334, 25);
            this.checkBox1.TabIndex = 79;
            this.checkBox1.Text = "Использовать рекомендованную цену";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(8, 310);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(117, 25);
            this.radioButton1.TabIndex = 80;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Без скидки";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(131, 310);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(185, 25);
            this.radioButton2.TabIndex = 80;
            this.radioButton2.Text = "Пенсионная скидка";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(322, 310);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(128, 25);
            this.radioButton3.TabIndex = 80;
            this.radioButton3.Text = "Иная скидка";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(458, 310);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 21);
            this.label9.TabIndex = 81;
            this.label9.Text = "Фильтрация";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Location = new System.Drawing.Point(462, 336);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 271);
            this.panel1.TabIndex = 82;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 168);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(346, 29);
            this.textBox1.TabIndex = 57;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 143);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 21);
            this.label10.TabIndex = 56;
            this.label10.Text = "Товар";
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 76);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 21);
            this.label11.TabIndex = 52;
            this.label11.Text = "Подтип товара";
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
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 13);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 21);
            this.label12.TabIndex = 50;
            this.label12.Text = "Тип товара";
            // 
            // tipBindingSource
            // 
            this.tipBindingSource.DataMember = "Tip";
            this.tipBindingSource.DataSource = this.deviseDataSet;
            // 
            // tipTableAdapter
            // 
            this.tipTableAdapter.ClearBeforeFill = true;
            // 
            // viewPodTipBindingSource
            // 
            this.viewPodTipBindingSource.DataMember = "View_PodTip";
            this.viewPodTipBindingSource.DataSource = this.deviseDataSet;
            // 
            // view_PodTipTableAdapter
            // 
            this.view_PodTipTableAdapter.ClearBeforeFill = true;
            // 
            // F_D_R_Sost_Nakladnoi_Prodag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 606);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sredn_ZenaLabel2);
            this.Controls.Add(this.imagePictureBox);
            this.Controls.Add(this.opisanieRichTextBox);
            this.Controls.Add(sredn_ZenaLabel);
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
            this.MaximumSize = new System.Drawing.Size(1185, 645);
            this.MinimumSize = new System.Drawing.Size(1185, 645);
            this.Name = "F_D_R_Sost_Nakladnoi_Prodag";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_D_R_Sost_Nakladnoi_Prodag";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_D_R_Sost_Nakladnoi_Prodag_FormClosed);
            this.Load += new System.EventHandler(this.F_D_R_Sost_Nakladnoi_Prodag_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUP_Koll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSkladBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPodTipBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource viewSkladBindingSource;
        private DeviseDataSetTableAdapters.View_SkladTableAdapter view_SkladTableAdapter;
        private DeviseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.RichTextBox opisanieRichTextBox;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.Label sredn_ZenaLabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.BindingSource tipBindingSource;
        private DeviseDataSetTableAdapters.TipTableAdapter tipTableAdapter;
        private System.Windows.Forms.BindingSource viewPodTipBindingSource;
        private DeviseDataSetTableAdapters.View_PodTipTableAdapter view_PodTipTableAdapter;
    }
}