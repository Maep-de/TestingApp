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
    
    public partial class frm_distanceAddress : Form
    {
        clsConsolers clsConsole = new clsConsolers();

        public frm_distanceAddress()
        {
            InitializeComponent();
            clsConsole.fiil_CBO(ddlAdressID);
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    // string value = ddlAdressID.SelectedItem.ToString();
        //    label3.Text = ddlAdressID.SelectedValue.ToString();
        //    label4.Text = ddlAdressID.SelectedItem.ToString()+"-item-"+
        //        ddlAdressID.SelectedIndex.ToString() + "-index-" + ddlAdressID.SelectedText.ToString()
        //        + "-text-";

        //}

        private void ddlAdressID_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Text = ddlAdressID.SelectedValue.ToString();
            label4.Text = ddlAdressID.SelectedItem.ToString() + "-item-" +
                ddlAdressID.SelectedIndex.ToString() + "-index-" + ddlAdressID.SelectedText.ToString()
                + "-text-";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int Addressvalue = Convert.ToInt32(ddlAdressID.SelectedValue.ToString());
            int value = Convert.ToInt32(txtValue.Text);

            if (Addressvalue > 0 && value > 0)
            {
                clsConsole.SearchProductData(lstTeachers, Addressvalue,value);
            }
            
        }

        
    }
}
