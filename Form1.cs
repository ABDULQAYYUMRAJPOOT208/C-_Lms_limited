using MidProjectDb.UserPanels;
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

namespace MidProjectDb
{
    public partial class dashBoard : Form
    {
        public dashBoard()
        {
            InitializeComponent();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void addUserPanel(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            dashPanel.Controls.Clear();
            dashPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            EnrolledStudents pannel = new EnrolledStudents();
            addUserPanel(pannel);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmClo pannel = new frmClo();
            addUserPanel(pannel);
        }

        private void dashPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBackMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAttendence pannel = new frmAttendence();
            addUserPanel(pannel);
        }

        private void btnAssessment_Click(object sender, EventArgs e)
        {
            frmAssessmenct pannel = new frmAssessmenct();
            addUserPanel(pannel);
        }

        private void btnAssessComp_Click(object sender, EventArgs e)
        {
            frmAssessComp pannel = new frmAssessComp();
            addUserPanel(pannel);
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            Result pannel = new Result();
            addUserPanel(pannel);
        }

        private void btnAllResult_Click(object sender, EventArgs e)
        {
            frmAllResult pannel = new frmAllResult();
            addUserPanel(pannel);
        }
    }
}
