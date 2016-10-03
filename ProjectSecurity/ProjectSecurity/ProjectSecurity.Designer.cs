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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.projectContent = new System.Windows.Forms.TabControl();
            this.tabPageEncryption = new System.Windows.Forms.TabPage();
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
            this.toolStripMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuSaveSource = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuSaveProcessed = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileText = new System.Windows.Forms.OpenFileDialog();
            this.saveFileText = new System.Windows.Forms.SaveFileDialog();
            this.toolStripFastMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitBtnSave = new System.Windows.Forms.ToolStripSplitButton();
            this.sourceBtnSaveSource = new System.Windows.Forms.ToolStripMenuItem();
            this.sourceBtnSaveProcessed = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripBtnEncryption = new System.Windows.Forms.ToolStripSplitButton();
            this.btnEncoding = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDecoding = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripBtnPrcToSrc = new System.Windows.Forms.ToolStripButton();
            this.frequencySourceText = new System.Windows.Forms.TextBox();
            this.splitFrequencyLettersChr = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.frequencyContent.SuspendLayout();
            this.tabLoadText.SuspendLayout();
            this.tabFrequencyLit.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.menu.SuspendLayout();
            this.toolStripFastMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitFrequencyLettersChr)).BeginInit();
            this.splitFrequencyLettersChr.Panel1.SuspendLayout();
            this.splitFrequencyLettersChr.Panel2.SuspendLayout();
            this.splitFrequencyLettersChr.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.projectContent.Location = new System.Drawing.Point(0, 52);
            this.projectContent.Multiline = true;
            this.projectContent.Name = "projectContent";
            this.projectContent.SelectedIndex = 0;
            this.projectContent.Size = new System.Drawing.Size(760, 358);
            this.projectContent.TabIndex = 0;
            this.projectContent.SelectedIndexChanged += new System.EventHandler(this.projectContentSelectedIndexChanged);
            this.projectContent.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.projectContentSelecting);
            // 
            // tabPageEncryption
            // 
            this.tabPageEncryption.Controls.Add(this.panelEncodDecod);
            this.tabPageEncryption.Location = new System.Drawing.Point(23, 4);
            this.tabPageEncryption.Name = "tabPageEncryption";
            this.tabPageEncryption.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEncryption.Size = new System.Drawing.Size(733, 350);
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
            this.panelEncodDecod.Location = new System.Drawing.Point(3, 6);
            this.panelEncodDecod.Name = "panelEncodDecod";
            this.panelEncodDecod.Size = new System.Drawing.Size(721, 335);
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
            this.splitEncodDecod.Size = new System.Drawing.Size(721, 335);
            this.splitEncodDecod.SplitterDistance = 343;
            this.splitEncodDecod.TabIndex = 0;
            // 
            // groupBoxTextIn
            // 
            this.groupBoxTextIn.Controls.Add(this.textBoxIn);
            this.groupBoxTextIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTextIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTextIn.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTextIn.Name = "groupBoxTextIn";
            this.groupBoxTextIn.Size = new System.Drawing.Size(343, 335);
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
            this.textBoxIn.Size = new System.Drawing.Size(337, 313);
            this.textBoxIn.TabIndex = 0;
            // 
            // groupBoxTextOut
            // 
            this.groupBoxTextOut.Controls.Add(this.textBoxOut);
            this.groupBoxTextOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTextOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTextOut.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTextOut.Name = "groupBoxTextOut";
            this.groupBoxTextOut.Size = new System.Drawing.Size(374, 335);
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
            this.textBoxOut.Size = new System.Drawing.Size(368, 313);
            this.textBoxOut.TabIndex = 0;
            // 
            // tabPageFrequency
            // 
            this.tabPageFrequency.Controls.Add(this.frequencyContent);
            this.tabPageFrequency.Location = new System.Drawing.Point(23, 4);
            this.tabPageFrequency.Name = "tabPageFrequency";
            this.tabPageFrequency.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFrequency.Size = new System.Drawing.Size(733, 350);
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
            this.frequencyContent.Size = new System.Drawing.Size(727, 344);
            this.frequencyContent.TabIndex = 0;
            // 
            // tabLoadText
            // 
            this.tabLoadText.Controls.Add(this.frequencySourceText);
            this.tabLoadText.Location = new System.Drawing.Point(4, 22);
            this.tabLoadText.Name = "tabLoadText";
            this.tabLoadText.Padding = new System.Windows.Forms.Padding(3);
            this.tabLoadText.Size = new System.Drawing.Size(719, 318);
            this.tabLoadText.TabIndex = 0;
            this.tabLoadText.Text = "Source text";
            this.tabLoadText.UseVisualStyleBackColor = true;
            // 
            // tabFrequencyLit
            // 
            this.tabFrequencyLit.Controls.Add(this.splitFrequencyLettersChr);
            this.tabFrequencyLit.Location = new System.Drawing.Point(4, 22);
            this.tabFrequencyLit.Name = "tabFrequencyLit";
            this.tabFrequencyLit.Padding = new System.Windows.Forms.Padding(3);
            this.tabFrequencyLit.Size = new System.Drawing.Size(719, 318);
            this.tabFrequencyLit.TabIndex = 1;
            this.tabFrequencyLit.Text = "Frequency letters chart";
            this.tabFrequencyLit.UseVisualStyleBackColor = true;
            // 
            // tabFrequencyPairsLit
            // 
            this.tabFrequencyPairsLit.Location = new System.Drawing.Point(4, 22);
            this.tabFrequencyPairsLit.Name = "tabFrequencyPairsLit";
            this.tabFrequencyPairsLit.Padding = new System.Windows.Forms.Padding(3);
            this.tabFrequencyPairsLit.Size = new System.Drawing.Size(719, 318);
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
            this.toolStripMenuFile});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(760, 24);
            this.menu.TabIndex = 2;
            this.menu.Text = "menuStrip1";
            // 
            // toolStripMenuFile
            // 
            this.toolStripMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripMenuSave,
            this.toolStripMenuExit});
            this.toolStripMenuFile.Name = "toolStripMenuFile";
            this.toolStripMenuFile.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuFile.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenText);
            // 
            // toolStripMenuSave
            // 
            this.toolStripMenuSave.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textToolStripMenuSaveSource,
            this.textToolStripMenuSaveProcessed});
            this.toolStripMenuSave.Name = "toolStripMenuSave";
            this.toolStripMenuSave.Size = new System.Drawing.Size(146, 22);
            this.toolStripMenuSave.Text = "Save";
            // 
            // textToolStripMenuSaveSource
            // 
            this.textToolStripMenuSaveSource.Name = "textToolStripMenuSaveSource";
            this.textToolStripMenuSaveSource.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.textToolStripMenuSaveSource.Size = new System.Drawing.Size(221, 22);
            this.textToolStripMenuSaveSource.Text = "Source text";
            this.textToolStripMenuSaveSource.Click += new System.EventHandler(this.SaveText);
            // 
            // textToolStripMenuSaveProcessed
            // 
            this.textToolStripMenuSaveProcessed.Name = "textToolStripMenuSaveProcessed";
            this.textToolStripMenuSaveProcessed.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.textToolStripMenuSaveProcessed.Size = new System.Drawing.Size(221, 22);
            this.textToolStripMenuSaveProcessed.Text = "Processed text";
            this.textToolStripMenuSaveProcessed.Click += new System.EventHandler(this.SaveText);
            // 
            // toolStripMenuExit
            // 
            this.toolStripMenuExit.Name = "toolStripMenuExit";
            this.toolStripMenuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.toolStripMenuExit.Size = new System.Drawing.Size(146, 22);
            this.toolStripMenuExit.Text = "Exit";
            this.toolStripMenuExit.Click += new System.EventHandler(this.toolStripMenuExitClick);
            // 
            // openFileText
            // 
            this.openFileText.FileName = "openFileText";
            this.openFileText.Filter = "Text file|*.txt";
            // 
            // saveFileText
            // 
            this.saveFileText.Filter = "Text file|*.txt";
            // 
            // toolStripFastMenu
            // 
            this.toolStripFastMenu.BackColor = System.Drawing.Color.Transparent;
            this.toolStripFastMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripFastMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripFastMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnOpen,
            this.toolStripSplitBtnSave,
            this.toolStripBtnEncryption,
            this.toolStripBtnPrcToSrc});
            this.toolStripFastMenu.Location = new System.Drawing.Point(0, 24);
            this.toolStripFastMenu.Name = "toolStripFastMenu";
            this.toolStripFastMenu.Size = new System.Drawing.Size(760, 25);
            this.toolStripFastMenu.TabIndex = 8;
            // 
            // toolStripBtnOpen
            // 
            this.toolStripBtnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnOpen.Image")));
            this.toolStripBtnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnOpen.Margin = new System.Windows.Forms.Padding(0, 1, 3, 2);
            this.toolStripBtnOpen.Name = "toolStripBtnOpen";
            this.toolStripBtnOpen.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnOpen.Text = "Open";
            this.toolStripBtnOpen.Click += new System.EventHandler(this.OpenText);
            // 
            // toolStripSplitBtnSave
            // 
            this.toolStripSplitBtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitBtnSave.DropDownButtonWidth = 15;
            this.toolStripSplitBtnSave.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sourceBtnSaveSource,
            this.sourceBtnSaveProcessed});
            this.toolStripSplitBtnSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitBtnSave.Image")));
            this.toolStripSplitBtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitBtnSave.Name = "toolStripSplitBtnSave";
            this.toolStripSplitBtnSave.Size = new System.Drawing.Size(36, 22);
            this.toolStripSplitBtnSave.Text = "Save as...";
            // 
            // sourceBtnSaveSource
            // 
            this.sourceBtnSaveSource.Image = ((System.Drawing.Image)(resources.GetObject("sourceBtnSaveSource.Image")));
            this.sourceBtnSaveSource.Name = "sourceBtnSaveSource";
            this.sourceBtnSaveSource.Size = new System.Drawing.Size(149, 22);
            this.sourceBtnSaveSource.Text = "Source text";
            this.sourceBtnSaveSource.Click += new System.EventHandler(this.SaveText);
            // 
            // sourceBtnSaveProcessed
            // 
            this.sourceBtnSaveProcessed.Image = ((System.Drawing.Image)(resources.GetObject("sourceBtnSaveProcessed.Image")));
            this.sourceBtnSaveProcessed.Name = "sourceBtnSaveProcessed";
            this.sourceBtnSaveProcessed.Size = new System.Drawing.Size(149, 22);
            this.sourceBtnSaveProcessed.Text = "Processed text";
            this.sourceBtnSaveProcessed.Click += new System.EventHandler(this.SaveText);
            // 
            // toolStripBtnEncryption
            // 
            this.toolStripBtnEncryption.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripBtnEncryption.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnEncryption.DropDownButtonWidth = 15;
            this.toolStripBtnEncryption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEncoding,
            this.btnDecoding});
            this.toolStripBtnEncryption.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnEncryption.Image")));
            this.toolStripBtnEncryption.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnEncryption.Margin = new System.Windows.Forms.Padding(0, 1, 3, 2);
            this.toolStripBtnEncryption.Name = "toolStripBtnEncryption";
            this.toolStripBtnEncryption.Size = new System.Drawing.Size(36, 22);
            this.toolStripBtnEncryption.Text = "Encryption";
            // 
            // btnEncoding
            // 
            this.btnEncoding.Image = ((System.Drawing.Image)(resources.GetObject("btnEncoding.Image")));
            this.btnEncoding.Name = "btnEncoding";
            this.btnEncoding.Size = new System.Drawing.Size(125, 22);
            this.btnEncoding.Text = "Encoding";
            this.btnEncoding.Click += new System.EventHandler(this.ButtonEncryptClick);
            // 
            // btnDecoding
            // 
            this.btnDecoding.Image = ((System.Drawing.Image)(resources.GetObject("btnDecoding.Image")));
            this.btnDecoding.Name = "btnDecoding";
            this.btnDecoding.Size = new System.Drawing.Size(125, 22);
            this.btnDecoding.Text = "Decoding";
            this.btnDecoding.Click += new System.EventHandler(this.ButtonEncryptClick);
            // 
            // toolStripBtnPrcToSrc
            // 
            this.toolStripBtnPrcToSrc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnPrcToSrc.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnPrcToSrc.Image")));
            this.toolStripBtnPrcToSrc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnPrcToSrc.Name = "toolStripBtnPrcToSrc";
            this.toolStripBtnPrcToSrc.Size = new System.Drawing.Size(23, 22);
            this.toolStripBtnPrcToSrc.Text = "Move processed to source text";
            this.toolStripBtnPrcToSrc.Click += new System.EventHandler(this.toolStripBtnPrcToSrcClick);
            // 
            // frequencySourceText
            // 
            this.frequencySourceText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frequencySourceText.Location = new System.Drawing.Point(3, 3);
            this.frequencySourceText.MaxLength = 999999999;
            this.frequencySourceText.Multiline = true;
            this.frequencySourceText.Name = "frequencySourceText";
            this.frequencySourceText.Size = new System.Drawing.Size(713, 312);
            this.frequencySourceText.TabIndex = 0;
            // 
            // splitFrequencyLettersChr
            // 
            this.splitFrequencyLettersChr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitFrequencyLettersChr.Location = new System.Drawing.Point(3, 3);
            this.splitFrequencyLettersChr.Name = "splitFrequencyLettersChr";
            this.splitFrequencyLettersChr.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitFrequencyLettersChr.Panel1
            // 
            this.splitFrequencyLettersChr.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitFrequencyLettersChr.Panel2
            // 
            this.splitFrequencyLettersChr.Panel2.Controls.Add(this.groupBox2);
            this.splitFrequencyLettersChr.Size = new System.Drawing.Size(713, 312);
            this.splitFrequencyLettersChr.SplitterDistance = 132;
            this.splitFrequencyLettersChr.SplitterWidth = 10;
            this.splitFrequencyLettersChr.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(713, 132);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Frequency letters";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chart1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(713, 170);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Frequency chart letters";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 16);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(707, 151);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(707, 113);
            this.dataGridView1.TabIndex = 0;
            // 
            // ProjectSecurity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 422);
            this.Controls.Add(this.toolStripFastMenu);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.projectContent);
            this.Name = "ProjectSecurity";
            this.Text = "ProjectSecurity";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
            this.frequencyContent.ResumeLayout(false);
            this.tabLoadText.ResumeLayout(false);
            this.tabLoadText.PerformLayout();
            this.tabFrequencyLit.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.toolStripFastMenu.ResumeLayout(false);
            this.toolStripFastMenu.PerformLayout();
            this.splitFrequencyLettersChr.Panel1.ResumeLayout(false);
            this.splitFrequencyLettersChr.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitFrequencyLettersChr)).EndInit();
            this.splitFrequencyLettersChr.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuFile;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.TabControl frequencyContent;
        private System.Windows.Forms.TabPage tabLoadText;
        private System.Windows.Forms.TabPage tabFrequencyLit;
        private System.Windows.Forms.TabPage tabFrequencyPairsLit;
        private System.Windows.Forms.OpenFileDialog openFileText;
        private System.Windows.Forms.SaveFileDialog saveFileText;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuSave;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuSaveSource;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuSaveProcessed;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuExit;
        private System.Windows.Forms.ToolStrip toolStripFastMenu;
        private System.Windows.Forms.ToolStripButton toolStripBtnOpen;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitBtnSave;
        private System.Windows.Forms.ToolStripMenuItem sourceBtnSaveSource;
        private System.Windows.Forms.ToolStripMenuItem sourceBtnSaveProcessed;
        private System.Windows.Forms.ToolStripSplitButton toolStripBtnEncryption;
        private System.Windows.Forms.ToolStripMenuItem btnEncoding;
        private System.Windows.Forms.ToolStripMenuItem btnDecoding;
        private System.Windows.Forms.ToolStripButton toolStripBtnPrcToSrc;
        private System.Windows.Forms.TextBox frequencySourceText;
        private System.Windows.Forms.SplitContainer splitFrequencyLettersChr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

