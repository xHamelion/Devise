
namespace Devise
{
    partial class F_D_R_Tip
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
            this.TB_Tip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_Red_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TB_Tip
            // 
            this.TB_Tip.Location = new System.Drawing.Point(48, 58);
            this.TB_Tip.Name = "TB_Tip";
            this.TB_Tip.Size = new System.Drawing.Size(216, 20);
            this.TB_Tip.TabIndex = 0;
            this.TB_Tip.TextChanged += new System.EventHandler(this.TB_Tip_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Тип товара";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BTN_Red_Save
            // 
            this.BTN_Red_Save.Location = new System.Drawing.Point(48, 95);
            this.BTN_Red_Save.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_Red_Save.Name = "BTN_Red_Save";
            this.BTN_Red_Save.Size = new System.Drawing.Size(216, 54);
            this.BTN_Red_Save.TabIndex = 59;
            this.BTN_Red_Save.Text = "button1";
            this.BTN_Red_Save.UseVisualStyleBackColor = true;
            this.BTN_Red_Save.Click += new System.EventHandler(this.BTN_Red_Save_Click);
            // 
            // F_D_R_Tip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 189);
            this.Controls.Add(this.BTN_Red_Save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Tip);
            this.MaximumSize = new System.Drawing.Size(329, 228);
            this.MinimumSize = new System.Drawing.Size(329, 228);
            this.Name = "F_D_R_Tip";
            this.Text = "F_D_R_Tip";
            this.Load += new System.EventHandler(this.F_D_R_Tip_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button BTN_Red_Save;
        public System.Windows.Forms.TextBox TB_Tip;
    }
}