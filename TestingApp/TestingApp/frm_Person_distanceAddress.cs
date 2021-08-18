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
    
    public partial class frm_Person_distanceAddress : Form
    {
        clsConsolers clsConsole = new clsConsolers();

        public frm_Person_distanceAddress()
        {
            InitializeComponent();
            clsConsole.fill_City_All(ddlCity);
            // clsConsole.fiil_CBO(ddlAdressID);
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    // string value = ddlAdressID.SelectedItem.ToString();
        //    label3.Text = ddlAdressID.SelectedValue.ToString();
        //    label4.Text = ddlAdressID.SelectedItem.ToString()+"-item-"+
        //        ddlAdressID.SelectedIndex.ToString() + "-index-" + ddlAdressID.SelectedText.ToString()
        //        + "-text-";

        //}

        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string City = ddlCity.SelectedItem.ToString();
            int Addressvalue = Convert.ToInt32(lblAddressID.Text);


            //int Addressvalue = 0;
            int value = Convert.ToInt32(txtValue.Text);

            if (ddlCity.SelectedItem.ToString() != "Select" && value > 0)
            {
                clsConsole.SearchProductData(lstTeachers, Addressvalue, value);
            }
            
        }

        private void ddlCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            string City = ddlCity.SelectedItem.ToString();
            clsConsole.fill_Address_New(ddlAdressID, City);
        }

        private void frm_Person_distanceAddress_Load(object sender, EventArgs e)
        {

        }

        private void ddlAdressID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string City = ddlCity.SelectedItem.ToString();
            string Street_Zipcode = ddlAdressID.SelectedItem.ToString();

            int Address_ID = 0;

            DataSet dsStudent = new DataSet();
            dsStudent.Merge(clsConsole.GetMedical_ID_data(City, Street_Zipcode));
            foreach (DataRow dr in dsStudent.Tables["Medical"].Rows)
            {
                Address_ID = Convert.ToInt32(dr["ID"].ToString());
            }

            lblAddressID.Text = Convert.ToString(Address_ID);
        }
    }
}
