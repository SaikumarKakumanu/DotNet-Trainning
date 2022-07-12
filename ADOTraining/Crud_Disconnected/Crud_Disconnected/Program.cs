﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Crud_Disconnected
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con;
            SqlDataAdapter sda;
            try
            {
                con = new SqlConnection(@"data source = RMGW58ZLPC0908\SQLEXPRESS; Initial Catalog=Northwind; user id=sa; password=Temp1234");
                con.Open();
                sda = new SqlDataAdapter("Select * from Region", con);
                DataSet ds = new DataSet();
                sda.Fill(ds,"NorthwindRegion");
                DataTable dt= ds.Tables["NorthwindRegion"];

                foreach (DataRow dr in dt.Rows)
                {
                    foreach (DataColumn dc in dt.Columns)
                    {
                        Console.Write(dr[dc]);
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }

                //Adding one more table to the same dataset
                //Console.WriteLine("-----------------------");
                //sda = new SqlDataAdapter("Select * from Shippers", con);
                //sda.Fill(ds, "NorthwindShippers");
                //dt = ds.Tables["NorthwindShippers"];

                ////iterating the datatable rows and columns to fetch the data
                //foreach (DataRow row1 in dt.Rows)
                //{
                //    foreach (DataColumn col1 in dt.Columns)
                //    {
                //        Console.Write(row1[col1]);
                //        Console.Write("  ");
                //    }
                //    Console.WriteLine();
                //}

                //sda = new SqlDataAdapter("Select * from [order details]where orderid between 10980 and 11000 order by unitprice desc", con);
                //sda.Fill(ds, "NorthwindOrdDetails");
                //dt = ds.Tables["NorthwindordDetails"];

                ////iterating the datatable rows and columns to fetch the data
                //foreach (DataRow row1 in dt.Rows)
                //{
                //    foreach (DataColumn col1 in dt.Columns)
                //    {
                //        Console.Write(row1[col1]);
                //        Console.Write("  ");
                //    }
                //    Console.WriteLine();
                //}

                //inserting one record into the Region table
                sda.Fill(ds);
                //add a new row
                DataRow drow = ds.Tables["NorthwindRegion"].NewRow();
                drow["RegionId"] = 5;
                drow["RegionDescription"] = "SouthEast";
                //add the datarow to the datatable in the dataset
                ds.Tables["NorthwindRegion"].Rows.Add(drow);

                //we need to update the details back into the database

                sda.Update(ds);
                Console.WriteLine("----------After Update----------");
                dt = ds.Tables["NorthwindRegion"];

                foreach (DataRow row1 in dt.Rows)
                {
                    foreach (DataColumn col1 in dt.Columns)
                    {
                        Console.Write(row1[col1]);
                        Console.Write("  ");
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
    
}
