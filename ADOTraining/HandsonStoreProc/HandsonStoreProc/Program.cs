using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace HandsonStoreProc
{
    class Program
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;

        public static SqlConnection getcon()
        {
            con = new SqlConnection(@"data source = RMGW58ZLPC0908\SQLEXPRESS; Initial Catalog=ZensarDB; user id=sa; password =Temp1234");
            con.Open();
            return con;
        }

        public static void Storedproc()
        {
            con = getcon();
            Console.WriteLine("Please Enter the Emp Code ");
            string csvariable = Console.ReadLine();
            Console.WriteLine("Please Enter the Emp name ");
            string ename= Console.ReadLine();
            Console.WriteLine("Please Enter the Emp anualsalary ");
            float annualsalary = Convert.ToSingle(Console.ReadLine());
            //cmd = new SqlCommand("select *  from Employee ");
            cmd = new SqlCommand("sp_salaryadding", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id", csvariable));
            cmd.Parameters.Add(new SqlParameter("@ename", SqlDbType.NVarChar, 0, "ename"));

            cmd.Parameters.Add(new SqlParameter("@annualsalary", SqlDbType.Float, 50, "annualsalary"));
            //cmd.Parameters.AddWithValue("@inParam", csvariable).Direction = System.Data.ParameterDirection.Input;

            cmd.Parameters.Add("@outParam", System.Data.SqlDbType.Int).Direction = System.Data.ParameterDirection.Output;
            cmd.Parameters.Add("@outParam", System.Data.SqlDbType.Int).Direction = System.Data.ParameterDirection.Output;

            // cmd.Parameters.Add("@retParam", System.Data.SqlDbType.Int).Direction = System.Data.ParameterDirection.ReturnValue;

            // Execute the command

            int res=cmd.ExecuteNonQuery();
            if (res > 0)
            {
                Console.WriteLine(res);
            }
            else
            {
                Console.WriteLine("no");
            }



            // Get the values

            int retval = (int)cmd.Parameters["@retParam"].Value;

            int outval = (int)cmd.Parameters["@outParam"].Value;

            Console.WriteLine("Employee salary is {0}", outval);

            Console.WriteLine("Return value: {0}, Out value: {1}", retval, outval);

            con.Close();
        }
        static void Main(string[] args)
        {
            Storedproc();
            Console.ReadLine();
        }
    }
}
