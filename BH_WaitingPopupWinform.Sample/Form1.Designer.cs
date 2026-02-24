namespace BH_WaitingPopupWinform.Sample
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnShow = new Button();
            txtTitle = new TextBox();
            label1 = new Label();
            txtDesc = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            delay = new NumericUpDown();
            height = new NumericUpDown();
            width = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)delay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)height).BeginInit();
            ((System.ComponentModel.ISupportInitialize)width).BeginInit();
            SuspendLayout();
            // 
            // btnShow
            // 
            btnShow.Location = new Point(166, 244);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(93, 38);
            btnShow.TabIndex = 10;
            btnShow.Text = "show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // txtTitle
            // 
            txtTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTitle.Location = new Point(166, 20);
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "Please Wait";
            txtTitle.Size = new Size(486, 23);
            txtTitle.TabIndex = 1;
            // 
            // label1
            // 
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(148, 23);
            label1.TabIndex = 0;
            label1.Text = "Title";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDesc
            // 
            txtDesc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDesc.Location = new Point(166, 65);
            txtDesc.Name = "txtDesc";
            txtDesc.PlaceholderText = "Logding...";
            txtDesc.Size = new Size(486, 23);
            txtDesc.TabIndex = 3;
            // 
            // label2
            // 
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(148, 23);
            label2.TabIndex = 2;
            label2.Text = "Description";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Location = new Point(12, 110);
            label3.Name = "label3";
            label3.Size = new Size(148, 23);
            label3.TabIndex = 4;
            label3.Text = "Width ( Default : 310 )";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Location = new Point(12, 155);
            label4.Name = "label4";
            label4.Size = new Size(148, 23);
            label4.TabIndex = 6;
            label4.Text = "Height ( Default : 90 )";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Location = new Point(12, 200);
            label5.Name = "label5";
            label5.Size = new Size(148, 23);
            label5.TabIndex = 8;
            label5.Text = "Waiting Time( Second )";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // delay
            // 
            delay.Location = new Point(166, 200);
            delay.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            delay.Name = "delay";
            delay.Size = new Size(120, 23);
            delay.TabIndex = 9;
            delay.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // height
            // 
            height.Location = new Point(166, 155);
            height.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            height.Minimum = new decimal(new int[] { 90, 0, 0, 0 });
            height.Name = "height";
            height.Size = new Size(120, 23);
            height.TabIndex = 7;
            height.Value = new decimal(new int[] { 90, 0, 0, 0 });
            // 
            // width
            // 
            width.Location = new Point(166, 110);
            width.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            width.Minimum = new decimal(new int[] { 310, 0, 0, 0 });
            width.Name = "width";
            width.Size = new Size(120, 23);
            width.TabIndex = 5;
            width.Value = new decimal(new int[] { 310, 0, 0, 0 });
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 501);
            Controls.Add(width);
            Controls.Add(height);
            Controls.Add(delay);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtDesc);
            Controls.Add(label1);
            Controls.Add(txtTitle);
            Controls.Add(btnShow);
            MinimumSize = new Size(316, 337);
            Name = "Form1";
            Text = "Sample";
            ((System.ComponentModel.ISupportInitialize)delay).EndInit();
            ((System.ComponentModel.ISupportInitialize)height).EndInit();
            ((System.ComponentModel.ISupportInitialize)width).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnShow;
        private TextBox txtTitle;
        private Label label1;
        private TextBox txtDesc;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private NumericUpDown delay;
        private NumericUpDown height;
        private NumericUpDown width;
    }
}
