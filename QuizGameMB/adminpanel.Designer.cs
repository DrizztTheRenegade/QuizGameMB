﻿namespace QuizGameMB
{
    partial class adminpanel
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
            this.btn_addquestion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_addquestion
            // 
            this.btn_addquestion.Location = new System.Drawing.Point(241, 377);
            this.btn_addquestion.Name = "btn_addquestion";
            this.btn_addquestion.Size = new System.Drawing.Size(75, 23);
            this.btn_addquestion.TabIndex = 0;
            this.btn_addquestion.Text = "Add";
            this.btn_addquestion.UseVisualStyleBackColor = true;
            // 
            // adminpanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_addquestion);
            this.Name = "adminpanel";
            this.Text = "ExaQuiz";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_addquestion;
    }
}