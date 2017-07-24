namespace RSS_reader
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AddCollectionButton = new System.Windows.Forms.Button();
            this.DeleteCollectionButton = new System.Windows.Forms.Button();
            this.RenameCollectionButton = new System.Windows.Forms.Button();
            this.AddChannelBox = new System.Windows.Forms.Button();
            this.DeleteChannelButton = new System.Windows.Forms.Button();
            this.RenameChannelButton = new System.Windows.Forms.Button();
            this.CollectionsListBox = new System.Windows.Forms.ListBox();
            this.ChannelListBox = new System.Windows.Forms.ListBox();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.AddCollectionButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.DeleteCollectionButton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.RenameCollectionButton, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.AddChannelBox, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.DeleteChannelButton, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.RenameChannelButton, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.CollectionsListBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ChannelListBox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.webBrowser, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(758, 529);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // AddCollectionButton
            // 
            this.AddCollectionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddCollectionButton.Location = new System.Drawing.Point(3, 247);
            this.AddCollectionButton.Name = "AddCollectionButton";
            this.AddCollectionButton.Size = new System.Drawing.Size(74, 34);
            this.AddCollectionButton.TabIndex = 0;
            this.AddCollectionButton.Text = "Add";
            this.AddCollectionButton.UseVisualStyleBackColor = true;
            this.AddCollectionButton.Click += new System.EventHandler(this.AddCollectionButton_Click);
            // 
            // DeleteCollectionButton
            // 
            this.DeleteCollectionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteCollectionButton.Location = new System.Drawing.Point(83, 247);
            this.DeleteCollectionButton.Name = "DeleteCollectionButton";
            this.DeleteCollectionButton.Size = new System.Drawing.Size(74, 34);
            this.DeleteCollectionButton.TabIndex = 1;
            this.DeleteCollectionButton.Text = "Delete";
            this.DeleteCollectionButton.UseVisualStyleBackColor = true;
            this.DeleteCollectionButton.Click += new System.EventHandler(this.DeleteCollectionButton_Click);
            // 
            // RenameCollectionButton
            // 
            this.RenameCollectionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RenameCollectionButton.Location = new System.Drawing.Point(163, 247);
            this.RenameCollectionButton.Name = "RenameCollectionButton";
            this.RenameCollectionButton.Size = new System.Drawing.Size(74, 34);
            this.RenameCollectionButton.TabIndex = 2;
            this.RenameCollectionButton.Text = "Rename";
            this.RenameCollectionButton.UseVisualStyleBackColor = true;
            this.RenameCollectionButton.Click += new System.EventHandler(this.RenameCollectionButton_Click);
            // 
            // AddChannelBox
            // 
            this.AddChannelBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddChannelBox.Location = new System.Drawing.Point(3, 491);
            this.AddChannelBox.Name = "AddChannelBox";
            this.AddChannelBox.Size = new System.Drawing.Size(74, 35);
            this.AddChannelBox.TabIndex = 3;
            this.AddChannelBox.Text = "Add";
            this.AddChannelBox.UseVisualStyleBackColor = true;
            this.AddChannelBox.Click += new System.EventHandler(this.AddChannelBox_Click);
            // 
            // DeleteChannelButton
            // 
            this.DeleteChannelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteChannelButton.Location = new System.Drawing.Point(83, 491);
            this.DeleteChannelButton.Name = "DeleteChannelButton";
            this.DeleteChannelButton.Size = new System.Drawing.Size(74, 35);
            this.DeleteChannelButton.TabIndex = 4;
            this.DeleteChannelButton.Text = "Delete";
            this.DeleteChannelButton.UseVisualStyleBackColor = true;
            this.DeleteChannelButton.Click += new System.EventHandler(this.DeleteChannelButton_Click);
            // 
            // RenameChannelButton
            // 
            this.RenameChannelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RenameChannelButton.Location = new System.Drawing.Point(163, 491);
            this.RenameChannelButton.Name = "RenameChannelButton";
            this.RenameChannelButton.Size = new System.Drawing.Size(74, 35);
            this.RenameChannelButton.TabIndex = 5;
            this.RenameChannelButton.Text = "Rename";
            this.RenameChannelButton.UseVisualStyleBackColor = true;
            this.RenameChannelButton.Click += new System.EventHandler(this.RenameChannelButton_Click);
            // 
            // CollectionsListBox
            // 
            this.CollectionsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.CollectionsListBox, 3);
            this.CollectionsListBox.FormattingEnabled = true;
            this.CollectionsListBox.ItemHeight = 16;
            this.CollectionsListBox.Location = new System.Drawing.Point(3, 43);
            this.CollectionsListBox.Name = "CollectionsListBox";
            this.CollectionsListBox.Size = new System.Drawing.Size(234, 196);
            this.CollectionsListBox.TabIndex = 6;
            this.CollectionsListBox.SelectedValueChanged += new System.EventHandler(this.CollectionsListBox_SelectedValueChanged);
            // 
            // ChannelListBox
            // 
            this.ChannelListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.ChannelListBox, 3);
            this.ChannelListBox.FormattingEnabled = true;
            this.ChannelListBox.ItemHeight = 16;
            this.ChannelListBox.Location = new System.Drawing.Point(3, 287);
            this.ChannelListBox.Name = "ChannelListBox";
            this.ChannelListBox.Size = new System.Drawing.Size(234, 196);
            this.ChannelListBox.TabIndex = 7;
            this.ChannelListBox.SelectedValueChanged += new System.EventHandler(this.ChannelListBox_SelectedValueChanged);
            // 
            // webBrowser
            // 
            this.webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser.Location = new System.Drawing.Point(243, 3);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.tableLayoutPanel1.SetRowSpan(this.webBrowser, 5);
            this.webBrowser.Size = new System.Drawing.Size(512, 523);
            this.webBrowser.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button AddCollectionButton;
        private System.Windows.Forms.Button DeleteCollectionButton;
        private System.Windows.Forms.Button RenameCollectionButton;
        private System.Windows.Forms.Button AddChannelBox;
        private System.Windows.Forms.Button DeleteChannelButton;
        private System.Windows.Forms.Button RenameChannelButton;
        private System.Windows.Forms.ListBox CollectionsListBox;
        private System.Windows.Forms.ListBox ChannelListBox;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}

