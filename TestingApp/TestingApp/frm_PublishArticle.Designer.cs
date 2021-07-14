namespace TestingApp
{
    partial class frm_PublishArticle
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
            this.label2 = new System.Windows.Forms.Label();
            this.ddlArticle = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.btnPublish = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtHeadline = new System.Windows.Forms.TextBox();
            this.lblHeadline = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtPublish = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Blog Type";
            // 
            // ddlArticle
            // 
            this.ddlArticle.FormattingEnabled = true;
            this.ddlArticle.Location = new System.Drawing.Point(217, 8);
            this.ddlArticle.Name = "ddlArticle";
            this.ddlArticle.Size = new System.Drawing.Size(332, 21);
            this.ddlArticle.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(217, 40);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(707, 20);
            this.txtTitle.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Content";
            // 
            // txtDetails
            // 
            this.txtDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDetails.Location = new System.Drawing.Point(217, 134);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(955, 312);
            this.txtDetails.TabIndex = 18;
            this.txtDetails.Text = "Multi-line \r\n label";
            // 
            // btnPublish
            // 
            this.btnPublish.Location = new System.Drawing.Point(217, 452);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(75, 23);
            this.btnPublish.TabIndex = 19;
            this.btnPublish.Text = "Publish";
            this.btnPublish.UseVisualStyleBackColor = true;
            this.btnPublish.Click += new System.EventHandler(this.btnPublish_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(220, 481);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(70, 13);
            this.lblMessage.TabIndex = 20;
            this.lblMessage.Text = "lblMessage";
            this.lblMessage.Visible = false;
            // 
            // txtHeadline
            // 
            this.txtHeadline.Location = new System.Drawing.Point(217, 75);
            this.txtHeadline.Multiline = true;
            this.txtHeadline.Name = "txtHeadline";
            this.txtHeadline.Size = new System.Drawing.Size(571, 47);
            this.txtHeadline.TabIndex = 21;
            // 
            // lblHeadline
            // 
            this.lblHeadline.AutoSize = true;
            this.lblHeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadline.Location = new System.Drawing.Point(30, 79);
            this.lblHeadline.Name = "lblHeadline";
            this.lblHeadline.Size = new System.Drawing.Size(63, 16);
            this.lblHeadline.TabIndex = 22;
            this.lblHeadline.Text = "Headline";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(579, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(106, 16);
            this.lblDate.TabIndex = 23;
            this.lblDate.Text = "Publication Date";
            // 
            // dtPublish
            // 
            this.dtPublish.CustomFormat = "dd-MM-yyyy";
            this.dtPublish.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPublish.Location = new System.Drawing.Point(691, 8);
            this.dtPublish.Name = "dtPublish";
            this.dtPublish.Size = new System.Drawing.Size(158, 20);
            this.dtPublish.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(855, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "(dd-MM-yyyy)";
            // 
            // frm_PublishArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 509);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtPublish);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblHeadline);
            this.Controls.Add(this.txtHeadline);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnPublish);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ddlArticle);
            this.Name = "frm_PublishArticle";
            this.Text = "frm_PublishArticle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ddlArticle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Button btnPublish;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtHeadline;
        private System.Windows.Forms.Label lblHeadline;
        private System.Windows.Forms.Label lblDate;
        internal System.Windows.Forms.DateTimePicker dtPublish;
        private System.Windows.Forms.Label label4;
    }
}