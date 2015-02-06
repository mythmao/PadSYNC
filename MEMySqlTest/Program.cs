
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEMySqlTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //DatabaseProviderFactory factory = new DatabaseProviderFactory();
            //Database db = factory.Create("CloudOrganization");
            //string sqlStr = "select * from JobSearch limit 5";
            //using (DbCommand cmd = db.GetSqlStringCommand(sqlStr))
            //{
            //    DataSet ds = db.ExecuteDataSet(cmd);
            //    if (ds != null && ds.Tables.Count > 0)
            //    {
            //        DataTable table = ds.Tables[0];
            //        Console.WriteLine(table.Rows.Count);
            //    }
            //}

            DbProviderFactory factory = DbProviderFactories.GetFactory("MySql.Data.MySqlClient");

            using (DbConnection connection = factory.CreateConnection())
            {
                connection.ConnectionString = "server=10.1.55.122;database=CloudOrganization;uid=root;pwd=xueda123$;Treat Tiny As Boolean=false";

                connection.Open();

                Console.WriteLine("state: " + connection.State);
                connection.Close();
            }
            Console.Read();
        }
    }
}
