using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MidProjectDb.UserPanels
{
    public partial class ResultPanel : UserControl
    {
        private readonly string connectionString = commonFunctions.ConnectionStr;

        public ResultPanel()
        {
            InitializeComponent();
            ShowAssessmentComponents();
            ShowRubricLevels();
            ViewRegisteredStudents();
        }

        private void ShowAssessmentComponents()
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                using (var command = new SqlCommand("SELECT * FROM AssessmentComponent", connection))
                {
                    connection.Open();
                    var reader = command.ExecuteReader();
                    var dataTable = new DataTable();
                    dataTable.Load(reader);
                    gridShowAssessComp.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowRubricLevels()
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                using (var command = new SqlCommand("SELECT * FROM RubricLevel", connection))
                {
                    connection.Open();
                    var adapter = new SqlDataAdapter(command);
                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    gridShowRubricLvl.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCalculateResult_Click(object sender, EventArgs e)
        {
            if (gridShowAssessComp.SelectedRows.Count > 0 &&
                gridShowRubricLvl.SelectedRows.Count > 0 &&
                gridShowSt.SelectedRows.Count > 0)
            {
                string name = gridShowAssessComp.SelectedRows[0].Cells["Name"].Value.ToString();
                string rdetail = gridShowRubricLvl.SelectedRows[0].Cells["Details"].Value.ToString();
                string rollNo = gridShowSt.SelectedRows[0].Cells["RegistrationNumber"].Value.ToString();

                using (var conn = new SqlConnection(commonFunctions.ConnectionStr))
                {
                    conn.Open();
                    int assCompId, stId, rId;
                    DateTime currDate = DateTime.Now.Date;
                    using (var cmd = new SqlCommand("SELECT ID FROM AssessmentComponent WHERE Name = @name", conn))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        assCompId = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    using (var cmd = new SqlCommand("SELECT ID FROM RubricLevel WHERE Details = @rdetail", conn))
                    {
                        cmd.Parameters.AddWithValue("@rdetail", rdetail);
                        rId = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    using (var cmd = new SqlCommand("SELECT ID FROM Student WHERE RegistrationNumber = @rollNo", conn))
                    {
                        cmd.Parameters.AddWithValue("@rollNo", rollNo);
                        stId = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    using (var cmd = new SqlCommand("MERGE INTO StudentResult AS Target " +
                                 "USING (VALUES (@stId, @assCompId, @rId, @currDate)) AS Source (StudentId, AssessmentComponentId, RubricMeasurementId, EvaluationDate) " +
                                 "ON (Target.StudentId = Source.StudentId AND Target.AssessmentComponentId = Source.AssessmentComponentId) " +
                                 "WHEN MATCHED THEN " +
                                 "UPDATE SET RubricMeasurementId = @rId, EvaluationDate = @currDate " +
                                 "WHEN NOT MATCHED THEN " +
                                 "INSERT (StudentId, AssessmentComponentId, RubricMeasurementId, EvaluationDate) " +
                                 "VALUES (@stId, @assCompId, @rId, @currDate);", conn))
                    {
                        cmd.Parameters.AddWithValue("@stId", stId);
                        cmd.Parameters.AddWithValue("@assCompId", assCompId);
                        cmd.Parameters.AddWithValue("@rId", rId);
                        cmd.Parameters.AddWithValue("@currDate", currDate);
                        cmd.ExecuteNonQuery();
                        commonFunctions.showBox("Done");
                    }
                    using (var cmd = new SqlCommand("SELECT MeasurementLevel FROM RubricLevel WHERE Details = @rdetail", conn))
                    {
                        var cMark = new SqlCommand("SELECT TotalMarks FROM AssessmentComponent WHERE Name = @name", conn);
                        cMark.Parameters.AddWithValue("@name", name);
                        int totalMarks = Convert.ToInt32(cMark.ExecuteScalar());
                        cmd.Parameters.AddWithValue("@rdetail", rdetail);
                        int rlvl = Convert.ToInt32(cmd.ExecuteScalar());
                        float obtained = (rlvl * totalMarks) /4 ;
                        lblMarks.Text = "Obtained Marks : " + obtained;
                    }
                }
            }
        }

        private bool isAlreadyResult(int id, SqlConnection conf, string regNo)
        {
            var cmd = new SqlCommand("Select * from StudentResult where StudentID = @id", conf);
            cmd.Parameters.AddWithValue("@id", id);
            object obj = cmd.ExecuteScalar();
            if(obj != null)
            {
                return true;
            }
            return false;
        }

        private void ViewRegisteredStudents()
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                using (var command = new SqlCommand("SELECT FirstName, RegistrationNumber FROM Student where status <> 6", connection))
                {
                    connection.Open();
                    var adapter = new SqlDataAdapter(command);
                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    gridShowSt.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
