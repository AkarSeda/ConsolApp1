using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Interfaces.OracleCustomerDal;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //Interfacesintro();
            //Demo2();

            ICustomerDal[] customerDals = new ICustomerDal[3] //ICustomerDal türünde 2 elemanlı bir array tanımladık.
            {
                new SqlServerCustomerDal(), //Array in ilk elemanı
                new OracleCustomerDal(), //Array in ikinci elemanı
                new MySqlCustomerDal()
            };

            foreach (var customerDal in customerDals) //Array olarak oluşturduğumuz customerDals ı gezerek add yaptık.
            {
                customerDal.Add();
            }

            Console.ReadLine();
        }

        private static void Demo2()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());
        }
    }

    interface IPerson // IPerson arayüzü üç özelliğe sahip.
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Customer : IPerson  //IPerson arayüzünü implemente ettik.
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }  //Customer ın person özellikleri dışında sahip olduğu farklı bir özellik(POLYMORPHİSM)
    }

    class Student : IPerson   //IPerson arayüzünü implemente ettik.
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }   //Student ın person özellikleri dışında sahip olduğu farklı bir özellik(POLYMORPHİSM)
    }

    class Worker : IPerson   //IPerson arayüzünü implemente ettik.
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }   //Worker ın person özellikleri dışında sahip olduğu farklı bir özellik(POLYMORPHİSM)
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}