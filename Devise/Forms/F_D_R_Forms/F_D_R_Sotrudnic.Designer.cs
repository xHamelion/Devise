
namespace Devise
{
    partial class F_D_R_Sotrudnic
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
            this.MTB_Tel = new System.Windows.Forms.MaskedTextBox();
            this.BTN_Red_Save = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_Otzh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Famil = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.regBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deviseDataSet = new Devise.DeviseDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.regTableAdapter = new Devise.DeviseDataSetTableAdapters.RegTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.regBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // MTB_Tel
            // 
            this.MTB_Tel.Location = new System.Drawing.Point(14, 236);
            this.MTB_Tel.Margin = new System.Windows.Forms.Padding(5);
            this.MTB_Tel.Mask = "+0(000)-000-00-00";
            this.MTB_Tel.Name = "MTB_Tel";
            this.MTB_Tel.Size = new System.Drawing.Size(362, 29);
            this.MTB_Tel.TabIndex = 68;
            // 
            // BTN_Red_Save
            // 
            this.BTN_Red_Save.Location = new System.Drawing.Point(14, 348);
            this.BTN_Red_Save.Margin = new System.Windows.Forms.Padding(8);
            this.BTN_Red_Save.Name = "BTN_Red_Save";
            this.BTN_Red_Save.Size = new System.Drawing.Size(362, 50);
            this.BTN_Red_Save.TabIndex = 67;
            this.BTN_Red_Save.Text = "button1";
            this.BTN_Red_Save.UseVisualStyleBackColor = true;
            this.BTN_Red_Save.Click += new System.EventHandler(this.BTN_Red_Save_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 210);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 21);
            this.label5.TabIndex = 66;
            this.label5.Text = "Телефон";
            // 
            // TB_Otzh
            // 
            this.TB_Otzh.Location = new System.Drawing.Point(14, 171);
            this.TB_Otzh.Margin = new System.Windows.Forms.Padding(5);
            this.TB_Otzh.Name = "TB_Otzh";
            this.TB_Otzh.Size = new System.Drawing.Size(362, 29);
            this.TB_Otzh.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 21);
            this.label3.TabIndex = 64;
            this.label3.Text = "Отчество";
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(14, 107);
            this.TB_Name.Margin = new System.Windows.Forms.Padding(5);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(362, 29);
            this.TB_Name.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 21);
            this.label2.TabIndex = 62;
            this.label2.Text = "Имя";
            // 
            // TB_Famil
            // 
            this.TB_Famil.Location = new System.Drawing.Point(14, 43);
            this.TB_Famil.Margin = new System.Windows.Forms.Padding(5);
            this.TB_Famil.Name = "TB_Famil";
            this.TB_Famil.Size = new System.Drawing.Size(362, 29);
            this.TB_Famil.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 60;
            this.label1.Text = "Фамилия";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.regBindingSource;
            this.comboBox1.DisplayMember = "Login";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(14, 306);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(326, 29);
            this.comboBox1.TabIndex = 69;
            this.comboBox1.ValueMember = "ID_Reg";
            // 
            // regBindingSource
            // 
            this.regBindingSource.DataMember = "Reg";
            this.regBindingSource.DataSource = this.deviseDataSet;
            // 
            // deviseDataSet
            // 
            this.deviseDataSet.DataSetName = "DeviseDataSet";
            this.deviseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 280);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 21);
            this.label4.TabIndex = 70;
            this.label4.Text = "Аккаунт для входа";
            // 
            // regTableAdapter
            // 
            this.regTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(348, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 29);
            this.button1.TabIndex = 71;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // F_D_R_Sotrudnic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 414);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.MTB_Tel);
            this.Controls.Add(this.BTN_Red_Save);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_Otzh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_Famil);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(407, 453);
            this.MinimumSize = new System.Drawing.Size(407, 453);
            this.Name = "F_D_R_Sotrudnic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_D_R_Sotrudnic";
            this.Load += new System.EventHandler(this.F_D_R_Sotrudnic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.regBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MaskedTextBox MTB_Tel;
        public System.Windows.Forms.Button BTN_Red_Save;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox TB_Otzh;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TB_Famil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private DeviseDataSet deviseDataSet;
        private System.Windows.Forms.BindingSource regBindingSource;
        private DeviseDataSetTableAdapters.RegTableAdapter regTableAdapter;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ComboBox comboBox1;
    }
}