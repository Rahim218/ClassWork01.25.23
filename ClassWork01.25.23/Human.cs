using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork01._25._23
{
    internal class Human
    {

        public string name;
        public string surname;
        public int age;

        public string GetFullName()
        {
            return $"{name} {surname}";
        }

    }
}
