namespace sts_processing
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
            this.selectButton = new System.Windows.Forms.Button();
            this.quoteListLabel = new System.Windows.Forms.Label();
            this.quoteList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(117, 195);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(75, 23);
            this.selectButton.TabIndex = 5;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // quoteListLabel
            // 
            this.quoteListLabel.AutoSize = true;
            this.quoteListLabel.Location = new System.Drawing.Point(12, 10);
            this.quoteListLabel.Name = "quoteListLabel";
            this.quoteListLabel.Size = new System.Drawing.Size(69, 13);
            this.quoteListLabel.TabIndex = 8;
            this.quoteListLabel.Text = "Select Quote";
            // 
            // quoteList
            // 
            this.quoteList.FormattingEnabled = true;
            this.quoteList.Location = new System.Drawing.Point(12, 29);
            this.quoteList.Name = "quoteList";
            this.quoteList.Size = new System.Drawing.Size(296, 160);
            this.quoteList.TabIndex = 7;
            // 
            // selectQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 225);
            this.Controls.Add(this.quoteListLabel);
            this.Controls.Add(this.quoteList);
            this.Controls.Add(this.selectButton);
            this.Name = "selectQuote";
            this.Text = "Processing Dept.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Label quoteListLabel;
        private System.Windows.Forms.ListBox quoteList;
    }
}

