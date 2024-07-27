using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MidProjectDb.UserPanels
{
    public partial class frmClo : UserControl
    {
        public frmClo()
        {
            InitializeComponent();
        }

        private void btnUpdateSt_Click(object sender, EventArgs e)
        {
            string cloName = txtCloName.Text, rubricDetail = txtRubricDetail.Text, lvl1 = txtlvl1Details.Text, lvl2 = txtlvl2Details.Text, lvl3 = txtlvl3Details.Text, lvl4 = txtlvl4Details.Text;
            if (commonFunctions.isEmptyStr(cloName) || commonFunctions.isEmptyStr(rubricDetail) || commonFunctions.isEmptyStr(lvl4) || commonFunctions.isEmptyStr(lvl3) || commonFunctions.isEmptyStr(lvl2) || commonFunctions.isEmptyStr(lvl1))
            {
                commonFunctions.showAlertBox("Kindly Fill all Fields First...");
                return;
            }
            try
            {
                using (var conf = new SqlConnection(commonFunctions.ConnectionStr))
                {
                    conf.Open();
                    var clo = new SqlCommand("Select Name from CLO Where Name = @cloName", conf);
                    clo.Parameters.AddWithValue("@cloName", cloName);
                    object cloObj = clo.ExecuteScalar();
                    if (cloObj != null)
                    {
                        commonFunctions.showAlertBox("CLO with this name is already present. Please choose a different name");
                       // return;
                    }
                    DateTime currDate = DateTime.Now;
                    var insertClo = new SqlCommand("Insert Into Clo values (@cloName,@currDate,@currDate2)", conf);
                    insertClo.Parameters.AddWithValue("@cloName", cloName);
                    insertClo.Parameters.AddWithValue("@currDate", currDate);
                    insertClo.Parameters.AddWithValue("@currDate2", currDate);
                    insertClo.ExecuteNonQuery();
                    if (isAlreadyRubric(rubricDetail))
                    {
                        commonFunctions.showAlertBox("Rubric With same details is Already Present...");
                        return;
                    }
                    int cloID = getCloId(cloName);
                    if( cloID < 0 )
                    {
                        commonFunctions.showAlertBox("No clo with this name");
                        return;
                    }
                    var insertRubric = new SqlCommand("Insert Into Rubric (ID,Details,CloId) values ((Select Count(*)+1 From Rubric),@rubricDetails,@cloID)", conf);
                    insertRubric.Parameters.AddWithValue("@rubricDetails", rubricDetail);
                    insertRubric.Parameters.AddWithValue("@cloID", cloID);
                    insertRubric.ExecuteNonQuery();

                    int rId = getRubricId(rubricDetail);
                    if (rId < 0)
                    {
                        commonFunctions.showAlertBox("No Rubric with this details");
                        return;
                    }
                    addRubLvl(rId, lvl4, 4);
                    addRubLvl(rId, lvl3, 3);
                    addRubLvl(rId, lvl2, 2);
                    addRubLvl(rId, lvl1, 1);
                    commonFunctions.showInfoBox("Clo Added successfully...");
                    clearAll();

                }
            }
            catch (Exception ex)
            {
                commonFunctions.showErrortBox(ex.ToString());
            }
        }

        private bool isAlreadyRubric(string rubricDetails)
        {
            using (var conf = new SqlConnection(commonFunctions.ConnectionStr))
            {
                conf.Open();
                var isAlready = new SqlCommand("Select Details From Rubric where Details = @rubricDetails", conf);
                isAlready.Parameters.AddWithValue("@rubricDetails", rubricDetails);
                object rubObj = isAlready.ExecuteScalar();
                if (rubObj != null)
                {
                    return true;
                }
            }
            return false;
        }

        private int getCloId(string cloName)
        {
            using (var conf = new SqlConnection(commonFunctions.ConnectionStr))
            {
                conf.Open();
                var isAlready = new SqlCommand("Select Id from Clo Where Name = @cloName", conf);
                isAlready.Parameters.AddWithValue("@cloName", cloName);
                object cloObj = isAlready.ExecuteScalar();
                if (cloObj != null)
                {
                    return (int)cloObj;
                }
                return -1;
            }
        }

        private int getRubricId(string rubricDetails)
        {
            using (var conf = new SqlConnection(commonFunctions.ConnectionStr))
            {
                conf.Open();
                var isAlready = new SqlCommand("Select ID from Rubric Where Details = @rDetail", conf);
                isAlready.Parameters.AddWithValue("@rDetail", rubricDetails);
                object roubObj = isAlready.ExecuteScalar();
                if(roubObj != null)
                {
                    return (int) roubObj;
                }
                return -1;
            }
        }

        private void addRubLvl(int rID,string details,int mLvl)
        {
           using (var conf = new  SqlConnection(commonFunctions.ConnectionStr))
            {
                conf.Open();
                var insertRubLvl = new SqlCommand($"Insert Into RubricLevel (RubricId,Details ,MeasurementLevel) values (@rId, @details,  @mLvl)", conf);
                insertRubLvl.Parameters.AddWithValue("@rid", rID);
                insertRubLvl.Parameters.AddWithValue("@details", details);
                insertRubLvl.Parameters.AddWithValue("@mLvl", mLvl);
                insertRubLvl.ExecuteNonQuery();
            }
        }
        private void clearAll()
        {
            txtCloName.Text = "";
            txtlvl1Details.Text = "";
            txtlvl2Details.Text = "";
            txtlvl3Details.Text = "";
            txtlvl4Details.Text = "";
            txtRubricDetail.Text = "";
        }

    }
}
