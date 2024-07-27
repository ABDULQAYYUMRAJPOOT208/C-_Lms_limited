using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace MidProjectDb.UserPanels
{
    public partial class frmAttendence : UserControl
    {
        public frmAttendence()
        {
            InitializeComponent();
            btnMarkAnother.Visible = false;
            btnMarkAnother.Enabled = false;
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime date = dtpicker.Value.Date;
                gridViewRegSt.DataSource = null;
                gridViewRegSt.Refresh();
                using (var conf = new SqlConnection(commonFunctions.ConnectionStr))
                {
                    conf.Open();

                    using (var isAlready = new SqlCommand("SELECT AttendanceDate FROM ClassAttendance WHERE CONVERT(date, AttendanceDate) = @date", conf))
                    {
                        isAlready.Parameters.AddWithValue("@date", date);
                        object result = isAlready.ExecuteScalar();

                        if (result == null)
                        {
                            using (var cmd = new SqlCommand("INSERT INTO ClassAttendance (AttendanceDate) VALUES (@date)", conf))
                            {
                                cmd.Parameters.AddWithValue("@date", date);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                    
                }
                InitializeDataGridView();
            }
             catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            btnMarkAnother.Enabled = true;
            btnMarkAnother.Visible = true;
            btnDate.Visible = false;
            btnDate.Enabled = false;
        }


        private void InitializeDataGridView()
        {
            gridViewRegSt.Rows.Clear();
            gridViewRegSt.DataSource = null;
            using (var conf = new SqlConnection(commonFunctions.ConnectionStr))
            {
                conf.Open();
                using (var cmd = new SqlCommand("SELECT RegistrationNumber, Status FROM Student WHERE Status <> 6", conf))
                {
                    SqlDataAdapter sdata = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sdata.Fill(dt);
                    gridViewRegSt.DataSource = dt;
                    gridViewRegSt.Refresh();

                    foreach (DataGridViewRow row in gridViewRegSt.Rows)
                    {
                        int status = Convert.ToInt32(row.Cells["Status"].Value);
                        switch (status)
                        {
                            case 1: 
                                row.Cells["Present"].Style.BackColor = Color.Green;
                                break;
                            case 2:
                                row.Cells["Absent"].Style.BackColor = Color.Red;
                                break;
                            case 3:
                                row.Cells["Leave"].Style.BackColor = Color.Yellow;
                                break;
                            case 4:
                                row.Cells["Late"].Style.BackColor = Color.Orange;
                                break;
                            default:
                               
                                break;
                        }
                    }
                }
            }

            gridViewRegSt.Columns.Add(CreateButtonColumn("Present", "Present"));
            gridViewRegSt.Columns.Add(CreateButtonColumn("Absent", "Absent"));
            gridViewRegSt.Columns.Add(CreateButtonColumn("Leave", "Leave"));
            gridViewRegSt.Columns.Add(CreateButtonColumn("Late", "Late"));

            gridViewRegSt.CellContentClick += dataGridView1_CellContentClick;
        }

        private DataGridViewButtonColumn CreateButtonColumn(string name, string text)
        {
            DataGridViewButtonColumn column = new DataGridViewButtonColumn();
            column.Name = name;
            column.HeaderText = text;
            column.Text = text;
            column.UseColumnTextForButtonValue = true;
            return column;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 1)
            {
                DataGridViewButtonCell buttonCell = gridViewRegSt.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell;
                if (buttonCell != null)
                {
                    using (var conf = new SqlConnection(commonFunctions.ConnectionStr))
                    {
                        conf.Open();
                        string stRollNo = gridViewRegSt.Rows[e.RowIndex].Cells["RegistrationNumber"].Value.ToString();
                        int studentID = GetStudentID(conf, stRollNo);
                        if (studentID == -1)
                        {
                            MessageBox.Show("Student not found.");
                            return;
                        }

                        string buttonText = buttonCell.Value.ToString();

                        var date = dtpicker.Value;
                        int attendanceID = GetAttendanceID(conf, date);
                        
                        if (attendanceID == -1)
                        {
                            MessageBox.Show("Attendance record not found for the selected date.");
                            return;
                        }
                        if(isAlreadyMarked(buttonText,attendanceID,studentID))
                        {
                            commonFunctions.showAlertBox("Student is already Marked Time Out You cannot change it now...");
                            return;
                        }
                        int status = GetAttendanceStatus(buttonText);

                        InsertAttendanceRecord(conf, studentID, attendanceID, status);

                        MessageBox.Show($"Button '{buttonText}' clicked for student with roll number '{gridViewRegSt.Rows[e.RowIndex].Cells["RegistrationNumber"].Value}'");
                    }
                }
            }
        }

        private int GetStudentID(SqlConnection connection, string registrationNumber)
        {
            using (var cmd = new SqlCommand("SELECT ID FROM Student WHERE RegistrationNumber = @registrationNumber", connection))
            {
                cmd.Parameters.AddWithValue("@registrationNumber", registrationNumber);
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    return Convert.ToInt32(result);
                }
                return -1;
            }
        }

        private int GetAttendanceID(SqlConnection connection, DateTime date)
        {
            using (var cmd = new SqlCommand("SELECT ID FROM ClassAttendance WHERE CONVERT(date, AttendanceDate) = @date", connection))
            {
                cmd.Parameters.AddWithValue("@date", date.Date);
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    return Convert.ToInt32(result);
                }
                return -1;
            }
        }


        private int GetAttendanceStatus(string buttonText)
        {
            using (var conf = new SqlConnection(commonFunctions.ConnectionStr))
            {
                conf.Open();
                var id = new SqlCommand("Select LookupId From Lookup Where Name = @name", conf);
                id.Parameters.AddWithValue("@name", buttonText);
                if(id.ExecuteScalar() == null)
                {
                    return -1; 
                }
                return Convert.ToInt32(id.ExecuteScalar());
            }
        }

        private void InsertAttendanceRecord(SqlConnection connection, int studentID, int attendanceID, int status)
        {
            using (var cmd = new SqlCommand("INSERT INTO StudentAttendance (AttendanceID, StudentID, AttendanceStatus) VALUES (@attendanceID, @studentID, @status)", connection))
            {
                cmd.Parameters.AddWithValue("@attendanceID", attendanceID);
                cmd.Parameters.AddWithValue("@studentID", studentID);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.ExecuteNonQuery();
            }
        }
        private bool isAlreadyMarked(string str, int attendanceDate, int stId)
        {
            using (var conn = new SqlConnection(commonFunctions.ConnectionStr))
            {
                conn.Open();
                var statusQuery = "SELECT Count(*) FROM StudentAttendance WHERE AttendanceID = @aId AND StudentID = @sId";
                var statusCommand = new SqlCommand(statusQuery, conn);
                statusCommand.Parameters.AddWithValue("@aId", attendanceDate);
                statusCommand.Parameters.AddWithValue("@sId", stId);
                object result = statusCommand.ExecuteScalar();
                if (result == null)
                    return false;

                return Convert.ToInt32(result.ToString()) > 0;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            btnDate.Enabled = true;
            btnDate.Visible = true;
            gridViewRegSt = new DataGridView();
            btnMarkAnother.Enabled = false; btnMarkAnother.Visible = false;
        }
    }

}
