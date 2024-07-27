using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MidProjectDb
{
    public class commonFunctions
    {
        public static String ConnectionStr = @"Data Source=(local);Initial Catalog=ProjectB;Integrated Security=True";
        public static void showBox(string str)
        {
            MessageBox.Show(str);
        }
        public static bool isEmptyStr(string str)
        {
            return str.Length == 0;
        }
        public static void showAlertBox(string str)
        {
            MessageBox.Show(str, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }public static void showInfoBox(string str)
        {
            MessageBox.Show(str, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void showErrortBox(string str)
        {
            MessageBox.Show(str, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static bool isValidInt(string str)
        {
            string input = "123";

            int result;
            if (int.TryParse(input, out result))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ValidateName(string name)
        {
            return Regex.IsMatch(name, @"^[a-zA-Z]+$");
        }
        public static bool ValidateContactNumber(string contactNumber)
        {
            return Regex.IsMatch(contactNumber, @"^\d{10}$");
        }
        public static bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");
        }
        public static bool ValidateRegistrationNumber(string regNumber)
        {
            return Regex.IsMatch(regNumber, @"^\d+-[a-zA-Z]+-\d+$");
        }


        public static bool validAllCredientials(ref string fName, ref string lName, ref string contact, ref string email, ref string regNo)
        {
            if (fName == "" || lName == "" || contact == "" || email == "" || regNo == "")
            {
                MessageBox.Show("First Enter All Credentials...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (ValidateName(fName) || ValidateName(lName))
            {
                if (ValidateContactNumber(contact))
                {
                    if (ValidateEmail(email))
                    {
                        if (ValidateRegistrationNumber(regNo))
                        {
                            return true;
                        }
                        else
                        {
                            showAlertBox("Please Enter Correct ROll-Number in Format \n YYYY-XX-YY \n 'Y' For Number and 'X' for Letter...");
                        }
                    }
                    else
                    {
                        showAlertBox("Please Enter Correct Email Address...");
                        return false;
                    }
                }
                else
                {
                    showAlertBox("Please Enter Correct Phone Number...");
                    return false;
                }
            }
            else
            {
                showAlertBox("Please Enter Name in Correct Format. Without Special Characters...");
                return false;
            }
            return true;
        }
    }
}
