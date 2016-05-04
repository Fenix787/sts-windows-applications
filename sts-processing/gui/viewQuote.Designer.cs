namespace sts_processing
{
    partial class viewQuote
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
            this.itemGridView = new System.Windows.Forms.DataGridView();
            this.itemLabel = new System.Windows.Forms.Label();
            this.discountLabel = new System.Windows.Forms.Label();
            this.discountTextBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.noteGridView = new System.Windows.Forms.DataGridView();
            this.noteLabel = new System.Windows.Forms.Label();
            this.finalizeButton = new System.Windows.Forms.Button();
            this.totalTitleLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.discountButton = new System.Windows.Forms.Button();
            this.emailAddressTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.itemGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // itemGridView
            // 
            this.itemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemGridView.Location = new System.Drawing.Point(18, 38);
            this.itemGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.itemGridView.Name = "itemGridView";
            this.itemGridView.Size = new System.Drawing.Size(518, 322);
            this.itemGridView.TabIndex = 0;
            this.itemGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.itemGridView_CellValidating);
            this.itemGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.itemGridView_DefaultValuesNeeded);
            this.itemGridView.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemGridView_RowValidated);
            // 
            // itemLabel
            // 
            this.itemLabel.AutoSize = true;
            this.itemLabel.Location = new System.Drawing.Point(14, 14);
            this.itemLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Size = new System.Drawing.Size(49, 20);
            this.itemLabel.TabIndex = 1;
            this.itemLabel.Text = "Items";
            // 
            // discountLabel
            // 
            this.discountLabel.AutoSize = true;
            this.discountLabel.Location = new System.Drawing.Point(14, 365);
            this.discountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(72, 20);
            this.discountLabel.TabIndex = 7;
            this.discountLabel.Text = "Discount";
            // 
            // discountTextBox
            // 
            this.discountTextBox.Location = new System.Drawing.Point(18, 389);
            this.discountTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.Size = new System.Drawing.Size(148, 26);
            this.discountTextBox.TabIndex = 6;
            this.discountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.discountTextBox_KeyPress);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(760, 411);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(112, 35);
            this.closeButton.TabIndex = 8;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // noteGridView
            // 
            this.noteGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.noteGridView.Location = new System.Drawing.Point(560, 38);
            this.noteGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.noteGridView.Name = "noteGridView";
            this.noteGridView.Size = new System.Drawing.Size(495, 322);
            this.noteGridView.TabIndex = 10;
            this.noteGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.noteGridView_DefaultValuesNeeded);
            this.noteGridView.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.noteGridView_RowValidated);
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.Location = new System.Drawing.Point(555, 14);
            this.noteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(51, 20);
            this.noteLabel.TabIndex = 11;
            this.noteLabel.Text = "Notes";
            // 
            // finalizeButton
            // 
            this.finalizeButton.Location = new System.Drawing.Point(902, 411);
            this.finalizeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.finalizeButton.Name = "finalizeButton";
            this.finalizeButton.Size = new System.Drawing.Size(112, 35);
            this.finalizeButton.TabIndex = 12;
            this.finalizeButton.Text = "Finalize";
            this.finalizeButton.UseVisualStyleBackColor = true;
            this.finalizeButton.Click += new System.EventHandler(this.finalizeButton_Click);
            // 
            // totalTitleLabel
            // 
            this.totalTitleLabel.AutoSize = true;
            this.totalTitleLabel.Location = new System.Drawing.Point(281, 389);
            this.totalTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalTitleLabel.Name = "totalTitleLabel";
            this.totalTitleLabel.Size = new System.Drawing.Size(44, 20);
            this.totalTitleLabel.TabIndex = 13;
            this.totalTitleLabel.Text = "Total";
            // 
            // totalLabel
            // 
            this.totalLabel.Location = new System.Drawing.Point(326, 389);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(209, 25);
            this.totalLabel.TabIndex = 14;
            this.totalLabel.Text = "totalLabel";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // discountButton
            // 
            this.discountButton.Location = new System.Drawing.Point(619, 411);
            this.discountButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.discountButton.Name = "discountButton";
            this.discountButton.Size = new System.Drawing.Size(112, 35);
            this.discountButton.TabIndex = 5;
            this.discountButton.Text = "Update";
            this.discountButton.UseVisualStyleBackColor = true;
            this.discountButton.Click += new System.EventHandler(this.discountButton_Click);
            // 
            // emailAddressTextBox
            // 
            this.emailAddressTextBox.Location = new System.Drawing.Point(18, 452);
            this.emailAddressTextBox.Name = "emailAddressTextBox";
            this.emailAddressTextBox.Size = new System.Drawing.Size(264, 26);
            this.emailAddressTextBox.TabIndex = 15;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(14, 426);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(111, 20);
            this.emailLabel.TabIndex = 16;
            this.emailLabel.Text = "Email Address";
            // 
            // viewQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 490);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.emailAddressTextBox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.totalTitleLabel);
            this.Controls.Add(this.finalizeButton);
            this.Controls.Add(this.noteLabel);
            this.Controls.Add(this.noteGridView);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.discountLabel);
            this.Controls.Add(this.discountTextBox);
            this.Controls.Add(this.discountButton);
            this.Controls.Add(this.itemLabel);
            this.Controls.Add(this.itemGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "viewQuote";
            this.Text = "viewQuote";
            ((System.ComponentModel.ISupportInitialize)(this.itemGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView itemGridView;
        private System.Windows.Forms.Label itemLabel;
        private System.Windows.Forms.Label discountLabel;
        private System.Windows.Forms.TextBox discountTextBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.DataGridView noteGridView;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.Button finalizeButton;
        private System.Windows.Forms.Label totalTitleLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button discountButton;
        private System.Windows.Forms.TextBox emailAddressTextBox;
        private System.Windows.Forms.Label emailLabel;
    }
}