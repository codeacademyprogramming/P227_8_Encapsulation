using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class Student
    {
        private string _groupNo;


        public string GroupNo
        {
            get
            {
                return _groupNo;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) &&  value.Length == 4)
                    _groupNo = value;
            }
        }


    }
}
