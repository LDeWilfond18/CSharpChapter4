﻿namespace Twitter
{
    partial class Form1
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
            this.txtTwitterMessage = new System.Windows.Forms.TextBox();
            this.lblCounter = new System.Windows.Forms.Label();
            this.btnPost = new System.Windows.Forms.Button();
            this.lblPosted = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTwitterMessage
            // 
            this.txtTwitterMessage.Location = new System.Drawing.Point(35, 12);
            this.txtTwitterMessage.Multiline = true;
            this.txtTwitterMessage.Name = "txtTwitterMessage";
            this.txtTwitterMessage.Size = new System.Drawing.Size(229, 101);
            this.txtTwitterMessage.TabIndex = 0;
            // 
            // lblCounter
            // 
            this.lblCounter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCounter.Location = new System.Drawing.Point(100, 116);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(100, 23);
            this.lblCounter.TabIndex = 1;
            // 
            // btnPost
            // 
            this.btnPost.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPost.Location = new System.Drawing.Point(115, 152);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(75, 23);
            this.btnPost.TabIndex = 2;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = false;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // lblPosted
            // 
            this.lblPosted.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPosted.Location = new System.Drawing.Point(100, 187);
            this.lblPosted.Name = "lblPosted";
            this.lblPosted.Size = new System.Drawing.Size(100, 23);
            this.lblPosted.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 251);
            this.Controls.Add(this.lblPosted);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.txtTwitterMessage);
            this.Name = "Form1";
            this.Text = "Twoter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTwitterMessage;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Label lblPosted;
    }
}

