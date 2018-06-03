namespace Photostudio
{
    partial class PasswordForm
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
            this.checkPassBtn = new System.Windows.Forms.Button();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkPassBtn
            // 
            this.checkPassBtn.Location = new System.Drawing.Point(171, 128);
            this.checkPassBtn.Name = "checkPassBtn";
            this.checkPassBtn.Size = new System.Drawing.Size(111, 35);
            this.checkPassBtn.TabIndex = 0;
            this.checkPassBtn.Text = "Вход";
            this.checkPassBtn.UseVisualStyleBackColor = true;
            this.checkPassBtn.Click += new System.EventHandler(this.checkPassBtn_Click);
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(116, 76);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(231, 20);
            this.passwordTB.TabIndex = 1;
            this.passwordTB.UseSystemPasswordChar = true;
            // 
            // PasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 223);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.checkPassBtn);
            this.Name = "PasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ввод пароля";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PasswordForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button checkPassBtn;
        private System.Windows.Forms.TextBox passwordTB;
    }
}