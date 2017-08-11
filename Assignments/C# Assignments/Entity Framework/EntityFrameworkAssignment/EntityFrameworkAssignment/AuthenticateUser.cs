using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


namespace EntityFrameworkAssignment
{
    public class AuthenticateUser
    {
        public bool UserAuthentication(string name, string userType)
        {
            using (SqlConnection con = new SqlConnection("data source=.; database=EntityFrameworkAssignment; integrated security=SSPI"))
            {
                SqlCommand cmd = new SqlCommand("spAuthenticateUser", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramName = new SqlParameter("@Name", name);
                SqlParameter paramUserType = new SqlParameter("@UserType", userType);

                cmd.Parameters.Add(paramName);
                cmd.Parameters.Add(paramUserType);

                con.Open();
                int ReturnCode = (int)cmd.ExecuteScalar();
                return ReturnCode == 1;
            }
        }
    }
}