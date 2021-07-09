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
    
    public partial class frmMedicalInsAddress : Form
    {
        clsConsolers clsConsole = new clsConsolers();
        public frmMedicalInsAddress()
        {
            InitializeComponent();
            clsConsole.fill_City_All(ddlCity);
        }



        private void ddlCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            string City = ddlCity.SelectedItem.ToString();
            clsConsole.fill_Address_New(ddlAdressID, City);
        }


        private void ddlAdressID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string City = ddlCity.SelectedItem.ToString();
            string Street_Zipcode = ddlAdressID.SelectedItem.ToString();

            int Address_ID = 0;
           // clsConsole.fix_Address_ID(ddlAdressID, City, Street_Zipcode);

            //int Address_ID = clsConsole.GetMedical_ID(City, Street_Zipcode);

            // string City1 = ddlCity.SelectedItem.ToString();

            DataSet dsStudent = new DataSet();
            dsStudent.Merge(clsConsole.GetMedical_ID_data(City, Street_Zipcode));
            foreach (DataRow dr in dsStudent.Tables["Medical"].Rows)
            {
                Address_ID = Convert.ToInt32(dr["ID"].ToString());
            }

            lblAddressID.Text = Convert.ToString(Address_ID);

        }

        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int Distance = Convert.ToInt32(txtValue.Text);
            int Addressvalue = Convert.ToInt32(lblAddressID.Text);  //ddlAdressID.SelectedItem.ToString();

            //int Addressvalue = 0;
            // int value = Convert.ToInt32(txtValue.Text);

            if (ddlCity.SelectedItem.ToString() != "Select" && Distance > 0)
            {
                clsConsole.SearchMedicalInstitution(lstTeachers, Addressvalue, Distance);
            }
        }

       
    }
}
