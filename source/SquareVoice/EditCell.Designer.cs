namespace SquareVoice
{
    partial class EditCell
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
            this.ImagePreviewPictureBox = new System.Windows.Forms.PictureBox();
            this.PickImageButton = new System.Windows.Forms.Button();
            this.ClearImageButton = new System.Windows.Forms.Button();
            this.CancelBttn = new System.Windows.Forms.Button();
            this.OkayButton = new System.Windows.Forms.Button();
            this.CaptionTextBox = new System.Windows.Forms.TextBox();
            this.CaptionLabel = new System.Windows.Forms.Label();
            this.ActionsLabel = new System.Windows.Forms.Label();
            this.AddActionButton = new System.Windows.Forms.Button();
            this.EditActionButton = new System.Windows.Forms.Button();
            this.DeleteActionButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ActionListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePreviewPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImagePreviewPictureBox
            // 
            this.ImagePreviewPictureBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ImagePreviewPictureBox.Location = new System.Drawing.Point(3, 3);
            this.ImagePreviewPictureBox.Name = "ImagePreviewPictureBox";
            this.ImagePreviewPictureBox.Size = new System.Drawing.Size(272, 234);
            this.ImagePreviewPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagePreviewPictureBox.TabIndex = 0;
            this.ImagePreviewPictureBox.TabStop = false;
            // 
            // PickImageButton
            // 
            this.PickImageButton.Location = new System.Drawing.Point(215, 267);
            this.PickImageButton.Name = "PickImageButton";
            this.PickImageButton.Size = new System.Drawing.Size(75, 23);
            this.PickImageButton.TabIndex = 1;
            this.PickImageButton.Text = "Pick Image";
            this.PickImageButton.UseVisualStyleBackColor = true;
            this.PickImageButton.Click += new System.EventHandler(this.PickImageButton_Click);
            // 
            // ClearImageButton
            // 
            this.ClearImageButton.Location = new System.Drawing.Point(12, 267);
            this.ClearImageButton.Name = "ClearImageButton";
            this.ClearImageButton.Size = new System.Drawing.Size(75, 23);
            this.ClearImageButton.TabIndex = 2;
            this.ClearImageButton.Text = "Clear Image";
            this.ClearImageButton.UseVisualStyleBackColor = true;
            this.ClearImageButton.Click += new System.EventHandler(this.ClearImageButton_Click);
            // 
            // CancelBttn
            // 
            this.CancelBttn.Location = new System.Drawing.Point(479, 309);
            this.CancelBttn.Name = "CancelBttn";
            this.CancelBttn.Size = new System.Drawing.Size(75, 23);
            this.CancelBttn.TabIndex = 3;
            this.CancelBttn.Text = "Cancel";
            this.CancelBttn.UseVisualStyleBackColor = true;
            this.CancelBttn.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkayButton
            // 
            this.OkayButton.Location = new System.Drawing.Point(398, 309);
            this.OkayButton.Name = "OkayButton";
            this.OkayButton.Size = new System.Drawing.Size(75, 23);
            this.OkayButton.TabIndex = 4;
            this.OkayButton.Text = "Okay";
            this.OkayButton.UseVisualStyleBackColor = true;
            this.OkayButton.Click += new System.EventHandler(this.OkayButton_Click);
            // 
            // CaptionTextBox
            // 
            this.CaptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionTextBox.Location = new System.Drawing.Point(97, 306);
            this.CaptionTextBox.Name = "CaptionTextBox";
            this.CaptionTextBox.Size = new System.Drawing.Size(193, 29);
            this.CaptionTextBox.TabIndex = 5;
            // 
            // CaptionLabel
            // 
            this.CaptionLabel.AutoSize = true;
            this.CaptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionLabel.Location = new System.Drawing.Point(12, 311);
            this.CaptionLabel.Name = "CaptionLabel";
            this.CaptionLabel.Size = new System.Drawing.Size(79, 24);
            this.CaptionLabel.TabIndex = 6;
            this.CaptionLabel.Text = "Caption:";
            // 
            // ActionsLabel
            // 
            this.ActionsLabel.AutoSize = true;
            this.ActionsLabel.Location = new System.Drawing.Point(314, 19);
            this.ActionsLabel.Name = "ActionsLabel";
            this.ActionsLabel.Size = new System.Drawing.Size(42, 13);
            this.ActionsLabel.TabIndex = 8;
            this.ActionsLabel.Text = "Actions";
            // 
            // AddActionButton
            // 
            this.AddActionButton.Location = new System.Drawing.Point(479, 210);
            this.AddActionButton.Name = "AddActionButton";
            this.AddActionButton.Size = new System.Drawing.Size(75, 23);
            this.AddActionButton.TabIndex = 10;
            this.AddActionButton.Text = "Add";
            this.AddActionButton.UseVisualStyleBackColor = true;
            this.AddActionButton.Click += new System.EventHandler(this.AddActionButton_Click);
            // 
            // EditActionButton
            // 
            this.EditActionButton.Enabled = false;
            this.EditActionButton.Location = new System.Drawing.Point(398, 210);
            this.EditActionButton.Name = "EditActionButton";
            this.EditActionButton.Size = new System.Drawing.Size(75, 23);
            this.EditActionButton.TabIndex = 11;
            this.EditActionButton.Text = "Edit";
            this.EditActionButton.UseVisualStyleBackColor = true;
            this.EditActionButton.Click += new System.EventHandler(this.EditActionButton_Click);
            // 
            // DeleteActionButton
            // 
            this.DeleteActionButton.Enabled = false;
            this.DeleteActionButton.Location = new System.Drawing.Point(317, 210);
            this.DeleteActionButton.Name = "DeleteActionButton";
            this.DeleteActionButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteActionButton.TabIndex = 12;
            this.DeleteActionButton.Text = "Delete";
            this.DeleteActionButton.UseVisualStyleBackColor = true;
            this.DeleteActionButton.Click += new System.EventHandler(this.DeleteActionButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ImagePreviewPictureBox);
            this.panel1.Location = new System.Drawing.Point(12, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 240);
            this.panel1.TabIndex = 13;
            // 
            // ActionListBox
            // 
            this.ActionListBox.FormattingEnabled = true;
            this.ActionListBox.Location = new System.Drawing.Point(317, 36);
            this.ActionListBox.Name = "ActionListBox";
            this.ActionListBox.Size = new System.Drawing.Size(237, 160);
            this.ActionListBox.TabIndex = 14;
            this.ActionListBox.SelectedIndexChanged += new System.EventHandler(this.ActionListBox_SelectedIndexChanged);
            // 
            // EditCell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 344);
            this.Controls.Add(this.ActionListBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DeleteActionButton);
            this.Controls.Add(this.EditActionButton);
            this.Controls.Add(this.AddActionButton);
            this.Controls.Add(this.ActionsLabel);
            this.Controls.Add(this.CaptionLabel);
            this.Controls.Add(this.CaptionTextBox);
            this.Controls.Add(this.OkayButton);
            this.Controls.Add(this.CancelBttn);
            this.Controls.Add(this.ClearImageButton);
            this.Controls.Add(this.PickImageButton);
            this.Name = "EditCell";
            this.Text = "Edit Cell";
            ((System.ComponentModel.ISupportInitialize)(this.ImagePreviewPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImagePreviewPictureBox;
        private System.Windows.Forms.Button PickImageButton;
        private System.Windows.Forms.Button ClearImageButton;
        private System.Windows.Forms.Button CancelBttn;
        private System.Windows.Forms.Button OkayButton;
        private System.Windows.Forms.TextBox CaptionTextBox;
        private System.Windows.Forms.Label CaptionLabel;
        private System.Windows.Forms.Label ActionsLabel;
        private System.Windows.Forms.Button AddActionButton;
        private System.Windows.Forms.Button EditActionButton;
        private System.Windows.Forms.Button DeleteActionButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox ActionListBox;
    }
}