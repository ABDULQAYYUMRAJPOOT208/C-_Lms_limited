using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using task1Lab1;

namespace MidProjectDb.UserPanels
{
    public partial class EnrolledStudents : UserControl
    {
        public EnrolledStudents()
        {
            InitializeComponent();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EnStHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddSt_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       private void addPanel(UserControl pannel)
        {
            pannel.Dock = DockStyle.Fill;
            dashPannel.Controls.Clear();
            dashPannel.Controls.Add(pannel);
            pannel.BringToFront();

        }

        private void picViewST_Click(object sender, EventArgs e)
        {
            btnAddSt_Click(sender, e);
        }

        private void btnViewSt_Click(object sender, EventArgs e)
        {
            frmViewRegisteredStudent view = new frmViewRegisteredStudent();
            addPanel(view);
        }

        private void btnAddSt_Click_1(object sender, EventArgs e)
        {
            frmAddSt pannel = new frmAddSt();
            addPanel(pannel);
        }

        private void btnUpdateSt_Click(object sender, EventArgs e)
        {
            frmUpadtSt pannel =new frmUpadtSt();
            addPanel(pannel);
        }

        private void btnDeleteSt_Click(object sender, EventArgs e)
        {
            frmDeleteSt pannel = new frmDeleteSt();
            addPanel(pannel);
        }
    }
}
