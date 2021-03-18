namespace TRPOProject
{
    partial class RegistredForm
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
            this.panelPassword = new System.Windows.Forms.Panel();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.panelUsername = new System.Windows.Forms.Panel();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.buttonRegisration = new System.Windows.Forms.Button();
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelHasAcc = new System.Windows.Forms.Label();
            this.panelSurname = new System.Windows.Forms.Panel();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.panelName = new System.Windows.Forms.Panel();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelExit = new System.Windows.Forms.Label();
            this.textBoxHiddenSurname = new System.Windows.Forms.TextBox();
            this.textBoxHiddenName = new System.Windows.Forms.TextBox();
            this.pictureBoxPassword = new System.Windows.Forms.PictureBox();
            this.pictureBoxUsername = new System.Windows.Forms.PictureBox();
            this.pictureBoxVisible = new System.Windows.Forms.PictureBox();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.panelKey = new System.Windows.Forms.Panel();
            this.textBoxKeyWrite = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVisible)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPassword
            // 
            this.panelPassword.BackColor = System.Drawing.Color.White;
            this.panelPassword.ForeColor = System.Drawing.Color.White;
            this.panelPassword.Location = new System.Drawing.Point(69, 198);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(286, 1);
            this.panelPassword.TabIndex = 12;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.White;
            this.textBoxPassword.Location = new System.Drawing.Point(99, 172);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(234, 18);
            this.textBoxPassword.TabIndex = 11;
            this.textBoxPassword.Text = "Password";
            this.textBoxPassword.Click += new System.EventHandler(this.textBox2_Click);
            this.textBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPassword_KeyDown);
            // 
            // panelUsername
            // 
            this.panelUsername.BackColor = System.Drawing.Color.White;
            this.panelUsername.ForeColor = System.Drawing.Color.White;
            this.panelUsername.Location = new System.Drawing.Point(69, 131);
            this.panelUsername.Name = "panelUsername";
            this.panelUsername.Size = new System.Drawing.Size(286, 1);
            this.panelUsername.TabIndex = 9;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsername.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUsername.ForeColor = System.Drawing.Color.White;
            this.textBoxUsername.Location = new System.Drawing.Point(99, 105);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(256, 18);
            this.textBoxUsername.TabIndex = 8;
            this.textBoxUsername.Text = "Username";
            this.textBoxUsername.Click += new System.EventHandler(this.textBox1_Click);
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBoxUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxUsername_KeyDown);
            // 
            // buttonRegisration
            // 
            this.buttonRegisration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.buttonRegisration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegisration.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegisration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.buttonRegisration.Location = new System.Drawing.Point(69, 416);
            this.buttonRegisration.Name = "buttonRegisration";
            this.buttonRegisration.Size = new System.Drawing.Size(286, 45);
            this.buttonRegisration.TabIndex = 13;
            this.buttonRegisration.Text = "Зарегистрироваться";
            this.buttonRegisration.UseVisualStyleBackColor = false;
            this.buttonRegisration.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeader.ForeColor = System.Drawing.Color.White;
            this.labelHeader.Location = new System.Drawing.Point(89, 26);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(235, 42);
            this.labelHeader.TabIndex = 14;
            this.labelHeader.Text = "Регистрация";
            // 
            // labelHasAcc
            // 
            this.labelHasAcc.AutoSize = true;
            this.labelHasAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.labelHasAcc.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHasAcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.labelHasAcc.Location = new System.Drawing.Point(153, 474);
            this.labelHasAcc.Name = "labelHasAcc";
            this.labelHasAcc.Size = new System.Drawing.Size(112, 15);
            this.labelHasAcc.TabIndex = 15;
            this.labelHasAcc.Text = "Уже есть аккаунт?";
            this.labelHasAcc.Click += new System.EventHandler(this.label2_Click);
            // 
            // panelSurname
            // 
            this.panelSurname.BackColor = System.Drawing.Color.White;
            this.panelSurname.ForeColor = System.Drawing.Color.White;
            this.panelSurname.Location = new System.Drawing.Point(69, 327);
            this.panelSurname.Name = "panelSurname";
            this.panelSurname.Size = new System.Drawing.Size(286, 1);
            this.panelSurname.TabIndex = 21;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBoxSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSurname.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSurname.ForeColor = System.Drawing.Color.White;
            this.textBoxSurname.Location = new System.Drawing.Point(71, 303);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(284, 18);
            this.textBoxSurname.TabIndex = 20;
            this.textBoxSurname.Text = "Surname";
            this.textBoxSurname.Click += new System.EventHandler(this.textBox3_Click);
            this.textBoxSurname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSurname_KeyDown);
            // 
            // panelName
            // 
            this.panelName.BackColor = System.Drawing.Color.White;
            this.panelName.ForeColor = System.Drawing.Color.White;
            this.panelName.Location = new System.Drawing.Point(69, 260);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(286, 1);
            this.panelName.TabIndex = 18;
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.ForeColor = System.Drawing.Color.White;
            this.textBoxName.Location = new System.Drawing.Point(71, 236);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(284, 18);
            this.textBoxName.TabIndex = 17;
            this.textBoxName.Text = "Name";
            this.textBoxName.Click += new System.EventHandler(this.textBox4_Click);
            this.textBoxName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxName_KeyDown);
            // 
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelExit.Location = new System.Drawing.Point(401, 3);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(17, 16);
            this.labelExit.TabIndex = 22;
            this.labelExit.Text = "X";
            this.labelExit.Click += new System.EventHandler(this.label3_Click);
            this.labelExit.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            this.labelExit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label3_MouseMove);
            // 
            // textBoxHiddenSurname
            // 
            this.textBoxHiddenSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBoxHiddenSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxHiddenSurname.Enabled = false;
            this.textBoxHiddenSurname.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxHiddenSurname.ForeColor = System.Drawing.Color.White;
            this.textBoxHiddenSurname.Location = new System.Drawing.Point(1, 279);
            this.textBoxHiddenSurname.Name = "textBoxHiddenSurname";
            this.textBoxHiddenSurname.ReadOnly = true;
            this.textBoxHiddenSurname.Size = new System.Drawing.Size(68, 18);
            this.textBoxHiddenSurname.TabIndex = 23;
            this.textBoxHiddenSurname.Text = "Surname:";
            this.textBoxHiddenSurname.Visible = false;
            // 
            // textBoxHiddenName
            // 
            this.textBoxHiddenName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBoxHiddenName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxHiddenName.Enabled = false;
            this.textBoxHiddenName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxHiddenName.ForeColor = System.Drawing.Color.White;
            this.textBoxHiddenName.Location = new System.Drawing.Point(1, 221);
            this.textBoxHiddenName.Name = "textBoxHiddenName";
            this.textBoxHiddenName.ReadOnly = true;
            this.textBoxHiddenName.Size = new System.Drawing.Size(49, 18);
            this.textBoxHiddenName.TabIndex = 24;
            this.textBoxHiddenName.Text = "Name:";
            this.textBoxHiddenName.Visible = false;
            // 
            // pictureBoxPassword
            // 
            this.pictureBoxPassword.Image = global::TRPOProject.Properties.Resources.lock_white;
            this.pictureBoxPassword.Location = new System.Drawing.Point(69, 166);
            this.pictureBoxPassword.Name = "pictureBoxPassword";
            this.pictureBoxPassword.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPassword.TabIndex = 10;
            this.pictureBoxPassword.TabStop = false;
            // 
            // pictureBoxUsername
            // 
            this.pictureBoxUsername.Image = global::TRPOProject.Properties.Resources.user_white;
            this.pictureBoxUsername.Location = new System.Drawing.Point(69, 99);
            this.pictureBoxUsername.Name = "pictureBoxUsername";
            this.pictureBoxUsername.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUsername.TabIndex = 7;
            this.pictureBoxUsername.TabStop = false;
            // 
            // pictureBoxVisible
            // 
            this.pictureBoxVisible.Image = global::TRPOProject.Properties.Resources.visible_white;
            this.pictureBoxVisible.Location = new System.Drawing.Point(331, 171);
            this.pictureBoxVisible.Name = "pictureBoxVisible";
            this.pictureBoxVisible.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxVisible.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxVisible.TabIndex = 25;
            this.pictureBoxVisible.TabStop = false;
            this.pictureBoxVisible.Click += new System.EventHandler(this.pictureBoxVisible_Click);
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPosition.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Items.AddRange(new object[] {
            "Администратор",
            "Работник"});
            this.comboBoxPosition.Location = new System.Drawing.Point(69, 373);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(150, 24);
            this.comboBoxPosition.TabIndex = 26;
            this.comboBoxPosition.SelectedIndexChanged += new System.EventHandler(this.comboBoxPosition_SelectedIndexChanged);
            this.comboBoxPosition.MouseEnter += new System.EventHandler(this.comboBoxPosition_MouseEnter);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(1, 349);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(92, 18);
            this.textBox1.TabIndex = 27;
            this.textBox1.Text = "Должность:";
            // 
            // textBoxKey
            // 
            this.textBoxKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBoxKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxKey.Enabled = false;
            this.textBoxKey.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxKey.ForeColor = System.Drawing.Color.White;
            this.textBoxKey.Location = new System.Drawing.Point(222, 349);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.ReadOnly = true;
            this.textBoxKey.Size = new System.Drawing.Size(68, 18);
            this.textBoxKey.TabIndex = 28;
            this.textBoxKey.Text = "Ключ:";
            this.textBoxKey.Visible = false;
            // 
            // panelKey
            // 
            this.panelKey.BackColor = System.Drawing.Color.White;
            this.panelKey.ForeColor = System.Drawing.Color.White;
            this.panelKey.Location = new System.Drawing.Point(222, 395);
            this.panelKey.Name = "panelKey";
            this.panelKey.Size = new System.Drawing.Size(175, 1);
            this.panelKey.TabIndex = 30;
            this.panelKey.Visible = false;
            // 
            // textBoxKeyWrite
            // 
            this.textBoxKeyWrite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBoxKeyWrite.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxKeyWrite.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxKeyWrite.ForeColor = System.Drawing.Color.White;
            this.textBoxKeyWrite.Location = new System.Drawing.Point(222, 375);
            this.textBoxKeyWrite.Name = "textBoxKeyWrite";
            this.textBoxKeyWrite.Size = new System.Drawing.Size(133, 18);
            this.textBoxKeyWrite.TabIndex = 29;
            this.textBoxKeyWrite.Text = "Ключ";
            this.textBoxKeyWrite.Visible = false;
            this.textBoxKeyWrite.Click += new System.EventHandler(this.textBoxKeyWrite_Click);
            this.textBoxKeyWrite.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxKeyWrite_KeyDown);
            // 
            // RegistredForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(420, 500);
            this.Controls.Add(this.panelKey);
            this.Controls.Add(this.textBoxKeyWrite);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBoxPosition);
            this.Controls.Add(this.pictureBoxVisible);
            this.Controls.Add(this.textBoxHiddenName);
            this.Controls.Add(this.textBoxHiddenSurname);
            this.Controls.Add(this.labelExit);
            this.Controls.Add(this.panelSurname);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.panelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelHasAcc);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.buttonRegisration);
            this.Controls.Add(this.panelPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.pictureBoxPassword);
            this.Controls.Add(this.panelUsername);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.pictureBoxUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistredForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistredForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegistredForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RegistredForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVisible)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.PictureBox pictureBoxPassword;
        private System.Windows.Forms.Panel panelUsername;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.PictureBox pictureBoxUsername;
        private System.Windows.Forms.Button buttonRegisration;
        public System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelHasAcc;
        private System.Windows.Forms.Panel panelSurname;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.TextBox textBoxHiddenSurname;
        private System.Windows.Forms.TextBox textBoxHiddenName;
        private System.Windows.Forms.PictureBox pictureBoxVisible;
        private System.Windows.Forms.ComboBox comboBoxPosition;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Panel panelKey;
        private System.Windows.Forms.TextBox textBoxKeyWrite;
        
    }
}