using System;
using System.Collections.Generic;
using System.Text;

namespace TestDemo.Delegate
{
    public class BubbleSorter
    {
        static public void Sort<T>(IList<T> sortArray, Func<T, T, bool> comparison)
        {
            bool swapped;
            do
            {
                swapped = false;
                for (var i = 0; i < sortArray.Count - 1; i++)
                {
                    if (comparison.Invoke(sortArray[i + 1], sortArray[i]))
                    {
                        T temp = sortArray[i];
                        sortArray[i] = sortArray[i + 1];
                        sortArray[i + 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);
        }
    }

    public class Employee
    {
        public string Name { get; }
        public decimal Salary { get; }

        public Employee(string name, decimal salary)
        {
            this.Name = name;
            this.Salary = salary;
        }

        public override string ToString() => $"{this.Name}, {this.Salary:C}";
        public static bool CompareSalary(Employee e1, Employee e2) => e1.Salary < e2.Salary;
    }
}
