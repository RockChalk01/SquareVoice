namespace SquareVoice
{
    partial class PickActionType
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
            this.ActionList = new System.Windows.Forms.ListBox();
            this.OkayBttn = new System.Windows.Forms.Button();
            this.CancelBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ActionList
            // 
            this.ActionList.FormattingEnabled = true;
            this.ActionList.Location = new System.Drawing.Point(12, 3);
            this.ActionList.Name = "ActionList";
            this.ActionList.Size = new System.Drawing.Size(234, 277);
            this.ActionList.Sorted = true;
            this.ActionList.TabIndex = 5;
            this.ActionList.SelectedIndexChanged += new System.EventHandler(this.ActionItemList_SelectedIndexChanged);
            // 
            // OkayBttn
            // 
            this.OkayBttn.Enabled = false;
            this.OkayBttn.Location = new System.Drawing.Point(90, 305);
            this.OkayBttn.Name = "OkayBttn";
            this.OkayBttn.Size = new System.Drawing.Size(75, 23);
            this.OkayBttn.TabIndex = 4;
            this.OkayBttn.Text = "Okay";
            this.OkayBttn.UseVisualStyleBackColor = true;
            this.OkayBttn.Click += new System.EventHandler(this.OkayBttn_Click);
            // 
            // CancelBttn
            // 
            this.CancelBttn.Location = new System.Drawing.Point(171, 305);
            this.CancelBttn.Name = "CancelBttn";
            this.CancelBttn.Size = new System.Drawing.Size(75, 23);
            this.CancelBttn.TabIndex = 3;
            this.CancelBttn.Text = "Cancel";
            this.CancelBttn.UseVisualStyleBackColor = true;
            this.CancelBttn.Click += new System.EventHandler(this.CancelBttn_Click);
            // 
            // PickActionType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 338);
            this.Controls.Add(this.ActionList);
            this.Controls.Add(this.OkayBttn);
            this.Controls.Add(this.CancelBttn);
            this.Name = "PickActionType";
            this.Text = "PickActionType";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ActionList;
        private System.Windows.Forms.Button OkayBttn;
        private System.Windows.Forms.Button CancelBttn;

    }
}