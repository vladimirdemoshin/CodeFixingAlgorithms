namespace HemmingApp
{
    partial class mainForm
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
            this.inputCodeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.encryptButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.hammingCodeTextBox = new System.Windows.Forms.TextBox();
            this.brokenCodeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.findButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputCodeTextBox
            // 
            this.inputCodeTextBox.Location = new System.Drawing.Point(12, 25);
            this.inputCodeTextBox.Name = "inputCodeTextBox";
            this.inputCodeTextBox.Size = new System.Drawing.Size(470, 20);
            this.inputCodeTextBox.TabIndex = 0;
            this.inputCodeTextBox.Text = "100100101110001";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Insert information code:";
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(340, 52);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(142, 23);
            this.encryptButton.TabIndex = 2;
            this.encryptButton.Text = "Get Hamming code";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hamming code:";
            // 
            // hammingCodeTextBox
            // 
            this.hammingCodeTextBox.Location = new System.Drawing.Point(12, 103);
            this.hammingCodeTextBox.Name = "hammingCodeTextBox";
            this.hammingCodeTextBox.Size = new System.Drawing.Size(473, 20);
            this.hammingCodeTextBox.TabIndex = 4;
            // 
            // brokenCodeTextBox
            // 
            this.brokenCodeTextBox.Location = new System.Drawing.Point(12, 187);
            this.brokenCodeTextBox.Name = "brokenCodeTextBox";
            this.brokenCodeTextBox.Size = new System.Drawing.Size(470, 20);
            this.brokenCodeTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Insert Hamming code to find a mistake:";
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(340, 213);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(142, 23);
            this.findButton.TabIndex = 7;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 245);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.brokenCodeTextBox);
            this.Controls.Add(this.hammingCodeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputCodeTextBox);
            this.Name = "mainForm";
            this.Text = "Hamming codes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputCodeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox hammingCodeTextBox;
        private System.Windows.Forms.TextBox brokenCodeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button findButton;
    }
}

