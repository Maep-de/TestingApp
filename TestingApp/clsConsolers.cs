using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;
using TestingApp.Properties;
using System.ComponentModel;
using System.Drawing;




namespace TestingApp
{
    class clsConsolers
    {
        private MySqlDataAdapter da;
        private MySqlCommand cmd;

        SQLConfig config = new SQLConfig();

        usableFunction funct = new usableFunction();
        public DataTable dt;
        
        //VIEW PRODUCT
        public void callProductData(DataGridView dgv, Int32 Distance_VALUE)
        {
            string sql = @"select sel.ID, sel.Name,sel.City,sel.Street, sel.ZipCode, sel.Distance from
                            (select P.ID, P.Name, PA.Address_ID,
                            A.City,A.Street,A.Coordinate,Lat_Point.Coordinate latCoordinate,
                            ST_Distance_Sphere(A.Coordinate, Lat_Point.Coordinate) Distance,
                            A.ZIP_CODE_ID,ZC.ID ZID, ZC.ZipCode
                    from Persons P
                    inner join Persons_Adresses PA on P.ID = PA.Person_ID
                    inner join Address A on PA.Address_ID = A.ID
                    inner join Zip_Code ZC on A.ZIP_CODE_ID = ZC.ID
                    left outer join(select Coordinate from Address
                        where ID = '2838')Lat_Point on Lat_Point.Coordinate != A.Coordinate
                        having ST_Distance_Sphere(A.Coordinate, Lat_Point.Coordinate) < " + Distance_VALUE + " )sel;";

            
            MySqlCommand cmd = new MySqlCommand(sql);

            config.Load_DTG(sql, dgv);

        }

        public void fiil_CBO(ComboBox AdressID)
        {
            string sql = @"select distinct ID, concat(ID, City, Street, ZIP_CODE_ID) IDNAME, City,Street , ZIP_CODE_ID, Latitude, Longitude
                            from Address
                            where Coordinate is not null
                            order by ZIP_CODE_ID asc, City asc, Street asc;";
            MySqlCommand cmd = new MySqlCommand(sql);

            config.fiil_CBO(sql, AdressID);

        }

        
        public void callProductData(DataGridView dgv)
        {
            string sql = @"select sel.ID, sel.Name,sel.City,sel.Street, sel.ZipCode, sel.Distance from
                            (select P.ID, P.Name, PA.Address_ID,
                            A.City,A.Street,A.Coordinate,Lat_Point.Coordinate latCoordinate,
                            ST_Distance_Sphere(A.Coordinate, Lat_Point.Coordinate) Distance,
                            A.ZIP_CODE_ID,ZC.ID ZID, ZC.ZipCode
                    from Persons P
                    inner join Persons_Adresses PA on P.ID = PA.Person_ID
                    inner join Address A on PA.Address_ID = A.ID
                    inner join Zip_Code ZC on A.ZIP_CODE_ID = ZC.ID
                    left outer join(select Coordinate from Address
                        where ID = '2838')Lat_Point on Lat_Point.Coordinate != A.Coordinate
                        having ST_Distance_Sphere(A.Coordinate, Lat_Point.Coordinate) < 6000)sel;";


            MySqlCommand cmd = new MySqlCommand(sql);

            config.Load_DTG(sql, dgv);

        }

     


    }

 
}