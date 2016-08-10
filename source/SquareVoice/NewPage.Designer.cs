namespace SquareVoice
{
    partial class NewPage
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
            this.CancelBttn = new System.Windows.Forms.Button();
            this.OkayButton = new System.Windows.Forms.Button();
            this.PageNameLabel = new System.Windows.Forms.Label();
            this.PageNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelBttn.Location = new System.Drawing.Point(328, 62);
            this.CancelBttn.Name = "CancelButton";
            this.CancelBttn.Size = new System.Drawing.Size(75, 23);
            this.CancelBttn.TabIndex = 0;
            this.CancelBttn.Text = "Cancel";
            this.CancelBttn.UseVisualStyleBackColor = true;
            this.CancelBttn.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkayButton
            // 
            this.OkayButton.Location = new System.Drawing.Point(247, 62);
            this.OkayButton.Name = "OkayButton";
            this.OkayButton.Size = new System.Drawing.Size(75, 23);
            this.OkayButton.TabIndex = 1;
            this.OkayButton.Text = "Okay";
            this.OkayButton.UseVisualStyleBackColor = true;
            this.OkayButton.Click += new System.EventHandler(this.OkayButton_Click);
            // 
            // PageNameLabel
            // 
            this.PageNameLabel.AutoSize = true;
            this.PageNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageNameLabel.Location = new System.Drawing.Point(12, 9);
            this.PageNameLabel.Name = "PageNameLabel";
            this.PageNameLabel.Size = new System.Drawing.Size(115, 24);
            this.PageNameLabel.TabIndex = 2;
            this.PageNameLabel.Text = "Page Name:";
            // 
            // PageNameTextBox
            // 
            this.PageNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageNameTextBox.Location = new System.Drawing.Point(133, 9);
            this.PageNameTextBox.Name = "PageNameTextBox";
            this.PageNameTextBox.Size = new System.Drawing.Size(270, 29);
            this.PageNameTextBox.TabIndex = 3;
            // 
            // NewPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 97);
            this.Controls.Add(this.PageNameTextBox);
            this.Controls.Add(this.PageNameLabel);
            this.Controls.Add(this.OkayButton);
            this.Controls.Add(this.CancelBttn);
            this.Name = "NewPage";
            this.Text = "New Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelBttn;
        private System.Windows.Forms.Button OkayButton;
        private System.Windows.Forms.Label PageNameLabel;
        private System.Windows.Forms.TextBox PageNameTextBox;
    }
}