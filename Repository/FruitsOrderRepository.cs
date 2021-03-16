using AdminProject.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AdminProject.Repository
{
    public class FruitsOrderRepository
    {
        public List<FruitsDropdownModel> GetAllFruitsName()
        {
            List<FruitsDropdownModel> fruitList = new List<FruitsDropdownModel>();
            FruitsDropdownModel oFruitsDropdownModel = new FruitsDropdownModel();
            string myConnection = "Data Source = DESKTOP-JVJFROS;Integrated Security=True;Database=FruitsDB";
            SqlConnection con = new SqlConnection(myConnection);
            SqlCommand cmd = new SqlCommand("GetAllFruitsName", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            fruitList = (from DataRow dr in dt.Rows
                         select new FruitsDropdownModel()
                         {
                             FruitsId = Convert.ToInt32(dr["FruitsId"]),
                             FruitsName = Convert.ToString(dr["FruitsName"])
                         }).ToList();
            con.Close();
            return fruitList;
        }

        public bool AddFruitsOrder(FruitsOrderModel fom)
        {
            FruitsDropdownModel oFruitsDropdownModel = new FruitsDropdownModel();
            string myConnection = "Data Source = DESKTOP-JVJFROS;Integrated Security=True;Database=FruitsDB";
            SqlConnection con = new SqlConnection(myConnection);
            SqlCommand cmd = new SqlCommand("SaveFruitsOrderDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FruitsId", fom.FruitsId);
            cmd.Parameters.AddWithValue("@OrderBy", fom.OrderBy);
            cmd.Parameters.AddWithValue("@Mobile", fom.Mobile);
            cmd.Parameters.AddWithValue("@Quantity", fom.Quantity);
          

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if(i >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}