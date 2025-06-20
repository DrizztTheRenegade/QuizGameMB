namespace QuizGameMB
{
    partial class ExaQuiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExaQuiz));
            this.welcome = new System.Windows.Forms.Label();
            this.userlogin = new System.Windows.Forms.Button();
            this.adminlogin = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.Button();
            this.help = new System.Windows.Forms.Button();
            this.panelmenu = new System.Windows.Forms.Panel();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panelmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Franklin Gothic Heavy", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.welcome.Location = new System.Drawing.Point(89, 31);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(246, 36);
            this.welcome.TabIndex = 0;
            this.welcome.Text = "Witam w ExaQuiz!";
            this.welcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.welcome.Click += new System.EventHandler(this.welcome_Click);
            // 
            // userlogin
            // 
            this.userlogin.BackColor = System.Drawing.Color.Gainsboro;
            this.userlogin.Location = new System.Drawing.Point(95, 87);
            this.userlogin.Name = "userlogin";
            this.userlogin.Size = new System.Drawing.Size(240, 23);
            this.userlogin.TabIndex = 1;
            this.userlogin.Text = "Zaloguj sié jako gracz";
            this.userlogin.UseVisualStyleBackColor = false;
            this.userlogin.Click += new System.EventHandler(this.userlogin_Click);
            // 
            // adminlogin
            // 
            this.adminlogin.Location = new System.Drawing.Point(95, 132);
            this.adminlogin.Name = "adminlogin";
            this.adminlogin.Size = new System.Drawing.Size(240, 23);
            this.adminlogin.TabIndex = 2;
            this.adminlogin.Text = "Załoguj sie jako admin";
            this.adminlogin.UseVisualStyleBackColor = true;
            this.adminlogin.Click += new System.EventHandler(this.adminlogin_Click);
            // 
            // settings
            // 
            this.settings.Location = new System.Drawing.Point(95, 178);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(240, 23);
            this.settings.TabIndex = 3;
            this.settings.Text = "Ustawienia";
            this.settings.UseVisualStyleBackColor = true;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // help
            // 
            this.help.Location = new System.Drawing.Point(95, 226);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(240, 23);
            this.help.TabIndex = 4;
            this.help.Text = "Pomoc";
            this.help.UseVisualStyleBackColor = true;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // panelmenu
            // 
            this.panelmenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelmenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelmenu.Controls.Add(this.welcome);
            this.panelmenu.Controls.Add(this.help);
            this.panelmenu.Controls.Add(this.userlogin);
            this.panelmenu.Controls.Add(this.settings);
            this.panelmenu.Controls.Add(this.adminlogin);
            this.panelmenu.Location = new System.Drawing.Point(111, 43);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(422, 331);
            this.panelmenu.TabIndex = 5;
            this.panelmenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelmenu_Paint);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // ExaQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 450);
            this.Controls.Add(this.panelmenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExaQuiz";
            this.Text = "ExaQuiz";
            this.Load += new System.EventHandler(this.ExaQuiz_Load);
            this.panelmenu.ResumeLayout(false);
            this.panelmenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Button userlogin;
        private System.Windows.Forms.Button adminlogin;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.Panel panelmenu;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

