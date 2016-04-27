namespace sts_maintain_salesrep
{
    partial class selectSalesRep
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
            this.salesRepList = new System.Windows.Forms.ListBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(102, 226);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(75, 23);
            this.selectButton.TabIndex = 0;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // salesRepList
            // 
            this.salesRepList.FormattingEnabled = true;
            this.salesRepList.Location = new System.Drawing.Point(79, 25);
            this.salesRepList.Name = "salesRepList";
            this.salesRepList.Size = new System.Drawing.Size(120, 173);
            this.salesRepList.TabIndex = 1;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(90, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(98, 13);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Select a Sales Rep";
            // 
            // selectSalesRep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.salesRepList);
            this.Controls.Add(this.selectButton);
            this.Name = "selectSalesRep";
            this.Text = "Modify Sales Rep";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.ListBox salesRepList;
        private System.Windows.Forms.Label titleLabel;
    }
}

