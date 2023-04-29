namespace oraclee_sql_app
{
    partial class Main_Form
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.selectFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboard1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboard2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crystalReport1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crystalReport2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectFormToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1030, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // selectFormToolStripMenuItem
            // 
            this.selectFormToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboard1ToolStripMenuItem,
            this.dashboard2ToolStripMenuItem,
            this.crystalReport1ToolStripMenuItem,
            this.crystalReport2ToolStripMenuItem});
            this.selectFormToolStripMenuItem.Name = "selectFormToolStripMenuItem";
            this.selectFormToolStripMenuItem.Size = new System.Drawing.Size(101, 26);
            this.selectFormToolStripMenuItem.Text = "Select Form";
            // 
            // dashboard1ToolStripMenuItem
            // 
            this.dashboard1ToolStripMenuItem.Name = "dashboard1ToolStripMenuItem";
            this.dashboard1ToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.dashboard1ToolStripMenuItem.Text = "Dashboard 1";
            this.dashboard1ToolStripMenuItem.Click += new System.EventHandler(this.dashboard1ToolStripMenuItem_Click);
            // 
            // dashboard2ToolStripMenuItem
            // 
            this.dashboard2ToolStripMenuItem.Name = "dashboard2ToolStripMenuItem";
            this.dashboard2ToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.dashboard2ToolStripMenuItem.Text = "Dashboard 2";
            this.dashboard2ToolStripMenuItem.Click += new System.EventHandler(this.dashboard2ToolStripMenuItem_Click);
            // 
            // crystalReport1ToolStripMenuItem
            // 
            this.crystalReport1ToolStripMenuItem.Name = "crystalReport1ToolStripMenuItem";
            this.crystalReport1ToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.crystalReport1ToolStripMenuItem.Text = "Crystal Report 1";
            this.crystalReport1ToolStripMenuItem.Click += new System.EventHandler(this.crystalReport1ToolStripMenuItem_Click);
            // 
            // crystalReport2ToolStripMenuItem
            // 
            this.crystalReport2ToolStripMenuItem.Name = "crystalReport2ToolStripMenuItem";
            this.crystalReport2ToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.crystalReport2ToolStripMenuItem.Text = "Crystal Report 2";
            this.crystalReport2ToolStripMenuItem.Click += new System.EventHandler(this.crystalReport2ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "(Team 04) – Hotel Booking System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(437, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "TA:  Nagwa Mostafa";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(1030, 571);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_Form";
            this.Text = "Main_Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem selectFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboard1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboard2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crystalReport1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crystalReport2ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}