namespace TestingApp
{
    partial class frm_SubjectWisePersondtl
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
            this.lstPersonSubwise = new System.Windows.Forms.DataGridView();
            this.ddlSubject = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lstPersonSubwise)).BeginInit();
            this.SuspendLayout();
            // 
            // lstPersonSubwise
            // 
            this.lstPersonSubwise.AllowUserToAddRows = false;
            this.lstPersonSubwise.AllowUserToDeleteRows = false;
            this.lstPersonSubwise.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstPersonSubwise.Location = new System.Drawing.Point(17, 57);
            this.lstPersonSubwise.Name = "lstPersonSubwise";
            this.lstPersonSubwise.Size = new System.Drawing.Size(1004, 377);
            this.lstPersonSubwise.TabIndex = 4;
            // 
            // ddlSubject
            // 
            this.ddlSubject.FormattingEnabled = true;
            this.ddlSubject.Location = new System.Drawing.Point(143, 12);
            this.ddlSubject.Name = "ddlSubject";
            this.ddlSubject.Size = new System.Drawing.Size(362, 21);
            this.ddlSubject.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select Subject";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(524, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frm_SubjectWisePersondtl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 450);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ddlSubject);
            this.Controls.Add(this.lstPersonSubwise);
            this.Name = "frm_SubjectWisePersondtl";
            this.Text = "frm_SubjectWisePersondtl";
            ((System.ComponentModel.ISupportInitialize)(this.lstPersonSubwise)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView lstPersonSubwise;
        private System.Windows.Forms.ComboBox ddlSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
    }
}