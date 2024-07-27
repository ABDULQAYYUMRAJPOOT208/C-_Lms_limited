using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MidProjectDb.UserPanels
{
    public partial class frmAssessmenct : UserControl
    {
        public frmAssessmenct()
        {
            InitializeComponent();
        }

        private void btnCreateAssess_Click(object sender, EventArgs e)
        {
            try
            {
                string title = txtAssessTitle.Text, tMarks = txtTotalMarks.Text, tWeight = txtTotalWeightage.Text;
                int totalMarks, totalWeight;
                if(isTitleAlready(title))
                {
                    commonFunctions.showAlertBox("This title is already present... \n Use a different name...");
                    return;
                }
                if (commonFunctions.isValidInt(tMarks))
                {
                    totalMarks = int.Parse(tMarks);
                }
                else
                {
                    commonFunctions.showAlertBox("Please Enter valid number in Total Marks...");
                    return;
                }
                if (commonFunctions.isValidInt(tWeight))
                {
                    totalWeight = int.Parse(tWeight);
                }
                else
                {
                    commonFunctions.showAlertBox("Please Enter valid number in Total Weightage...");
                    return;
                }
                DateTime currDate = DateTime.Now.Date;

                using (var conf = new SqlConnection(commonFunctions.ConnectionStr)) 
                {
                    conf.Open();
                    using (var cmd = new SqlCommand("Insert Into Assessment (Title, DateCreated, TotalMarks, TotalWeightage) Values (@title, @date, @tmarks,@tweight )",conf))
                    {
                        cmd.Parameters.AddWithValue("@title", title);
                        cmd.Parameters.AddWithValue("@date", currDate);
                        cmd.Parameters.AddWithValue("@tmarks", totalMarks);
                        cmd.Parameters.AddWithValue("@tweight", totalWeight);
                        cmd.ExecuteNonQuery();
                    }
                }

            }
            catch (Exception ex)
            {
                commonFunctions.showErrortBox(ex.Message);
            }
        }

        private bool isTitleAlready(string t)
        {
            using (var conf = new SqlConnection(commonFunctions.ConnectionStr))
            {
                conf.Open();
                using (var cmd = new SqlCommand($"Select Assessment.Title From Assessment Where Title = @t",conf))
                {
                    cmd.Parameters.Add("@t", t);
                    object tObj = cmd.ExecuteScalar();
                    if(tObj != null)
                    {
                        return true;
                    }
                    return false;
                }
            }
        }
    }
}
