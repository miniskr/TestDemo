using System;
using TestDemo.Solution;
using TestDemo.DesignMode;
using TestDemo.Sample;
using TestDemo.Delegate;

namespace TestDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee[] employees =
            //{
            //    new Employee("Bugs Bunny", 2000),
            //    new Employee("Elmer Fudd", 1000),
            //    new Employee("Daffy Duck", 2500),
            //    new Employee("Wile Coyote", 100000.28m),
            //    new Employee("Foghorn Leghorn", 2300),
            //    new Employee("RoadRunner", 5000)
            //};

            //BubbleSorter.Sort(employees, Employee.CompareSalary);
            //foreach(var employee in employees)
            //{
            //    Console.WriteLine(employee);
            //}

            var dealer = new CarDealer();
            var valtteri = new Consumer("Valtteri");
            dealer.NewCarInfo += valtteri.NewCarIsHere;
            dealer.NewCar("Willimas");

            var max = new Consumer("Max");
            dealer.NewCarInfo += max.NewCarIsHere;
            dealer.NewCar("Mercedes");
            dealer.NewCarInfo -= valtteri.NewCarIsHere;
            dealer.NewCar("Ferrari");

            Console.ReadLine();
        }

    }
}
