namespace SPZ_SystemPerformanceViewer
{
    partial class Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.counterList = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.removeCounterButton = new System.Windows.Forms.Button();
            this.addCounterButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.CpuUsageLabel = new System.Windows.Forms.Label();
            this.MemoryGraph = new CircularProgressBar.CircularProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.ProcessIdLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MachineNameLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.CPUGraph = new CircularProgressBar.CircularProgressBar();
            this.label10 = new System.Windows.Forms.Label();
            this.AvailableMemoryLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ProcessNameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StartTimeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PriorityLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IsRespondingLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(63)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.counterList);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 409);
            this.panel1.TabIndex = 0;
            // 
            // counterList
            // 
            this.counterList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(63)))));
            this.counterList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.counterList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.counterList.ForeColor = System.Drawing.Color.White;
            this.counterList.FormattingEnabled = true;
            this.counterList.ItemHeight = 19;
            this.counterList.Location = new System.Drawing.Point(3, 41);
            this.counterList.Name = "counterList";
            this.counterList.Size = new System.Drawing.Size(234, 268);
            this.counterList.TabIndex = 1;
            this.counterList.SelectedIndexChanged += new System.EventHandler(this.counterList_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(50)))));
            this.panel3.Controls.Add(this.removeCounterButton);
            this.panel3.Controls.Add(this.addCounterButton);
            this.panel3.Location = new System.Drawing.Point(3, 309);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(237, 48);
            this.panel3.TabIndex = 0;
            // 
            // removeCounterButton
            // 
            this.removeCounterButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeCounterButton.Location = new System.Drawing.Point(123, 4);
            this.removeCounterButton.Name = "removeCounterButton";
            this.removeCounterButton.Size = new System.Drawing.Size(111, 41);
            this.removeCounterButton.TabIndex = 1;
            this.removeCounterButton.Text = "Remove ";
            this.removeCounterButton.UseMnemonic = false;
            this.removeCounterButton.UseVisualStyleBackColor = true;
            this.removeCounterButton.Click += new System.EventHandler(this.removeCounterButton_Click);
            // 
            // addCounterButton
            // 
            this.addCounterButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addCounterButton.Location = new System.Drawing.Point(4, 4);
            this.addCounterButton.Name = "addCounterButton";
            this.addCounterButton.Size = new System.Drawing.Size(113, 41);
            this.addCounterButton.TabIndex = 0;
            this.addCounterButton.Text = "Add process";
            this.addCounterButton.UseVisualStyleBackColor = true;
            this.addCounterButton.Click += new System.EventHandler(this.addCounterButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(12)))), ((int)(((byte)(18)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.AvailableMemoryLabel);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.CpuUsageLabel);
            this.panel2.Controls.Add(this.MemoryGraph);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.CPUGraph);
            this.panel2.Location = new System.Drawing.Point(273, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(515, 413);
            this.panel2.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(3, 366);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 19);
            this.label9.TabIndex = 4;
            this.label9.Text = "Memory:";
            // 
            // CpuUsageLabel
            // 
            this.CpuUsageLabel.AutoSize = true;
            this.CpuUsageLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CpuUsageLabel.ForeColor = System.Drawing.Color.White;
            this.CpuUsageLabel.Location = new System.Drawing.Point(3, 178);
            this.CpuUsageLabel.Name = "CpuUsageLabel";
            this.CpuUsageLabel.Size = new System.Drawing.Size(83, 19);
            this.CpuUsageLabel.TabIndex = 3;
            this.CpuUsageLabel.Text = "CPU usage:";
            // 
            // MemoryGraph
            // 
            this.MemoryGraph.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.MemoryGraph.AnimationSpeed = 500;
            this.MemoryGraph.BackColor = System.Drawing.Color.Transparent;
            this.MemoryGraph.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MemoryGraph.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MemoryGraph.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MemoryGraph.InnerMargin = 2;
            this.MemoryGraph.InnerWidth = -1;
            this.MemoryGraph.Location = new System.Drawing.Point(34, 200);
            this.MemoryGraph.MarqueeAnimationSpeed = 2000;
            this.MemoryGraph.Name = "MemoryGraph";
            this.MemoryGraph.OuterColor = System.Drawing.Color.Gray;
            this.MemoryGraph.OuterMargin = -25;
            this.MemoryGraph.OuterWidth = 26;
            this.MemoryGraph.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.MemoryGraph.ProgressWidth = 25;
            this.MemoryGraph.SecondaryFont = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MemoryGraph.Size = new System.Drawing.Size(172, 171);
            this.MemoryGraph.StartAngle = 270;
            this.MemoryGraph.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.MemoryGraph.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.MemoryGraph.SubscriptText = "";
            this.MemoryGraph.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.MemoryGraph.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.MemoryGraph.SuperscriptText = "";
            this.MemoryGraph.TabIndex = 2;
            this.MemoryGraph.Text = "Memory";
            this.MemoryGraph.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.MemoryGraph.Value = 68;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(222, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 295);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Process Info";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.05809F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.94191F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ProcessIdLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.MachineNameLabel, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.FileNameLabel, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ProcessNameLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.StartTimeLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.PriorityLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.IsRespondingLabel, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(241, 255);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Process Id:";
            // 
            // ProcessIdLabel
            // 
            this.ProcessIdLabel.AutoSize = true;
            this.ProcessIdLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProcessIdLabel.Location = new System.Drawing.Point(113, 31);
            this.ProcessIdLabel.Name = "ProcessIdLabel";
            this.ProcessIdLabel.Size = new System.Drawing.Size(64, 15);
            this.ProcessIdLabel.TabIndex = 1;
            this.ProcessIdLabel.Text = "Process Id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Machine Name:";
            // 
            // MachineNameLabel
            // 
            this.MachineNameLabel.AutoSize = true;
            this.MachineNameLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MachineNameLabel.Location = new System.Drawing.Point(113, 155);
            this.MachineNameLabel.Name = "MachineNameLabel";
            this.MachineNameLabel.Size = new System.Drawing.Size(89, 15);
            this.MachineNameLabel.TabIndex = 9;
            this.MachineNameLabel.Text = "Machine Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(3, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "File Name:";
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FileNameLabel.Location = new System.Drawing.Point(113, 186);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(61, 15);
            this.FileNameLabel.TabIndex = 11;
            this.FileNameLabel.Text = "File Name";
            // 
            // CPUGraph
            // 
            this.CPUGraph.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.CPUGraph.AnimationSpeed = 500;
            this.CPUGraph.BackColor = System.Drawing.Color.Transparent;
            this.CPUGraph.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CPUGraph.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CPUGraph.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CPUGraph.InnerMargin = 2;
            this.CPUGraph.InnerWidth = -1;
            this.CPUGraph.Location = new System.Drawing.Point(34, 4);
            this.CPUGraph.MarqueeAnimationSpeed = 2000;
            this.CPUGraph.Name = "CPUGraph";
            this.CPUGraph.OuterColor = System.Drawing.Color.Gray;
            this.CPUGraph.OuterMargin = -25;
            this.CPUGraph.OuterWidth = 26;
            this.CPUGraph.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CPUGraph.ProgressWidth = 25;
            this.CPUGraph.SecondaryFont = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CPUGraph.Size = new System.Drawing.Size(172, 171);
            this.CPUGraph.StartAngle = 270;
            this.CPUGraph.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.CPUGraph.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.CPUGraph.SubscriptText = "";
            this.CPUGraph.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.CPUGraph.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.CPUGraph.SuperscriptText = "";
            this.CPUGraph.TabIndex = 0;
            this.CPUGraph.Text = "CPU";
            this.CPUGraph.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.CPUGraph.Value = 68;
            this.CPUGraph.Click += new System.EventHandler(this.mainGraph_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(7, 389);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 19);
            this.label10.TabIndex = 5;
            this.label10.Text = "AvailableMemory:";
            // 
            // AvailableMemoryLabel
            // 
            this.AvailableMemoryLabel.AutoSize = true;
            this.AvailableMemoryLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AvailableMemoryLabel.ForeColor = System.Drawing.Color.White;
            this.AvailableMemoryLabel.Location = new System.Drawing.Point(139, 389);
            this.AvailableMemoryLabel.Name = "AvailableMemoryLabel";
            this.AvailableMemoryLabel.Size = new System.Drawing.Size(122, 19);
            this.AvailableMemoryLabel.TabIndex = 6;
            this.AvailableMemoryLabel.Text = "AvailableMemory";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 15);
            this.label11.TabIndex = 12;
            this.label11.Text = "Process Name:";
            // 
            // ProcessNameLabel
            // 
            this.ProcessNameLabel.AutoSize = true;
            this.ProcessNameLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProcessNameLabel.Location = new System.Drawing.Point(113, 0);
            this.ProcessNameLabel.Name = "ProcessNameLabel";
            this.ProcessNameLabel.Size = new System.Drawing.Size(84, 15);
            this.ProcessNameLabel.TabIndex = 13;
            this.ProcessNameLabel.Text = "Process Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Start Time:";
            // 
            // StartTimeLabel
            // 
            this.StartTimeLabel.AutoSize = true;
            this.StartTimeLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartTimeLabel.Location = new System.Drawing.Point(113, 62);
            this.StartTimeLabel.Name = "StartTimeLabel";
            this.StartTimeLabel.Size = new System.Drawing.Size(62, 15);
            this.StartTimeLabel.TabIndex = 15;
            this.StartTimeLabel.Text = "Start Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Priority:";
            // 
            // PriorityLabel
            // 
            this.PriorityLabel.AutoSize = true;
            this.PriorityLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriorityLabel.Location = new System.Drawing.Point(113, 93);
            this.PriorityLabel.Name = "PriorityLabel";
            this.PriorityLabel.Size = new System.Drawing.Size(49, 15);
            this.PriorityLabel.TabIndex = 17;
            this.PriorityLabel.Text = "Priority";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Is Responding:";
            // 
            // IsRespondingLabel
            // 
            this.IsRespondingLabel.AutoSize = true;
            this.IsRespondingLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IsRespondingLabel.Location = new System.Drawing.Point(113, 124);
            this.IsRespondingLabel.Name = "IsRespondingLabel";
            this.IsRespondingLabel.Size = new System.Drawing.Size(84, 15);
            this.IsRespondingLabel.TabIndex = 19;
            this.IsRespondingLabel.Text = "Is Responding";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "Kill process";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(324, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "It will kill current process";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(68, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 26);
            this.label7.TabIndex = 2;
            this.label7.Text = "Process list";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(3, 364);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(234, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "Service list";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(12)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(800, 437);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.Text = "Main";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox counterList;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button removeCounterButton;
        private System.Windows.Forms.Button addCounterButton;
        private CircularProgressBar.CircularProgressBar CPUGraph;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ProcessIdLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label MachineNameLabel;
        private CircularProgressBar.CircularProgressBar MemoryGraph;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label CpuUsageLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.Label AvailableMemoryLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label ProcessNameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label StartTimeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PriorityLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label IsRespondingLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
    }
}