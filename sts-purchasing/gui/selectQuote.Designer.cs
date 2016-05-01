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
            this.SuspendLayout();
            // 
            // quoteList
            // 
            this.quoteList.FormattingEnabled = true;
            this.quoteList.Location = new System.Drawing.Point(45, 39);
            this.quoteList.Name = "quoteList";
            this.quoteList.Size = new System.Drawing.Size(296, 160);
            this.quoteList.TabIndex = 0;
            // 
            // discountButton
            // 
            this.discountButton.Location = new System.Drawing.Point(45, 226);
            this.discountButton.Name = "discountButton";
            this.discountButton.Size = new System.Drawing.Size(75, 23);
            this.discountButton.TabIndex = 1;
            this.discountButton.Text = "Discount";
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
            // selectQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 274);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.discountButton);
            this.Controls.Add(this.quoteList);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "selectQuote";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox quoteList;
        private System.Windows.Forms.Button discountButton;
        private System.Windows.Forms.Button convertButton;
    }
}

