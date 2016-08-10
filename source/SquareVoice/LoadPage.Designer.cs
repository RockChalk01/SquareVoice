namespace SquareVoice
{
    partial class LoadPage
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
            this.OkayBttn = new System.Windows.Forms.Button();
            this.PageList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // CancelBttn
            // 
            this.CancelBttn.Location = new System.Drawing.Point(171, 314);
            this.CancelBttn.Name = "CancelBttn";
            this.CancelBttn.Size = new System.Drawing.Size(75, 23);
            this.CancelBttn.TabIndex = 0;
            this.CancelBttn.Text = "Cancel";
            this.CancelBttn.UseVisualStyleBackColor = true;
            this.CancelBttn.Click += new System.EventHandler(this.CancelBttn_Click);
            // 
            // OkayBttn
            // 
            this.OkayBttn.Enabled = false;
            this.OkayBttn.Location = new System.Drawing.Point(90, 314);
            this.OkayBttn.Name = "OkayBttn";
            this.OkayBttn.Size = new System.Drawing.Size(75, 23);
            this.OkayBttn.TabIndex = 1;
            this.OkayBttn.Text = "Okay";
            this.OkayBttn.UseVisualStyleBackColor = true;
            this.OkayBttn.Click += new System.EventHandler(this.OkayBttn_Click);
            // 
            // PageList
            // 
            this.PageList.FormattingEnabled = true;
            this.PageList.Location = new System.Drawing.Point(12, 12);
            this.PageList.Name = "PageList";
            this.PageList.Size = new System.Drawing.Size(234, 277);
            this.PageList.Sorted = true;
            this.PageList.TabIndex = 2;
            this.PageList.SelectedIndexChanged += new System.EventHandler(this.PageList_SelectedIndexChanged);
            // 
            // LoadPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 349);
            this.Controls.Add(this.PageList);
            this.Controls.Add(this.OkayBttn);
            this.Controls.Add(this.CancelBttn);
            this.Name = "LoadPage";
            this.Text = "Load Page";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CancelBttn;
        private System.Windows.Forms.Button OkayBttn;
        private System.Windows.Forms.ListBox PageList;
    }
}