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

namespace MidProjectDb.UserPanels
{
    public partial class Result : UserControl
    {
        public Result()
        {
            InitializeComponent();
            showAssess();
            showRubrics();
        }

        private void gridShowRubric_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
        private void btnGoToResult_Click(object sender, EventArgs e)
        {
            
        }
        private void addUserPanel(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            dashPannel.Controls.Clear();
            dashPannel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnGoToResult_Click_1(object sender, EventArgs e)
        {
            if (gridShowAssess.SelectedRows.Count > 0 && gridShowRubric.SelectedRows.Count > 0)
            {
                

                ResultPanel pannel = new ResultPanel();
                addUserPanel(pannel);
            }
        }
    }
}
