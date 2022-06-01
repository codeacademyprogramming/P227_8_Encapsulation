using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class Human
    {
        public string FullName;
        protected int _age;

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value > 14)
                    _age = value;
            }
        }

        public int GetAge()
        {
            return _age;
        }

        public void SetAge(int age)
        {
            if (age > 14)
                _age = age;
        }
    }
}
