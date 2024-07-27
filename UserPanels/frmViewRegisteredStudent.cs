using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace MidProjectDb.UserPanels
{
    public partial class frmViewRegisteredStudent : UserControl
    {
        private String ConnectionStr = @"Data Source=(local);Initial Catalog=ProjectB;Integrated Security=True";
        public frmViewRegisteredStudent()
        {
            InitializeComponent();
            viewRegisteredSt();
        }

        private void viewRegisteredSt()
        {
            using (var con = new SqlConnection(ConnectionStr))
            {
                using (SqlCommand cmd = new SqlCommand("Select FirstName,LastName,Contact,Email,RegistrationNumber From Student Where Status <> 6", con))
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

        private void pnlStMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridViewRegSt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("University of Engineering & Technology", new Font("Arial Black", 25, FontStyle.Bold), Brushes.Black, new Point(40, 40));
            e.Graphics.DrawString("Final Year Project Management System", new Font("Arial Black", 15, FontStyle.Bold), Brushes.Black, new Point(190, 100));
            e.Graphics.DrawString("All Registered Students Report", new Font("Arial Black", 15, FontStyle.Bold), Brushes.Black, new Point(250, 150));
            e.Graphics.DrawString("___________________________", new Font("Arial Black", 15, FontStyle.Bold), Brushes.Black, new Point(0, 200));

            e.Graphics.DrawString("Date: " + DateTime.Now.ToShortDateString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(10, 250));
            e.Graphics.DrawString("Time: " + DateTime.Now.ToShortTimeString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(350, 250));
            e.Graphics.DrawString("___________________________", new Font("Arial Black", 15, FontStyle.Bold), Brushes.Black, new Point(0, 300));

            using (var conf = new SqlConnection(commonFunctions.ConnectionStr))
            {
                conf.Open();
                var cmd = new SqlCommand("Select FirstName,LastName,Contact,Email,RegistrationNumber From Student ", conf);
                SqlDataAdapter sql = new SqlDataAdapter(cmd);

                DataTable AdvisorData = new DataTable();
                sql.Fill(AdvisorData);


                int yPos = 350;
                e.Graphics.DrawString("First Name", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(10, yPos));
                e.Graphics.DrawString("Last Name", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(120, yPos));
                e.Graphics.DrawString("Contact", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(250, yPos));
                e.Graphics.DrawString("Email", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(350, yPos));
                e.Graphics.DrawString("RegistrationNumber", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(520, yPos));
                yPos += 30;

                yPos += 10;

                foreach (DataRow row in AdvisorData.Rows)
                {
                    e.Graphics.DrawString(row["FirstName"].ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, yPos));
                    e.Graphics.DrawString(row["LastName"].ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(120, yPos));
                    e.Graphics.DrawString(row["Contact"].ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(250, yPos));
                    e.Graphics.DrawString(row["Email"].ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(350, yPos));
                    e.Graphics.DrawString(row["RegistrationNumber"].ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(620, yPos));
                   
                    yPos += 30;
                }
            }

          }

        private void btnAllSt_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void btnOnlyDelete_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument2;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("University of Engineering & Technology", new Font("Arial Black", 25, FontStyle.Bold), Brushes.Black, new Point(40, 40));
            e.Graphics.DrawString("Final Year Project Management System", new Font("Arial Black", 15, FontStyle.Bold), Brushes.Black, new Point(190, 100));
            e.Graphics.DrawString("All Deleted Student Report", new Font("Arial Black", 15, FontStyle.Bold), Brushes.Black, new Point(250, 150));
            e.Graphics.DrawString("___________________________", new Font("Arial Black", 15, FontStyle.Bold), Brushes.Black, new Point(0, 200));

            e.Graphics.DrawString("Date: " + DateTime.Now.ToShortDateString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(10, 250));
            e.Graphics.DrawString("Time: " + DateTime.Now.ToShortTimeString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(350, 250));
            e.Graphics.DrawString("___________________________", new Font("Arial Black", 15, FontStyle.Bold), Brushes.Black, new Point(0, 300));

            using (var conf = new SqlConnection(commonFunctions.ConnectionStr))
            {
                conf.Open();
                var cmd = new SqlCommand("Select FirstName,LastName,Contact,Email,RegistrationNumber From Student Where Status = 6", conf);
                SqlDataAdapter sql = new SqlDataAdapter(cmd);

                DataTable AdvisorData = new DataTable();
                sql.Fill(AdvisorData);


                int yPos = 350;
                e.Graphics.DrawString("First Name", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(10, yPos));
                e.Graphics.DrawString("Last Name", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(120, yPos));
                e.Graphics.DrawString("Contact", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(250, yPos));
                e.Graphics.DrawString("Email", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(350, yPos));
                e.Graphics.DrawString("RegistrationNumber", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(520, yPos));
                
                yPos += 30;

                
                yPos += 10;

                foreach (DataRow row in AdvisorData.Rows)
                {
                    e.Graphics.DrawString(row["FirstName"].ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, yPos));
                    e.Graphics.DrawString(row["LastName"].ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(120, yPos));
                    e.Graphics.DrawString(row["Contact"].ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(250, yPos));
                    e.Graphics.DrawString(row["Email"].ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(350, yPos));
                   e.Graphics.DrawString(row["RegistrationNumber"].ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(620, yPos));
                    
                    yPos += 30;
                }
            }
        }

        private void printDocument3_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("University of Engineering & Technology", new Font("Arial Black", 25, FontStyle.Bold), Brushes.Black, new Point(40, 40));
            e.Graphics.DrawString("Final Year Project Management System", new Font("Arial Black", 15, FontStyle.Bold), Brushes.Black, new Point(190, 100));
            e.Graphics.DrawString("All Active Students Report", new Font("Arial Black", 15, FontStyle.Bold), Brushes.Black, new Point(250, 150));
            e.Graphics.DrawString("___________________________", new Font("Arial Black", 15, FontStyle.Bold), Brushes.Black, new Point(0, 200));

            e.Graphics.DrawString("Date: " + DateTime.Now.ToShortDateString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(10, 250));
            e.Graphics.DrawString("Time: " + DateTime.Now.ToShortTimeString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(350, 250));
            e.Graphics.DrawString("___________________________", new Font("Arial Black", 15, FontStyle.Bold), Brushes.Black, new Point(0, 300));

            using (var conf = new SqlConnection(commonFunctions.ConnectionStr))
            {
                conf.Open();
                var cmd = new SqlCommand("Select FirstName,LastName,Contact,Email,RegistrationNumber From Student Where Status <> 6", conf);
                SqlDataAdapter sql = new SqlDataAdapter(cmd);

                DataTable AdvisorData = new DataTable();
                sql.Fill(AdvisorData);


                int yPos = 350;
                e.Graphics.DrawString("First Name", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(10, yPos));
                e.Graphics.DrawString("Last Name", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(120, yPos));
                e.Graphics.DrawString("Contact", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(250, yPos));
                e.Graphics.DrawString("Email", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(350, yPos));
                e.Graphics.DrawString("RegistrationNumber", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(520, yPos));
                
                yPos += 30;

                yPos += 10;

                foreach (DataRow row in AdvisorData.Rows)
                {
                    e.Graphics.DrawString(row["FirstName"].ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, yPos));
                    e.Graphics.DrawString(row["LastName"].ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(120, yPos));
                    e.Graphics.DrawString(row["Contact"].ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(250, yPos));
                    e.Graphics.DrawString(row["Email"].ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(350, yPos));
                    e.Graphics.DrawString(row["RegistrationNumber"].ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(620, yPos));
                    
                    yPos += 30;
                }
            }
        }

        private void btnOnlyActive_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument3;
            printPreviewDialog1.ShowDialog();
        }
    }
}
