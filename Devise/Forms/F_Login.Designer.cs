
namespace Devise
{
    partial class F_Login
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTN_Show = new System.Windows.Forms.Button();
            this.BTN_Out = new System.Windows.Forms.Button();
            this.L_per = new System.Windows.Forms.LinkLabel();
            this.BTN_Vhod_Reg = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Label = new System.Windows.Forms.Label();
            this.TB_Porol = new System.Windows.Forms.TextBox();
            this.TB_Log = new System.Windows.Forms.TextBox();
            this.btn_spravka = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_Show
            // 
            this.BTN_Show.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTN_Show.BackgroundImage = global::Devise.Properties.Resources.NonShow;
            this.BTN_Show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Show.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTN_Show.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BTN_Show.Location = new System.Drawing.Point(351, 147);
            this.BTN_Show.Name = "BTN_Show";
            this.BTN_Show.Size = new System.Drawing.Size(31, 29);
            this.BTN_Show.TabIndex = 30;
            this.BTN_Show.UseVisualStyleBackColor = false;
            this.BTN_Show.Click += new System.EventHandler(this.BTN_Show_Click);
            // 
            // BTN_Out
            // 
            this.BTN_Out.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.BTN_Out.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BTN_Out.Location = new System.Drawing.Point(216, 250);
            this.BTN_Out.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_Out.Name = "BTN_Out";
            this.BTN_Out.Size = new System.Drawing.Size(166, 48);
            this.BTN_Out.TabIndex = 29;
            this.BTN_Out.Text = "Выйти";
            this.BTN_Out.UseVisualStyleBackColor = true;
            // 
            // L_per
            // 
            this.L_per.AutoSize = true;
            this.L_per.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.L_per.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.L_per.Location = new System.Drawing.Point(48, 181);
            this.L_per.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.L_per.Name = "L_per";
            this.L_per.Size = new System.Drawing.Size(201, 24);
            this.L_per.TabIndex = 28;
            this.L_per.TabStop = true;
            this.L_per.Text = "Зарегистрироваться";
            this.L_per.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.L_per.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.L_per_LinkClicked);
            // 
            // BTN_Vhod_Reg
            // 
            this.BTN_Vhod_Reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.BTN_Vhod_Reg.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BTN_Vhod_Reg.Location = new System.Drawing.Point(48, 250);
            this.BTN_Vhod_Reg.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_Vhod_Reg.Name = "BTN_Vhod_Reg";
            this.BTN_Vhod_Reg.Size = new System.Drawing.Size(166, 48);
            this.BTN_Vhod_Reg.TabIndex = 27;
            this.BTN_Vhod_Reg.Text = "Войти";
            this.BTN_Vhod_Reg.UseVisualStyleBackColor = true;
            this.BTN_Vhod_Reg.Click += new System.EventHandler(this.BTN_Vhod_Reg_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(45, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "Пороль";
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label.Location = new System.Drawing.Point(45, 38);
            this.Label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(64, 24);
            this.Label.TabIndex = 25;
            this.Label.Text = "Логин";
            // 
            // TB_Porol
            // 
            this.TB_Porol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.TB_Porol.Location = new System.Drawing.Point(48, 147);
            this.TB_Porol.Margin = new System.Windows.Forms.Padding(5);
            this.TB_Porol.Name = "TB_Porol";
            this.TB_Porol.PasswordChar = '*';
            this.TB_Porol.Size = new System.Drawing.Size(295, 29);
            this.TB_Porol.TabIndex = 24;
            this.TB_Porol.Text = "Admin";
            // 
            // TB_Log
            // 
            this.TB_Log.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.TB_Log.Location = new System.Drawing.Point(48, 67);
            this.TB_Log.Margin = new System.Windows.Forms.Padding(5);
            this.TB_Log.Name = "TB_Log";
            this.TB_Log.Size = new System.Drawing.Size(334, 29);
            this.TB_Log.TabIndex = 23;
            this.TB_Log.Text = "Admin";
            // 
            // btn_spravka
            // 
            this.btn_spravka.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_spravka.Location = new System.Drawing.Point(360, 316);
            this.btn_spravka.Name = "btn_spravka";
            this.btn_spravka.Size = new System.Drawing.Size(75, 23);
            this.btn_spravka.TabIndex = 101;
            this.btn_spravka.Text = "Справка";
            this.btn_spravka.UseVisualStyleBackColor = true;
            this.btn_spravka.Click += new System.EventHandler(this.btn_spravka_Click);
            // 
            // F_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 351);
            this.Controls.Add(this.btn_spravka);
            this.Controls.Add(this.BTN_Show);
            this.Controls.Add(this.BTN_Out);
            this.Controls.Add(this.L_per);
            this.Controls.Add(this.BTN_Vhod_Reg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.TB_Porol);
            this.Controls.Add(this.TB_Log);
            this.MaximumSize = new System.Drawing.Size(463, 390);
            this.MinimumSize = new System.Drawing.Size(463, 390);
            this.Name = "F_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.F_Login_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Show;
        private System.Windows.Forms.Button BTN_Out;
        private System.Windows.Forms.LinkLabel L_per;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Button btn_spravka;
        public System.Windows.Forms.Button BTN_Vhod_Reg;
        public System.Windows.Forms.TextBox TB_Log;
        public System.Windows.Forms.TextBox TB_Porol;
    }
}

