using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods ///Burda kaldım Virtual metot tam oturmadı bugün bakıcam ona 
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer sglServer = new SqlServer();
            sglServer.Add();
            MySql mySql = new MySql();
            mySql.Add();

            Console.ReadLine();
        }

        class Database   //Diyelim ki veritabanı işleri yapıcaz.
        {
            //Ve databese imizin içinde ekleme ve silme metodlarımız olsun.
            public virtual void Add()
            {
                Console.WriteLine("Added by default");
            }
            public virtual void Delete()
            {
                Console.WriteLine("Deleted by default");
            }
        }

        class SqlServer : Database
        {

        }

        class MySql : Database
        {

        }
    }
}
