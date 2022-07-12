using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BasicADO
{
    class Program
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        static void Main(string[] args)
        {
           // SelectData();
            //GetScalarFun();
            //InsertProductData();
            //DeleteProduct();
            UpdateProduct();
            Console.Read();
        }
        public static void UpdateProduct()
        {
            con = getcon();
            Console.WriteLine("Enter the product id : ");
            int pid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the product name : ");
            string pname = Console.ReadLine();
            Console.WriteLine("Enter the product prise : ");
            int pprice = Convert.ToInt32(Console.ReadLine());
            cmd = new SqlCommand("update product set ProductName = @proname, price = @proprice where productid = @pid",con);
            cmd.Parameters.AddWithValue("@pid",pid);
            cmd.Parameters.AddWithValue("@proname",pname);
            cmd.Parameters.AddWithValue("@proprice",pprice);
            int res = cmd.ExecuteNonQuery();

            if(res>0)
                Console.WriteLine("Record updated ");
            else
                Console.WriteLine("No Record Updated ");
        }
        public static void DeleteProduct()
        {
            con = getcon();
            Console.WriteLine("Enter Product id to delete :");
            int pid = Convert.ToInt32(Console.ReadLine());
            cmd = new SqlCommand("delete from product where productid=@pid", con);
            cmd.Parameters.AddWithValue("@pid", pid);
            int res = cmd.ExecuteNonQuery();
            if (res > 0)
                Console.WriteLine("record deleted");
            else
                Console.WriteLine("Not deleted");
        }

        public static void InsertProductData()
        {
            con = getcon();
            Console.WriteLine("Enter ProductId:");
            int pid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Description :");
            string pdesc = Console.ReadLine();
            Console.WriteLine("Enter Product Price :");
            int pprice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Available Qty :");
            int pqty = Convert.ToInt32(Console.ReadLine());
            cmd = new SqlCommand("Insert into Product values(@id,@desc,@price,@qty)", con);
            cmd.Parameters.AddWithValue("@id", pid);
            cmd.Parameters.AddWithValue("@desc", pdesc);
            cmd.Parameters.AddWithValue("@price", pprice);
            cmd.Parameters.AddWithValue("@qty", pqty);
            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                Console.WriteLine("Added one record.");
            }
            else
                Console.WriteLine("Something went wrong.. did not insert");
        }
        public static void GetScalarFun()
        {
            con = getcon();
            cmd = new SqlCommand("select count(Empid) from tblEmployee",con);
            int empcount = Convert.ToInt32(cmd.ExecuteScalar());
            Console.WriteLine("No of Employees : {0}",empcount);
        }
        public static void SelectData()
        {
            con = getcon();
            cmd = new SqlCommand("select * from tblEmployee",con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine("Employee Id : " + dr[0] + " Employee Name : " + dr[1]+
                    " Employee Gender : " + dr[2] +  " Employee Salary : " + dr[3]);
                
            }
        }
        public static SqlConnection getcon()
        {
            con = new SqlConnection("data source = RMGW58ZLPC0908\\SQLEXPRESS; Initial catalog = ZensarDB; " + "user id= sa; password = Temp1234");
            con.Open();
            return con;
        }
    }
}
