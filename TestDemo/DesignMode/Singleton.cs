using System;
using System.Collections.Generic;
using System.Text;

namespace TestDemo.DesignMode
{
    public class Singleton
    {
        private static Singleton s_instance;
        private int _state;
        private Singleton(int state)
        {
            this._state = state;
        }
        public static Singleton Instance
        {
            get => s_instance ?? (s_instance = new Singleton(42));
        }
    }

    public class Car
    {
        private readonly string _description;
        private readonly uint _nWheels;
        public Car(string description, uint nWheels)
        {
            this._description = description;
            this._nWheels = nWheels;
        }

        public Car(string description) : this(description, 4)
        {
        }
    }
}
