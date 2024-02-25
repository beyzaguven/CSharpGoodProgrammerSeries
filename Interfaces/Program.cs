using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        //interface new'lenemez.
        static void Main(string[] args)
        {
            //interface'ler onu implemente eden class'ın referansını tutabilir:
            //IPersonManager customerManager = new CustomerManager();
            //customerManager.Add();
            //IPersonManager employeeManager = new EmployeeManager(); 
            //employeeManager.Add();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new CustomerManager());
            projectManager.Add(new EmployeeManager());

            Console.ReadLine();
        }
    }

    interface IPersonManager
    {
        //unimplemented operation
        void Add();
        void Update();
    }


    //inherits - class ---------------- implements - interface
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //müşteri ekleme kodları.
            Console.WriteLine("Customer is added.");
        }

        public void Update()
        {
            Console.WriteLine("Customer is updated.");
        }
    }
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            //personel ekleme kodları.
            Console.WriteLine("Employee is added.");
        }

        public void Update()
        {
            Console.WriteLine("Employee is updated.");
        }
    }

    class InternManager : IPersonManager

    {
        public void Add()
        {
            Console.WriteLine("Intern is added.");
        }

        public void Update()
        {
            Console.WriteLine("Intern is updated.");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager) //parametre olarak interface kullanımı. (interface implemente edildiği sınıfın referanslarını da tuttuğu için.)
        {
            personManager.Add();

        }

    }
}
