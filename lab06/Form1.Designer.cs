namespace lab06
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
            this.firstNumberTextBox = new System.Windows.Forms.TextBox();
            this.secondNumberTextBox = new System.Windows.Forms.TextBox();
            this.sumNumberTextBox = new System.Windows.Forms.TextBox();
            this.plusButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNumberTextBox
            // 
            this.firstNumberTextBox.Location = new System.Drawing.Point(194, 104);
            this.firstNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.firstNumberTextBox.Name = "firstNumberTextBox";
            this.firstNumberTextBox.Size = new System.Drawing.Size(785, 30);
            this.firstNumberTextBox.TabIndex = 0;
            // 
            // secondNumberTextBox
            // 
            this.secondNumberTextBox.Location = new System.Drawing.Point(194, 147);
            this.secondNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.secondNumberTextBox.Name = "secondNumberTextBox";
            this.secondNumberTextBox.Size = new System.Drawing.Size(785, 30);
            this.secondNumberTextBox.TabIndex = 1;
            // 
            // sumNumberTextBox
            // 
            this.sumNumberTextBox.Location = new System.Drawing.Point(194, 386);
            this.sumNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sumNumberTextBox.Name = "sumNumberTextBox";
            this.sumNumberTextBox.Size = new System.Drawing.Size(785, 30);
            this.sumNumberTextBox.TabIndex = 2;
            // 
            // plusButton
            // 
            this.plusButton.Location = new System.Drawing.Point(523, 264);
            this.plusButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(107, 34);
            this.plusButton.TabIndex = 3;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(133, 510);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(107, 34);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(937, 510);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(107, 34);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 660);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.sumNumberTextBox);
            this.Controls.Add(this.secondNumberTextBox);
            this.Controls.Add(this.firstNumberTextBox);
            this.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Довга сума";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox firstNumberTextBox;
        private TextBox secondNumberTextBox;
        private TextBox sumNumberTextBox;
        private Button plusButton;
        private Button clearButton;
        private Button exitButton;
    }
}