using System;
using System.Collections.Generic;
using System.Text;

namespace TestDemo.Delegate
{
    public class CarEventArgs : EventArgs
    {
        public string Car { get; }
        public CarEventArgs(string car) => this.Car = car;
    }

    public class CarDealer
    {
        public event EventHandler<CarEventArgs> NewCarInfo;
        public void NewCar(string car)
        {
            Console.WriteLine($"CarDealer, new car {car}");
            NewCarInfo?.Invoke(this, new CarEventArgs(car));
        }
    }

    public class Consumer
    {
        private readonly string _name;
        public Consumer(string name) => this._name = name;

        public void NewCarIsHere(object sender, CarEventArgs e)
        {
            Console.WriteLine($"{_name}: car {e.Car} is new");
        }
    }
}
