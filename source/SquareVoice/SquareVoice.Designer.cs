namespace SquareVoice
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.OuterPanel = new System.Windows.Forms.TableLayoutPanel();
            this.InnerPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxYes = new System.Windows.Forms.PictureBox();
            this.pictureBoxNo = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.cbDelayTimeout = new System.Windows.Forms.ComboBox();
            this.behaviorMap1 = new EyeXFramework.Forms.BehaviorMap(this.components);
            this.OuterPanel.SuspendLayout();
            this.InnerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNo)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OuterPanel
            // 
            this.OuterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OuterPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OuterPanel.ColumnCount = 1;
            this.OuterPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.OuterPanel.Controls.Add(this.InnerPanel, 0, 1);
            this.OuterPanel.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.OuterPanel.Location = new System.Drawing.Point(1, 1);
            this.OuterPanel.Name = "OuterPanel";
            this.OuterPanel.RowCount = 2;
            this.OuterPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.OuterPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.OuterPanel.Size = new System.Drawing.Size(483, 368);
            this.OuterPanel.TabIndex = 0;
            this.OuterPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.OuterPanel_Paint);
            // 
            // InnerPanel
            // 
            this.InnerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InnerPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.InnerPanel.ColumnCount = 2;
            this.InnerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.InnerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.InnerPanel.Controls.Add(this.pictureBoxYes, 0, 0);
            this.InnerPanel.Controls.Add(this.pictureBoxNo, 1, 0);
            this.InnerPanel.Location = new System.Drawing.Point(3, 43);
            this.InnerPanel.Name = "InnerPanel";
            this.InnerPanel.Padding = new System.Windows.Forms.Padding(5);
            this.InnerPanel.RowCount = 1;
            this.InnerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.InnerPanel.Size = new System.Drawing.Size(477, 322);
            this.InnerPanel.TabIndex = 0;
            // 
            // pictureBoxYes
            // 
            this.pictureBoxYes.BackgroundImage = global::SquareVoice.Properties.Resources.Yes;
            this.pictureBoxYes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxYes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxYes.InitialImage = null;
            this.pictureBoxYes.Location = new System.Drawing.Point(8, 8);
            this.pictureBoxYes.Name = "pictureBoxYes";
            this.pictureBoxYes.Size = new System.Drawing.Size(227, 306);
            this.pictureBoxYes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxYes.TabIndex = 0;
            this.pictureBoxYes.TabStop = false;
            this.pictureBoxYes.Click += new System.EventHandler(this.pictureBoxYes_Click);
            // 
            // pictureBoxNo
            // 
            this.pictureBoxNo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxNo.BackgroundImage = global::SquareVoice.Properties.Resources.No;
            this.pictureBoxNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxNo.Location = new System.Drawing.Point(241, 8);
            this.pictureBoxNo.Name = "pictureBoxNo";
            this.pictureBoxNo.Size = new System.Drawing.Size(228, 306);
            this.pictureBoxNo.TabIndex = 1;
            this.pictureBoxNo.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.cbDelayTimeout);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(477, 34);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(444, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cbDelayTimeout
            // 
            this.cbDelayTimeout.DisplayMember = "10";
            this.cbDelayTimeout.FormattingEnabled = true;
            this.cbDelayTimeout.Items.AddRange(new object[] {
            "10",
            "100",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000",
            "1200",
            "1400",
            "1600",
            "1800",
            "2000",
            "3000",
            "4000",
            "5000"});
            this.cbDelayTimeout.Location = new System.Drawing.Point(317, 3);
            this.cbDelayTimeout.Name = "cbDelayTimeout";
            this.cbDelayTimeout.Size = new System.Drawing.Size(121, 21);
            this.cbDelayTimeout.TabIndex = 1;
            this.cbDelayTimeout.SelectedIndexChanged += new System.EventHandler(this.cbDelayTimeout_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 367);
            this.Controls.Add(this.OuterPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.OuterPanel.ResumeLayout(false);
            this.InnerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNo)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel OuterPanel;
        private System.Windows.Forms.TableLayoutPanel InnerPanel;
        private System.Windows.Forms.PictureBox pictureBoxYes;
        private System.Windows.Forms.PictureBox pictureBoxNo;
        private EyeXFramework.Forms.BehaviorMap behaviorMap1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbDelayTimeout;


    }
}

