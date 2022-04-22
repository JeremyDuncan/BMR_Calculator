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
            this.inputHeight = new System.Windows.Forms.TextBox();
            this.inputWeight = new System.Windows.Forms.TextBox();
            this.inputAge = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(209, 57);
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
            this.maleCheckbox.Location = new System.Drawing.Point(177, 143);
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
            this.femaleCheckbox.Location = new System.Drawing.Point(360, 143);
            this.femaleCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.femaleCheckbox.Name = "femaleCheckbox";
            this.femaleCheckbox.Size = new System.Drawing.Size(174, 55);
            this.femaleCheckbox.TabIndex = 2;
            this.femaleCheckbox.Text = "Female";
            this.femaleCheckbox.UseVisualStyleBackColor = true;
            // 
            // inputHeight
            // 
            this.inputHeight.Location = new System.Drawing.Point(196, 236);
            this.inputHeight.Margin = new System.Windows.Forms.Padding(4);
            this.inputHeight.Name = "inputHeight";
            this.inputHeight.Size = new System.Drawing.Size(305, 57);
            this.inputHeight.TabIndex = 3;
            this.inputHeight.Text = "Height (Inches)";
            this.inputHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputWeight
            // 
            this.inputWeight.Location = new System.Drawing.Point(196, 317);
            this.inputWeight.Margin = new System.Windows.Forms.Padding(4);
            this.inputWeight.Name = "inputWeight";
            this.inputWeight.Size = new System.Drawing.Size(305, 57);
            this.inputWeight.TabIndex = 4;
            this.inputWeight.Text = "Weight (Pounds)";
            this.inputWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputAge
            // 
            this.inputAge.Location = new System.Drawing.Point(196, 393);
            this.inputAge.Margin = new System.Windows.Forms.Padding(4);
            this.inputAge.Name = "inputAge";
            this.inputAge.Size = new System.Drawing.Size(305, 57);
            this.inputAge.TabIndex = 5;
            this.inputAge.Text = "Age";
            this.inputAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(231, 511);
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
            this.resultsLabel.Location = new System.Drawing.Point(218, 671);
            this.resultsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(261, 56);
            this.resultsLabel.TabIndex = 7;
            this.resultsLabel.Text = "Results Here";
            this.resultsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 50F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(767, 872);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.inputAge);
            this.Controls.Add(this.inputWeight);
            this.Controls.Add(this.inputHeight);
            this.Controls.Add(this.femaleCheckbox);
            this.Controls.Add(this.maleCheckbox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Jeremy\'s BMR Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private CheckBox maleCheckbox;
        private CheckBox femaleCheckbox;
        private TextBox inputHeight;
        private TextBox inputWeight;
        private TextBox inputAge;
        private Button enterButton;
        private Label resultsLabel;
    }
}