using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MidProjectDb.UserPanels
{
    public partial class frmAddSt : UserControl
    {
        private String ConnectionStr = @"Data Source=(local);Initial Catalog=ProjectB;Integrated Security=True";

        public frmAddSt()
        {
            InitializeComponent();
        }

        private void btnAddSt_Click(object sender, EventArgs e)
        {

            string fName = txtFirstName.Text, lName = txtLastName.Text, contact = txtContact.Text, email = txtEmail.Text, regNo = txtRegNo.Text;
            if (commonFunctions.validAllCredientials(ref fName,ref lName, ref contact,ref email,ref regNo))
            {
                try
                {

                    using (var con = new SqlConnection(ConnectionStr))
                    {
                        using (SqlCommand cmd = new SqlCommand("Insert into Student (FirstName, LastName, Contact, Email, RegistrationNumber, Status) values (@FirstName, @LastName, @Contact, @Email, @RegistrationNumber, @Status)", con))
                        {
                            con.Open();
                            cmd.Parameters.AddWithValue("@FirstName", fName);
                            cmd.Parameters.AddWithValue("@LastName", lName);
                            cmd.Parameters.AddWithValue("@Contact", contact);
                            cmd.Parameters.AddWithValue("@Email", email);
                            cmd.Parameters.AddWithValue("@RegistrationNumber", regNo);
                            cmd.Parameters.AddWithValue("@Status", 5);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Student Added Successfully...");
                            txtFirstName.Text = "";
                            txtLastName.Text = "";
                            txtContact.Text = "";
                            txtEmail.Text = "";
                            txtRegNo.Text = "";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
