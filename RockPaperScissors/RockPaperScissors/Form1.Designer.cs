namespace RockPaperScissors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnRock = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblWin = new System.Windows.Forms.Label();
            this.lblLoss = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRock
            // 
            this.btnRock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRock.BackgroundImage")));
            this.btnRock.Location = new System.Drawing.Point(12, 12);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(274, 186);
            this.btnRock.TabIndex = 0;
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPaper.BackgroundImage")));
            this.btnPaper.Location = new System.Drawing.Point(292, 12);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(319, 186);
            this.btnPaper.TabIndex = 1;
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnScissors
            // 
            this.btnScissors.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnScissors.BackgroundImage")));
            this.btnScissors.Location = new System.Drawing.Point(617, 12);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(257, 186);
            this.btnScissors.TabIndex = 2;
            this.btnScissors.UseVisualStyleBackColor = true;
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblResult.Location = new System.Drawing.Point(111, 236);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(652, 109);
            this.lblResult.TabIndex = 3;
            // 
            // lblWin
            // 
            this.lblWin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWin.Location = new System.Drawing.Point(158, 405);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(100, 23);
            this.lblWin.TabIndex = 4;
            // 
            // lblLoss
            // 
            this.lblLoss.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLoss.Location = new System.Drawing.Point(642, 404);
            this.lblLoss.Name = "lblLoss";
            this.lblLoss.Size = new System.Drawing.Size(100, 23);
            this.lblLoss.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "dubs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(586, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "loss";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 507);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLoss);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.Name = "Form1";
            this.Text = "Rock Paper Scissors";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.Label lblLoss;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

