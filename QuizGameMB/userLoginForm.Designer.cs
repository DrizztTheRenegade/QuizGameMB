namespace QuizGameMB
{
    partial class userLoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.userLoginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cześć! Wprowadz swoje imię i zacznij rozwiązywać quiz:";
            // 
            // userName
            // 
            this.userName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.userName.Location = new System.Drawing.Point(65, 80);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(353, 22);
            this.userName.TabIndex = 1;
            // 
            // userLoginBtn
            // 
            this.userLoginBtn.Location = new System.Drawing.Point(343, 117);
            this.userLoginBtn.Name = "userLoginBtn";
            this.userLoginBtn.Size = new System.Drawing.Size(75, 23);
            this.userLoginBtn.TabIndex = 2;
            this.userLoginBtn.Text = "Dalej";
            this.userLoginBtn.UseVisualStyleBackColor = true;
            this.userLoginBtn.Click += new System.EventHandler(this.userLoginBtn_Click);
            // 
            // userLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 283);
            this.Controls.Add(this.userLoginBtn);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.label1);
            this.Name = "userLoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Button userLoginBtn;
    }
}