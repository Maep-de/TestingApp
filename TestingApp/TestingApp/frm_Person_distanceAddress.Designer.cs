namespace TestingApp
{
    partial class frm_Person_distanceAddress
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
            this.ddlAdressID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstTeachers = new System.Windows.Forms.DataGridView();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ddlCity = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAddressID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lstTeachers)).BeginInit();
            this.SuspendLayout();
            // 
            // ddlAdressID
            // 
            this.ddlAdressID.FormattingEnabled = true;
            this.ddlAdressID.Location = new System.Drawing.Point(163, 42);
            this.ddlAdressID.Name = "ddlAdressID";
            this.ddlAdressID.Size = new System.Drawing.Size(301, 21);
            this.ddlAdressID.TabIndex = 0;
            this.ddlAdressID.SelectedIndexChanged += new System.EventHandler(this.ddlAdressID_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Adress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "(with Street, ZipCode)";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(164, 122);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // lstTeachers
            // 
            this.lstTeachers.AllowUserToAddRows = false;
            this.lstTeachers.AllowUserToDeleteRows = false;
            this.lstTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstTeachers.Location = new System.Drawing.Point(17, 151);
            this.lstTeachers.Name = "lstTeachers";
            this.lstTeachers.Size = new System.Drawing.Size(854, 364);
            this.lstTeachers.TabIndex = 6;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(164, 83);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(300, 20);
            this.txtValue.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Distance Value";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Select City";
            // 
            // ddlCity
            // 
            this.ddlCity.FormattingEnabled = true;
            this.ddlCity.Location = new System.Drawing.Point(164, 11);
            this.ddlCity.Name = "ddlCity";
            this.ddlCity.Size = new System.Drawing.Size(300, 21);
            this.ddlCity.TabIndex = 9;
            this.ddlCity.SelectedIndexChanged += new System.EventHandler(this.ddlCity_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(444, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Persons List around this  Address";
            this.label7.Visible = false;
            // 
            // lblAddressID
            // 
            this.lblAddressID.AutoSize = true;
            this.lblAddressID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressID.Location = new System.Drawing.Point(557, 72);
            this.lblAddressID.Name = "lblAddressID";
            this.lblAddressID.Size = new System.Drawing.Size(72, 16);
            this.lblAddressID.TabIndex = 21;
            this.lblAddressID.Text = "AddressID";
            // 
            // frm_Person_distanceAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 515);
            this.Controls.Add(this.lblAddressID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ddlCity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.lstTeachers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ddlAdressID);
            this.Name = "frm_Person_distanceAddress";
            this.Text = "frm_Person_distanceAddress";
            this.Load += new System.EventHandler(this.frm_Person_distanceAddress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lstTeachers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ddlAdressID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView lstTeachers;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ddlCity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAddressID;
    }
}