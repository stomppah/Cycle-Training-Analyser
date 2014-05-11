namespace Analyser
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.exerciseDataPanel = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkedSmodeList = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.totalDistanceLabel = new System.Windows.Forms.Label();
            this.averageSpeedLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.maxSpeedLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.averageHeartRateLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.minHeartRateLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.maxHeartRateLabel = new System.Windows.Forms.Label();
            this.durationLabel = new System.Windows.Forms.Label();
            this.averagePowerLabel = new System.Windows.Forms.Label();
            this.maxPowerLabel = new System.Windows.Forms.Label();
            this.averageAltitudeLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.maxAltitudeLabel = new System.Windows.Forms.Label();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imperialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metricToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuStrip.SuspendLayout();
            this.exerciseDataPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(1008, 24);
            this.MainMenuStrip.TabIndex = 0;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + O";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // exerciseDataPanel
            // 
            this.exerciseDataPanel.Controls.Add(this.maxAltitudeLabel);
            this.exerciseDataPanel.Controls.Add(this.label14);
            this.exerciseDataPanel.Controls.Add(this.tabControl1);
            this.exerciseDataPanel.Controls.Add(this.checkedSmodeList);
            this.exerciseDataPanel.Controls.Add(this.averageAltitudeLabel);
            this.exerciseDataPanel.Controls.Add(this.maxPowerLabel);
            this.exerciseDataPanel.Controls.Add(this.averagePowerLabel);
            this.exerciseDataPanel.Controls.Add(this.durationLabel);
            this.exerciseDataPanel.Controls.Add(this.maxHeartRateLabel);
            this.exerciseDataPanel.Controls.Add(this.timeLabel);
            this.exerciseDataPanel.Controls.Add(this.minHeartRateLabel);
            this.exerciseDataPanel.Controls.Add(this.dateLabel);
            this.exerciseDataPanel.Controls.Add(this.averageHeartRateLabel);
            this.exerciseDataPanel.Controls.Add(this.label12);
            this.exerciseDataPanel.Controls.Add(this.label11);
            this.exerciseDataPanel.Controls.Add(this.maxSpeedLabel);
            this.exerciseDataPanel.Controls.Add(this.label10);
            this.exerciseDataPanel.Controls.Add(this.averageSpeedLabel);
            this.exerciseDataPanel.Controls.Add(this.totalDistanceLabel);
            this.exerciseDataPanel.Controls.Add(this.label9);
            this.exerciseDataPanel.Controls.Add(this.label8);
            this.exerciseDataPanel.Controls.Add(this.label7);
            this.exerciseDataPanel.Controls.Add(this.label6);
            this.exerciseDataPanel.Controls.Add(this.label5);
            this.exerciseDataPanel.Controls.Add(this.label4);
            this.exerciseDataPanel.Controls.Add(this.label3);
            this.exerciseDataPanel.Controls.Add(this.label2);
            this.exerciseDataPanel.Controls.Add(this.label1);
            this.exerciseDataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exerciseDataPanel.Location = new System.Drawing.Point(0, 24);
            this.exerciseDataPanel.Margin = new System.Windows.Forms.Padding(10);
            this.exerciseDataPanel.Name = "exerciseDataPanel";
            this.exerciseDataPanel.Size = new System.Drawing.Size(1008, 673);
            this.exerciseDataPanel.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1008, 570);
            this.tabControl1.TabIndex = 32;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.zedGraphControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1000, 544);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Graph View";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.BackColor = System.Drawing.Color.Transparent;
            this.zedGraphControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.zedGraphControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControl1.Location = new System.Drawing.Point(3, 3);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(994, 538);
            this.zedGraphControl1.TabIndex = 31;
            this.zedGraphControl1.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1000, 551);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "List View";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(994, 545);
            this.dataGridView1.TabIndex = 31;
            // 
            // checkedSmodeList
            // 
            this.checkedSmodeList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedSmodeList.Enabled = false;
            this.checkedSmodeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedSmodeList.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkedSmodeList.FormattingEnabled = true;
            this.checkedSmodeList.Items.AddRange(new object[] {
            "Speed",
            "Cadence",
            "Altitude",
            "Power",
            "Imperial Measurements?"});
            this.checkedSmodeList.Location = new System.Drawing.Point(799, 573);
            this.checkedSmodeList.Name = "checkedSmodeList";
            this.checkedSmodeList.Size = new System.Drawing.Size(206, 94);
            this.checkedSmodeList.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 648);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Distance:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 573);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Avg Speed:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(193, 598);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Max. Speed:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(382, 573);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Avg. Heart Rate:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(384, 598);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Min. Heart Rate:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(381, 622);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Max. Heart Rate:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(590, 573);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Avg. Power:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(589, 598);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Max. Power:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(187, 622);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Avg. Altitude:";
            // 
            // totalDistanceLabel
            // 
            this.totalDistanceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.totalDistanceLabel.AutoSize = true;
            this.totalDistanceLabel.BackColor = System.Drawing.SystemColors.Control;
            this.totalDistanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.totalDistanceLabel.Location = new System.Drawing.Point(73, 648);
            this.totalDistanceLabel.Name = "totalDistanceLabel";
            this.totalDistanceLabel.Size = new System.Drawing.Size(0, 13);
            this.totalDistanceLabel.TabIndex = 22;
            // 
            // averageSpeedLabel
            // 
            this.averageSpeedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.averageSpeedLabel.AutoSize = true;
            this.averageSpeedLabel.BackColor = System.Drawing.SystemColors.Control;
            this.averageSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.averageSpeedLabel.Location = new System.Drawing.Point(271, 573);
            this.averageSpeedLabel.Name = "averageSpeedLabel";
            this.averageSpeedLabel.Size = new System.Drawing.Size(0, 13);
            this.averageSpeedLabel.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(29, 573);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Date:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // maxSpeedLabel
            // 
            this.maxSpeedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.maxSpeedLabel.AutoSize = true;
            this.maxSpeedLabel.BackColor = System.Drawing.SystemColors.Control;
            this.maxSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.maxSpeedLabel.Location = new System.Drawing.Point(271, 598);
            this.maxSpeedLabel.Name = "maxSpeedLabel";
            this.maxSpeedLabel.Size = new System.Drawing.Size(0, 13);
            this.maxSpeedLabel.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(29, 598);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Time:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(8, 622);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Duration:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // averageHeartRateLabel
            // 
            this.averageHeartRateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.averageHeartRateLabel.AutoSize = true;
            this.averageHeartRateLabel.BackColor = System.Drawing.SystemColors.Control;
            this.averageHeartRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.averageHeartRateLabel.Location = new System.Drawing.Point(485, 573);
            this.averageHeartRateLabel.Name = "averageHeartRateLabel";
            this.averageHeartRateLabel.Size = new System.Drawing.Size(0, 13);
            this.averageHeartRateLabel.TabIndex = 25;
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.SystemColors.Control;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dateLabel.Location = new System.Drawing.Point(73, 573);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(0, 13);
            this.dateLabel.TabIndex = 19;
            // 
            // minHeartRateLabel
            // 
            this.minHeartRateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.minHeartRateLabel.AutoSize = true;
            this.minHeartRateLabel.BackColor = System.Drawing.SystemColors.Control;
            this.minHeartRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.minHeartRateLabel.Location = new System.Drawing.Point(485, 598);
            this.minHeartRateLabel.Name = "minHeartRateLabel";
            this.minHeartRateLabel.Size = new System.Drawing.Size(0, 13);
            this.minHeartRateLabel.TabIndex = 26;
            // 
            // timeLabel
            // 
            this.timeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.timeLabel.Location = new System.Drawing.Point(73, 598);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(0, 13);
            this.timeLabel.TabIndex = 20;
            // 
            // maxHeartRateLabel
            // 
            this.maxHeartRateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.maxHeartRateLabel.AutoSize = true;
            this.maxHeartRateLabel.BackColor = System.Drawing.SystemColors.Control;
            this.maxHeartRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.maxHeartRateLabel.Location = new System.Drawing.Point(485, 622);
            this.maxHeartRateLabel.Name = "maxHeartRateLabel";
            this.maxHeartRateLabel.Size = new System.Drawing.Size(0, 13);
            this.maxHeartRateLabel.TabIndex = 27;
            // 
            // durationLabel
            // 
            this.durationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.durationLabel.AutoSize = true;
            this.durationLabel.BackColor = System.Drawing.SystemColors.Control;
            this.durationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.durationLabel.Location = new System.Drawing.Point(73, 622);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(0, 13);
            this.durationLabel.TabIndex = 21;
            // 
            // averagePowerLabel
            // 
            this.averagePowerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.averagePowerLabel.AutoSize = true;
            this.averagePowerLabel.BackColor = System.Drawing.SystemColors.Control;
            this.averagePowerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.averagePowerLabel.Location = new System.Drawing.Point(666, 573);
            this.averagePowerLabel.Name = "averagePowerLabel";
            this.averagePowerLabel.Size = new System.Drawing.Size(0, 13);
            this.averagePowerLabel.TabIndex = 28;
            // 
            // maxPowerLabel
            // 
            this.maxPowerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.maxPowerLabel.AutoSize = true;
            this.maxPowerLabel.BackColor = System.Drawing.SystemColors.Control;
            this.maxPowerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.maxPowerLabel.Location = new System.Drawing.Point(666, 598);
            this.maxPowerLabel.Name = "maxPowerLabel";
            this.maxPowerLabel.Size = new System.Drawing.Size(0, 13);
            this.maxPowerLabel.TabIndex = 29;
            // 
            // averageAltitudeLabel
            // 
            this.averageAltitudeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.averageAltitudeLabel.AutoSize = true;
            this.averageAltitudeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.averageAltitudeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.averageAltitudeLabel.Location = new System.Drawing.Point(271, 622);
            this.averageAltitudeLabel.Name = "averageAltitudeLabel";
            this.averageAltitudeLabel.Size = new System.Drawing.Size(0, 13);
            this.averageAltitudeLabel.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(186, 648);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "Max. Altitude:";
            // 
            // maxAltitudeLabel
            // 
            this.maxAltitudeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.maxAltitudeLabel.AutoSize = true;
            this.maxAltitudeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.maxAltitudeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.maxAltitudeLabel.Location = new System.Drawing.Point(271, 648);
            this.maxAltitudeLabel.Name = "maxAltitudeLabel";
            this.maxAltitudeLabel.Size = new System.Drawing.Size(0, 13);
            this.maxAltitudeLabel.TabIndex = 34;
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unitsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // unitsToolStripMenuItem
            // 
            this.unitsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imperialToolStripMenuItem,
            this.metricToolStripMenuItem});
            this.unitsToolStripMenuItem.Name = "unitsToolStripMenuItem";
            this.unitsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.unitsToolStripMenuItem.Text = "Units";
            // 
            // imperialToolStripMenuItem
            // 
            this.imperialToolStripMenuItem.Name = "imperialToolStripMenuItem";
            this.imperialToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.imperialToolStripMenuItem.Text = "Imperial";
            // 
            // metricToolStripMenuItem
            // 
            this.metricToolStripMenuItem.Name = "metricToolStripMenuItem";
            this.metricToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.metricToolStripMenuItem.Text = "Metric";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 697);
            this.Controls.Add(this.exerciseDataPanel);
            this.Controls.Add(this.MainMenuStrip);
            this.MinimumSize = new System.Drawing.Size(1024, 726);
            this.Name = "MainForm";
            this.Text = "Cycle Data Analyser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.exerciseDataPanel.ResumeLayout(false);
            this.exerciseDataPanel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Panel exerciseDataPanel;
        private System.Windows.Forms.CheckedListBox checkedSmodeList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label maxAltitudeLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label averageAltitudeLabel;
        private System.Windows.Forms.Label maxPowerLabel;
        private System.Windows.Forms.Label averagePowerLabel;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.Label maxHeartRateLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label minHeartRateLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label averageHeartRateLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label maxSpeedLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label averageSpeedLabel;
        private System.Windows.Forms.Label totalDistanceLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imperialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metricToolStripMenuItem;
    }
}

