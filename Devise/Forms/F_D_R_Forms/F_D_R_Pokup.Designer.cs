﻿
namespace Devise
{
    partial class F_D_R_Pokup
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
            this.TB_Otzh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Famil = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BTN_Red_Save = new System.Windows.Forms.Button();
            this.MTB_Tel = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // TB_Otzh
            // 
            this.TB_Otzh.Location = new System.Drawing.Point(57, 152);
            this.TB_Otzh.Name = "TB_Otzh";
            this.TB_Otzh.Size = new System.Drawing.Size(197, 20);
            this.TB_Otzh.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Отчество";
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(57, 101);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(197, 20);
            this.TB_Name.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Имя";
            // 
            // TB_Famil
            // 
            this.TB_Famil.Location = new System.Drawing.Point(57, 52);
            this.TB_Famil.Name = "TB_Famil";
            this.TB_Famil.Size = new System.Drawing.Size(197, 20);
            this.TB_Famil.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Фамилия";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "Телефон";
            // 
            // BTN_Red_Save
            // 
            this.BTN_Red_Save.Location = new System.Drawing.Point(57, 240);
            this.BTN_Red_Save.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_Red_Save.Name = "BTN_Red_Save";
            this.BTN_Red_Save.Size = new System.Drawing.Size(197, 54);
            this.BTN_Red_Save.TabIndex = 58;
            this.BTN_Red_Save.Text = "button1";
            this.BTN_Red_Save.UseVisualStyleBackColor = true;
            this.BTN_Red_Save.Click += new System.EventHandler(this.BTN_Red_Save_Click);
            // 
            // MTB_Tel
            // 
            this.MTB_Tel.Location = new System.Drawing.Point(57, 202);
            this.MTB_Tel.Mask = "+0(000)-000-00-00";
            this.MTB_Tel.Name = "MTB_Tel";
            this.MTB_Tel.Size = new System.Drawing.Size(197, 20);
            this.MTB_Tel.TabIndex = 59;
            // 
            // F_D_R_Pokup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 330);
            this.Controls.Add(this.MTB_Tel);
            this.Controls.Add(this.BTN_Red_Save);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_Otzh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_Famil);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(325, 369);
            this.MinimumSize = new System.Drawing.Size(325, 369);
            this.Name = "F_D_R_Pokup";
            this.Text = "F_D_R_Pokup";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_D_R_Pokup_FormClosed);
            this.Load += new System.EventHandler(this.F_D_R_Pokup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox TB_Otzh;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TB_Famil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button BTN_Red_Save;
        public System.Windows.Forms.MaskedTextBox MTB_Tel;
    }
}