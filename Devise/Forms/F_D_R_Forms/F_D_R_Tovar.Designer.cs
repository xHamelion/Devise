
namespace Devise
{
    partial class F_D_R_Tovar
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
            this.TB_Tovar = new System.Windows.Forms.TextBox();
            this.BTN_Red_Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_Tip = new System.Windows.Forms.ComboBox();
            this.tipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deviseDataSet = new Devise.DeviseDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_PodTip = new System.Windows.Forms.ComboBox();
            this.viewPodTipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tipTableAdapter = new Devise.DeviseDataSetTableAdapters.TipTableAdapter();
            this.view_PodTipTableAdapter = new Devise.DeviseDataSetTableAdapters.View_PodTipTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tipBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPodTipBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_Tovar
            // 
            this.TB_Tovar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Tovar.Location = new System.Drawing.Point(20, 52);
            this.TB_Tovar.Margin = new System.Windows.Forms.Padding(5);
            this.TB_Tovar.Name = "TB_Tovar";
            this.TB_Tovar.Size = new System.Drawing.Size(880, 29);
            this.TB_Tovar.TabIndex = 42;
            // 
            // BTN_Red_Save
            // 
            this.BTN_Red_Save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Red_Save.Location = new System.Drawing.Point(20, 456);
            this.BTN_Red_Save.Margin = new System.Windows.Forms.Padding(8);
            this.BTN_Red_Save.Name = "BTN_Red_Save";
            this.BTN_Red_Save.Size = new System.Drawing.Size(1116, 54);
            this.BTN_Red_Save.TabIndex = 41;
            this.BTN_Red_Save.Text = "button1";
            this.BTN_Red_Save.UseVisualStyleBackColor = true;
            this.BTN_Red_Save.Click += new System.EventHandler(this.BTN_Red_Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 40;
            this.label1.Text = "Товар";
            // 
            // CB_Tip
            // 
            this.CB_Tip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_Tip.DataSource = this.tipBindingSource;
            this.CB_Tip.DisplayMember = "Tip";
            this.CB_Tip.FormattingEnabled = true;
            this.CB_Tip.Location = new System.Drawing.Point(20, 115);
            this.CB_Tip.Margin = new System.Windows.Forms.Padding(5);
            this.CB_Tip.Name = "CB_Tip";
            this.CB_Tip.Size = new System.Drawing.Size(837, 29);
            this.CB_Tip.TabIndex = 43;
            this.CB_Tip.ValueMember = "ID_Tip";
            this.CB_Tip.ValueMemberChanged += new System.EventHandler(this.comboBox1_ValueMemberChanged);
            this.CB_Tip.SelectedValueChanged += new System.EventHandler(this.CB_Tip_SelectedValueChanged);
            // 
            // tipBindingSource
            // 
            this.tipBindingSource.DataMember = "Tip";
            this.tipBindingSource.DataSource = this.deviseDataSet;
            // 
            // deviseDataSet
            // 
            this.deviseDataSet.DataSetName = "DeviseDataSet";
            this.deviseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 44;
            this.label2.Text = "Тип товара";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 21);
            this.label3.TabIndex = 46;
            this.label3.Text = "Подтип товара";
            // 
            // CB_PodTip
            // 
            this.CB_PodTip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_PodTip.FormattingEnabled = true;
            this.CB_PodTip.Location = new System.Drawing.Point(20, 184);
            this.CB_PodTip.Margin = new System.Windows.Forms.Padding(5);
            this.CB_PodTip.Name = "CB_PodTip";
            this.CB_PodTip.Size = new System.Drawing.Size(837, 29);
            this.CB_PodTip.TabIndex = 45;
            // 
            // viewPodTipBindingSource
            // 
            this.viewPodTipBindingSource.DataMember = "View_PodTip";
            this.viewPodTipBindingSource.DataSource = this.deviseDataSet;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(20, 267);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(1116, 176);
            this.richTextBox1.TabIndex = 47;
            this.richTextBox1.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 241);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 21);
            this.label4.TabIndex = 48;
            this.label4.Text = "Описание - характеристики";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(910, 35);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 188);
            this.button1.TabIndex = 50;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(957, 36);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tipTableAdapter
            // 
            this.tipTableAdapter.ClearBeforeFill = true;
            // 
            // view_PodTipTableAdapter
            // 
            this.view_PodTipTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(757, 233);
            this.button2.Margin = new System.Windows.Forms.Padding(5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(379, 37);
            this.button2.TabIndex = 51;
            this.button2.Text = "Использовать шаблон для товара";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(867, 115);
            this.button4.Margin = new System.Windows.Forms.Padding(5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(33, 29);
            this.button4.TabIndex = 53;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(867, 184);
            this.button5.Margin = new System.Windows.Forms.Padding(5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(33, 29);
            this.button5.TabIndex = 54;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // F_D_R_Tovar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 518);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CB_PodTip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CB_Tip);
            this.Controls.Add(this.TB_Tovar);
            this.Controls.Add(this.BTN_Red_Save);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(1166, 557);
            this.Name = "F_D_R_Tovar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_D_R_Tovar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_D_R_Tovar_FormClosed);
            this.Load += new System.EventHandler(this.F_D_R_Tovar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tipBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPodTipBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox TB_Tovar;
        public System.Windows.Forms.Button BTN_Red_Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private DeviseDataSet deviseDataSet;
        private System.Windows.Forms.BindingSource tipBindingSource;
        private DeviseDataSetTableAdapters.TipTableAdapter tipTableAdapter;
        private System.Windows.Forms.BindingSource viewPodTipBindingSource;
        private DeviseDataSetTableAdapters.View_PodTipTableAdapter view_PodTipTableAdapter;
        public System.Windows.Forms.ComboBox CB_Tip;
        public System.Windows.Forms.ComboBox CB_PodTip;
        public System.Windows.Forms.RichTextBox richTextBox1;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}