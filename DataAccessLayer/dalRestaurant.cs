using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class dalRestaurant
    {
        public static List<ModelRestaurant> GetRestaurantsinfo()
        {
            SqlConnection con = DBHelper.GetConnection();
            SqlCommand cmd = new SqlCommand(" select *from Restaurant;", con);
            con.Open();
            SqlDataReader sqlDataReaderreader = cmd.ExecuteReader();
            List<ModelRestaurant> listRestaurant = new List<ModelRestaurant>();
            while (sqlDataReaderreader.Read())
            {
                ModelRestaurant rest1 = new ModelRestaurant();
                rest1.id = Convert.ToInt32(sqlDataReaderreader["id"]);
                rest1.food = sqlDataReaderreader["food"].ToString();
                rest1.name = sqlDataReaderreader["name"].ToString();
                listRestaurant.Add(rest1);

            }
            con.Close();
            return listRestaurant;
        }
    }
}
