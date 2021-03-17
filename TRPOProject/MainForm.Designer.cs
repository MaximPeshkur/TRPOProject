
namespace TRPOProject
{
    partial class MainForm
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
            this.labelExit = new System.Windows.Forms.Label();
            this.AddRecbutton = new System.Windows.Forms.Button();
            this.Statisticsbutton = new System.Windows.Forms.Button();
            this.GetInfobutton = new System.Windows.Forms.Button();
            this.DeleteRecbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelExit.Location = new System.Drawing.Point(783, 0);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(17, 16);
            this.labelExit.TabIndex = 23;
            this.labelExit.Text = "X";
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click);
            this.labelExit.MouseLeave += new System.EventHandler(this.labelExit_MouseLeave);
            this.labelExit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelExit_MouseMove);
            // 
            // AddRecbutton
            // 
            this.AddRecbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.AddRecbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRecbutton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddRecbutton.ForeColor = System.Drawing.Color.White;
            this.AddRecbutton.Location = new System.Drawing.Point(1, 19);
            this.AddRecbutton.Name = "AddRecbutton";
            this.AddRecbutton.Size = new System.Drawing.Size(400, 216);
            this.AddRecbutton.TabIndex = 24;
            this.AddRecbutton.Text = "ДОБАВИТЬ ЗАКАЗ";
            this.AddRecbutton.UseVisualStyleBackColor = false;
            this.AddRecbutton.MouseLeave += new System.EventHandler(this.AddRecbutton_MouseLeave);
            this.AddRecbutton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddRecbutton_MouseMove);
            // 
            // Statisticsbutton
            // 
            this.Statisticsbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Statisticsbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Statisticsbutton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Statisticsbutton.ForeColor = System.Drawing.Color.White;
            this.Statisticsbutton.Location = new System.Drawing.Point(1, 232);
            this.Statisticsbutton.Name = "Statisticsbutton";
            this.Statisticsbutton.Size = new System.Drawing.Size(400, 218);
            this.Statisticsbutton.TabIndex = 25;
            this.Statisticsbutton.Text = "СТАТИСТИКА";
            this.Statisticsbutton.UseVisualStyleBackColor = false;
            this.Statisticsbutton.MouseLeave += new System.EventHandler(this.Statisticsbutton_MouseLeave);
            this.Statisticsbutton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Statisticsbutton_MouseMove);
            // 
            // GetInfobutton
            // 
            this.GetInfobutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.GetInfobutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetInfobutton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetInfobutton.ForeColor = System.Drawing.Color.White;
            this.GetInfobutton.Location = new System.Drawing.Point(400, 232);
            this.GetInfobutton.Name = "GetInfobutton";
            this.GetInfobutton.Size = new System.Drawing.Size(400, 218);
            this.GetInfobutton.TabIndex = 26;
            this.GetInfobutton.Text = "ПОИСК ЗАКАЗА";
            this.GetInfobutton.UseVisualStyleBackColor = false;
            this.GetInfobutton.Click += new System.EventHandler(this.GetInfobutton_Click);
            this.GetInfobutton.MouseLeave += new System.EventHandler(this.GetInfobutton_MouseLeave);
            this.GetInfobutton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GetInfobutton_MouseMove);
            // 
            // DeleteRecbutton
            // 
            this.DeleteRecbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.DeleteRecbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteRecbutton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteRecbutton.ForeColor = System.Drawing.Color.White;
            this.DeleteRecbutton.Location = new System.Drawing.Point(400, 19);
            this.DeleteRecbutton.Name = "DeleteRecbutton";
            this.DeleteRecbutton.Size = new System.Drawing.Size(400, 216);
            this.DeleteRecbutton.TabIndex = 27;
            this.DeleteRecbutton.Text = "УДАЛИТЬ ЗАКАЗ";
            this.DeleteRecbutton.UseVisualStyleBackColor = false;
            this.DeleteRecbutton.MouseLeave += new System.EventHandler(this.DeleteRecbutton_MouseLeave);
            this.DeleteRecbutton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DeleteRecbutton_MouseMove);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteRecbutton);
            this.Controls.Add(this.GetInfobutton);
            this.Controls.Add(this.Statisticsbutton);
            this.Controls.Add(this.AddRecbutton);
            this.Controls.Add(this.labelExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.Button AddRecbutton;
        private System.Windows.Forms.Button Statisticsbutton;
        private System.Windows.Forms.Button GetInfobutton;
        private System.Windows.Forms.Button DeleteRecbutton;
    }
}