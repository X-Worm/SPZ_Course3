namespace SPZ_SystemPerformanceViewer
{
    partial class AddCounter
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
            this.addCounterButton = new System.Windows.Forms.Button();
            this.countersTree = new System.Windows.Forms.TreeView();
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalProcessCountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addCounterButton
            // 
            this.addCounterButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addCounterButton.Location = new System.Drawing.Point(12, 389);
            this.addCounterButton.Name = "addCounterButton";
            this.addCounterButton.Size = new System.Drawing.Size(359, 49);
            this.addCounterButton.TabIndex = 0;
            this.addCounterButton.Text = "Add process";
            this.addCounterButton.UseVisualStyleBackColor = true;
            this.addCounterButton.Click += new System.EventHandler(this.addCounterButton_Click);
            // 
            // countersTree
            // 
            this.countersTree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(63)))));
            this.countersTree.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countersTree.ForeColor = System.Drawing.Color.White;
            this.countersTree.Location = new System.Drawing.Point(12, 12);
            this.countersTree.Name = "countersTree";
            this.countersTree.Size = new System.Drawing.Size(359, 280);
            this.countersTree.TabIndex = 1;
            // 
            // previousButton
            // 
            this.previousButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.previousButton.Location = new System.Drawing.Point(13, 336);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(182, 47);
            this.previousButton.TabIndex = 2;
            this.previousButton.Text = "<< 10 items";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextButton.Location = new System.Drawing.Point(201, 336);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(170, 47);
            this.nextButton.TabIndex = 3;
            this.nextButton.Text = "10 items >>";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total process count:";
            // 
            // TotalProcessCountLabel
            // 
            this.TotalProcessCountLabel.AutoSize = true;
            this.TotalProcessCountLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TotalProcessCountLabel.ForeColor = System.Drawing.Color.White;
            this.TotalProcessCountLabel.Location = new System.Drawing.Point(158, 295);
            this.TotalProcessCountLabel.Name = "TotalProcessCountLabel";
            this.TotalProcessCountLabel.Size = new System.Drawing.Size(81, 19);
            this.TotalProcessCountLabel.TabIndex = 5;
            this.TotalProcessCountLabel.Text = "Total count";
            // 
            // AddCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(12)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(383, 450);
            this.Controls.Add(this.TotalProcessCountLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.countersTree);
            this.Controls.Add(this.addCounterButton);
            this.Name = "AddCounter";
            this.Text = "AddCounter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addCounterButton;
        private System.Windows.Forms.TreeView countersTree;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TotalProcessCountLabel;
    }
}