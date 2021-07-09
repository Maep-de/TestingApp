namespace TestingApp
{
    partial class frmMedicalInsAddress
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
            this.label6 = new System.Windows.Forms.Label();
            this.ddlCity = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.lstTeachers = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ddlAdressID = new System.Windows.Forms.ComboBox();
            this.lblAddressID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lstTeachers)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Select City";
            // 
            // ddlCity
            // 
            this.ddlCity.FormattingEnabled = true;
            this.ddlCity.Location = new System.Drawing.Point(167, 9);
            this.ddlCity.Name = "ddlCity";
            this.ddlCity.Size = new System.Drawing.Size(300, 21);
            this.ddlCity.TabIndex = 18;
            this.ddlCity.SelectedIndexChanged += new System.EventHandler(this.ddlCity_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Distance Value";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(167, 81);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(300, 20);
            this.txtValue.TabIndex = 16;
            // 
            // lstTeachers
            // 
            this.lstTeachers.AllowUserToAddRows = false;
            this.lstTeachers.AllowUserToDeleteRows = false;
            this.lstTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstTeachers.Location = new System.Drawing.Point(22, 149);
            this.lstTeachers.Name = "lstTeachers";
            this.lstTeachers.Size = new System.Drawing.Size(1145, 364);
            this.lstTeachers.TabIndex = 15;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(167, 120);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "(with Street, ZipCode)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Select Adress";
            // 
            // ddlAdressID
            // 
            this.ddlAdressID.FormattingEnabled = true;
            this.ddlAdressID.Location = new System.Drawing.Point(166, 40);
            this.ddlAdressID.Name = "ddlAdressID";
            this.ddlAdressID.Size = new System.Drawing.Size(301, 21);
            this.ddlAdressID.TabIndex = 11;
            this.ddlAdressID.SelectedIndexChanged += new System.EventHandler(this.ddlAdressID_SelectedIndexChanged);
            // 
            // lblAddressID
            // 
            this.lblAddressID.AutoSize = true;
            this.lblAddressID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressID.Location = new System.Drawing.Point(396, 120);
            this.lblAddressID.Name = "lblAddressID";
            this.lblAddressID.Size = new System.Drawing.Size(72, 16);
            this.lblAddressID.TabIndex = 20;
            this.lblAddressID.Text = "AddressID";
            // 
            // frmMedicalInsAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 532);
            this.Controls.Add(this.lblAddressID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ddlCity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.lstTeachers);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ddlAdressID);
            this.Name = "frmMedicalInsAddress";
            this.Text = "frmMedicalInsAddress";
            ((System.ComponentModel.ISupportInitialize)(this.lstTeachers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ddlCity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.DataGridView lstTeachers;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddlAdressID;
        private System.Windows.Forms.Label lblAddressID;
    }
}