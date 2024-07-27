using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace MidProjectDb.UserPanels
{
    public partial class frmAssessComp : UserControl
    {
        public frmAssessComp()
        {
            InitializeComponent();
            showRubrics();
            showAssess();
        }

        private void showAssess()
        {
            try
            {
                using (var conf = new SqlConnection(commonFunctions.ConnectionStr))
                {
                    conf.Open();
                    using (var cmd = new SqlCommand("SELECT * FROM Assessment", conf))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        gridShowAssess.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                commonFunctions.showErrortBox(ex.Message);
            }
        }

        private void showRubrics()
        {
            try
            {
                using (var conf = new SqlConnection(commonFunctions.ConnectionStr))
                {
                    conf.Open();
                    using (var cmd = new SqlCommand("Select * From Rubric", conf))
                    {
                        SqlDataAdapter sql = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sql.Fill(dt);
                        gridShowRubric.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                commonFunctions.showErrortBox(ex.Message);
            }
        }

        private void btnAddComp_Click(object sender, EventArgs e)
        {
            string name = txtCompName.Text, tMarks = txtTMarks.Text;
            int totalMarks;
            if (commonFunctions.isValidInt(tMarks))
            {
                totalMarks = int.Parse(txtTMarks.Text);
            }
            else
            {
                commonFunctions.showAlertBox("Enter valid Integer in Marks...");
                return;
            }

            DateTime dateTime = DateTime.Now.Date;
            if (gridShowAssess.SelectedRows.Count > 0 && gridShowRubric.SelectedRows.Count > 0)
            {
                string title = gridShowAssess.SelectedRows[0].Cells["Title"].Value.ToString();
                string rDetails = gridShowRubric.SelectedRows[0].Cells["Details"].Value.ToString();

                using (var conf = new SqlConnection(commonFunctions.ConnectionStr))
                {
                    conf.Open();

                    var assessID = new SqlCommand("SELECT Id FROM Assessment WHERE Title = @title", conf);
                    assessID.Parameters.AddWithValue("@title", title);
                    int assId = Convert.ToInt32(assessID.ExecuteScalar());
                    var rubId = new SqlCommand("SELECT Id FROM Rubric WHERE Details = @details", conf);
                    rubId.Parameters.AddWithValue("@details", rDetails);
                    int rid = Convert.ToInt32(rubId.ExecuteScalar());
                    using (var cmd = new SqlCommand("INSERT INTO AssessmentComponent (Name, RubricID, TotalMarks, DateCreated, DateUpdated, AssessmentId) VALUES (@name, @rId, @totalMarks, @cdate, @udate, @asId)", conf))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@rId", rid);
                        cmd.Parameters.AddWithValue("@totalMarks", totalMarks);
                        cmd.Parameters.AddWithValue("@cdate", dateTime);
                        cmd.Parameters.AddWithValue("@udate", dateTime);
                        cmd.Parameters.AddWithValue("@asId", assId);
                        cmd.ExecuteNonQuery();
                        commonFunctions.showBox("Done");
                    }
                }
            }
        }

    }
}
