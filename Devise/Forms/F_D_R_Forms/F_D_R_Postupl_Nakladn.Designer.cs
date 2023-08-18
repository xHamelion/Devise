
namespace Devise
{
    partial class F_D_R_Postupl_Nakladn
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
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.postavhickBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deviseDataSet = new Devise.DeviseDataSet();
            this.BTN_Red_Save = new System.Windows.Forms.Button();
            this.DTP = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Nomer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.viewSotrudnicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_SotrudnicTableAdapter = new Devise.DeviseDataSetTableAdapters.View_SotrudnicTableAdapter();
            this.postavhickTableAdapter = new Devise.DeviseDataSetTableAdapters.PostavhickTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.postavhickBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSotrudnicBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 44;
            this.label3.Text = "Поставшик";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.postavhickBindingSource;
            this.comboBox1.DisplayMember = "Naimenovanie_Organiz";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(24, 163);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(332, 29);
            this.comboBox1.TabIndex = 43;
            this.comboBox1.ValueMember = "ID_Postavhick";
            // 
            // postavhickBindingSource
            // 
            this.postavhickBindingSource.DataMember = "Postavhick";
            this.postavhickBindingSource.DataSource = this.deviseDataSet;
            // 
            // deviseDataSet
            // 
            this.deviseDataSet.DataSetName = "DeviseDataSet";
            this.deviseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BTN_Red_Save
            // 
            this.BTN_Red_Save.Location = new System.Drawing.Point(24, 265);
            this.BTN_Red_Save.Margin = new System.Windows.Forms.Padding(8);
            this.BTN_Red_Save.Name = "BTN_Red_Save";
            this.BTN_Red_Save.Size = new System.Drawing.Size(378, 50);
            this.BTN_Red_Save.TabIndex = 42;
            this.BTN_Red_Save.Text = "button1";
            this.BTN_Red_Save.UseVisualStyleBackColor = true;
            this.BTN_Red_Save.Click += new System.EventHandler(this.BTN_Red_Save_Click);
            // 
            // DTP
            // 
            this.DTP.Location = new System.Drawing.Point(24, 104);
            this.DTP.Margin = new System.Windows.Forms.Padding(5);
            this.DTP.Name = "DTP";
            this.DTP.Size = new System.Drawing.Size(379, 29);
            this.DTP.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 21);
            this.label2.TabIndex = 40;
            this.label2.Text = "Дата поставки";
            // 
            // TB_Nomer
            // 
            this.TB_Nomer.Location = new System.Drawing.Point(24, 47);
            this.TB_Nomer.Margin = new System.Windows.Forms.Padding(5);
            this.TB_Nomer.Name = "TB_Nomer";
            this.TB_Nomer.Size = new System.Drawing.Size(379, 29);
            this.TB_Nomer.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 38;
            this.label1.Text = "Номер";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 198);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 21);
            this.label4.TabIndex = 46;
            this.label4.Text = "Принимаюший сотрудник";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.viewSotrudnicBindingSource;
            this.comboBox2.DisplayMember = "FIO";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(24, 224);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(5);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(332, 29);
            this.comboBox2.TabIndex = 45;
            this.comboBox2.ValueMember = "ID_Sotrudnic";
            // 
            // viewSotrudnicBindingSource
            // 
            this.viewSotrudnicBindingSource.DataMember = "View_Sotrudnic";
            this.viewSotrudnicBindingSource.DataSource = this.deviseDataSet;
            // 
            // view_SotrudnicTableAdapter
            // 
            this.view_SotrudnicTableAdapter.ClearBeforeFill = true;
            // 
            // postavhickTableAdapter
            // 
            this.postavhickTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(368, 163);
            this.button4.Margin = new System.Windows.Forms.Padding(5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(34, 28);
            this.button4.TabIndex = 54;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(368, 224);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 28);
            this.button1.TabIndex = 55;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // F_D_R_Postupl_Nakladn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 335);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BTN_Red_Save);
            this.Controls.Add(this.DTP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_Nomer);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(442, 374);
            this.MinimumSize = new System.Drawing.Size(442, 374);
            this.Name = "F_D_R_Postupl_Nakladn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_D_R_Postupl_Nakladn";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_D_R_Postupl_Nakladn_FormClosed);
            this.Load += new System.EventHandler(this.F_D_R_Postupl_Nakladn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.postavhickBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSotrudnicBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Button BTN_Red_Save;
        public System.Windows.Forms.DateTimePicker DTP;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TB_Nomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox comboBox2;
        private DeviseDataSet deviseDataSet;
        private System.Windows.Forms.BindingSource viewSotrudnicBindingSource;
        private DeviseDataSetTableAdapters.View_SotrudnicTableAdapter view_SotrudnicTableAdapter;
        private System.Windows.Forms.BindingSource postavhickBindingSource;
        private DeviseDataSetTableAdapters.PostavhickTableAdapter postavhickTableAdapter;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
    }
}