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
            this.discountButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.noteGridView = new System.Windows.Forms.DataGridView();
            this.noteLabel = new System.Windows.Forms.Label();
            this.finalizeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.itemGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // itemGridView
            // 
            this.itemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemGridView.Location = new System.Drawing.Point(18, 60);
            this.itemGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.itemGridView.Name = "itemGridView";
            this.itemGridView.Size = new System.Drawing.Size(241, 187);
            this.itemGridView.TabIndex = 0;
            this.itemGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.itemGridView_CellValidating);
            this.itemGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.itemGridView_DefaultValuesNeeded);
            this.itemGridView.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemGridView_RowValidated);
            // 
            // itemLabel
            // 
            this.itemLabel.AutoSize = true;
            this.itemLabel.Location = new System.Drawing.Point(14, 35);
            this.itemLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Size = new System.Drawing.Size(49, 20);
            this.itemLabel.TabIndex = 1;
            this.itemLabel.Text = "Items";
            // 
            // discountLabel
            // 
            this.discountLabel.AutoSize = true;
            this.discountLabel.Location = new System.Drawing.Point(14, 440);
            this.discountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(72, 20);
            this.discountLabel.TabIndex = 7;
            this.discountLabel.Text = "Discount";
            // 
            // discountTextBox
            // 
            this.discountTextBox.Location = new System.Drawing.Point(18, 465);
            this.discountTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.Size = new System.Drawing.Size(148, 26);
            this.discountTextBox.TabIndex = 6;
            this.discountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.discountTextBox_KeyPress);
            // 
            // discountButton
            // 
            this.discountButton.Location = new System.Drawing.Point(177, 465);
            this.discountButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.discountButton.Name = "discountButton";
            this.discountButton.Size = new System.Drawing.Size(112, 35);
            this.discountButton.TabIndex = 5;
            this.discountButton.Text = "Update";
            this.discountButton.UseVisualStyleBackColor = true;
            this.discountButton.Click += new System.EventHandler(this.discountButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(1041, 460);
            this.backButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(112, 35);
            this.backButton.TabIndex = 8;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // noteGridView
            // 
            this.noteGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.noteGridView.Location = new System.Drawing.Point(560, 60);
            this.noteGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.noteGridView.Name = "noteGridView";
            this.noteGridView.Size = new System.Drawing.Size(594, 231);
            this.noteGridView.TabIndex = 10;
            this.noteGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.noteGridView_DefaultValuesNeeded);
            this.noteGridView.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.noteGridView_RowValidated);
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.Location = new System.Drawing.Point(560, 34);
            this.noteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(51, 20);
            this.noteLabel.TabIndex = 11;
            this.noteLabel.Text = "Notes";
            // 
            // finalizeButton
            // 
            this.finalizeButton.Location = new System.Drawing.Point(423, 465);
            this.finalizeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.finalizeButton.Name = "finalizeButton";
            this.finalizeButton.Size = new System.Drawing.Size(112, 35);
            this.finalizeButton.TabIndex = 12;
            this.finalizeButton.Text = "Finalize";
            this.finalizeButton.UseVisualStyleBackColor = true;
            this.finalizeButton.Click += new System.EventHandler(this.finalizeButton_Click);
            // 
            // viewQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 515);
            this.Controls.Add(this.finalizeButton);
            this.Controls.Add(this.noteLabel);
            this.Controls.Add(this.noteGridView);
            this.Controls.Add(this.backButton);
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
        private System.Windows.Forms.Button discountButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView noteGridView;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.Button finalizeButton;
    }
}