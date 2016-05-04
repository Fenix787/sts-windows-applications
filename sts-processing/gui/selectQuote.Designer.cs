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
            this.quoteList = new System.Windows.Forms.ListBox();
            this.customerList = new System.Windows.Forms.ListBox();
            this.quoteListLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.selectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // quoteList
            // 
            this.quoteList.FormattingEnabled = true;
            this.quoteList.ItemHeight = 20;
            this.quoteList.Location = new System.Drawing.Point(228, 43);
            this.quoteList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.quoteList.Name = "quoteList";
            this.quoteList.Size = new System.Drawing.Size(178, 264);
            this.quoteList.TabIndex = 0;
            // 
            // customerList
            // 
            this.customerList.FormattingEnabled = true;
            this.customerList.ItemHeight = 20;
            this.customerList.Location = new System.Drawing.Point(18, 43);
            this.customerList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.customerList.Name = "customerList";
            this.customerList.Size = new System.Drawing.Size(178, 264);
            this.customerList.TabIndex = 2;
            this.customerList.SelectedValueChanged += new System.EventHandler(this.customerList_SelectedValueChanged);
            // 
            // quoteListLabel
            // 
            this.quoteListLabel.AutoSize = true;
            this.quoteListLabel.Location = new System.Drawing.Point(228, 20);
            this.quoteListLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quoteListLabel.Name = "quoteListLabel";
            this.quoteListLabel.Size = new System.Drawing.Size(112, 20);
            this.quoteListLabel.TabIndex = 3;
            this.quoteListLabel.Text = "Select a quote";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(14, 18);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(140, 20);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Select a Customer";
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(153, 348);
            this.selectButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(112, 35);
            this.selectButton.TabIndex = 5;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // selectQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 402);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.quoteListLabel);
            this.Controls.Add(this.customerList);
            this.Controls.Add(this.quoteList);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "selectQuote";
            this.Text = "Processing Dept.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox quoteList;
        private System.Windows.Forms.ListBox customerList;
        private System.Windows.Forms.Label quoteListLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button selectButton;
    }
}

