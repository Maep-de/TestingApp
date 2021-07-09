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


        private void btnSearch_Click(object sender, EventArgs e)
        {
            string City = ddlCity.SelectedItem.ToString();
            string Address = ddlAdressID.SelectedItem.ToString();

            int Addressvalue = 0;
            int value = Convert.ToInt32(txtValue.Text);

            if (ddlCity.SelectedItem.ToString() != "Select" && value > 0)
            {
                clsConsole.SearchMedicalInstitution(lstTeachers, Addressvalue, value);
            }

        }

        

        private void ddlAdressID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string City = ddlCity.SelectedItem.ToString();
            string Street_Zipcode = ddlAdressID.SelectedItem.ToString();

            
           // clsConsole.fix_Address_ID(ddlAdressID, City, Street_Zipcode);

            int Address_ID = clsConsole.GetMedical_ID(City, Street_Zipcode);

           // string City1 = ddlCity.SelectedItem.ToString();



        }

        private void ddlCity_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string City = ddlCity.SelectedItem.ToString();
            clsConsole.fill_Address_New(ddlAdressID, City);
        }
    }
}
