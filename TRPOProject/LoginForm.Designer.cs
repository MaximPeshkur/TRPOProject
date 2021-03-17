namespace TRPOProject
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            this.labelHeader = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.panelUsername = new System.Windows.Forms.Panel();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.labelNoAcc = new System.Windows.Forms.Label();
            this.labelExit = new System.Windows.Forms.Label();
            this.pictureBoxVisible = new System.Windows.Forms.PictureBox();
            this.pictureBoxPassword = new System.Windows.Forms.PictureBox();
            this.pictureBoxUsername = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVisible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsername)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeader.ForeColor = System.Drawing.Color.White;
            this.labelHeader.Location = new System.Drawing.Point(84, 30);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(241, 42);
            this.labelHeader.TabIndex = 1;
            this.labelHeader.Text = "Авторизация";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsername.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUsername.ForeColor = System.Drawing.Color.White;
            this.textBoxUsername.Location = new System.Drawing.Point(91, 134);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(256, 18);
            this.textBoxUsername.TabIndex = 2;
            this.textBoxUsername.Text = "Username";
            this.textBoxUsername.Click += new System.EventHandler(this.textBox1_Click);
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panelUsername
            // 
            this.panelUsername.BackColor = System.Drawing.Color.White;
            this.panelUsername.ForeColor = System.Drawing.Color.White;
            this.panelUsername.Location = new System.Drawing.Point(61, 160);
            this.panelUsername.Name = "panelUsername";
            this.panelUsername.Size = new System.Drawing.Size(286, 1);
            this.panelUsername.TabIndex = 3;
            // 
            // panelPassword
            // 
            this.panelPassword.BackColor = System.Drawing.Color.White;
            this.panelPassword.ForeColor = System.Drawing.Color.White;
            this.panelPassword.Location = new System.Drawing.Point(61, 244);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(286, 1);
            this.panelPassword.TabIndex = 6;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.White;
            this.textBoxPassword.Location = new System.Drawing.Point(91, 218);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(226, 18);
            this.textBoxPassword.TabIndex = 5;
            this.textBoxPassword.Text = "Password";
            this.textBoxPassword.Click += new System.EventHandler(this.textBox2_Click);
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.buttonLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogIn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonLogIn.Location = new System.Drawing.Point(61, 319);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(286, 45);
            this.buttonLogIn.TabIndex = 7;
            this.buttonLogIn.Text = "Войти";
            this.buttonLogIn.UseVisualStyleBackColor = false;
            this.buttonLogIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelNoAcc
            // 
            this.labelNoAcc.AutoSize = true;
            this.labelNoAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.labelNoAcc.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNoAcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.labelNoAcc.Location = new System.Drawing.Point(157, 387);
            this.labelNoAcc.Name = "labelNoAcc";
            this.labelNoAcc.Size = new System.Drawing.Size(88, 15);
            this.labelNoAcc.TabIndex = 8;
            this.labelNoAcc.Text = "Нет аккаунта?";
            this.labelNoAcc.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelExit.Location = new System.Drawing.Point(400, 3);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(17, 16);
            this.labelExit.TabIndex = 9;
            this.labelExit.Text = "X";
            this.labelExit.Click += new System.EventHandler(this.label3_Click);
            this.labelExit.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            this.labelExit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label3_MouseMove);
            // 
            // pictureBoxVisible
            // 
            this.pictureBoxVisible.Image = global::TRPOProject.Properties.Resources.visible_white;
            this.pictureBoxVisible.Location = new System.Drawing.Point(323, 217);
            this.pictureBoxVisible.Name = "pictureBoxVisible";
            this.pictureBoxVisible.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxVisible.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxVisible.TabIndex = 10;
            this.pictureBoxVisible.TabStop = false;
            this.pictureBoxVisible.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBoxPassword
            // 
            this.pictureBoxPassword.Image = global::TRPOProject.Properties.Resources.lock_white;
            this.pictureBoxPassword.Location = new System.Drawing.Point(61, 214);
            this.pictureBoxPassword.Name = "pictureBoxPassword";
            this.pictureBoxPassword.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPassword.TabIndex = 4;
            this.pictureBoxPassword.TabStop = false;
            // 
            // pictureBoxUsername
            // 
            this.pictureBoxUsername.Image = global::TRPOProject.Properties.Resources.user_white;
            this.pictureBoxUsername.Location = new System.Drawing.Point(61, 130);
            this.pictureBoxUsername.Name = "pictureBoxUsername";
            this.pictureBoxUsername.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUsername.TabIndex = 0;
            this.pictureBoxUsername.TabStop = false;
            // 
            // timer1
            // 
            // 
            // timer2
            // 
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(420, 450);
            this.Controls.Add(this.pictureBoxVisible);
            this.Controls.Add(this.labelExit);
            this.Controls.Add(this.labelNoAcc);
            this.Controls.Add(this.buttonLogIn);
            this.Controls.Add(this.panelPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.pictureBoxPassword);
            this.Controls.Add(this.panelUsername);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.pictureBoxUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
           // this.Load += new System.EventHandler(this.LoginForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVisible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsername)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxUsername;
        public System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Panel panelUsername;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.PictureBox pictureBoxPassword;
        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.Label labelNoAcc;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.PictureBox pictureBoxVisible;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

