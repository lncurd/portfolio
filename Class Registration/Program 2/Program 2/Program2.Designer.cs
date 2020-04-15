namespace Program_2
{
    partial class Program2
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
            this.initialTextBox = new System.Windows.Forms.TextBox();
            this.creditTextBox = new System.Windows.Forms.TextBox();
            this.intialLabel = new System.Windows.Forms.Label();
            this.creditLabel = new System.Windows.Forms.Label();
            this.enterButton = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // initialTextBox
            // 
            this.initialTextBox.Location = new System.Drawing.Point(163, 59);
            this.initialTextBox.Name = "initialTextBox";
            this.initialTextBox.Size = new System.Drawing.Size(89, 20);
            this.initialTextBox.TabIndex = 0;
            // 
            // creditTextBox
            // 
            this.creditTextBox.Location = new System.Drawing.Point(163, 92);
            this.creditTextBox.Name = "creditTextBox";
            this.creditTextBox.Size = new System.Drawing.Size(89, 20);
            this.creditTextBox.TabIndex = 1;
            // 
            // intialLabel
            // 
            this.intialLabel.AutoSize = true;
            this.intialLabel.Location = new System.Drawing.Point(22, 62);
            this.intialLabel.Name = "intialLabel";
            this.intialLabel.Size = new System.Drawing.Size(135, 13);
            this.intialLabel.TabIndex = 2;
            this.intialLabel.Text = "Enter first intial of last name";
            // 
            // creditLabel
            // 
            this.creditLabel.AutoSize = true;
            this.creditLabel.Location = new System.Drawing.Point(67, 99);
            this.creditLabel.Name = "creditLabel";
            this.creditLabel.Size = new System.Drawing.Size(90, 13);
            this.creditLabel.TabIndex = 3;
            this.creditLabel.Text = "Enter credit hours";
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(107, 131);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 4;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateLabel.Location = new System.Drawing.Point(37, 182);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(100, 23);
            this.dateLabel.TabIndex = 5;
            // 
            // timeLabel
            // 
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLabel.Location = new System.Drawing.Point(152, 182);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(100, 23);
            this.timeLabel.TabIndex = 6;
            // 
            // Program2
            // 
            this.AcceptButton = this.enterButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 207);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.creditLabel);
            this.Controls.Add(this.intialLabel);
            this.Controls.Add(this.creditTextBox);
            this.Controls.Add(this.initialTextBox);
            this.Name = "Program2";
            this.Text = "Program 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox initialTextBox;
        private System.Windows.Forms.TextBox creditTextBox;
        private System.Windows.Forms.Label intialLabel;
        private System.Windows.Forms.Label creditLabel;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label timeLabel;
    }
}

