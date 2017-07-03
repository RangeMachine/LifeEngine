namespace LifeEngine
{
    partial class FormLife
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLife));
            this.m_buttonStart = new System.Windows.Forms.Button();
            this.m_buttonStop = new System.Windows.Forms.Button();
            this.m_buttonRandomize = new System.Windows.Forms.Button();
            this.m_buttonClear = new System.Windows.Forms.Button();
            this.m_buttonReset = new System.Windows.Forms.Button();
            this.m_rulesCombobox = new System.Windows.Forms.ComboBox();
            this.m_buttonStep = new System.Windows.Forms.Button();
            this.m_panelScroller = new System.Windows.Forms.Panel();
            this.m_lifeGrid = new LifeEngine.LifeGrid();
            this.m_buttonZoomOut = new System.Windows.Forms.Button();
            this.m_buttonZoomIn = new System.Windows.Forms.Button();
            this.lblZoom = new System.Windows.Forms.Label();
            this.m_labelZoomCount = new System.Windows.Forms.Label();
            this.m_labelStepNumber = new System.Windows.Forms.Label();
            this.m_labelPopulation = new System.Windows.Forms.Label();
            this.m_menuStrip = new System.Windows.Forms.MenuStrip();
            this.m_menuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.m_menuGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.m_menuLiveColor = new System.Windows.Forms.ToolStripMenuItem();
            this.m_menuDeadColor = new System.Windows.Forms.ToolStripMenuItem();
            this.m_menuHistoryColor = new System.Windows.Forms.ToolStripMenuItem();
            this.m_menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.m_menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRules = new System.Windows.Forms.Label();
            this.m_sizeCombobox = new System.Windows.Forms.ComboBox();
            this.m_sizeLabel = new System.Windows.Forms.Label();
            this.m_speedCombobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_panelScroller.SuspendLayout();
            this.m_menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_buttonStart
            // 
            this.m_buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_buttonStart.Location = new System.Drawing.Point(2, 630);
            this.m_buttonStart.Name = "m_buttonStart";
            this.m_buttonStart.Size = new System.Drawing.Size(75, 23);
            this.m_buttonStart.TabIndex = 0;
            this.m_buttonStart.Text = "&Start";
            this.m_buttonStart.UseVisualStyleBackColor = true;
            // 
            // m_buttonStop
            // 
            this.m_buttonStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_buttonStop.Location = new System.Drawing.Point(83, 630);
            this.m_buttonStop.Name = "m_buttonStop";
            this.m_buttonStop.Size = new System.Drawing.Size(75, 23);
            this.m_buttonStop.TabIndex = 1;
            this.m_buttonStop.Text = "S&top";
            this.m_buttonStop.UseVisualStyleBackColor = true;
            // 
            // m_buttonRandomize
            // 
            this.m_buttonRandomize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_buttonRandomize.Location = new System.Drawing.Point(164, 659);
            this.m_buttonRandomize.Name = "m_buttonRandomize";
            this.m_buttonRandomize.Size = new System.Drawing.Size(75, 23);
            this.m_buttonRandomize.TabIndex = 6;
            this.m_buttonRandomize.Text = "R&andomize";
            this.m_buttonRandomize.UseVisualStyleBackColor = true;
            // 
            // m_buttonClear
            // 
            this.m_buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_buttonClear.Location = new System.Drawing.Point(83, 659);
            this.m_buttonClear.Name = "m_buttonClear";
            this.m_buttonClear.Size = new System.Drawing.Size(75, 23);
            this.m_buttonClear.TabIndex = 5;
            this.m_buttonClear.Text = "&Clear";
            this.m_buttonClear.UseVisualStyleBackColor = true;
            // 
            // m_buttonReset
            // 
            this.m_buttonReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_buttonReset.Location = new System.Drawing.Point(2, 659);
            this.m_buttonReset.Name = "m_buttonReset";
            this.m_buttonReset.Size = new System.Drawing.Size(75, 23);
            this.m_buttonReset.TabIndex = 4;
            this.m_buttonReset.Text = "&Reset";
            this.m_buttonReset.UseVisualStyleBackColor = true;
            // 
            // m_rulesCombobox
            // 
            this.m_rulesCombobox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_rulesCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_rulesCombobox.DropDownWidth = 200;
            this.m_rulesCombobox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_rulesCombobox.FormattingEnabled = true;
            this.m_rulesCombobox.Location = new System.Drawing.Point(402, 1);
            this.m_rulesCombobox.MaxDropDownItems = 10;
            this.m_rulesCombobox.Name = "m_rulesCombobox";
            this.m_rulesCombobox.Size = new System.Drawing.Size(200, 21);
            this.m_rulesCombobox.TabIndex = 3;
            // 
            // m_buttonStep
            // 
            this.m_buttonStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_buttonStep.Location = new System.Drawing.Point(164, 630);
            this.m_buttonStep.Name = "m_buttonStep";
            this.m_buttonStep.Size = new System.Drawing.Size(75, 23);
            this.m_buttonStep.TabIndex = 2;
            this.m_buttonStep.Text = "Ste&p";
            this.m_buttonStep.UseVisualStyleBackColor = true;
            // 
            // m_panelScroller
            // 
            this.m_panelScroller.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_panelScroller.AutoScroll = true;
            this.m_panelScroller.CausesValidation = false;
            this.m_panelScroller.Controls.Add(this.m_lifeGrid);
            this.m_panelScroller.Location = new System.Drawing.Point(2, 24);
            this.m_panelScroller.Name = "m_panelScroller";
            this.m_panelScroller.Size = new System.Drawing.Size(600, 600);
            this.m_panelScroller.TabIndex = 7;
            // 
            // m_lifeGrid
            // 
            this.m_lifeGrid.CellColorAlive = System.Drawing.Color.DeepSkyBlue;
            this.m_lifeGrid.CellColorDead = System.Drawing.Color.White;
            this.m_lifeGrid.CellColorHistory = System.Drawing.Color.LightGreen;
            this.m_lifeGrid.Columns = 100;
            this.m_lifeGrid.LinesSize = 1F;
            this.m_lifeGrid.LinesVisible = false;
            this.m_lifeGrid.Location = new System.Drawing.Point(0, 0);
            this.m_lifeGrid.Name = "m_lifeGrid";
            this.m_lifeGrid.Rows = 100;
            this.m_lifeGrid.Size = new System.Drawing.Size(600, 600);
            this.m_lifeGrid.TabIndex = 15;
            this.m_lifeGrid.TabStop = false;
            // 
            // m_buttonZoomOut
            // 
            this.m_buttonZoomOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_buttonZoomOut.Location = new System.Drawing.Point(554, 659);
            this.m_buttonZoomOut.Name = "m_buttonZoomOut";
            this.m_buttonZoomOut.Size = new System.Drawing.Size(23, 23);
            this.m_buttonZoomOut.TabIndex = 8;
            this.m_buttonZoomOut.Text = "-";
            this.m_buttonZoomOut.UseVisualStyleBackColor = true;
            // 
            // m_buttonZoomIn
            // 
            this.m_buttonZoomIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_buttonZoomIn.Location = new System.Drawing.Point(525, 659);
            this.m_buttonZoomIn.Name = "m_buttonZoomIn";
            this.m_buttonZoomIn.Size = new System.Drawing.Size(23, 23);
            this.m_buttonZoomIn.TabIndex = 9;
            this.m_buttonZoomIn.Text = "+";
            this.m_buttonZoomIn.UseVisualStyleBackColor = true;
            // 
            // lblZoom
            // 
            this.lblZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblZoom.AutoSize = true;
            this.lblZoom.Location = new System.Drawing.Point(525, 635);
            this.lblZoom.Name = "lblZoom";
            this.lblZoom.Size = new System.Drawing.Size(71, 13);
            this.lblZoom.TabIndex = 10;
            this.lblZoom.Text = "Zoom In/Out:";
            this.lblZoom.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // m_labelZoomCount
            // 
            this.m_labelZoomCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_labelZoomCount.AutoSize = true;
            this.m_labelZoomCount.Location = new System.Drawing.Point(583, 664);
            this.m_labelZoomCount.Name = "m_labelZoomCount";
            this.m_labelZoomCount.Size = new System.Drawing.Size(13, 13);
            this.m_labelZoomCount.TabIndex = 11;
            this.m_labelZoomCount.Text = "1";
            // 
            // m_labelStepNumber
            // 
            this.m_labelStepNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_labelStepNumber.AutoSize = true;
            this.m_labelStepNumber.Location = new System.Drawing.Point(368, 635);
            this.m_labelStepNumber.Name = "m_labelStepNumber";
            this.m_labelStepNumber.Size = new System.Drawing.Size(71, 13);
            this.m_labelStepNumber.TabIndex = 12;
            this.m_labelStepNumber.Text = "Generation: 0";
            // 
            // m_labelPopulation
            // 
            this.m_labelPopulation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_labelPopulation.AutoSize = true;
            this.m_labelPopulation.Location = new System.Drawing.Point(368, 664);
            this.m_labelPopulation.Name = "m_labelPopulation";
            this.m_labelPopulation.Size = new System.Drawing.Size(69, 13);
            this.m_labelPopulation.TabIndex = 13;
            this.m_labelPopulation.Text = "Population: 0";
            // 
            // m_menuStrip
            // 
            this.m_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_menuOptions,
            this.m_menuHelp});
            this.m_menuStrip.Location = new System.Drawing.Point(0, 0);
            this.m_menuStrip.Name = "m_menuStrip";
            this.m_menuStrip.Size = new System.Drawing.Size(604, 24);
            this.m_menuStrip.TabIndex = 14;
            this.m_menuStrip.Text = "m_menuStrip";
            // 
            // m_menuOptions
            // 
            this.m_menuOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_menuGrid,
            this.m_menuLiveColor,
            this.m_menuDeadColor,
            this.m_menuHistoryColor});
            this.m_menuOptions.Name = "m_menuOptions";
            this.m_menuOptions.Size = new System.Drawing.Size(61, 20);
            this.m_menuOptions.Text = "&Options";
            // 
            // m_menuGrid
            // 
            this.m_menuGrid.Checked = true;
            this.m_menuGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.m_menuGrid.Image = global::LifeEngine.Properties.Resources.IconGrid;
            this.m_menuGrid.Name = "m_menuGrid";
            this.m_menuGrid.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.m_menuGrid.Size = new System.Drawing.Size(170, 22);
            this.m_menuGrid.Text = "Show &Grid";
            this.m_menuGrid.Click += new System.EventHandler(this.MenuOptionsShowGridClick);
            // 
            // m_menuLiveColor
            // 
            this.m_menuLiveColor.Image = global::LifeEngine.Properties.Resources.IconColor;
            this.m_menuLiveColor.Name = "m_menuLiveColor";
            this.m_menuLiveColor.Size = new System.Drawing.Size(170, 22);
            this.m_menuLiveColor.Text = "&Live Cell Color";
            this.m_menuLiveColor.Click += new System.EventHandler(this.MenuOptionsLiveCellColorClick);
            // 
            // m_menuDeadColor
            // 
            this.m_menuDeadColor.Image = global::LifeEngine.Properties.Resources.IconColor;
            this.m_menuDeadColor.Name = "m_menuDeadColor";
            this.m_menuDeadColor.Size = new System.Drawing.Size(170, 22);
            this.m_menuDeadColor.Text = "&Dead Cell Color";
            this.m_menuDeadColor.Click += new System.EventHandler(this.MenuOptionsDeadCellColorClick);
            // 
            // m_menuHistoryColor
            // 
            this.m_menuHistoryColor.Image = global::LifeEngine.Properties.Resources.IconColor;
            this.m_menuHistoryColor.Name = "m_menuHistoryColor";
            this.m_menuHistoryColor.Size = new System.Drawing.Size(170, 22);
            this.m_menuHistoryColor.Text = "&History Cell Color";
            this.m_menuHistoryColor.Click += new System.EventHandler(this.MenuOptionsHistoryCellColorClick);
            // 
            // m_menuHelp
            // 
            this.m_menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_menuAbout});
            this.m_menuHelp.Name = "m_menuHelp";
            this.m_menuHelp.Size = new System.Drawing.Size(44, 20);
            this.m_menuHelp.Text = "Help";
            // 
            // m_menuAbout
            // 
            this.m_menuAbout.Image = global::LifeEngine.Properties.Resources.IconHelp;
            this.m_menuAbout.Name = "m_menuAbout";
            this.m_menuAbout.Size = new System.Drawing.Size(152, 22);
            this.m_menuAbout.Text = "About";
            this.m_menuAbout.Click += new System.EventHandler(this.MenuHelpAboutClick);
            // 
            // lblRules
            // 
            this.lblRules.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRules.AutoSize = true;
            this.lblRules.Location = new System.Drawing.Point(359, 5);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(37, 13);
            this.lblRules.TabIndex = 15;
            this.lblRules.Text = "Rules:";
            this.lblRules.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // m_sizeCombobox
            // 
            this.m_sizeCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_sizeCombobox.FormattingEnabled = true;
            this.m_sizeCombobox.Location = new System.Drawing.Point(304, 632);
            this.m_sizeCombobox.Name = "m_sizeCombobox";
            this.m_sizeCombobox.Size = new System.Drawing.Size(58, 21);
            this.m_sizeCombobox.TabIndex = 16;
            this.m_sizeCombobox.SelectedIndexChanged += new System.EventHandler(this.SizeComboboxSelectedIndexChanged);
            // 
            // m_sizeLabel
            // 
            this.m_sizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_sizeLabel.AutoSize = true;
            this.m_sizeLabel.Location = new System.Drawing.Point(268, 635);
            this.m_sizeLabel.Name = "m_sizeLabel";
            this.m_sizeLabel.Size = new System.Drawing.Size(30, 13);
            this.m_sizeLabel.TabIndex = 17;
            this.m_sizeLabel.Text = "Size:";
            this.m_sizeLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // m_speedCombobox
            // 
            this.m_speedCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_speedCombobox.FormattingEnabled = true;
            this.m_speedCombobox.Location = new System.Drawing.Point(304, 661);
            this.m_speedCombobox.Name = "m_speedCombobox";
            this.m_speedCombobox.Size = new System.Drawing.Size(58, 21);
            this.m_speedCombobox.TabIndex = 18;
            this.m_speedCombobox.SelectedIndexChanged += new System.EventHandler(this.SpeedComboboxSelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 666);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Speed:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // FormLife
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 688);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_speedCombobox);
            this.Controls.Add(this.m_sizeLabel);
            this.Controls.Add(this.m_sizeCombobox);
            this.Controls.Add(this.lblRules);
            this.Controls.Add(this.m_labelPopulation);
            this.Controls.Add(this.m_labelStepNumber);
            this.Controls.Add(this.m_labelZoomCount);
            this.Controls.Add(this.lblZoom);
            this.Controls.Add(this.m_buttonZoomIn);
            this.Controls.Add(this.m_buttonZoomOut);
            this.Controls.Add(this.m_buttonStep);
            this.Controls.Add(this.m_rulesCombobox);
            this.Controls.Add(this.m_buttonReset);
            this.Controls.Add(this.m_buttonClear);
            this.Controls.Add(this.m_buttonRandomize);
            this.Controls.Add(this.m_buttonStop);
            this.Controls.Add(this.m_buttonStart);
            this.Controls.Add(this.m_panelScroller);
            this.Controls.Add(this.m_menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.m_menuStrip;
            this.MaximizeBox = false;
            this.Name = "FormLife";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game of Life";
            this.m_panelScroller.ResumeLayout(false);
            this.m_menuStrip.ResumeLayout(false);
            this.m_menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_buttonStart;
        private System.Windows.Forms.Button m_buttonStop;
        private System.Windows.Forms.Button m_buttonRandomize;
        private System.Windows.Forms.Button m_buttonClear;
        private System.Windows.Forms.Button m_buttonReset;
        private System.Windows.Forms.ComboBox m_rulesCombobox;
        private System.Windows.Forms.Button m_buttonStep;
        private System.Windows.Forms.Panel m_panelScroller;
        private System.Windows.Forms.Button m_buttonZoomOut;
        private System.Windows.Forms.Button m_buttonZoomIn;
        private System.Windows.Forms.Label lblZoom;
        private System.Windows.Forms.Label m_labelZoomCount;
        private System.Windows.Forms.Label m_labelStepNumber;
        private System.Windows.Forms.Label m_labelPopulation;
        private System.Windows.Forms.MenuStrip m_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem m_menuOptions;
        private System.Windows.Forms.ToolStripMenuItem m_menuGrid;
        private System.Windows.Forms.ToolStripMenuItem m_menuLiveColor;
        private System.Windows.Forms.ToolStripMenuItem m_menuDeadColor;
        private LifeEngine.LifeGrid m_lifeGrid;
        private System.Windows.Forms.Label lblRules;
        private System.Windows.Forms.ToolStripMenuItem m_menuHelp;
        private System.Windows.Forms.ToolStripMenuItem m_menuAbout;
        private System.Windows.Forms.ComboBox m_sizeCombobox;
        private System.Windows.Forms.ToolStripMenuItem m_menuHistoryColor;
        private System.Windows.Forms.Label m_sizeLabel;
        private System.Windows.Forms.ComboBox m_speedCombobox;
        private System.Windows.Forms.Label label1;
    }
}