
namespace Devise
{
    partial class F_D_R_Pod_Kategor
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
            this.BTN_Red_Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Tip = new System.Windows.Forms.TextBox();
            this.tipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deviseDataSet = new Devise.DeviseDataSet();
            this.tipTableAdapter = new Devise.DeviseDataSetTableAdapters.TipTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tipBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Red_Save
            // 
            this.BTN_Red_Save.Location = new System.Drawing.Point(24, 99);
            this.BTN_Red_Save.Margin = new System.Windows.Forms.Padding(8);
            this.BTN_Red_Save.Name = "BTN_Red_Save";
            this.BTN_Red_Save.Size = new System.Drawing.Size(360, 52);
            this.BTN_Red_Save.TabIndex = 62;
            this.BTN_Red_Save.Text = "button1";
            this.BTN_Red_Save.UseVisualStyleBackColor = true;
            this.BTN_Red_Save.Click += new System.EventHandler(this.BTN_Red_Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 21);
            this.label1.TabIndex = 61;
            this.label1.Text = "Подтип товара";
            // 
            // TB_Tip
            // 
            this.TB_Tip.Location = new System.Drawing.Point(24, 53);
            this.TB_Tip.Margin = new System.Windows.Forms.Padding(5);
            this.TB_Tip.Name = "TB_Tip";
            this.TB_Tip.Size = new System.Drawing.Size(358, 29);
            this.TB_Tip.TabIndex = 60;
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
            // tipTableAdapter
            // 
            this.tipTableAdapter.ClearBeforeFill = true;
            // 
            // F_D_R_Pod_Kategor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 174);
            this.Controls.Add(this.BTN_Red_Save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Tip);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(421, 213);
            this.MinimumSize = new System.Drawing.Size(421, 213);
            this.Name = "F_D_R_Pod_Kategor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_D_R_Pod_Kategor";
            this.Load += new System.EventHandler(this.F_D_R_Pod_Kategor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tipBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button BTN_Red_Save;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TB_Tip;
        private DeviseDataSet deviseDataSet;
        private System.Windows.Forms.BindingSource tipBindingSource;
        private DeviseDataSetTableAdapters.TipTableAdapter tipTableAdapter;
    }
}