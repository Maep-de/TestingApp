namespace TestingApp
{
    partial class frm_InstitutionWisePerson
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
            this.lstPerson = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.lstPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // lstPerson
            // 
            this.lstPerson.AllowUserToAddRows = false;
            this.lstPerson.AllowUserToDeleteRows = false;
            this.lstPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstPerson.Location = new System.Drawing.Point(25, 12);
            this.lstPerson.Name = "lstPerson";
            this.lstPerson.Size = new System.Drawing.Size(750, 426);
            this.lstPerson.TabIndex = 3;
            // 
            // frm_InstitutionWisePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstPerson);
            this.Name = "frm_InstitutionWisePerson";
            this.Text = "frm_InstitutionWisePerson";
            ((System.ComponentModel.ISupportInitialize)(this.lstPerson)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView lstPerson;
    }
}