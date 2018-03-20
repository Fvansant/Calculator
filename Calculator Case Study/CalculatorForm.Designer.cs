namespace Calculator_Case_Study
{
    partial class CalculatorLayout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorLayout));
            this.entryAnswerTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.backspaceButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.decimalButton = new System.Windows.Forms.Button();
            this.equalsButton = new System.Windows.Forms.Button();
            this.clearEverthingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // entryAnswerTextBox
            // 
            this.entryAnswerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.entryAnswerTextBox.Location = new System.Drawing.Point(13, 24);
            this.entryAnswerTextBox.Multiline = true;
            this.entryAnswerTextBox.Name = "entryAnswerTextBox";
            this.entryAnswerTextBox.ReadOnly = true;
            this.entryAnswerTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.entryAnswerTextBox.Size = new System.Drawing.Size(337, 38);
            this.entryAnswerTextBox.TabIndex = 0;
            this.entryAnswerTextBox.Enter += new System.EventHandler(this.clearButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.clearButton.Location = new System.Drawing.Point(95, 68);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(80, 80);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "C";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // backspaceButton
            // 
            this.backspaceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.backspaceButton.Location = new System.Drawing.Point(181, 68);
            this.backspaceButton.Name = "backspaceButton";
            this.backspaceButton.Size = new System.Drawing.Size(80, 80);
            this.backspaceButton.TabIndex = 7;
            this.backspaceButton.Text = "<=";
            this.backspaceButton.UseVisualStyleBackColor = true;
            this.backspaceButton.Click += new System.EventHandler(this.backspaceButton_Click);
            // 
            // divideButton
            // 
            this.divideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.divideButton.Location = new System.Drawing.Point(267, 68);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(80, 80);
            this.divideButton.TabIndex = 8;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
            // 
            // sevenButton
            // 
            this.sevenButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sevenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.sevenButton.Location = new System.Drawing.Point(10, 154);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(80, 80);
            this.sevenButton.TabIndex = 9;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = false;
            this.sevenButton.Click += new System.EventHandler(this.sevenButton_Click);
            // 
            // eightButton
            // 
            this.eightButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.eightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.eightButton.Location = new System.Drawing.Point(96, 154);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(80, 80);
            this.eightButton.TabIndex = 10;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = false;
            this.eightButton.Click += new System.EventHandler(this.eightButton_Click);
            // 
            // nineButton
            // 
            this.nineButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.nineButton.Location = new System.Drawing.Point(181, 154);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(80, 80);
            this.nineButton.TabIndex = 11;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = false;
            this.nineButton.Click += new System.EventHandler(this.nineButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.multiplyButton.Location = new System.Drawing.Point(267, 154);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(80, 80);
            this.multiplyButton.TabIndex = 12;
            this.multiplyButton.Text = "*";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // fourButton
            // 
            this.fourButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.fourButton.Location = new System.Drawing.Point(9, 240);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(80, 80);
            this.fourButton.TabIndex = 13;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = false;
            this.fourButton.Click += new System.EventHandler(this.fourButton_Click);
            // 
            // fiveButton
            // 
            this.fiveButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.fiveButton.Location = new System.Drawing.Point(95, 240);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(80, 80);
            this.fiveButton.TabIndex = 14;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = false;
            this.fiveButton.Click += new System.EventHandler(this.fiveButton_Click);
            // 
            // sixButton
            // 
            this.sixButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.sixButton.Location = new System.Drawing.Point(181, 240);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(80, 80);
            this.sixButton.TabIndex = 15;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = false;
            this.sixButton.Click += new System.EventHandler(this.sixButton_Click);
            // 
            // subtractButton
            // 
            this.subtractButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.subtractButton.Location = new System.Drawing.Point(267, 240);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(80, 80);
            this.subtractButton.TabIndex = 16;
            this.subtractButton.Text = "-";
            this.subtractButton.UseVisualStyleBackColor = true;
            this.subtractButton.Click += new System.EventHandler(this.subtractButton_Click);
            // 
            // oneButton
            // 
            this.oneButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.oneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.oneButton.Location = new System.Drawing.Point(10, 326);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(80, 80);
            this.oneButton.TabIndex = 17;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = false;
            this.oneButton.Click += new System.EventHandler(this.oneButton_Click);
            // 
            // twoButton
            // 
            this.twoButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.twoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.twoButton.Location = new System.Drawing.Point(93, 326);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(80, 80);
            this.twoButton.TabIndex = 18;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = false;
            this.twoButton.Click += new System.EventHandler(this.twoButton_Click);
            // 
            // threeButton
            // 
            this.threeButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.threeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.threeButton.Location = new System.Drawing.Point(179, 326);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(80, 80);
            this.threeButton.TabIndex = 19;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = false;
            this.threeButton.Click += new System.EventHandler(this.threeButton_Click);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.addButton.Location = new System.Drawing.Point(265, 326);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(80, 80);
            this.addButton.TabIndex = 20;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // zeroButton
            // 
            this.zeroButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.zeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.zeroButton.Location = new System.Drawing.Point(10, 412);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(80, 80);
            this.zeroButton.TabIndex = 21;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = false;
            this.zeroButton.Click += new System.EventHandler(this.zeroButton_Click);
            // 
            // decimalButton
            // 
            this.decimalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.decimalButton.Location = new System.Drawing.Point(96, 412);
            this.decimalButton.Name = "decimalButton";
            this.decimalButton.Size = new System.Drawing.Size(80, 80);
            this.decimalButton.TabIndex = 22;
            this.decimalButton.Text = ".";
            this.decimalButton.UseVisualStyleBackColor = true;
            this.decimalButton.Click += new System.EventHandler(this.decimalButton_Click);
            // 
            // equalsButton
            // 
            this.equalsButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.equalsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.equalsButton.Location = new System.Drawing.Point(179, 412);
            this.equalsButton.Name = "equalsButton";
            this.equalsButton.Size = new System.Drawing.Size(166, 80);
            this.equalsButton.TabIndex = 23;
            this.equalsButton.Text = "=";
            this.equalsButton.UseVisualStyleBackColor = false;
            this.equalsButton.Click += new System.EventHandler(this.equalsButton_Click);
            // 
            // clearEverthingButton
            // 
            this.clearEverthingButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.clearEverthingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.clearEverthingButton.Location = new System.Drawing.Point(10, 68);
            this.clearEverthingButton.Name = "clearEverthingButton";
            this.clearEverthingButton.Size = new System.Drawing.Size(80, 80);
            this.clearEverthingButton.TabIndex = 5;
            this.clearEverthingButton.Text = "CE";
            this.clearEverthingButton.UseVisualStyleBackColor = false;
            this.clearEverthingButton.Click += new System.EventHandler(this.clearEverthingButton_Click);
            // 
            // CalculatorLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(360, 504);
            this.Controls.Add(this.equalsButton);
            this.Controls.Add(this.decimalButton);
            this.Controls.Add(this.zeroButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.threeButton);
            this.Controls.Add(this.twoButton);
            this.Controls.Add(this.oneButton);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.sixButton);
            this.Controls.Add(this.fiveButton);
            this.Controls.Add(this.fourButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.nineButton);
            this.Controls.Add(this.eightButton);
            this.Controls.Add(this.sevenButton);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.backspaceButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.clearEverthingButton);
            this.Controls.Add(this.entryAnswerTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CalculatorLayout";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox entryAnswerTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button backspaceButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button decimalButton;
        private System.Windows.Forms.Button equalsButton;
        private System.Windows.Forms.Button clearEverthingButton;
    }
}

