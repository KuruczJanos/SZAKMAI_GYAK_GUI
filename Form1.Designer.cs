namespace RealESTATESGUI
{
    partial class MainFrame
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
            listBox1 = new ListBox();
            sellerNameLabel = new Label();
            sellerPhoneLabel = new Label();
            LoadAdsButton = new Button();
            sellerAdsCountLabel = new Label();
            sellerNameTextLabel = new Label();
            sellerPhoneTextLabel = new Label();
            adsCountLabel = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 16);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(160, 424);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // sellerNameLabel
            // 
            sellerNameLabel.AutoSize = true;
            sellerNameLabel.Location = new Point(205, 42);
            sellerNameLabel.Name = "sellerNameLabel";
            sellerNameLabel.Size = new Size(67, 15);
            sellerNameLabel.TabIndex = 1;
            sellerNameLabel.Text = "Eladó neve:";
            // 
            // sellerPhoneLabel
            // 
            sellerPhoneLabel.AutoSize = true;
            sellerPhoneLabel.Location = new Point(205, 85);
            sellerPhoneLabel.Name = "sellerPhoneLabel";
            sellerPhoneLabel.Size = new Size(112, 15);
            sellerPhoneLabel.TabIndex = 2;
            sellerPhoneLabel.Text = "Eladó telefonszáma:";
            // 
            // LoadAdsButton
            // 
            LoadAdsButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LoadAdsButton.Location = new Point(205, 119);
            LoadAdsButton.Name = "LoadAdsButton";
            LoadAdsButton.Size = new Size(574, 23);
            LoadAdsButton.TabIndex = 5;
            LoadAdsButton.Text = "Hirdetések betöltése";
            LoadAdsButton.UseVisualStyleBackColor = true;
            LoadAdsButton.Click += LoadAdsButton_Click;
            // 
            // sellerAdsCountLabel
            // 
            sellerAdsCountLabel.AutoSize = true;
            sellerAdsCountLabel.Location = new Point(205, 164);
            sellerAdsCountLabel.Name = "sellerAdsCountLabel";
            sellerAdsCountLabel.Size = new Size(102, 15);
            sellerAdsCountLabel.TabIndex = 7;
            sellerAdsCountLabel.Text = "Hirdetések száma:";
            // 
            // sellerNameTextLabel
            // 
            sellerNameTextLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            sellerNameTextLabel.AutoSize = true;
            sellerNameTextLabel.Location = new Point(317, 42);
            sellerNameTextLabel.Name = "sellerNameTextLabel";
            sellerNameTextLabel.Size = new Size(0, 15);
            sellerNameTextLabel.TabIndex = 8;
            // 
            // sellerPhoneTextLabel
            // 
            sellerPhoneTextLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            sellerPhoneTextLabel.AutoSize = true;
            sellerPhoneTextLabel.Location = new Point(323, 85);
            sellerPhoneTextLabel.Name = "sellerPhoneTextLabel";
            sellerPhoneTextLabel.Size = new Size(0, 15);
            sellerPhoneTextLabel.TabIndex = 9;
            // 
            // adsCountLabel
            // 
            adsCountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            adsCountLabel.AutoSize = true;
            adsCountLabel.Location = new Point(323, 164);
            adsCountLabel.Name = "adsCountLabel";
            adsCountLabel.Size = new Size(0, 15);
            adsCountLabel.TabIndex = 10;
            // 
            // MainFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 450);
            Controls.Add(adsCountLabel);
            Controls.Add(sellerPhoneTextLabel);
            Controls.Add(sellerNameTextLabel);
            Controls.Add(sellerAdsCountLabel);
            Controls.Add(LoadAdsButton);
            Controls.Add(sellerPhoneLabel);
            Controls.Add(sellerNameLabel);
            Controls.Add(listBox1);
            Name = "MainFrame";
            Text = "Ingatlanok";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label sellerNameLabel;
        private Label sellerPhoneLabel;
        private Button LoadAdsButton;
        private Label sellerAdsCountLabel;
        private Label sellerNameTextLabel;
        private Label sellerPhoneTextLabel;
        private Label adsCountLabel;
    }
}