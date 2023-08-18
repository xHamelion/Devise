
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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_Show
            // 
            this.BTN_Show.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTN_Show.BackgroundImage = global::Devise.Properties.Resources.NonShow;
            this.BTN_Show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Show.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTN_Show.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BTN_Show.Location = new System.Drawing.Point(341, 111);
            this.BTN_Show.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_Show.Name = "BTN_Show";
            this.BTN_Show.Size = new System.Drawing.Size(28, 29);
            this.BTN_Show.TabIndex = 109;
            this.BTN_Show.UseVisualStyleBackColor = false;
            this.BTN_Show.Click += new System.EventHandler(this.BTN_Show_Click);
            // 
            // BTN_Out
            // 
            this.BTN_Out.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.BTN_Out.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BTN_Out.Location = new System.Drawing.Point(210, 180);
            this.BTN_Out.Margin = new System.Windows.Forms.Padding(8);
            this.BTN_Out.Name = "BTN_Out";
            this.BTN_Out.Size = new System.Drawing.Size(159, 44);
            this.BTN_Out.TabIndex = 108;
            this.BTN_Out.Text = "Выйти";
            this.BTN_Out.UseVisualStyleBackColor = true;
            this.BTN_Out.Click += new System.EventHandler(this.BTN_Out_Click);
            // 
            // L_per
            // 
            this.L_per.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.L_per.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.L_per.Location = new System.Drawing.Point(21, 148);
            this.L_per.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.L_per.Name = "L_per";
            this.L_per.Size = new System.Drawing.Size(348, 24);
            this.L_per.TabIndex = 107;
            this.L_per.TabStop = true;
            this.L_per.Text = "Зарегистрироваться";
            this.L_per.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.L_per.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.L_per_LinkClicked);
            // 
            // BTN_Vhod_Reg
            // 
            this.BTN_Vhod_Reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.BTN_Vhod_Reg.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BTN_Vhod_Reg.Location = new System.Drawing.Point(21, 180);
            this.BTN_Vhod_Reg.Margin = new System.Windows.Forms.Padding(8);
            this.BTN_Vhod_Reg.Name = "BTN_Vhod_Reg";
            this.BTN_Vhod_Reg.Size = new System.Drawing.Size(159, 44);
            this.BTN_Vhod_Reg.TabIndex = 106;
            this.BTN_Vhod_Reg.Text = "Войти";
            this.BTN_Vhod_Reg.UseVisualStyleBackColor = true;
            this.BTN_Vhod_Reg.Click += new System.EventHandler(this.BTN_Vhod_Reg_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(17, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 105;
            this.label2.Text = "Пороль";
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label.Location = new System.Drawing.Point(17, 66);
            this.Label.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(64, 24);
            this.Label.TabIndex = 104;
            this.Label.Text = "Логин";
            // 
            // TB_Porol
            // 
            this.TB_Porol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.TB_Porol.Location = new System.Drawing.Point(95, 111);
            this.TB_Porol.Margin = new System.Windows.Forms.Padding(8);
            this.TB_Porol.Name = "TB_Porol";
            this.TB_Porol.PasswordChar = '*';
            this.TB_Porol.Size = new System.Drawing.Size(242, 29);
            this.TB_Porol.TabIndex = 103;
            // 
            // TB_Log
            // 
            this.TB_Log.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.TB_Log.Location = new System.Drawing.Point(95, 66);
            this.TB_Log.Margin = new System.Windows.Forms.Padding(8);
            this.TB_Log.Name = "TB_Log";
            this.TB_Log.Size = new System.Drawing.Size(274, 29);
            this.TB_Log.TabIndex = 102;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 49);
            this.label1.TabIndex = 111;
            this.label1.Text = "Авторизация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // F_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 237);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Show);
            this.Controls.Add(this.BTN_Out);
            this.Controls.Add(this.L_per);
            this.Controls.Add(this.BTN_Vhod_Reg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.TB_Porol);
            this.Controls.Add(this.TB_Log);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(405, 276);
            this.MinimumSize = new System.Drawing.Size(405, 276);
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
        public System.Windows.Forms.Button BTN_Vhod_Reg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label;
        public System.Windows.Forms.TextBox TB_Porol;
        public System.Windows.Forms.TextBox TB_Log;
        private System.Windows.Forms.Label label1;
    }
}

