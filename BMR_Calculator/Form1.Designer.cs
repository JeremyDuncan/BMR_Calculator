namespace BMR_Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.maleCheckbox = new System.Windows.Forms.CheckBox();
            this.femaleCheckbox = new System.Windows.Forms.CheckBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.inputHeight = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inputWeight = new System.Windows.Forms.NumericUpDown();
            this.inputAge = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.inputHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputAge)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(279, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "BMR Calculator";
            // 
            // maleCheckbox
            // 
            this.maleCheckbox.AutoSize = true;
            this.maleCheckbox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.maleCheckbox.Location = new System.Drawing.Point(250, 164);
            this.maleCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.maleCheckbox.Name = "maleCheckbox";
            this.maleCheckbox.Size = new System.Drawing.Size(136, 55);
            this.maleCheckbox.TabIndex = 1;
            this.maleCheckbox.Text = "Male";
            this.maleCheckbox.UseVisualStyleBackColor = true;
            // 
            // femaleCheckbox
            // 
            this.femaleCheckbox.AutoSize = true;
            this.femaleCheckbox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.femaleCheckbox.Location = new System.Drawing.Point(433, 164);
            this.femaleCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.femaleCheckbox.Name = "femaleCheckbox";
            this.femaleCheckbox.Size = new System.Drawing.Size(174, 55);
            this.femaleCheckbox.TabIndex = 2;
            this.femaleCheckbox.Text = "Female";
            this.femaleCheckbox.UseVisualStyleBackColor = true;
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(321, 540);
            this.enterButton.Margin = new System.Windows.Forms.Padding(4);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(231, 72);
            this.enterButton.TabIndex = 6;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultsLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resultsLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resultsLabel.Location = new System.Drawing.Point(45, 656);
            this.resultsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultsLabel.MaximumSize = new System.Drawing.Size(800, 0);
            this.resultsLabel.MinimumSize = new System.Drawing.Size(800, 200);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(800, 200);
            this.resultsLabel.TabIndex = 7;
            this.resultsLabel.Text = "Please enter your information";
            this.resultsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputHeight
            // 
            this.inputHeight.Location = new System.Drawing.Point(433, 257);
            this.inputHeight.Name = "inputHeight";
            this.inputHeight.Size = new System.Drawing.Size(145, 57);
            this.inputHeight.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 51);
            this.label2.TabIndex = 9;
            this.label2.Text = "HEIGHT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 51);
            this.label3.TabIndex = 10;
            this.label3.Text = "WEIGHT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 51);
            this.label4.TabIndex = 11;
            this.label4.Text = "AGE";
            // 
            // inputWeight
            // 
            this.inputWeight.Location = new System.Drawing.Point(433, 335);
            this.inputWeight.Name = "inputWeight";
            this.inputWeight.Size = new System.Drawing.Size(145, 57);
            this.inputWeight.TabIndex = 12;
            // 
            // inputAge
            // 
            this.inputAge.Location = new System.Drawing.Point(433, 420);
            this.inputAge.Name = "inputAge";
            this.inputAge.Size = new System.Drawing.Size(145, 57);
            this.inputAge.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 50F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(902, 872);
            this.Controls.Add(this.inputAge);
            this.Controls.Add(this.inputWeight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputHeight);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.femaleCheckbox);
            this.Controls.Add(this.maleCheckbox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Jeremy\'s BMR Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.inputHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private CheckBox maleCheckbox;
        private CheckBox femaleCheckbox;
        private Button enterButton;
        private Label resultsLabel;
        private NumericUpDown inputHeight;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown inputWeight;
        private NumericUpDown inputAge;
    }
}