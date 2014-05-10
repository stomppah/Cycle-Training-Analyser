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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.exerciseDataPanel = new System.Windows.Forms.Panel();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.averageAltitudeLabel = new System.Windows.Forms.Label();
            this.maxPowerLabel = new System.Windows.Forms.Label();
            this.averagePowerLabel = new System.Windows.Forms.Label();
            this.MaxHeartRateLabel = new System.Windows.Forms.Label();
            this.minHeartRateLabel = new System.Windows.Forms.Label();
            this.averageHeartRateLabel = new System.Windows.Forms.Label();
            this.maxSpeedLabel = new System.Windows.Forms.Label();
            this.averageSpeedLabel = new System.Windows.Forms.Label();
            this.totalDistanceLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.checkedSmodeList = new System.Windows.Forms.CheckedListBox();
            this.durationLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.MainMenuStrip.SuspendLayout();
            this.exerciseDataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
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
            this.exerciseDataPanel.Controls.Add(this.tabControl1);
            this.exerciseDataPanel.Controls.Add(this.checkedSmodeList);
            this.exerciseDataPanel.Controls.Add(this.nameLabel);
            this.exerciseDataPanel.Controls.Add(this.averageAltitudeLabel);
            this.exerciseDataPanel.Controls.Add(this.label14);
            this.exerciseDataPanel.Controls.Add(this.maxPowerLabel);
            this.exerciseDataPanel.Controls.Add(this.averagePowerLabel);
            this.exerciseDataPanel.Controls.Add(this.durationLabel);
            this.exerciseDataPanel.Controls.Add(this.MaxHeartRateLabel);
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
            this.exerciseDataPanel.Size = new System.Drawing.Size(1008, 664);
            this.exerciseDataPanel.TabIndex = 6;
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
            this.zedGraphControl1.Size = new System.Drawing.Size(1149, 571);
            this.zedGraphControl1.TabIndex = 31;
            this.zedGraphControl1.Visible = false;
            // 
            // averageAltitudeLabel
            // 
            this.averageAltitudeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.averageAltitudeLabel.AutoSize = true;
            this.averageAltitudeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.averageAltitudeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.averageAltitudeLabel.Location = new System.Drawing.Point(930, 638);
            this.averageAltitudeLabel.Name = "averageAltitudeLabel";
            this.averageAltitudeLabel.Size = new System.Drawing.Size(0, 13);
            this.averageAltitudeLabel.TabIndex = 30;
            // 
            // maxPowerLabel
            // 
            this.maxPowerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.maxPowerLabel.AutoSize = true;
            this.maxPowerLabel.BackColor = System.Drawing.SystemColors.Control;
            this.maxPowerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.maxPowerLabel.Location = new System.Drawing.Point(930, 604);
            this.maxPowerLabel.Name = "maxPowerLabel";
            this.maxPowerLabel.Size = new System.Drawing.Size(0, 13);
            this.maxPowerLabel.TabIndex = 29;
            // 
            // averagePowerLabel
            // 
            this.averagePowerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.averagePowerLabel.AutoSize = true;
            this.averagePowerLabel.BackColor = System.Drawing.SystemColors.Control;
            this.averagePowerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.averagePowerLabel.Location = new System.Drawing.Point(930, 568);
            this.averagePowerLabel.Name = "averagePowerLabel";
            this.averagePowerLabel.Size = new System.Drawing.Size(0, 13);
            this.averagePowerLabel.TabIndex = 28;
            // 
            // MaxHeartRateLabel
            // 
            this.MaxHeartRateLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.MaxHeartRateLabel.AutoSize = true;
            this.MaxHeartRateLabel.BackColor = System.Drawing.SystemColors.Control;
            this.MaxHeartRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MaxHeartRateLabel.Location = new System.Drawing.Point(866, 638);
            this.MaxHeartRateLabel.Name = "MaxHeartRateLabel";
            this.MaxHeartRateLabel.Size = new System.Drawing.Size(0, 13);
            this.MaxHeartRateLabel.TabIndex = 27;
            // 
            // minHeartRateLabel
            // 
            this.minHeartRateLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.minHeartRateLabel.AutoSize = true;
            this.minHeartRateLabel.BackColor = System.Drawing.SystemColors.Control;
            this.minHeartRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.minHeartRateLabel.Location = new System.Drawing.Point(866, 604);
            this.minHeartRateLabel.Name = "minHeartRateLabel";
            this.minHeartRateLabel.Size = new System.Drawing.Size(0, 13);
            this.minHeartRateLabel.TabIndex = 26;
            // 
            // averageHeartRateLabel
            // 
            this.averageHeartRateLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.averageHeartRateLabel.AutoSize = true;
            this.averageHeartRateLabel.BackColor = System.Drawing.SystemColors.Control;
            this.averageHeartRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.averageHeartRateLabel.Location = new System.Drawing.Point(866, 568);
            this.averageHeartRateLabel.Name = "averageHeartRateLabel";
            this.averageHeartRateLabel.Size = new System.Drawing.Size(0, 13);
            this.averageHeartRateLabel.TabIndex = 25;
            // 
            // maxSpeedLabel
            // 
            this.maxSpeedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.maxSpeedLabel.AutoSize = true;
            this.maxSpeedLabel.BackColor = System.Drawing.SystemColors.Control;
            this.maxSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.maxSpeedLabel.Location = new System.Drawing.Point(751, 638);
            this.maxSpeedLabel.Name = "maxSpeedLabel";
            this.maxSpeedLabel.Size = new System.Drawing.Size(0, 13);
            this.maxSpeedLabel.TabIndex = 24;
            // 
            // averageSpeedLabel
            // 
            this.averageSpeedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.averageSpeedLabel.AutoSize = true;
            this.averageSpeedLabel.BackColor = System.Drawing.SystemColors.Control;
            this.averageSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.averageSpeedLabel.Location = new System.Drawing.Point(751, 604);
            this.averageSpeedLabel.Name = "averageSpeedLabel";
            this.averageSpeedLabel.Size = new System.Drawing.Size(0, 13);
            this.averageSpeedLabel.TabIndex = 23;
            // 
            // totalDistanceLabel
            // 
            this.totalDistanceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.totalDistanceLabel.AutoSize = true;
            this.totalDistanceLabel.BackColor = System.Drawing.SystemColors.Control;
            this.totalDistanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.totalDistanceLabel.Location = new System.Drawing.Point(751, 568);
            this.totalDistanceLabel.Name = "totalDistanceLabel";
            this.totalDistanceLabel.Size = new System.Drawing.Size(0, 13);
            this.totalDistanceLabel.TabIndex = 22;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(994, 530);
            this.dataGridView1.TabIndex = 31;
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.SystemColors.Control;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.nameLabel.Location = new System.Drawing.Point(74, 571);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 13);
            this.nameLabel.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label14.Location = new System.Drawing.Point(12, 571);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Name";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkedSmodeList
            // 
            this.checkedSmodeList.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.checkedSmodeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedSmodeList.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkedSmodeList.FormattingEnabled = true;
            this.checkedSmodeList.Items.AddRange(new object[] {
            "Speed",
            "Cadence",
            "Altitude",
            "Power",
            "Imperial Measurements?"});
            this.checkedSmodeList.Location = new System.Drawing.Point(286, 568);
            this.checkedSmodeList.Name = "checkedSmodeList";
            this.checkedSmodeList.Size = new System.Drawing.Size(283, 94);
            this.checkedSmodeList.TabIndex = 22;
            // 
            // durationLabel
            // 
            this.durationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.durationLabel.AutoSize = true;
            this.durationLabel.BackColor = System.Drawing.SystemColors.Control;
            this.durationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.durationLabel.Location = new System.Drawing.Point(271, 600);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(0, 13);
            this.durationLabel.TabIndex = 21;
            // 
            // timeLabel
            // 
            this.timeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.timeLabel.Location = new System.Drawing.Point(271, 571);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(0, 13);
            this.timeLabel.TabIndex = 20;
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.SystemColors.Control;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dateLabel.Location = new System.Drawing.Point(74, 600);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(0, 13);
            this.dateLabel.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label12.Location = new System.Drawing.Point(189, 600);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Duration";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label11.Location = new System.Drawing.Point(216, 571);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Time";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label10.Location = new System.Drawing.Point(19, 600);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Date";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(852, 641);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Avg. Altitude";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(856, 607);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Max. Power";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(857, 571);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Avg. Power";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(762, 641);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Max. Heart Rate";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(765, 607);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Min. Heart Rate";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(763, 571);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Avg. Heart Rate";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(678, 641);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Max. Speed";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(682, 607);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Avg Speed";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(666, 571);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total Distance";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1008, 562);
            this.tabControl1.TabIndex = 32;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.zedGraphControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1155, 577);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Graph View";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1000, 536);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "List View";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 688);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Panel exerciseDataPanel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedSmodeList;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label averageAltitudeLabel;
        private System.Windows.Forms.Label maxPowerLabel;
        private System.Windows.Forms.Label averagePowerLabel;
        private System.Windows.Forms.Label MaxHeartRateLabel;
        private System.Windows.Forms.Label minHeartRateLabel;
        private System.Windows.Forms.Label averageHeartRateLabel;
        private System.Windows.Forms.Label maxSpeedLabel;
        private System.Windows.Forms.Label averageSpeedLabel;
        private System.Windows.Forms.Label totalDistanceLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

