using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace TestingApp
{
   public class Connector
    {
        static void ConnectorMain(string[] args)
        {
            string connStr = "server=78.46.106.198;user=root;database=drfuture.database;port=23306;password=GZ9bzSr9B?4kA!8#";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();

                //SQL Query to execute
                //selecting only first 10 rows for demo
                string sql = @"select
                            P.ID, P.Name, PA.Address_ID,
                            A.City,A.Street,A.Coordinate,Lat_Point.Coordinate,
                            ST_Distance_Sphere(A.Coordinate, Lat_Point.Coordinate) Distance,
                            A.ZIP_CODE_ID,ZC.ID, ZC.ZipCode
                    from Persons P
                    inner join Persons_Adresses PA on P.ID = PA.Person_ID
                    inner join Address A on PA.Address_ID = A.ID
                    inner join Zip_Code ZC on A.ZIP_CODE_ID = ZC.ID
                    left outer join(select Coordinate from Address
                        where ID = '2838')Lat_Point on Lat_Point.Coordinate != A.Coordinate
                        having ST_Distance_Sphere(A.Coordinate, Lat_Point.Coordinate) < 6000 ; ";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                //read the data
                while (rdr.Read())
                {
                    Console.WriteLine(rdr[1] + " -- " + rdr[3] + " -- " + rdr[4] + " -- " + rdr[7]);
                }
                rdr.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());
            }


            conn.Close();
            Console.WriteLine("Connection Closed. Press any key to exit...");
            Console.Read();
        }


    }


 
}
