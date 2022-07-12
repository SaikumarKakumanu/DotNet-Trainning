using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CRUD_Connected
{
    class Region
    {
        public int RegionId { get; set; }
        public string RegionDescription { get; set; }
        DataAccess da = new DataAccess();
        public void GetRegion()
        {
            Console.WriteLine("Enter Region Id:");
            RegionId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Description :");
            RegionDescription = Console.ReadLine();
        }
        public void DisplayRegion()
        {
            da.DisplayRegion();
        }
        public void InsertRegion()
        {
            GetRegion();
            da.InsertRegion(this.RegionId,this.RegionDescription);
        }
        public void UpdateRegion()
        {
            GetRegion();
            da.UpdateRegion(this.RegionId,this.RegionDescription);
        }

        public void DeleteRegion()
        {
            da.DeleteRegion();
        }
    }
    class DataAccess
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader dr;

        private SqlConnection GetConnection()
        {
            string connection = @"data source=RMGW58ZLPC0908\SQLEXPRESS;Initial Catalog=Northwind; user id =sa; password = Temp1234";
            con = new SqlConnection(connection);
            con.Open();
            return con;
        }

        public void DisplayRegion()
        {
            try
            {
                con = GetConnection();
                cmd = new SqlCommand("select * from Region", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine(dr["RegionId"] + " " + dr["RegionDescription"]);
                }
            }
            catch (SqlException se)
            {
                Console.WriteLine("Some error Occured ..");
            }
            finally
            {
                con.Close();
            }
        }
        public void InsertRegion(int RegionId, string RegionDescription)
        {
            try
            {
                con = GetConnection();
                cmd = new SqlCommand("insert into Region values(@RegionId,@RegionDescription)", con);
                cmd.Parameters.AddWithValue("@RegionId", RegionId);
                cmd.Parameters.AddWithValue("@RegionDescription", RegionDescription);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("Values Inserted");
                }
                else
                {
                    Console.WriteLine("Not Inserted");
                }

            }
            catch (SqlException se)
            {
                Console.WriteLine("Values Not Inserted");
            }
            finally
            {
                con.Close();
            }
        }

        public void UpdateRegion(int RegionId, string RegionDescription)
        {
            try
            {
                con = GetConnection();
                cmd = new SqlCommand("update Region set RegionDescription=@RegionDescription where RegionId=@RegionId", con);
                cmd.Parameters.AddWithValue("@RegionId", RegionId);
                cmd.Parameters.AddWithValue("@RegionDescription", RegionDescription);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("rows updated");
                }
                else
                {
                    Console.WriteLine("not updated");
                }
            }
            catch (SqlException se)
            {
                Console.WriteLine("Values Not Inserted");
            }
            finally
            {
                con.Close();
            }
        }

        public void DeleteRegion()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Region region = new Region();
            try
            {
                region.DisplayRegion();
                //region.InsertRegion();
                region.UpdateRegion();
                //region.DeleteRegion();
                Console.Read();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
