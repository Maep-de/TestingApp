using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingApp
{
    public partial class frm_PublishArticle : Form
    {
        clsConsolers clsConsole = new clsConsolers();
        public frm_PublishArticle()
        {
            InitializeComponent();
            clsConsole.fill_ArticleType(ddlArticle);
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            if(txtTitle.Text!= "" && txtDetails.Text != "")
            {

                //Content = details
                //add VisibleFromDate,, VisibleDuration later;
                //VisibleFromDate = from which date Blog willbe visible(date type), VisibleDuration = how long the article will be viewed


                string date = dtPublish.Value.ToString("yyyy-MM-dd");
                //string timeStamp = GetTimestamp(DateTime.Now);
                DateTime Curnt_Time;
                Curnt_Time =  Convert.ToDateTime(DateTime.Now);
                string InsertAt = Curnt_Time.ToString("yyyy-MM-dd HH:mm:ss");
                lblMessage.Visible = false;
                lblMessage.Text = "";
                clsConsole.InsertIntoArticle(Convert.ToInt32(ddlArticle.SelectedValue.ToString()), txtTitle.Text, txtHeadline.Text, txtDetails.Text, date, InsertAt);
                clearAll();
            }
            else
            {
                lblMessage.Visible = true;
                lblMessage.Text = "Please Enter your Article Title and Content";
            }

            
        }


        void clearAll()
        {
            ddlArticle.SelectedIndex = 0;
            txtTitle.Text = "";
            txtDetails.Text = "";
            lblMessage.Visible = false;
            lblMessage.Text = "" ;
            txtHeadline.Text = "";

        }

       
    }
}
