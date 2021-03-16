using AdminProject.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AdminProject.Repository
{
    public class AuthorizeRepository
    {
        public List<AuthorizeModel> GetDetails()
        {
            List<AuthorizeModel> testFormList = new List<AuthorizeModel>();
            string myConnection = "Data Source=DESKTOP-JVJFROS;Integrated Security=true;Database=RollDB";
            SqlConnection con = new SqlConnection(myConnection);
            SqlCommand cmd = new SqlCommand("GetDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            try
            {
                while (dr.Read())
                {
                    AuthorizeModel oAuthorizeModel = new AuthorizeModel()
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        RollName = dr["RollName"].ToString(),
                        UserId = dr["UserId"].ToString(),
                        Password = dr["Password"].ToString(),
                       
                    };
                    testFormList.Add(oAuthorizeModel);

                }
            }
            catch (Exception ex)
            {

            }

            return testFormList;
        }

    }
}