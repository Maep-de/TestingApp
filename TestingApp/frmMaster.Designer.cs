namespace TestingApp
{
    partial class frmMaster
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
            this.searchWithDistanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.distanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchWithDistanceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // searchWithDistanceToolStripMenuItem
            // 
            this.searchWithDistanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.distanceToolStripMenuItem,
            this.personToolStripMenuItem});
            this.searchWithDistanceToolStripMenuItem.Name = "searchWithDistanceToolStripMenuItem";
            this.searchWithDistanceToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.searchWithDistanceToolStripMenuItem.Text = "Search on";
            // 
            // distanceToolStripMenuItem
            // 
            this.distanceToolStripMenuItem.Name = "distanceToolStripMenuItem";
            this.distanceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.distanceToolStripMenuItem.Text = "Distance";
            this.distanceToolStripMenuItem.Click += new System.EventHandler(this.distanceToolStripMenuItem_Click);
            // 
            // personToolStripMenuItem
            // 
            this.personToolStripMenuItem.Name = "personToolStripMenuItem";
            this.personToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.personToolStripMenuItem.Text = "Person";
            this.personToolStripMenuItem.Click += new System.EventHandler(this.personToolStripMenuItem_Click);
            // 
            // frmMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMaster";
            this.Text = "frmMaster";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem searchWithDistanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem distanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personToolStripMenuItem;
    }
}