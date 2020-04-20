namespace SPZ_SystemPerformanceViewer
{
    partial class Services
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
            this.servicesListBox = new System.Windows.Forms.ListView();
            this.startServiceButton = new System.Windows.Forms.Button();
            this.stopServiceButton = new System.Windows.Forms.Button();
            this.restartServiceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // servicesListBox
            // 
            this.servicesListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(63)))));
            this.servicesListBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.servicesListBox.ForeColor = System.Drawing.Color.White;
            this.servicesListBox.HideSelection = false;
            this.servicesListBox.Location = new System.Drawing.Point(12, 12);
            this.servicesListBox.Name = "servicesListBox";
            this.servicesListBox.Size = new System.Drawing.Size(661, 330);
            this.servicesListBox.TabIndex = 0;
            this.servicesListBox.UseCompatibleStateImageBehavior = false;
            this.servicesListBox.View = System.Windows.Forms.View.Details;
            this.servicesListBox.SelectedIndexChanged += new System.EventHandler(this.servicesListBox_SelectedIndexChanged);
            // 
            // startServiceButton
            // 
            this.startServiceButton.BackColor = System.Drawing.Color.LightGray;
            this.startServiceButton.Location = new System.Drawing.Point(13, 349);
            this.startServiceButton.Name = "startServiceButton";
            this.startServiceButton.Size = new System.Drawing.Size(101, 31);
            this.startServiceButton.TabIndex = 1;
            this.startServiceButton.Text = "Start";
            this.startServiceButton.UseVisualStyleBackColor = false;
            this.startServiceButton.Click += new System.EventHandler(this.startServiceButton_Click);
            // 
            // stopServiceButton
            // 
            this.stopServiceButton.BackColor = System.Drawing.Color.LightGray;
            this.stopServiceButton.Location = new System.Drawing.Point(120, 348);
            this.stopServiceButton.Name = "stopServiceButton";
            this.stopServiceButton.Size = new System.Drawing.Size(101, 31);
            this.stopServiceButton.TabIndex = 2;
            this.stopServiceButton.Text = "Stop";
            this.stopServiceButton.UseVisualStyleBackColor = false;
            this.stopServiceButton.Click += new System.EventHandler(this.stopServiceButton_Click);
            // 
            // restartServiceButton
            // 
            this.restartServiceButton.BackColor = System.Drawing.Color.LightGray;
            this.restartServiceButton.Location = new System.Drawing.Point(227, 348);
            this.restartServiceButton.Name = "restartServiceButton";
            this.restartServiceButton.Size = new System.Drawing.Size(101, 31);
            this.restartServiceButton.TabIndex = 3;
            this.restartServiceButton.Text = "Restart";
            this.restartServiceButton.UseVisualStyleBackColor = false;
            this.restartServiceButton.Click += new System.EventHandler(this.restartServiceButton_Click);
            // 
            // Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(12)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(685, 426);
            this.Controls.Add(this.restartServiceButton);
            this.Controls.Add(this.stopServiceButton);
            this.Controls.Add(this.startServiceButton);
            this.Controls.Add(this.servicesListBox);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(12)))), ((int)(((byte)(18)))));
            this.Name = "Services";
            this.Text = "Services";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView servicesListBox;
        private System.Windows.Forms.Button startServiceButton;
        private System.Windows.Forms.Button stopServiceButton;
        private System.Windows.Forms.Button restartServiceButton;
    }
}