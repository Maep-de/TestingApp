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
            this.distanceFromPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectWisePersonToolStripMenuItemdtl = new System.Windows.Forms.ToolStripMenuItem();
            this.bedsQuantityForDeptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.institutionWisePersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectWisePersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articlePublicationCurrentWebpageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchDoctorWithSpecializationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withSpecializationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicalInstitutionFromAddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchWithDistanceToolStripMenuItem,
            this.countToolStripMenuItem,
            this.publicationToolStripMenuItem,
            this.searchDoctorWithSpecializationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // searchWithDistanceToolStripMenuItem
            // 
            this.searchWithDistanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medicalInstitutionFromAddressToolStripMenuItem,
            this.distanceFromPersonToolStripMenuItem,
            this.personToolStripMenuItem,
            this.subjectWisePersonToolStripMenuItemdtl,
            this.bedsQuantityForDeptToolStripMenuItem,
            this.distanceToolStripMenuItem});
            this.searchWithDistanceToolStripMenuItem.Name = "searchWithDistanceToolStripMenuItem";
            this.searchWithDistanceToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchWithDistanceToolStripMenuItem.Text = "Search";
            // 
            // distanceToolStripMenuItem
            // 
            this.distanceToolStripMenuItem.Name = "distanceToolStripMenuItem";
            this.distanceToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.distanceToolStripMenuItem.Text = "with Distance";
            this.distanceToolStripMenuItem.Click += new System.EventHandler(this.distanceToolStripMenuItem_Click);
            // 
            // personToolStripMenuItem
            // 
            this.personToolStripMenuItem.Name = "personToolStripMenuItem";
            this.personToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.personToolStripMenuItem.Text = "Distance from Address";
            this.personToolStripMenuItem.Click += new System.EventHandler(this.personToolStripMenuItem_Click);
            // 
            // distanceFromPersonToolStripMenuItem
            // 
            this.distanceFromPersonToolStripMenuItem.Name = "distanceFromPersonToolStripMenuItem";
            this.distanceFromPersonToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.distanceFromPersonToolStripMenuItem.Text = "Distance from Person";
            this.distanceFromPersonToolStripMenuItem.Click += new System.EventHandler(this.distanceFromPersonToolStripMenuItem_Click);
            // 
            // subjectWisePersonToolStripMenuItemdtl
            // 
            this.subjectWisePersonToolStripMenuItemdtl.Name = "subjectWisePersonToolStripMenuItemdtl";
            this.subjectWisePersonToolStripMenuItemdtl.Size = new System.Drawing.Size(247, 22);
            this.subjectWisePersonToolStripMenuItemdtl.Text = "Subject wise Person";
            this.subjectWisePersonToolStripMenuItemdtl.Click += new System.EventHandler(this.subjectWisePersonToolStripMenuItemdtl_Click);
            // 
            // bedsQuantityForDeptToolStripMenuItem
            // 
            this.bedsQuantityForDeptToolStripMenuItem.Name = "bedsQuantityForDeptToolStripMenuItem";
            this.bedsQuantityForDeptToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.bedsQuantityForDeptToolStripMenuItem.Text = "Beds quantity for Dept";
            this.bedsQuantityForDeptToolStripMenuItem.Click += new System.EventHandler(this.bedsQuantityForDeptToolStripMenuItem_Click);
            // 
            // countToolStripMenuItem
            // 
            this.countToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.institutionWisePersonToolStripMenuItem,
            this.subjectWisePersonToolStripMenuItem});
            this.countToolStripMenuItem.Name = "countToolStripMenuItem";
            this.countToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.countToolStripMenuItem.Text = "Count";
            // 
            // institutionWisePersonToolStripMenuItem
            // 
            this.institutionWisePersonToolStripMenuItem.Name = "institutionWisePersonToolStripMenuItem";
            this.institutionWisePersonToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.institutionWisePersonToolStripMenuItem.Text = "Institution wise Person";
            this.institutionWisePersonToolStripMenuItem.Click += new System.EventHandler(this.institutionWisePersonToolStripMenuItem_Click);
            // 
            // subjectWisePersonToolStripMenuItem
            // 
            this.subjectWisePersonToolStripMenuItem.Name = "subjectWisePersonToolStripMenuItem";
            this.subjectWisePersonToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.subjectWisePersonToolStripMenuItem.Text = "Subject wise Person";
            this.subjectWisePersonToolStripMenuItem.Click += new System.EventHandler(this.subjectWisePersonToolStripMenuItem_Click);
            // 
            // publicationToolStripMenuItem
            // 
            this.publicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articlesToolStripMenuItem,
            this.articlePublicationCurrentWebpageToolStripMenuItem});
            this.publicationToolStripMenuItem.Name = "publicationToolStripMenuItem";
            this.publicationToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.publicationToolStripMenuItem.Text = "Publication";
            // 
            // articlesToolStripMenuItem
            // 
            this.articlesToolStripMenuItem.Name = "articlesToolStripMenuItem";
            this.articlesToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.articlesToolStripMenuItem.Text = "Articles";
            this.articlesToolStripMenuItem.Click += new System.EventHandler(this.articlesToolStripMenuItem_Click);
            // 
            // articlePublicationCurrentWebpageToolStripMenuItem
            // 
            this.articlePublicationCurrentWebpageToolStripMenuItem.Name = "articlePublicationCurrentWebpageToolStripMenuItem";
            this.articlePublicationCurrentWebpageToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.articlePublicationCurrentWebpageToolStripMenuItem.Text = "Article Publication Current Webpage";
            this.articlePublicationCurrentWebpageToolStripMenuItem.Click += new System.EventHandler(this.articlePublicationCurrentWebpageToolStripMenuItem_Click);
            // 
            // searchDoctorWithSpecializationToolStripMenuItem
            // 
            this.searchDoctorWithSpecializationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.withSpecializationToolStripMenuItem});
            this.searchDoctorWithSpecializationToolStripMenuItem.Name = "searchDoctorWithSpecializationToolStripMenuItem";
            this.searchDoctorWithSpecializationToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.searchDoctorWithSpecializationToolStripMenuItem.Text = "Search Hospitals ";
            // 
            // withSpecializationToolStripMenuItem
            // 
            this.withSpecializationToolStripMenuItem.Name = "withSpecializationToolStripMenuItem";
            this.withSpecializationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.withSpecializationToolStripMenuItem.Text = "with Specialization";
            this.withSpecializationToolStripMenuItem.Click += new System.EventHandler(this.withSpecializationToolStripMenuItem_Click);
            // 
            // medicalInstitutionFromAddressToolStripMenuItem
            // 
            this.medicalInstitutionFromAddressToolStripMenuItem.Name = "medicalInstitutionFromAddressToolStripMenuItem";
            this.medicalInstitutionFromAddressToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.medicalInstitutionFromAddressToolStripMenuItem.Text = "Medical Institution from Address";
            this.medicalInstitutionFromAddressToolStripMenuItem.Click += new System.EventHandler(this.medicalInstitutionFromAddressToolStripMenuItem_Click);
            // 
            // frmMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 711);
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
        private System.Windows.Forms.ToolStripMenuItem distanceFromPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem institutionWisePersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjectWisePersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjectWisePersonToolStripMenuItemdtl;
        private System.Windows.Forms.ToolStripMenuItem bedsQuantityForDeptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem publicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articlesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articlePublicationCurrentWebpageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchDoctorWithSpecializationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withSpecializationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicalInstitutionFromAddressToolStripMenuItem;
    }
}