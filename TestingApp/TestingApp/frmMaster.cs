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
    public partial class frmMaster : Form
    {
        public frmMaster()
        {
            InitializeComponent();
        }

        

        public void showForm(Form frm)
        {
            closeForm();

            this.IsMdiContainer = true;
            frm.MdiParent = this;
            frm.Show();
        }
        public void closeForm()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
        }
        private void distanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmSearchwithDistance();
            showForm(frm);
        }
        private void personToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_distanceAddress();
            showForm(frm);
        }

        

        private void distanceFromPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_persondistance();
            showForm(frm);
        }

        private void institutionWisePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_InstitutionWisePerson();
            showForm(frm);
        }

        private void subjectWisePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_SubjectWisePerson();
            showForm(frm);
        }

        

        private void subjectWisePersonToolStripMenuItemdtl_Click(object sender, EventArgs e)
        {
            Form frm = new frm_SubjectWisePersondtl();
            showForm(frm);
        }

        private void bedsQuantityForDeptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_DepartmentwiseBeds();
            showForm(frm);
        }

        private void articlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_PublishArticle();
            showForm(frm);
        }

        private void articlePublicationCurrentWebpageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frm_PublishArticleOld();
            showForm(frm);
        }

        private void withSpecializationToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // Form frm = new frm_HospitalwithSpec();
          //  showForm(frm);
        }

        private void medicalInstitutionFromAddressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmMedicalInsAddress();
            showForm(frm);
        }
    }
}
