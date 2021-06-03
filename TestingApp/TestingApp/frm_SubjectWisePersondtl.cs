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
    public partial class frm_SubjectWisePersondtl : Form
    {
        clsConsolers clsConsole = new clsConsolers();

        public frm_SubjectWisePersondtl()
        {
            InitializeComponent();
            clsConsole.fill_Subject(ddlSubject);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string Subject = ddlSubject.SelectedValue.ToString();
            

            if (Subject != null )
            {
                clsConsole.SearchPerson_Subjwise(lstPersonSubwise, Subject);
            }
        }
    }
}
