using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class Employee:Human
    {
        public int Age
        {
            get => _age;
            set
            {
                if (value > 17)
                    _age = value;
            }
        }
    }
}
