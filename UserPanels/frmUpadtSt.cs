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
    public partial class frmUpadtSt : UserControl
    {
        private String ConnectionStr = @"Data Source=(local);Initial Catalog=ProjectB;Integrated Security=True";

        public frmUpadtSt()
        {
            InitializeComponent();
            viewRegisteredSt();
        }
        private void viewRegisteredSt()
        {
            using (var con = new SqlConnection(commonFunctions.ConnectionStr))
            {
                using (SqlCommand cmd = new SqlCommand("Select FirstName,LastName,Contact,Email,RegistrationNumber ,Status From Student", con))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gridViewRegSt.DataSource = dt;
                }
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAddSt_Click(object sender, EventArgs e)
        {
            
        }


        private void CellClicked(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex == -1 && e.ColumnIndex == -1)
            {
                return;
            }
            if (gridViewRegSt.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gridViewRegSt.SelectedRows[0];
                txtFirstName.Text = selectedRow.Cells["FirstName"].Value.ToString();
                txtLastName.Text = selectedRow.Cells["LastName"].Value.ToString();
                txtContact.Text = selectedRow.Cells["Contact"].Value.ToString();
                txtEmail.Text = selectedRow.Cells["Email"].Value.ToString();
                txtRegNo.Text = selectedRow.Cells["RegistrationNumber"].Value.ToString();
                txtStatus.Text = selectedRow.Cells["Status"].Value.ToString();
            }
        }

        private void btnUpdateSt_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "" || txtLastName.Text == "" || txtContact.Text == "" || txtEmail.Text == "" || txtRegNo.Text == "")
            {
                MessageBox.Show("First Enter All Credentials...");
                goto end;
            }
            try
            {
                string fname = txtFirstName.Text, lname = txtLastName.Text, contact = txtContact.Text, email = txtEmail.Text, regNo = txtRegNo.Text, status = txtStatus.Text;

                using (var conf = new SqlConnection(ConnectionStr))
                {
                    conf.Open();
                    using (var idSelection = new SqlCommand("SELECT id FROM Student WHERE RegistrationNumber = @regNo", conf))
                    {
                        idSelection.Parameters.AddWithValue("@regNo", regNo);

                       DataGridViewRow row = gridViewRegSt.SelectedRows[0];
                        if (row.Cells["RegistrationNumber"].Value == null)
                        {
                            MessageBox.Show("No Data in selected Row");
                            goto end;
                        }
                        if(idSelection.ExecuteScalar() == null)
                        {
                            commonFunctions.showErrortBox("ID id null \n Student Registration number cannot be changed...");
                            return;
                        }
                        int studentID = int.Parse(idSelection.ExecuteScalar().ToString());
                        SqlCommand change = new SqlCommand("UPDATE Student SET FirstName = @FirstName, LastName = @LastName, Contact = @Contact, Email = @Email, RegistrationNumber = @RegistrationNumber, Status = @Status WHERE ID = @ID", conf);
                        change.Parameters.AddWithValue("@FirstName", fname);
                        change.Parameters.AddWithValue("@LastName", lname);
                        change.Parameters.AddWithValue("@Contact", contact);
                        change.Parameters.AddWithValue("@Email", email);
                        change.Parameters.AddWithValue("@RegistrationNumber", regNo);
                        change.Parameters.AddWithValue("@Status", status);
                        change.Parameters.AddWithValue("@ID", studentID);
                        change.ExecuteNonQuery();
                        MessageBox.Show("Updated Successfully...");
                        viewRegisteredSt();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            end: { }
        }

        private void pnlStMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void gridViewRegSt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtRegNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
