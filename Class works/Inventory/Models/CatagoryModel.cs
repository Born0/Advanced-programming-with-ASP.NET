using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Inventory.Models
{
    public class CatagoryModel
    {
        DataAccess db = new DataAccess();
        SqlDataReader reader;

        public List<Catagory> GetAllCatagories()
        {
            string sql = "Select * From Admins";
            reader = db.GetData(sql);
            List<Catagory> allCatagories = new List<Catagory>();
            while (reader.Read())
            {
                Catagory catagory = new Catagory();
                catagory.CatagoryId = (int)reader["CatagoryId"];
                catagory.CatagoryName = reader["CatagoryName"].ToString();
                allCatagories.Add(catagory);
            }
            return allCatagories;
        }
    }
}