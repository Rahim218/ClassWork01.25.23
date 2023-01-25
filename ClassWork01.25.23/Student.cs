using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork01._25._23
{
    internal class Student
    {
       public string Fullname;
        public int Groupno;
        public int Point;

        public bool IsGraduated()
        {
            if (Point>=65)
            {
                return true;
            }
            return false;
        }
    }
}
