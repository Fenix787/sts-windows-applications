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
            this.SuspendLayout();
            // 
            // quoteList
            // 
            this.quoteList.FormattingEnabled = true;
            this.quoteList.Location = new System.Drawing.Point(152, 28);
            this.quoteList.Name = "quoteList";
            this.quoteList.Size = new System.Drawing.Size(120, 173);
            this.quoteList.TabIndex = 0;
            // 
            // customerList
            // 
            this.customerList.FormattingEnabled = true;
            this.customerList.Location = new System.Drawing.Point(12, 28);
            this.customerList.Name = "customerList";
            this.customerList.Size = new System.Drawing.Size(120, 173);
            this.customerList.TabIndex = 2;
            this.customerList.SelectedValueChanged += new System.EventHandler(this.customerList_SelectedValueChanged);
            // 
            // quoteListLabel
            // 
            this.quoteListLabel.AutoSize = true;
            this.quoteListLabel.Location = new System.Drawing.Point(152, 13);
            this.quoteListLabel.Name = "quoteListLabel";
            this.quoteListLabel.Size = new System.Drawing.Size(76, 13);
            this.quoteListLabel.TabIndex = 3;
            this.quoteListLabel.Text = "Select a quote";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(9, 12);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(98, 13);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Select a Sales Rep";
            // 
            // selectQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.quoteListLabel);
            this.Controls.Add(this.customerList);
            this.Controls.Add(this.quoteList);
            this.Name = "selectQuote";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox quoteList;
        private System.Windows.Forms.ListBox customerList;
        private System.Windows.Forms.Label quoteListLabel;
        private System.Windows.Forms.Label titleLabel;
    }
}

