namespace TestingApp
{
    partial class frm_SubjectWisePerson
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
            ((System.ComponentModel.ISupportInitialize)(this.lstPersonSubwise)).BeginInit();
            this.SuspendLayout();
            // 
            // lstPersonSubwise
            // 
            this.lstPersonSubwise.AllowUserToAddRows = false;
            this.lstPersonSubwise.AllowUserToDeleteRows = false;
            this.lstPersonSubwise.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstPersonSubwise.Location = new System.Drawing.Point(22, 20);
            this.lstPersonSubwise.Name = "lstPersonSubwise";
            this.lstPersonSubwise.Size = new System.Drawing.Size(766, 418);
            this.lstPersonSubwise.TabIndex = 3;
            // 
            // frm_SubjectWisePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstPersonSubwise);
            this.Name = "frm_SubjectWisePerson";
            this.Text = "frm_SubjectWisePerson";
            ((System.ComponentModel.ISupportInitialize)(this.lstPersonSubwise)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView lstPersonSubwise;
    }
}