namespace DailySpecial
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWeekDay = new System.Windows.Forms.TextBox();
            this.btnGetSpecial = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a day number to see our special";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "For example, Sunday = 1";
            // 
            // txtWeekDay
            // 
            this.txtWeekDay.Location = new System.Drawing.Point(124, 159);
            this.txtWeekDay.Name = "txtWeekDay";
            this.txtWeekDay.Size = new System.Drawing.Size(100, 20);
            this.txtWeekDay.TabIndex = 2;
            // 
            // btnGetSpecial
            // 
            this.btnGetSpecial.Location = new System.Drawing.Point(137, 196);
            this.btnGetSpecial.Name = "btnGetSpecial";
            this.btnGetSpecial.Size = new System.Drawing.Size(75, 23);
            this.btnGetSpecial.TabIndex = 3;
            this.btnGetSpecial.Text = "Get special";
            this.btnGetSpecial.UseVisualStyleBackColor = true;
            this.btnGetSpecial.Click += new System.EventHandler(this.btnGetSpecial_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblOutput.Location = new System.Drawing.Point(87, 239);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(182, 23);
            this.lblOutput.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 398);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnGetSpecial);
            this.Controls.Add(this.txtWeekDay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWeekDay;
        private System.Windows.Forms.Button btnGetSpecial;
        private System.Windows.Forms.Label lblOutput;
    }
}

