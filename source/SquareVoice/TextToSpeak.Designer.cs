namespace SquareVoice
{
    partial class TextToSpeak
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
            this.CaptionLabel = new System.Windows.Forms.Label();
            this.TextToSpeakTextBox = new System.Windows.Forms.TextBox();
            this.OkayButton = new System.Windows.Forms.Button();
            this.CancelBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CaptionLabel
            // 
            this.CaptionLabel.AutoSize = true;
            this.CaptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionLabel.Location = new System.Drawing.Point(12, 15);
            this.CaptionLabel.Name = "CaptionLabel";
            this.CaptionLabel.Size = new System.Drawing.Size(130, 24);
            this.CaptionLabel.TabIndex = 8;
            this.CaptionLabel.Text = "Text to Speak:";
            // 
            // TextToSpeakTextBox
            // 
            this.TextToSpeakTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextToSpeakTextBox.Location = new System.Drawing.Point(21, 42);
            this.TextToSpeakTextBox.Multiline = true;
            this.TextToSpeakTextBox.Name = "TextToSpeakTextBox";
            this.TextToSpeakTextBox.Size = new System.Drawing.Size(374, 183);
            this.TextToSpeakTextBox.TabIndex = 7;
            // 
            // OkayButton
            // 
            this.OkayButton.Location = new System.Drawing.Point(239, 244);
            this.OkayButton.Name = "OkayButton";
            this.OkayButton.Size = new System.Drawing.Size(75, 23);
            this.OkayButton.TabIndex = 10;
            this.OkayButton.Text = "Okay";
            this.OkayButton.UseVisualStyleBackColor = true;
            this.OkayButton.Click += new System.EventHandler(this.OkayButton_Click);
            // 
            // CancelBttn
            // 
            this.CancelBttn.Location = new System.Drawing.Point(320, 244);
            this.CancelBttn.Name = "CancelBttn";
            this.CancelBttn.Size = new System.Drawing.Size(75, 23);
            this.CancelBttn.TabIndex = 9;
            this.CancelBttn.Text = "Cancel";
            this.CancelBttn.UseVisualStyleBackColor = true;
            this.CancelBttn.Click += new System.EventHandler(this.CancelBttn_Click);
            // 
            // TextToSpeak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 279);
            this.Controls.Add(this.OkayButton);
            this.Controls.Add(this.CancelBttn);
            this.Controls.Add(this.CaptionLabel);
            this.Controls.Add(this.TextToSpeakTextBox);
            this.Name = "TextToSpeak";
            this.Text = "Text to Speak";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CaptionLabel;
        private System.Windows.Forms.TextBox TextToSpeakTextBox;
        private System.Windows.Forms.Button OkayButton;
        private System.Windows.Forms.Button CancelBttn;
    }
}