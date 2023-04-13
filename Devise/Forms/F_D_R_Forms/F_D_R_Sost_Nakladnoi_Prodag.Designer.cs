
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
            sredn_ZenaLabel = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUP_Koll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSkladBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // sredn_ZenaLabel
            // 
            sredn_ZenaLabel.Location = new System.Drawing.Point(25, 201);
            sredn_ZenaLabel.Name = "sredn_ZenaLabel";
            sredn_ZenaLabel.Size = new System.Drawing.Size(162, 15);
            sredn_ZenaLabel.TabIndex = 68;
            sredn_ZenaLabel.Text = "Средняя цена за 1 ед.";
            sredn_ZenaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Location = new System.Drawing.Point(193, 201);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(169, 31);
            label7.TabIndex = 76;
            label7.Text = "Рекомендованная цена за 1 ед.\r\nС наценкой";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_Summa
            // 
            this.TB_Summa.Enabled = false;
            this.TB_Summa.Location = new System.Drawing.Point(25, 174);
            this.TB_Summa.Name = "TB_Summa";
            this.TB_Summa.Size = new System.Drawing.Size(337, 20);
            this.TB_Summa.TabIndex = 69;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 67;
            this.label6.Text = "Сумма";
            // 
            // NUP_Koll
            // 
            this.NUP_Koll.Location = new System.Drawing.Point(25, 77);
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
            this.NUP_Koll.Size = new System.Drawing.Size(337, 20);
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
            this.label5.Location = new System.Drawing.Point(22, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 65;
            this.label5.Text = "Количество";
            // 
            // TB_Zena
            // 
            this.TB_Zena.Location = new System.Drawing.Point(25, 124);
            this.TB_Zena.Name = "TB_Zena";
            this.TB_Zena.Size = new System.Drawing.Size(337, 20);
            this.TB_Zena.TabIndex = 64;
            this.TB_Zena.TextChanged += new System.EventHandler(this.TB_Zena_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "Цена";
            // 
            // CB_Tovar
            // 
            this.CB_Tovar.DataSource = this.viewSkladBindingSource;
            this.CB_Tovar.DisplayMember = "Tovar";
            this.CB_Tovar.FormattingEnabled = true;
            this.CB_Tovar.Location = new System.Drawing.Point(25, 30);
            this.CB_Tovar.Name = "CB_Tovar";
            this.CB_Tovar.Size = new System.Drawing.Size(337, 21);
            this.CB_Tovar.TabIndex = 62;
            this.CB_Tovar.ValueMember = "ID_Tovar";
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
            this.label2.Location = new System.Drawing.Point(22, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "Товар";
            // 
            // BTN_Red_Save
            // 
            this.BTN_Red_Save.Location = new System.Drawing.Point(25, 270);
            this.BTN_Red_Save.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_Red_Save.Name = "BTN_Red_Save";
            this.BTN_Red_Save.Size = new System.Drawing.Size(337, 54);
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
            this.opisanieRichTextBox.Location = new System.Drawing.Point(386, 25);
            this.opisanieRichTextBox.Name = "opisanieRichTextBox";
            this.opisanieRichTextBox.ReadOnly = true;
            this.opisanieRichTextBox.Size = new System.Drawing.Size(419, 299);
            this.opisanieRichTextBox.TabIndex = 71;
            this.opisanieRichTextBox.Text = "";
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.viewSkladBindingSource, "Image", true));
            this.imagePictureBox.Location = new System.Drawing.Point(811, 25);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(202, 202);
            this.imagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagePictureBox.TabIndex = 72;
            this.imagePictureBox.TabStop = false;
            // 
            // sredn_ZenaLabel2
            // 
            this.sredn_ZenaLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viewSkladBindingSource, "Sredn_Zena", true));
            this.sredn_ZenaLabel2.Location = new System.Drawing.Point(28, 243);
            this.sredn_ZenaLabel2.Name = "sredn_ZenaLabel2";
            this.sredn_ZenaLabel2.Size = new System.Drawing.Size(159, 23);
            this.sredn_ZenaLabel2.TabIndex = 73;
            this.sredn_ZenaLabel2.Text = "***";
            this.sredn_ZenaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sredn_ZenaLabel2.TextChanged += new System.EventHandler(this.sredn_ZenaLabel2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 74;
            this.label1.Text = "Описание";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(808, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 75;
            this.label3.Text = "Изображение";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(196, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 23);
            this.label8.TabIndex = 78;
            this.label8.Text = "***";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // F_D_R_Sost_Nakladnoi_Prodag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 343);
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
            this.MaximumSize = new System.Drawing.Size(1036, 382);
            this.MinimumSize = new System.Drawing.Size(1036, 382);
            this.Name = "F_D_R_Sost_Nakladnoi_Prodag";
            this.Text = "F_D_R_Sost_Nakladnoi_Prodag";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_D_R_Sost_Nakladnoi_Prodag_FormClosed);
            this.Load += new System.EventHandler(this.F_D_R_Sost_Nakladnoi_Prodag_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUP_Koll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSkladBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
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
    }
}