namespace sts_purchasing
{
    partial class selectQuote
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
            this.quoteList = new System.Windows.Forms.ListBox();
            this.discountButton = new System.Windows.Forms.Button();
            this.convertButton = new System.Windows.Forms.Button();
            this.discountTextBox = new System.Windows.Forms.TextBox();
            this.discountLabel = new System.Windows.Forms.Label();
            this.convertLabel = new System.Windows.Forms.Label();
            this.quoteListLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // quoteList
            // 
            this.quoteList.FormattingEnabled = true;
            this.quoteList.Location = new System.Drawing.Point(45, 39);
            this.quoteList.Name = "quoteList";
            this.quoteList.Size = new System.Drawing.Size(296, 160);
            this.quoteList.TabIndex = 0;
            this.quoteList.SelectedIndexChanged += new System.EventHandler(this.quoteList_SelectedIndexChanged);
            // 
            // discountButton
            // 
            this.discountButton.Location = new System.Drawing.Point(151, 226);
            this.discountButton.Name = "discountButton";
            this.discountButton.Size = new System.Drawing.Size(75, 23);
            this.discountButton.TabIndex = 1;
            this.discountButton.Text = "Update";
            this.discountButton.UseVisualStyleBackColor = true;
            this.discountButton.Click += new System.EventHandler(this.discountButton_Click);
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(266, 226);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 2;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // discountTextBox
            // 
            this.discountTextBox.Location = new System.Drawing.Point(45, 226);
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.Size = new System.Drawing.Size(100, 20);
            this.discountTextBox.TabIndex = 3;
            this.discountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.discountTextBox_KeyPress);
            // 
            // discountLabel
            // 
            this.discountLabel.AutoSize = true;
            this.discountLabel.Location = new System.Drawing.Point(45, 206);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(49, 13);
            this.discountLabel.TabIndex = 4;
            this.discountLabel.Text = "Discount";
            // 
            // convertLabel
            // 
            this.convertLabel.AutoSize = true;
            this.convertLabel.Location = new System.Drawing.Point(263, 206);
            this.convertLabel.Name = "convertLabel";
            this.convertLabel.Size = new System.Drawing.Size(81, 13);
            this.convertLabel.TabIndex = 5;
            this.convertLabel.Text = "Purchase Order";
            // 
            // quoteListLabel
            // 
            this.quoteListLabel.AutoSize = true;
            this.quoteListLabel.Location = new System.Drawing.Point(45, 20);
            this.quoteListLabel.Name = "quoteListLabel";
            this.quoteListLabel.Size = new System.Drawing.Size(138, 13);
            this.quoteListLabel.TabIndex = 6;
            this.quoteListLabel.Text = "Quotes awaiting conversion";
            // 
            // selectQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 274);
            this.Controls.Add(this.quoteListLabel);
            this.Controls.Add(this.convertLabel);
            this.Controls.Add(this.discountLabel);
            this.Controls.Add(this.discountTextBox);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.discountButton);
            this.Controls.Add(this.quoteList);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "selectQuote";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox quoteList;
        private System.Windows.Forms.Button discountButton;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.TextBox discountTextBox;
        private System.Windows.Forms.Label discountLabel;
        private System.Windows.Forms.Label convertLabel;
        private System.Windows.Forms.Label quoteListLabel;
    }
}

