namespace Fahrenheit_to_Celsius
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMorning = new System.Windows.Forms.TextBox();
            this.txtNoon = new System.Windows.Forms.TextBox();
            this.txtAfternoon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnToCelsius = new System.Windows.Forms.Button();
            this.btnToF = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSwitch1 = new System.Windows.Forms.Label();
            this.lblSwitch2 = new System.Windows.Forms.Label();
            this.lblOutput1 = new System.Windows.Forms.Label();
            this.lblOutput2 = new System.Windows.Forms.Label();
            this.lblOutput3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(325, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temp Converter";
            // 
            // txtMorning
            // 
            this.txtMorning.Location = new System.Drawing.Point(72, 78);
            this.txtMorning.Name = "txtMorning";
            this.txtMorning.Size = new System.Drawing.Size(100, 20);
            this.txtMorning.TabIndex = 1;
            // 
            // txtNoon
            // 
            this.txtNoon.Location = new System.Drawing.Point(72, 136);
            this.txtNoon.Name = "txtNoon";
            this.txtNoon.Size = new System.Drawing.Size(100, 20);
            this.txtNoon.TabIndex = 2;
            // 
            // txtAfternoon
            // 
            this.txtAfternoon.Location = new System.Drawing.Point(72, 192);
            this.txtAfternoon.Name = "txtAfternoon";
            this.txtAfternoon.Size = new System.Drawing.Size(100, 20);
            this.txtAfternoon.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "8:00 A.M.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "12:00 P.M.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "5:00 P.M.";
            // 
            // btnToCelsius
            // 
            this.btnToCelsius.Location = new System.Drawing.Point(188, 338);
            this.btnToCelsius.Name = "btnToCelsius";
            this.btnToCelsius.Size = new System.Drawing.Size(140, 23);
            this.btnToCelsius.TabIndex = 7;
            this.btnToCelsius.Text = "Convert to Celsius";
            this.btnToCelsius.UseVisualStyleBackColor = true;
            this.btnToCelsius.Click += new System.EventHandler(this.btnToCelsius_Click);
            // 
            // btnToF
            // 
            this.btnToF.Location = new System.Drawing.Point(441, 338);
            this.btnToF.Name = "btnToF";
            this.btnToF.Size = new System.Drawing.Size(140, 23);
            this.btnToF.TabIndex = 8;
            this.btnToF.Text = "Convert to Fahrenheit";
            this.btnToF.UseVisualStyleBackColor = true;
            this.btnToF.Click += new System.EventHandler(this.btnToF_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(528, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "8:00 A.M.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(528, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "12:00 P.M.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(528, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "5:00 P.M.";
            // 
            // lblSwitch1
            // 
            this.lblSwitch1.AutoSize = true;
            this.lblSwitch1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSwitch1.Location = new System.Drawing.Point(62, 30);
            this.lblSwitch1.Name = "lblSwitch1";
            this.lblSwitch1.Size = new System.Drawing.Size(76, 17);
            this.lblSwitch1.TabIndex = 15;
            this.lblSwitch1.Text = "Fahrenheit";
            // 
            // lblSwitch2
            // 
            this.lblSwitch2.AutoSize = true;
            this.lblSwitch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSwitch2.Location = new System.Drawing.Point(570, 30);
            this.lblSwitch2.Name = "lblSwitch2";
            this.lblSwitch2.Size = new System.Drawing.Size(53, 17);
            this.lblSwitch2.TabIndex = 16;
            this.lblSwitch2.Text = "Celsius";
            // 
            // lblOutput1
            // 
            this.lblOutput1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutput1.Location = new System.Drawing.Point(587, 74);
            this.lblOutput1.Name = "lblOutput1";
            this.lblOutput1.Size = new System.Drawing.Size(152, 40);
            this.lblOutput1.TabIndex = 17;
            // 
            // lblOutput2
            // 
            this.lblOutput2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutput2.Location = new System.Drawing.Point(587, 132);
            this.lblOutput2.Name = "lblOutput2";
            this.lblOutput2.Size = new System.Drawing.Size(152, 39);
            this.lblOutput2.TabIndex = 18;
            // 
            // lblOutput3
            // 
            this.lblOutput3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutput3.Location = new System.Drawing.Point(587, 189);
            this.lblOutput3.Name = "lblOutput3";
            this.lblOutput3.Size = new System.Drawing.Size(152, 44);
            this.lblOutput3.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(230, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblOutput3);
            this.Controls.Add(this.lblOutput2);
            this.Controls.Add(this.lblOutput1);
            this.Controls.Add(this.lblSwitch2);
            this.Controls.Add(this.lblSwitch1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnToF);
            this.Controls.Add(this.btnToCelsius);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAfternoon);
            this.Controls.Add(this.txtNoon);
            this.Controls.Add(this.txtMorning);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMorning;
        private System.Windows.Forms.TextBox txtNoon;
        private System.Windows.Forms.TextBox txtAfternoon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnToCelsius;
        private System.Windows.Forms.Button btnToF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSwitch1;
        private System.Windows.Forms.Label lblSwitch2;
        private System.Windows.Forms.Label lblOutput1;
        private System.Windows.Forms.Label lblOutput2;
        private System.Windows.Forms.Label lblOutput3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

