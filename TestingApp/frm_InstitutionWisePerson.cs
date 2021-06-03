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
    public partial class frm_InstitutionWisePerson : Form
    {
        clsConsolers varInsert = new clsConsolers();

        public frm_InstitutionWisePerson()
        {
            InitializeComponent();            
            varInsert.callPersonList(lstPerson);
        }
    }
}
