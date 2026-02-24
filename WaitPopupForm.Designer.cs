namespace BH_WaitingPopupWinform
{
    partial class WaitPopupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaitPopupForm));
            customBorderPanel1 = new CustomBorderPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            lbDesc = new Label();
            pictureBox1 = new PictureBox();
            lbTitle = new Label();
            customBorderPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // customBorderPanel1
            // 
            customBorderPanel1.BackColor = Color.White;
            customBorderPanel1.BorderColor = Color.Black;
            customBorderPanel1.BorderThickness = 2;
            customBorderPanel1.Controls.Add(tableLayoutPanel1);
            customBorderPanel1.Dock = DockStyle.Fill;
            customBorderPanel1.Location = new Point(0, 0);
            customBorderPanel1.Name = "customBorderPanel1";
            customBorderPanel1.Padding = new Padding(2);
            customBorderPanel1.Size = new Size(310, 90);
            customBorderPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lbDesc, 1, 1);
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(lbTitle, 1, 0);
            tableLayoutPanel1.Location = new Point(5, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(2);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(300, 80);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lbDesc
            // 
            lbDesc.Dock = DockStyle.Fill;
            lbDesc.Location = new Point(95, 40);
            lbDesc.Name = "lbDesc";
            lbDesc.Padding = new Padding(5, 0, 5, 5);
            lbDesc.Size = new Size(200, 38);
            lbDesc.TabIndex = 2;
            lbDesc.Text = "Loading...";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 2);
            pictureBox1.Margin = new Padding(19, 0, 5, 0);
            pictureBox1.Name = "pictureBox1";
            tableLayoutPanel1.SetRowSpan(pictureBox1, 2);
            pictureBox1.Size = new Size(66, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lbTitle
            // 
            lbTitle.Dock = DockStyle.Fill;
            lbTitle.Font = new Font("맑은 고딕", 13F);
            lbTitle.Location = new Point(95, 2);
            lbTitle.Name = "lbTitle";
            lbTitle.Padding = new Padding(5);
            lbTitle.Size = new Size(200, 38);
            lbTitle.TabIndex = 1;
            lbTitle.Text = "Please Wait";
            lbTitle.TextAlign = ContentAlignment.BottomLeft;
            // 
            // WaitPopupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 90);
            Controls.Add(customBorderPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "WaitPopupForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "WaitPopupForm";
            customBorderPanel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CustomBorderPanel customBorderPanel1;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        public Label lbDesc;
        public Label lbTitle;
    }
}