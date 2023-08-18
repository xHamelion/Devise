
namespace Devise
{
    partial class F_D_R_Vibitie_Nakladn
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
            this.viewPokupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deviseDataSet = new Devise.DeviseDataSet();
            this.BTN_Red_Save = new System.Windows.Forms.Button();
            this.DTP = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Nomer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CB_Sotrud = new System.Windows.Forms.ComboBox();
            this.viewSotrudnicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TB_Dost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.view_PokupTableAdapter = new Devise.DeviseDataSetTableAdapters.View_PokupTableAdapter();
            this.view_SotrudnicTableAdapter = new Devise.DeviseDataSetTableAdapters.View_SotrudnicTableAdapter();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.viewPokupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSotrudnicBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 207);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 51;
            this.label3.Text = "Продавец";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.viewPokupBindingSource;
            this.comboBox1.DisplayMember = "FIO";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(19, 165);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(365, 29);
            this.comboBox1.TabIndex = 50;
            this.comboBox1.ValueMember = "ID_Pokup";
            // 
            // viewPokupBindingSource
            // 
            this.viewPokupBindingSource.DataMember = "View_Pokup";
            this.viewPokupBindingSource.DataSource = this.deviseDataSet;
            // 
            // deviseDataSet
            // 
            this.deviseDataSet.DataSetName = "DeviseDataSet";
            this.deviseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BTN_Red_Save
            // 
            this.BTN_Red_Save.Location = new System.Drawing.Point(19, 340);
            this.BTN_Red_Save.Margin = new System.Windows.Forms.Padding(8);
            this.BTN_Red_Save.Name = "BTN_Red_Save";
            this.BTN_Red_Save.Size = new System.Drawing.Size(409, 43);
            this.BTN_Red_Save.TabIndex = 49;
            this.BTN_Red_Save.Text = "button1";
            this.BTN_Red_Save.UseVisualStyleBackColor = true;
            this.BTN_Red_Save.Click += new System.EventHandler(this.BTN_Red_Save_Click);
            // 
            // DTP
            // 
            this.DTP.Location = new System.Drawing.Point(18, 98);
            this.DTP.Margin = new System.Windows.Forms.Padding(5);
            this.DTP.Name = "DTP";
            this.DTP.Size = new System.Drawing.Size(409, 29);
            this.DTP.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 21);
            this.label2.TabIndex = 47;
            this.label2.Text = "Дата продажи";
            // 
            // TB_Nomer
            // 
            this.TB_Nomer.Location = new System.Drawing.Point(19, 34);
            this.TB_Nomer.Margin = new System.Windows.Forms.Padding(5);
            this.TB_Nomer.Name = "TB_Nomer";
            this.TB_Nomer.Size = new System.Drawing.Size(384, 29);
            this.TB_Nomer.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 45;
            this.label1.Text = "Номер";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 21);
            this.label4.TabIndex = 53;
            this.label4.Text = "Клиент";
            // 
            // CB_Sotrud
            // 
            this.CB_Sotrud.DataSource = this.viewSotrudnicBindingSource;
            this.CB_Sotrud.DisplayMember = "FIO";
            this.CB_Sotrud.FormattingEnabled = true;
            this.CB_Sotrud.Location = new System.Drawing.Point(19, 233);
            this.CB_Sotrud.Margin = new System.Windows.Forms.Padding(5);
            this.CB_Sotrud.Name = "CB_Sotrud";
            this.CB_Sotrud.Size = new System.Drawing.Size(408, 29);
            this.CB_Sotrud.TabIndex = 52;
            this.CB_Sotrud.ValueMember = "ID_Sotrudnic";
            // 
            // viewSotrudnicBindingSource
            // 
            this.viewSotrudnicBindingSource.DataMember = "View_Sotrudnic";
            this.viewSotrudnicBindingSource.DataSource = this.deviseDataSet;
            // 
            // TB_Dost
            // 
            this.TB_Dost.Location = new System.Drawing.Point(19, 298);
            this.TB_Dost.Margin = new System.Windows.Forms.Padding(5);
            this.TB_Dost.Name = "TB_Dost";
            this.TB_Dost.Size = new System.Drawing.Size(409, 29);
            this.TB_Dost.TabIndex = 55;
            this.TB_Dost.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 272);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 21);
            this.label5.TabIndex = 54;
            this.label5.Text = "Сумма доставки";
            // 
            // view_PokupTableAdapter
            // 
            this.view_PokupTableAdapter.ClearBeforeFill = true;
            // 
            // view_SotrudnicTableAdapter
            // 
            this.view_SotrudnicTableAdapter.ClearBeforeFill = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(413, 40);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 56;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(395, 165);
            this.button5.Margin = new System.Windows.Forms.Padding(5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(33, 29);
            this.button5.TabIndex = 57;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // F_D_R_Vibitie_Nakladn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 402);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.TB_Dost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CB_Sotrud);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BTN_Red_Save);
            this.Controls.Add(this.DTP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_Nomer);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(467, 441);
            this.MinimumSize = new System.Drawing.Size(467, 441);
            this.Name = "F_D_R_Vibitie_Nakladn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_D_R_Vibitie_Nakladn";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_D_R_Vibitie_Nakladn_FormClosed);
            this.Load += new System.EventHandler(this.F_D_R_Vibitie_Nakladn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewPokupBindingSource)).EndInit();
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
        public System.Windows.Forms.ComboBox CB_Sotrud;
        public System.Windows.Forms.TextBox TB_Dost;
        private System.Windows.Forms.Label label5;
        private DeviseDataSet deviseDataSet;
        private System.Windows.Forms.BindingSource viewPokupBindingSource;
        private DeviseDataSetTableAdapters.View_PokupTableAdapter view_PokupTableAdapter;
        private System.Windows.Forms.BindingSource viewSotrudnicBindingSource;
        private DeviseDataSetTableAdapters.View_SotrudnicTableAdapter view_SotrudnicTableAdapter;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button5;
    }
}