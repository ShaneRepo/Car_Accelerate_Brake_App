using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Accelerate_Brake_App
{
    class Car
    {
        // Fields
        private int _year;
        private string _make;
        private int _speed;
        // Constructors
        public Car()
        {
            _speed = 0;
            _year = 0;
            _make = "";
        }
        public Car(int yr,string mk) 
        {
            _speed = 0;
            _year = yr;
            _make = mk;
        }
        // Year property
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }
        // Make property
        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }
        // Speed property
        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }
        // Accelerate method
        public void Accelerate()
        {
            _speed += 5;
        }
        // Brake method
        public void Brake()
        {   
            _speed -= 5;
        }       
    }
}
