using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class Car
    {
        private string _model;
        public string Brand;
        private int _fuelCapacity;

        public string Model
        {
            get => _model;
            set
            {
                if (!String.IsNullOrWhiteSpace(value) && value.Length > 1)
                {
                    _model = value;
                }
            }
        }

        public int FuelCapacity
        {
            get => _fuelCapacity;
            set
            {
                if (value >= 20 && value <= 120)
                    _fuelCapacity = value;
            }
        }


    }
}
