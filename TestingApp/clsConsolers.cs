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


        public void SearchProductData(DataGridView dgv, Int32 Addressvalue, Int32 Distance_VALUE)
        {
            string sql = @"select distinct CONCAT(Sub.Name,' ',Sub.LastName ) PersonName,Sub.MedName,Sub.Subject, Sub.distance
                            from
                            (SELECT  ME.Subject,
                                   ME.PERSON_ID,
                                   ME.Medical_Institution_ID,
                                   MI.Name MedName,
                                   P.ID,
                                   P.Name,
                                   P.LastName,
                                   PA.Address_ID,
                                   A.Coordinate,
                                   Lat_Point.Coordinate LatCoordinate,
                                   ST_Distance_Sphere(A.Coordinate, Lat_Point.Coordinate) distance
                            from Medical_Education ME
                            inner join Medical_Institutions MI on ME.Medical_Institution_ID = MI.ID
                            inner join Persons P on ME.PERSON_ID = P.ID
                            inner join Persons_Adresses PA on P.ID = PA.Person_ID
                            inner join Address A on PA.Address_ID = A.ID
                            left outer join (select Coordinate from Address
                                where ID = " + Addressvalue + " )Lat_Point " +
                                @" on Lat_Point.Coordinate!= A.Coordinate                                  
                                and A.Coordinate is not null
                                having ST_Distance_Sphere(A.Coordinate, Lat_Point.Coordinate) < " + Distance_VALUE + " )Sub order by Sub.distance asc;";
            //and ME.Subject = 'Radiologie'


            MySqlCommand cmd = new MySqlCommand(sql);

            config.Load_DTG(sql, dgv);

        }

        public void fiil_CBO(ComboBox AdressID)
        {
            string sql = @"select distinct A.ID,CONCAT( A.City, ' ---', A.Street , ' ---', A.ZIP_CODE_ID, ' ---', ZC.ZipCode) AS IDNAME ,
                City,  Street ,  ZIP_CODE_ID,
                Latitude, Longitude
                from Address A
                inner join Zip_Code ZC on A.ZIP_CODE_ID = ZC.ID
                where Coordinate is not null
                order by A.ZIP_CODE_ID asc, A.City asc, A.Street asc;";
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


        public void callPersonList(DataGridView dgv)
        {
            string sql = @"select  MI.Name InstitutionName, count(P.ID) TotalPerson
                            from Medical_Institutions MI
                            inner join Medical_Education ME on MI.ID = ME.Medical_Institution_ID
                            inner join Persons P on P.ID = ME.PERSON_ID
                            group by   MI.Name
                            order by  MI.Name asc;";


            MySqlCommand cmd = new MySqlCommand(sql);

            config.Load_DTG(sql, dgv);

        }


        public void callPersonSubjwise(DataGridView dgv)
        {
            string sql = @"select distinct ME.Subject , count(P.ID) TotalPerson
                            from Medical_Education ME
                            inner join Persons P on P.ID = ME.PERSON_ID
                            group by  ME.Subject
                            order by  ME.Subject asc;";


            MySqlCommand cmd = new MySqlCommand(sql);

            config.Load_DTG(sql, dgv);

        }

    }

 
}