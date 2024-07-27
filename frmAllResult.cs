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
    public partial class frmAllResult : UserControl
    {
        public frmAllResult()
        {
            InitializeComponent();
            ViewRegisteredStudents();
        }
        private void ViewRegisteredStudents()
        {
            try
            {
                using (var connection = new SqlConnection(commonFunctions.ConnectionStr))
                using (var command = new SqlCommand("SELECT * FROM StudentResult", connection))
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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("University of Engineering & Technology", new Font("Arial Black", 25, FontStyle.Bold), Brushes.Black, new Point(40, 40));
            e.Graphics.DrawString("Final Year Project Management System", new Font("Arial Black", 15, FontStyle.Bold), Brushes.Black, new Point(190, 100));
            e.Graphics.DrawString("Result of All Evaluated Students", new Font("Arial Black", 15, FontStyle.Bold), Brushes.Black, new Point(250, 150));
            e.Graphics.DrawString("___________________________", new Font("Arial Black", 15, FontStyle.Bold), Brushes.Black, new Point(0, 200));

            e.Graphics.DrawString("Date: " + DateTime.Now.ToShortDateString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(10, 250));
            e.Graphics.DrawString("Time: " + DateTime.Now.ToShortTimeString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(350, 250));
            e.Graphics.DrawString("___________________________", new Font("Arial Black", 15, FontStyle.Bold), Brushes.Black, new Point(0, 300));

            using (var conf = new SqlConnection(commonFunctions.ConnectionStr))
            {
                conf.Open();
                var cmd = new SqlCommand("Select StudentId,AssessmentComponentId,RubricMeasurementId,EvaluationDate From StudentResult", conf);
                SqlDataAdapter sql = new SqlDataAdapter(cmd);

                DataTable AdvisorData = new DataTable();
                sql.Fill(AdvisorData);

                int yPos = 350;
                e.Graphics.DrawString("StudentId", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(10, yPos));
                e.Graphics.DrawString("EvaluationDate", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(150, yPos));
                e.Graphics.DrawString("AssessmentComponentId", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(500, yPos));
                e.Graphics.DrawString("ObtainedMarks", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(350, yPos));
                
                yPos += 30;
                yPos += 10;



                foreach (DataRow row in AdvisorData.Rows)
                {
                    int assid = Convert.ToInt32(row["AssessmentComponentId"]);
                    int rubid = Convert.ToInt32(row["RubricMeasurementId"]);
                    var stMark = new SqlCommand("SELECT TotalMarks FROM AssessmentComponent WHERE Id = @assid", conf);
                    stMark.Parameters.AddWithValue("@assid", assid);
                    object markObj = stMark.ExecuteScalar();
                    int totalMarks = Convert.ToInt32(markObj);
                    var mlvl = new SqlCommand("SELECT MeasurementLevel FROM RubricLevel WHERE Id = @rubid", conf);
                    mlvl.Parameters.AddWithValue("@rubid", rubid);
                    object mlvlObj = mlvl.ExecuteScalar();
                    int measurementLevel = Convert.ToInt32(mlvlObj);

                    float obtained = (totalMarks * measurementLevel) / 4;

                    e.Graphics.DrawString(row["StudentId"].ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, yPos));
                    e.Graphics.DrawString(row["EvaluationDate"].ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(150, yPos));
                    e.Graphics.DrawString(row["AssessmentComponentId"].ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(500, yPos));
                    e.Graphics.DrawString(obtained.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(350, yPos));

                    yPos += 30;
                }


            }
        }

        private void btnPrintResult_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}

