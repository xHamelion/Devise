﻿
namespace Devise
{
    partial class F_D_R_Postavhick
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
            this.label5 = new System.Windows.Forms.Label();
            this.TB_Naim_Org = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BTN_Red_Save = new System.Windows.Forms.Button();
            this.MTB_Telef = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 21);
            this.label5.TabIndex = 41;
            this.label5.Text = "Телефон";
            // 
            // TB_Naim_Org
            // 
            this.TB_Naim_Org.Location = new System.Drawing.Point(24, 50);
            this.TB_Naim_Org.Margin = new System.Windows.Forms.Padding(5);
            this.TB_Naim_Org.Name = "TB_Naim_Org";
            this.TB_Naim_Org.Size = new System.Drawing.Size(268, 29);
            this.TB_Naim_Org.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 21);
            this.label4.TabIndex = 38;
            this.label4.Text = "Наименование организации";
            // 
            // BTN_Red_Save
            // 
            this.BTN_Red_Save.Location = new System.Drawing.Point(24, 154);
            this.BTN_Red_Save.Margin = new System.Windows.Forms.Padding(8);
            this.BTN_Red_Save.Name = "BTN_Red_Save";
            this.BTN_Red_Save.Size = new System.Drawing.Size(270, 52);
            this.BTN_Red_Save.TabIndex = 37;
            this.BTN_Red_Save.Text = "button1";
            this.BTN_Red_Save.UseVisualStyleBackColor = true;
            this.BTN_Red_Save.Click += new System.EventHandler(this.BTN_Red_Save_Click);
            // 
            // MTB_Telef
            // 
            this.MTB_Telef.Location = new System.Drawing.Point(24, 116);
            this.MTB_Telef.Margin = new System.Windows.Forms.Padding(5);
            this.MTB_Telef.Mask = "+0(000)-000-00-00";
            this.MTB_Telef.Name = "MTB_Telef";
            this.MTB_Telef.Size = new System.Drawing.Size(268, 29);
            this.MTB_Telef.TabIndex = 42;
            // 
            // F_D_R_Postavhick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 228);
            this.Controls.Add(this.MTB_Telef);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_Naim_Org);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BTN_Red_Save);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(332, 267);
            this.MinimumSize = new System.Drawing.Size(332, 267);
            this.Name = "F_D_R_Postavhick";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_D_R_Postavhick";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_D_R_Postavhick_FormClosed);
            this.Load += new System.EventHandler(this.F_D_R_Postavhick_Load);
            this.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.F_D_R_Postavhick_ControlRemoved);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox TB_Naim_Org;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button BTN_Red_Save;
        public System.Windows.Forms.MaskedTextBox MTB_Telef;
    }
}