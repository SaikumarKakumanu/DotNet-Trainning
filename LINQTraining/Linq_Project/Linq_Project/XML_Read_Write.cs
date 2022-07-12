using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Xml;

namespace Linq_Project
{
    class XML_Read_Write
    {
        static void Main()
        {
            XmlWriter();
            XMLReader();
            Console.Read();
        }

        static void XmlWriter()
        {
            try
            {
                //create a dataset, a namespace, and a table with colns and rows
                DataSet ds = new DataSet("DS");
                ds.Namespace = "StdNamespace";
                DataTable stdTable = new DataTable("Student");
                DataColumn col1 = new DataColumn("Name");
                DataColumn col2 = new DataColumn("Address");
                stdTable.Columns.Add(col1);
                stdTable.Columns.Add(col2);
                ds.Tables.Add(stdTable);

                //add student data to the table
                DataRow newrow = stdTable.NewRow();
                newrow["Name"] = "Ramesh";
                newrow["Address"] = "Hyderabad";
                stdTable.Rows.Add(newrow);
                //2, row of details
                newrow = stdTable.NewRow();
                newrow["Name"] = "Girish";
                newrow["Address"] = "Chennai";
                stdTable.Rows.Add(newrow);
                //3r drow of details
                newrow = stdTable.NewRow();
                newrow["Name"] = "Akilesh";
                newrow["Address"] = "Kolkatta";
                stdTable.Rows.Add(newrow);
                ds.AcceptChanges();

                //4th row of details
                newrow = stdTable.NewRow();
                newrow["Name"] = "Sai";
                newrow["Address"] = "Hyderabad";
                stdTable.Rows.Add(newrow);

                //5th row of details
                newrow = stdTable.NewRow();
                newrow["Name"] = "Venkat";
                newrow["Address"] = "Bangalore";
                stdTable.Rows.Add(newrow);

                ds.AcceptChanges();

                //to store the above dataset data into an xml file using stream writer
                StreamWriter sw = new StreamWriter(@"C:\DotnetTraining\LINQTraining\May23.xml");
                //write the data

                ds.WriteXml(sw);
                sw.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        static void XMLReader()
        {
            //create a dataset object to read

            DataSet ds = new DataSet();
            //fill with the data
            ds.ReadXml(@"C:\DotnetTraining\LINQTraining\May23.xml");

            foreach (DataTable table in ds.Tables)
            {
                Console.WriteLine(table);
                for (int i = 0; i < table.Columns.Count; i++)
                    Console.Write("\t" + table.Columns[i].ColumnName);
                Console.WriteLine();
                foreach (var row in table.AsEnumerable())
                {
                    for (int i = 0; i < table.Columns.Count; i++)
                    {
                        Console.Write("\t" + row[i]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
