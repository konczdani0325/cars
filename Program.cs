using autoSale.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoSale
{
    public class Program
    {
        public static Concet con=new Concet();
        public static List<Car> carList = new List<Car>();
     
        public static void feladat1()
        {
           
            string sql = "SELECT * FROM cars";
            con.Connection.Open();
            MySqlCommand cmd = new MySqlCommand(sql,con.Connection);
            MySqlDataReader dt= cmd.ExecuteReader();
            dt.Read();
            do 
            {
                int id_num = dt.GetInt32(0);
                string id_ker = Convert.ToString(id_num);
                string brand_ker = dt.GetString(1);
                string type_ker = dt.GetString(2);
                string licence_ker = dt.GetString(3);
                int ev_num = dt.GetInt32(4);
                string ev_ker = Convert.ToString(ev_num);
                string ossz_ker = $"{id_ker};{brand_ker};{type_ker};{licence_ker};{ev_ker}";
                carList.Add(new Car(ossz_ker));

            } while (dt.Read());
            con.Connection.Close();
        }
        static void Main(string[] args)
        {
            feladat1();
            
            foreach (var item in carList)
            {
                Console.WriteLine(item.id+"\t"+item.Brand+"\t"+item.Type+"\t"+item.Licence+"\t"+item.year+"\n");
            }
           
            Console.ReadLine();
        }
    }
}
