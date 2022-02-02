using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]  //Bir çalışan array i oluşturdum
            {   //Manageriçin Worker için ve Robot için çalışma işlemi yaptım
                new Manager(),
                new Worker(),
                new Robot()
            };
            foreach (var worker in workers) //bu şekilde tüm workers ı gezip
            {
                worker.Work();  //çalıştırıyoruz.
            }

            IEat[] eats = new IEat[2]
            {
                new Manager(),
                new Worker()
            };
            foreach (var worker in eats)
            {
                worker.Eat();
            }
        }
    }

    interface IWorker  //Şierketteki tüm çalışanlar(Şirkette üç tip çalışan olucak birazdan)
    {
        void Work();  //Tüm çalışanlar çalışır.

    }

    interface IEat
    {
        void Eat();  //Tüm çalışanlar yemek yer.
    }

    interface ISalary
    {
        void GetSalary();  //Tüm çalışanlar maaş alır.
    }

    class Manager : IWorker, IEat, ISalary //Arayüzümüzde oluşturduğumuz özellikleri yöneticiye impement ettik
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }

    class Worker : IWorker, IEat, ISalary//Arayüzümüzde oluşturduğumuz özellikleri  çalışana impement ettik
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}
