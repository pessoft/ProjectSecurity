namespace ProjectSecurity
{
    partial class ProjectSecurity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectSecurity));
            this.projectContent = new System.Windows.Forms.TabControl();
            this.tabPageEncryption = new System.Windows.Forms.TabPage();
            this.toolStripFastMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripEncryptionButton = new System.Windows.Forms.ToolStripSplitButton();
            this.encodingButton = new System.Windows.Forms.ToolStripMenuItem();
            this.decodingButton = new System.Windows.Forms.ToolStripMenuItem();
            this.panelEncodDecod = new System.Windows.Forms.Panel();
            this.splitEncodDecod = new System.Windows.Forms.SplitContainer();
            this.groupBoxTextIn = new System.Windows.Forms.GroupBox();
            this.textBoxIn = new System.Windows.Forms.TextBox();
            this.groupBoxTextOut = new System.Windows.Forms.GroupBox();
            this.textBoxOut = new System.Windows.Forms.TextBox();
            this.tabPageFrequency = new System.Windows.Forms.TabPage();
            this.frequencyContent = new System.Windows.Forms.TabControl();
            this.tabLoadText = new System.Windows.Forms.TabPage();
            this.tabFrequencyLit = new System.Windows.Forms.TabPage();
            this.tabFrequencyPairsLit = new System.Windows.Forms.TabPage();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourceTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processedTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectContent.SuspendLayout();
            this.tabPageEncryption.SuspendLayout();
            this.toolStripFastMenu.SuspendLayout();
            this.panelEncodDecod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitEncodDecod)).BeginInit();
            this.splitEncodDecod.Panel1.SuspendLayout();
            this.splitEncodDecod.Panel2.SuspendLayout();
            this.splitEncodDecod.SuspendLayout();
            this.groupBoxTextIn.SuspendLayout();
            this.groupBoxTextOut.SuspendLayout();
            this.tabPageFrequency.SuspendLayout();
            this.frequencyContent.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // projectContent
            // 
            this.projectContent.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.projectContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.projectContent.Controls.Add(this.tabPageEncryption);
            this.projectContent.Controls.Add(this.tabPageFrequency);
            this.projectContent.Location = new System.Drawing.Point(0, 27);
            this.projectContent.Multiline = true;
            this.projectContent.Name = "projectContent";
            this.projectContent.SelectedIndex = 0;
            this.projectContent.Size = new System.Drawing.Size(767, 383);
            this.projectContent.TabIndex = 0;
            // 
            // tabPageEncryption
            // 
            this.tabPageEncryption.Controls.Add(this.toolStripFastMenu);
            this.tabPageEncryption.Controls.Add(this.panelEncodDecod);
            this.tabPageEncryption.Location = new System.Drawing.Point(23, 4);
            this.tabPageEncryption.Name = "tabPageEncryption";
            this.tabPageEncryption.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEncryption.Size = new System.Drawing.Size(740, 375);
            this.tabPageEncryption.TabIndex = 0;
            this.tabPageEncryption.Text = "Encryption";
            this.tabPageEncryption.UseVisualStyleBackColor = true;
            // 
            // toolStripFastMenu
            // 
            this.toolStripFastMenu.BackColor = System.Drawing.Color.Transparent;
            this.toolStripFastMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSplitButton2,
            this.toolStripEncryptionButton});
            this.toolStripFastMenu.Location = new System.Drawing.Point(3, 3);
            this.toolStripFastMenu.Name = "toolStripFastMenu";
            this.toolStripFastMenu.Size = new System.Drawing.Size(734, 25);
            this.toolStripFastMenu.TabIndex = 7;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Margin = new System.Windows.Forms.Padding(0, 1, 3, 2);
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Open";
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton2.DropDownButtonWidth = 15;
            this.toolStripSplitButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sourceTextToolStripMenuItem,
            this.processedTextToolStripMenuItem});
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(36, 22);
            this.toolStripSplitButton2.Text = "Save as...";
            // 
            // toolStripEncryptionButton
            // 
            this.toolStripEncryptionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripEncryptionButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripEncryptionButton.DropDownButtonWidth = 15;
            this.toolStripEncryptionButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encodingButton,
            this.decodingButton});
            this.toolStripEncryptionButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripEncryptionButton.Image")));
            this.toolStripEncryptionButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripEncryptionButton.Margin = new System.Windows.Forms.Padding(0, 1, 3, 2);
            this.toolStripEncryptionButton.Name = "toolStripEncryptionButton";
            this.toolStripEncryptionButton.Size = new System.Drawing.Size(36, 22);
            this.toolStripEncryptionButton.Text = "Encryption";
            // 
            // encodingButton
            // 
            this.encodingButton.Image = ((System.Drawing.Image)(resources.GetObject("encodingButton.Image")));
            this.encodingButton.Name = "encodingButton";
            this.encodingButton.Size = new System.Drawing.Size(152, 22);
            this.encodingButton.Text = "Encoding";
            this.encodingButton.Click += new System.EventHandler(this.ButtonEncryptClick);
            // 
            // decodingButton
            // 
            this.decodingButton.Image = ((System.Drawing.Image)(resources.GetObject("decodingButton.Image")));
            this.decodingButton.Name = "decodingButton";
            this.decodingButton.Size = new System.Drawing.Size(152, 22);
            this.decodingButton.Text = "Decoding";
            this.decodingButton.Click += new System.EventHandler(this.ButtonEncryptClick);
            // 
            // panelEncodDecod
            // 
            this.panelEncodDecod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEncodDecod.Controls.Add(this.splitEncodDecod);
            this.panelEncodDecod.Location = new System.Drawing.Point(6, 31);
            this.panelEncodDecod.Name = "panelEncodDecod";
            this.panelEncodDecod.Size = new System.Drawing.Size(728, 335);
            this.panelEncodDecod.TabIndex = 4;
            // 
            // splitEncodDecod
            // 
            this.splitEncodDecod.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.splitEncodDecod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitEncodDecod.Location = new System.Drawing.Point(0, 0);
            this.splitEncodDecod.Name = "splitEncodDecod";
            // 
            // splitEncodDecod.Panel1
            // 
            this.splitEncodDecod.Panel1.Controls.Add(this.groupBoxTextIn);
            // 
            // splitEncodDecod.Panel2
            // 
            this.splitEncodDecod.Panel2.Controls.Add(this.groupBoxTextOut);
            this.splitEncodDecod.Size = new System.Drawing.Size(728, 335);
            this.splitEncodDecod.SplitterDistance = 347;
            this.splitEncodDecod.TabIndex = 0;
            // 
            // groupBoxTextIn
            // 
            this.groupBoxTextIn.Controls.Add(this.textBoxIn);
            this.groupBoxTextIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTextIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTextIn.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTextIn.Name = "groupBoxTextIn";
            this.groupBoxTextIn.Size = new System.Drawing.Size(347, 335);
            this.groupBoxTextIn.TabIndex = 0;
            this.groupBoxTextIn.TabStop = false;
            this.groupBoxTextIn.Text = "Source text";
            // 
            // textBoxIn
            // 
            this.textBoxIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxIn.Location = new System.Drawing.Point(3, 19);
            this.textBoxIn.MaxLength = 9999999;
            this.textBoxIn.Multiline = true;
            this.textBoxIn.Name = "textBoxIn";
            this.textBoxIn.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxIn.Size = new System.Drawing.Size(341, 313);
            this.textBoxIn.TabIndex = 0;
            // 
            // groupBoxTextOut
            // 
            this.groupBoxTextOut.Controls.Add(this.textBoxOut);
            this.groupBoxTextOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTextOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTextOut.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTextOut.Name = "groupBoxTextOut";
            this.groupBoxTextOut.Size = new System.Drawing.Size(377, 335);
            this.groupBoxTextOut.TabIndex = 0;
            this.groupBoxTextOut.TabStop = false;
            this.groupBoxTextOut.Text = "Processed text";
            // 
            // textBoxOut
            // 
            this.textBoxOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxOut.Location = new System.Drawing.Point(3, 19);
            this.textBoxOut.MaxLength = 9999999;
            this.textBoxOut.Multiline = true;
            this.textBoxOut.Name = "textBoxOut";
            this.textBoxOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOut.Size = new System.Drawing.Size(371, 313);
            this.textBoxOut.TabIndex = 0;
            // 
            // tabPageFrequency
            // 
            this.tabPageFrequency.Controls.Add(this.frequencyContent);
            this.tabPageFrequency.Location = new System.Drawing.Point(23, 4);
            this.tabPageFrequency.Name = "tabPageFrequency";
            this.tabPageFrequency.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFrequency.Size = new System.Drawing.Size(740, 375);
            this.tabPageFrequency.TabIndex = 1;
            this.tabPageFrequency.Text = "Frequency";
            this.tabPageFrequency.UseVisualStyleBackColor = true;
            // 
            // frequencyContent
            // 
            this.frequencyContent.Controls.Add(this.tabLoadText);
            this.frequencyContent.Controls.Add(this.tabFrequencyLit);
            this.frequencyContent.Controls.Add(this.tabFrequencyPairsLit);
            this.frequencyContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frequencyContent.Location = new System.Drawing.Point(3, 3);
            this.frequencyContent.Name = "frequencyContent";
            this.frequencyContent.SelectedIndex = 0;
            this.frequencyContent.Size = new System.Drawing.Size(734, 369);
            this.frequencyContent.TabIndex = 0;
            // 
            // tabLoadText
            // 
            this.tabLoadText.Location = new System.Drawing.Point(4, 22);
            this.tabLoadText.Name = "tabLoadText";
            this.tabLoadText.Padding = new System.Windows.Forms.Padding(3);
            this.tabLoadText.Size = new System.Drawing.Size(726, 343);
            this.tabLoadText.TabIndex = 0;
            this.tabLoadText.Text = "Text";
            this.tabLoadText.UseVisualStyleBackColor = true;
            // 
            // tabFrequencyLit
            // 
            this.tabFrequencyLit.Location = new System.Drawing.Point(4, 22);
            this.tabFrequencyLit.Name = "tabFrequencyLit";
            this.tabFrequencyLit.Padding = new System.Windows.Forms.Padding(3);
            this.tabFrequencyLit.Size = new System.Drawing.Size(726, 343);
            this.tabFrequencyLit.TabIndex = 1;
            this.tabFrequencyLit.Text = "Frequency letters chart";
            this.tabFrequencyLit.UseVisualStyleBackColor = true;
            // 
            // tabFrequencyPairsLit
            // 
            this.tabFrequencyPairsLit.Location = new System.Drawing.Point(4, 22);
            this.tabFrequencyPairsLit.Name = "tabFrequencyPairsLit";
            this.tabFrequencyPairsLit.Padding = new System.Windows.Forms.Padding(3);
            this.tabFrequencyPairsLit.Size = new System.Drawing.Size(726, 343);
            this.tabFrequencyPairsLit.TabIndex = 2;
            this.tabFrequencyPairsLit.Text = "Frequency pairs letters chart";
            this.tabFrequencyPairsLit.UseVisualStyleBackColor = true;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 400);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(760, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Ready";
            this.toolStripStatusLabel.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(760, 24);
            this.menu.TabIndex = 2;
            this.menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // sourceTextToolStripMenuItem
            // 
            this.sourceTextToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sourceTextToolStripMenuItem.Image")));
            this.sourceTextToolStripMenuItem.Name = "sourceTextToolStripMenuItem";
            this.sourceTextToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sourceTextToolStripMenuItem.Text = "Source text";
            // 
            // processedTextToolStripMenuItem
            // 
            this.processedTextToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("processedTextToolStripMenuItem.Image")));
            this.processedTextToolStripMenuItem.Name = "processedTextToolStripMenuItem";
            this.processedTextToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.processedTextToolStripMenuItem.Text = "Processed text";
            // 
            // ProjectSecurity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 422);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.projectContent);
            this.Name = "ProjectSecurity";
            this.Text = "ProjectSecurity";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.projectContent.ResumeLayout(false);
            this.tabPageEncryption.ResumeLayout(false);
            this.tabPageEncryption.PerformLayout();
            this.toolStripFastMenu.ResumeLayout(false);
            this.toolStripFastMenu.PerformLayout();
            this.panelEncodDecod.ResumeLayout(false);
            this.splitEncodDecod.Panel1.ResumeLayout(false);
            this.splitEncodDecod.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitEncodDecod)).EndInit();
            this.splitEncodDecod.ResumeLayout(false);
            this.groupBoxTextIn.ResumeLayout(false);
            this.groupBoxTextIn.PerformLayout();
            this.groupBoxTextOut.ResumeLayout(false);
            this.groupBoxTextOut.PerformLayout();
            this.tabPageFrequency.ResumeLayout(false);
            this.frequencyContent.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl projectContent;
        private System.Windows.Forms.TabPage tabPageEncryption;
        private System.Windows.Forms.Panel panelEncodDecod;
        private System.Windows.Forms.SplitContainer splitEncodDecod;
        private System.Windows.Forms.GroupBox groupBoxTextIn;
        private System.Windows.Forms.TextBox textBoxIn;
        private System.Windows.Forms.GroupBox groupBoxTextOut;
        private System.Windows.Forms.TextBox textBoxOut;
        private System.Windows.Forms.TabPage tabPageFrequency;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.TabControl frequencyContent;
        private System.Windows.Forms.TabPage tabLoadText;
        private System.Windows.Forms.TabPage tabFrequencyLit;
        private System.Windows.Forms.TabPage tabFrequencyPairsLit;
        private System.Windows.Forms.ToolStrip toolStripFastMenu;
        private System.Windows.Forms.ToolStripSplitButton toolStripEncryptionButton;
        private System.Windows.Forms.ToolStripMenuItem encodingButton;
        private System.Windows.Forms.ToolStripMenuItem decodingButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripMenuItem sourceTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processedTextToolStripMenuItem;
    }
}

