using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MidProjectDb.UserPanels
{
    public partial class frmDeleteSt : UserControl
    {
        private String ConnectionStr = @"Data Source=(local);Initial Catalog=ProjectB;Integrated Security=True";
        public frmDeleteSt()
        {
            InitializeComponent();
            viewAllSt();
        }
        private void viewAllSt()
        {
            using (var conf = new SqlConnection(ConnectionStr))
            {
                conf.Open();
                SqlCommand allSt = new SqlCommand("Select FirstName,LastName,Contact,Email,RegistrationNumber From Student Where Status <> 6", conf);
                allSt.ExecuteNonQuery();
                SqlDataAdapter sqlData = new SqlDataAdapter(allSt);
                DataTable dt = new DataTable();
                sqlData.Fill(dt);
                gridViewRegSt.DataSource = dt;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridViewRegSt.SelectedRows.Count > 0)
            {

                try
                {

                    using (var conf = new SqlConnection(ConnectionStr))
                    {
                        conf.Open();
                        DataGridViewRow dr = gridViewRegSt.SelectedRows[0];
                        if (dr.Cells["RegistrationNumber"].Value == null)
                        {
                            MessageBox.Show("No Data In Selected Row...");
                            goto end;
                        }
                        string id = dr.Cells["RegistrationNumber"].Value.ToString();
                        using (var selectID = new SqlCommand("Update Student Set Status = 6 Where RegistrationNumber = @id", conf))
                        {
                            selectID.Parameters.AddWithValue("@id", id);
                            MessageBox.Show("Student Deleted Successfully...");
                            selectID.ExecuteNonQuery();
                            viewAllSt();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        end: { }
        }

        private void gridViewRegSt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex == -1)
            {
                return;
            }
        }
    }
}
