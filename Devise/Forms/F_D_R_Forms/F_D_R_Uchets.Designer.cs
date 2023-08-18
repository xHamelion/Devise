
namespace Devise
{
    partial class F_D_R_Uchets
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
            this.label3 = new System.Windows.Forms.Label();
            this.CB_PodTip = new System.Windows.Forms.ComboBox();
            this.TB_Tovar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BTN_Red_Save = new System.Windows.Forms.Button();
            this.BTN_Otm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 21);
            this.label3.TabIndex = 52;
            this.label3.Text = "Уровень доступа";
            // 
            // CB_PodTip
            // 
            this.CB_PodTip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_PodTip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_PodTip.FormattingEnabled = true;
            this.CB_PodTip.Items.AddRange(new object[] {
            "0 - администратор",
            "1 - менеджер",
            "2 - покупатель"});
            this.CB_PodTip.Location = new System.Drawing.Point(14, 188);
            this.CB_PodTip.Margin = new System.Windows.Forms.Padding(5);
            this.CB_PodTip.Name = "CB_PodTip";
            this.CB_PodTip.Size = new System.Drawing.Size(277, 29);
            this.CB_PodTip.TabIndex = 51;
            this.CB_PodTip.TextChanged += new System.EventHandler(this.CB_PodTip_TextChanged);
            // 
            // TB_Tovar
            // 
            this.TB_Tovar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Tovar.Location = new System.Drawing.Point(14, 47);
            this.TB_Tovar.Margin = new System.Windows.Forms.Padding(5);
            this.TB_Tovar.Name = "TB_Tovar";
            this.TB_Tovar.Size = new System.Drawing.Size(277, 29);
            this.TB_Tovar.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 47;
            this.label1.Text = "Логин";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(14, 114);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 29);
            this.textBox1.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 53;
            this.label2.Text = "Пороль";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(324, 47);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(245, 170);
            this.richTextBox1.TabIndex = 55;
            this.richTextBox1.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 21);
            this.label4.TabIndex = 56;
            this.label4.Text = "Пояснение";
            // 
            // BTN_Red_Save
            // 
            this.BTN_Red_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.BTN_Red_Save.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BTN_Red_Save.Location = new System.Drawing.Point(324, 225);
            this.BTN_Red_Save.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_Red_Save.Name = "BTN_Red_Save";
            this.BTN_Red_Save.Size = new System.Drawing.Size(245, 48);
            this.BTN_Red_Save.TabIndex = 58;
            this.BTN_Red_Save.Text = "Принять";
            this.BTN_Red_Save.UseVisualStyleBackColor = true;
            this.BTN_Red_Save.Click += new System.EventHandler(this.BTN_Red_Save_Click);
            // 
            // BTN_Otm
            // 
            this.BTN_Otm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.BTN_Otm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BTN_Otm.Location = new System.Drawing.Point(14, 225);
            this.BTN_Otm.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_Otm.Name = "BTN_Otm";
            this.BTN_Otm.Size = new System.Drawing.Size(277, 48);
            this.BTN_Otm.TabIndex = 57;
            this.BTN_Otm.Text = "Отмена";
            this.BTN_Otm.UseVisualStyleBackColor = true;
            this.BTN_Otm.Click += new System.EventHandler(this.BTN_Otm_Click);
            // 
            // F_D_R_Uchets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 286);
            this.Controls.Add(this.BTN_Red_Save);
            this.Controls.Add(this.BTN_Otm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CB_PodTip);
            this.Controls.Add(this.TB_Tovar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(597, 325);
            this.MinimumSize = new System.Drawing.Size(597, 325);
            this.Name = "F_D_R_Uchets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_D_R_Uchets";
            this.Load += new System.EventHandler(this.F_D_R_Uchets_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox CB_PodTip;
        public System.Windows.Forms.TextBox TB_Tovar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button BTN_Red_Save;
        public System.Windows.Forms.Button BTN_Otm;
    }
}