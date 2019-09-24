using System;
using System.Configuration;
using System.Data.SqlClient;

namespace WebFormUsingC
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [Obsolete]
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationSettings.AppSettings.Get("Connection");
            lblErrorMessage.Visible = false;
            string firstName = tFName.Text.Trim();
            string lastName = tLname.Text.Trim();
            string emailAddress = tEmail.Text.Trim();
            string address = tAddress.Text.Trim();
            string contactNumber = tContactNumber.Text.Trim();
            string qualification = tQualification.Text.Trim();
            long mobileNumber = 0;
            int count = 0;
            bool isValidNumber = long.TryParse(contactNumber, out mobileNumber);
            if (isValidNumber)
            {
                //check if the user exist
                using (var connection = new SqlConnection(connectionString))
                {
                    string query = "select * from UserRegistrationDetails where ContactNumber = @ContactNumber";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add("@ContactNumber", contactNumber);
                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                                count++;
                        }
                        connection.Close();
                    }
                }
                //DLL required system.Data.SQLClient Done
                //Create SQL Connection
                if (count == 0)
                {
                    int result = 0;
                    using (var connection = new SqlConnection(connectionString))
                    {
                        string query = "insert into UserRegistrationDetails (FirstName,LastName,Email,Address,ContactNumber,RegistrationDate,Qualification) values "
                            + "(@Fname,@Lname,@Email,@Address,@contactNumber,@Date,@Qualification)";
                        //Create SQL Command
                        using (var command = new SqlCommand(query, connection))
                        {
                            //Adding the parameters
                            command.Parameters.Add("@Fname", firstName);
                            command.Parameters.Add("@Lname", lastName);
                            command.Parameters.Add("@Email", emailAddress);
                            command.Parameters.Add("@Address", address);
                            command.Parameters.Add("@contactNumber", contactNumber);
                            command.Parameters.Add("@Date", DateTime.Now.Date);
                            command.Parameters.Add("@Qualification", qualification);
                            connection.Open();
                            result = command.ExecuteNonQuery();
                            connection.Close();
                        }
                    }
                    if (result == 1)
                    {
                        lblErrorMessage.Text = "User Registered successfully, you can now attempt the question paper.";
                        lblErrorMessage.Visible = true;
                    }
                    else
                    {
                        lblErrorMessage.Text = "An error occured while regestring user.";
                        lblErrorMessage.Visible = true;
                    }
                }
                else
                {
                    lblErrorMessage.Text = "User Already exist.";
                    lblErrorMessage.Visible = true;
                }

                //ExecutenonQuery or ExecuteReader on the command
            }
            else
            {
                lblErrorMessage.Text = "Mobile Number is Invalid.";
                lblErrorMessage.Visible = true;
            }
            //Response.Redirect("~/Registration");
        }
    }
}