using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.update();

            CustomerProperty customerProperty = new CustomerProperty();
            customerProperty.city = "Ankara";
            customerProperty.Id = 123445;
            customerProperty.FirstName ="Seda";
            customerProperty.LastName = "Akar";

            Console.ReadLine();
        }
    }
}
