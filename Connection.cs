using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
namespace OnlineOction
{
    public class Connection
    {
        SqlConnection con;
        SqlCommand cd;
        public SqlDataReader dr;
        SqlDataAdapter rd;
        public void getcon()
        {
            try
            {


                con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\rakesh\OnlineOction\OnlineOction\App_Data\onlineoction.mdf;Integrated Security=True;User Instance=True");
                con.Open();
            }
            catch (Exception Ex)
            {
                String y = Ex.Message;
                Console.Write(y);
            }
        }

        public string save(String q)
        {
            try
            {

                getcon();
                cd = new SqlCommand(q, con);
                int y = cd.ExecuteNonQuery();
                con.Close();
                return y + "";
            }
            catch (Exception Ex)
            {
                return Ex.Message;
            }
        }
        public void search(String q)
        {
            try
            {

                getcon();
                cd = new SqlCommand(q, con);
                dr = cd.ExecuteReader();
                
              
            }
            catch (Exception Ex)
            {
                String y = Ex.Message;
                Console.Write(y);
            }
        }
    }
}
