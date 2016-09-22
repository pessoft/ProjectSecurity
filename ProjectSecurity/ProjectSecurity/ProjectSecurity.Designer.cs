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
            this.projectContent = new System.Windows.Forms.TabControl();
            this.tabPageEncryption = new System.Windows.Forms.TabPage();
            this.panelEncodDecod = new System.Windows.Forms.Panel();
            this.splitEncodDecod = new System.Windows.Forms.SplitContainer();
            this.groupBoxTextIn = new System.Windows.Forms.GroupBox();
            this.textBoxIn = new System.Windows.Forms.TextBox();
            this.groupBoxTextOut = new System.Windows.Forms.GroupBox();
            this.textBoxOut = new System.Windows.Forms.TextBox();
            this.buttonDecoding = new System.Windows.Forms.Button();
            this.buttonEncoding = new System.Windows.Forms.Button();
            this.tabPageFrequency = new System.Windows.Forms.TabPage();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.frequencyContent = new System.Windows.Forms.TabControl();
            this.tabLoadText = new System.Windows.Forms.TabPage();
            this.tabFrequencyLit = new System.Windows.Forms.TabPage();
            this.tabFrequencyPairsLit = new System.Windows.Forms.TabPage();
            this.projectContent.SuspendLayout();
            this.tabPageEncryption.SuspendLayout();
            this.panelEncodDecod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitEncodDecod)).BeginInit();
            this.splitEncodDecod.Panel1.SuspendLayout();
            this.splitEncodDecod.Panel2.SuspendLayout();
            this.splitEncodDecod.SuspendLayout();
            this.groupBoxTextIn.SuspendLayout();
            this.groupBoxTextOut.SuspendLayout();
            this.tabPageFrequency.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.menu.SuspendLayout();
            this.frequencyContent.SuspendLayout();
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
            this.tabPageEncryption.Controls.Add(this.panelEncodDecod);
            this.tabPageEncryption.Controls.Add(this.buttonDecoding);
            this.tabPageEncryption.Controls.Add(this.buttonEncoding);
            this.tabPageEncryption.Location = new System.Drawing.Point(23, 4);
            this.tabPageEncryption.Name = "tabPageEncryption";
            this.tabPageEncryption.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEncryption.Size = new System.Drawing.Size(740, 375);
            this.tabPageEncryption.TabIndex = 0;
            this.tabPageEncryption.Text = "Encryption";
            this.tabPageEncryption.UseVisualStyleBackColor = true;
            // 
            // panelEncodDecod
            // 
            this.panelEncodDecod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEncodDecod.Controls.Add(this.splitEncodDecod);
            this.panelEncodDecod.Location = new System.Drawing.Point(12, 8);
            this.panelEncodDecod.Name = "panelEncodDecod";
            this.panelEncodDecod.Size = new System.Drawing.Size(720, 329);
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
            this.splitEncodDecod.Size = new System.Drawing.Size(720, 329);
            this.splitEncodDecod.SplitterDistance = 344;
            this.splitEncodDecod.TabIndex = 0;
            // 
            // groupBoxTextIn
            // 
            this.groupBoxTextIn.Controls.Add(this.textBoxIn);
            this.groupBoxTextIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTextIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTextIn.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTextIn.Name = "groupBoxTextIn";
            this.groupBoxTextIn.Size = new System.Drawing.Size(344, 329);
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
            this.textBoxIn.Multiline = true;
            this.textBoxIn.Name = "textBoxIn";
            this.textBoxIn.Size = new System.Drawing.Size(338, 307);
            this.textBoxIn.TabIndex = 0;
            // 
            // groupBoxTextOut
            // 
            this.groupBoxTextOut.Controls.Add(this.textBoxOut);
            this.groupBoxTextOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTextOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTextOut.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTextOut.Name = "groupBoxTextOut";
            this.groupBoxTextOut.Size = new System.Drawing.Size(372, 329);
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
            this.textBoxOut.Multiline = true;
            this.textBoxOut.Name = "textBoxOut";
            this.textBoxOut.Size = new System.Drawing.Size(366, 307);
            this.textBoxOut.TabIndex = 0;
            // 
            // buttonDecoding
            // 
            this.buttonDecoding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDecoding.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDecoding.Location = new System.Drawing.Point(655, 339);
            this.buttonDecoding.Name = "buttonDecoding";
            this.buttonDecoding.Size = new System.Drawing.Size(78, 26);
            this.buttonDecoding.TabIndex = 6;
            this.buttonDecoding.Tag = "";
            this.buttonDecoding.Text = "Decoding";
            this.buttonDecoding.UseVisualStyleBackColor = true;
            // 
            // buttonEncoding
            // 
            this.buttonEncoding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEncoding.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEncoding.Location = new System.Drawing.Point(570, 339);
            this.buttonEncoding.Name = "buttonEncoding";
            this.buttonEncoding.Size = new System.Drawing.Size(78, 26);
            this.buttonEncoding.TabIndex = 5;
            this.buttonEncoding.Tag = "";
            this.buttonEncoding.Text = "Encoding";
            this.buttonEncoding.UseVisualStyleBackColor = true;
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
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Ready";
            this.toolStripStatusLabel.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
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
            this.Load += new System.EventHandler(this.ProjectSecurity_Load);
            this.projectContent.ResumeLayout(false);
            this.tabPageEncryption.ResumeLayout(false);
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
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.frequencyContent.ResumeLayout(false);
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
        private System.Windows.Forms.Button buttonDecoding;
        private System.Windows.Forms.Button buttonEncoding;
        private System.Windows.Forms.TabPage tabPageFrequency;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.TabControl frequencyContent;
        private System.Windows.Forms.TabPage tabLoadText;
        private System.Windows.Forms.TabPage tabFrequencyLit;
        private System.Windows.Forms.TabPage tabFrequencyPairsLit;
    }
}

