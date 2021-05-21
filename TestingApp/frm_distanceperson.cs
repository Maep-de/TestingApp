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
    
    public partial class frm_distanceperson : Form
    {
        clsConsolers clsConsole = new clsConsolers();

        public frm_distanceperson()
        {
            InitializeComponent();
            clsConsole.fiil_CBO(ddlAdressID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // string value = ddlAdressID.SelectedItem.ToString();
            label3.Text = ddlAdressID.SelectedValue.ToString();
            label4.Text = ddlAdressID.SelectedItem.ToString()+"-item-"+
                ddlAdressID.SelectedIndex.ToString() + "-index-" + ddlAdressID.SelectedText.ToString()
                + "-text-";

        }
    }
}
