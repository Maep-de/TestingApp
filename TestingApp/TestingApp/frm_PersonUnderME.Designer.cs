namespace TestingApp
{
    partial class frm_PersonUnderME
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
            this.lblAddressID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ddlCity = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lstTeachers = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ddlAdressID = new System.Windows.Forms.ComboBox();
            this.ddlInstitution = new System.Windows.Forms.ComboBox();
            this.ddlSubject = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lstTeachers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddressID
            // 
            this.lblAddressID.AutoSize = true;
            this.lblAddressID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressID.Location = new System.Drawing.Point(336, 79);
            this.lblAddressID.Name = "lblAddressID";
            this.lblAddressID.Size = new System.Drawing.Size(72, 16);
            this.lblAddressID.TabIndex = 30;
            this.lblAddressID.Text = "AddressID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Select City";
            // 
            // ddlCity
            // 
            this.ddlCity.FormattingEnabled = true;
            this.ddlCity.Location = new System.Drawing.Point(157, 8);
            this.ddlCity.Name = "ddlCity";
            this.ddlCity.Size = new System.Drawing.Size(300, 21);
            this.ddlCity.TabIndex = 28;
            this.ddlCity.SelectedIndexChanged += new System.EventHandler(this.ddlCity_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(548, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Instituion Name";
            // 
            // lstTeachers
            // 
            this.lstTeachers.AllowUserToAddRows = false;
            this.lstTeachers.AllowUserToDeleteRows = false;
            this.lstTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstTeachers.Location = new System.Drawing.Point(27, 161);
            this.lstTeachers.Name = "lstTeachers";
            this.lstTeachers.Size = new System.Drawing.Size(1145, 348);
            this.lstTeachers.TabIndex = 25;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(452, 79);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(161, 23);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "(with Street, ZipCode)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Select Adress";
            // 
            // ddlAdressID
            // 
            this.ddlAdressID.FormattingEnabled = true;
            this.ddlAdressID.Location = new System.Drawing.Point(156, 39);
            this.ddlAdressID.Name = "ddlAdressID";
            this.ddlAdressID.Size = new System.Drawing.Size(301, 21);
            this.ddlAdressID.TabIndex = 21;
            this.ddlAdressID.SelectedIndexChanged += new System.EventHandler(this.ddlAdressID_SelectedIndexChanged);
            // 
            // ddlInstitution
            // 
            this.ddlInstitution.FormattingEnabled = true;
            this.ddlInstitution.Location = new System.Drawing.Point(690, 7);
            this.ddlInstitution.Name = "ddlInstitution";
            this.ddlInstitution.Size = new System.Drawing.Size(301, 21);
            this.ddlInstitution.TabIndex = 31;
            // 
            // ddlSubject
            // 
            this.ddlSubject.FormattingEnabled = true;
            this.ddlSubject.Location = new System.Drawing.Point(690, 39);
            this.ddlSubject.Name = "ddlSubject";
            this.ddlSubject.Size = new System.Drawing.Size(301, 21);
            this.ddlSubject.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(548, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Subject";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(344, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(349, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Institution wise Person Details Information";
            // 
            // frm_PersonUnderME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 521);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ddlSubject);
            this.Controls.Add(this.ddlInstitution);
            this.Controls.Add(this.lblAddressID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ddlCity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstTeachers);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ddlAdressID);
            this.Name = "frm_PersonUnderME";
            this.Text = "frm_PersonUnderME";
            ((System.ComponentModel.ISupportInitialize)(this.lstTeachers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddressID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ddlCity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView lstTeachers;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddlAdressID;
        private System.Windows.Forms.ComboBox ddlInstitution;
        private System.Windows.Forms.ComboBox ddlSubject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}