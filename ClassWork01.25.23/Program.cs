using System;

namespace ClassWork01._25._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region AtClass
            //    Human person = new Human
            //    {
            //        name = "Rahim",
            //        surname = "Valiyev",
            //        age = 23
            //    };

            //    Student student1 = new Student
            //    {
            //        Fullname = "Rahim Valiyev",
            //        Groupno = 629,
            //        Point = 45
            //    };
            //    Console.WriteLine(student1.IsGraduated());

            //    Product product = new Product("Milla", 15);
            #endregion

            Notebook[] notebooks = new Notebook[4];
            for (int i = 0; i < notebooks.Length; i++)
            {
                Console.WriteLine($"{i+1}-ci Mehsul");
                Console.Write("Computerin brandini daxil edin : ");
                var brand = Console.ReadLine();

                Console.Write("Computerin modelini daxil edin : ");
                var model = Console.ReadLine();

                Console.Write("Computerin qiymetini daxil edin : ");
                var price = Convert.ToDouble(Console.ReadLine());

                Notebook pc = new Notebook(brand, model, price);
                notebooks[i] = pc;
            }
            for (int i = 0; i < notebooks.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine(notebooks[i].ShowInfo());
                Console.WriteLine();
            }
            double sum = 0;
            for (int i = 0; i < notebooks.Length; i++)
            {
                sum += notebooks[i].Price;
              
            }
            double avarage = sum / notebooks.Length;
            Console.WriteLine($"Mehsullarin qiymetlerinin ortalamasi : {avarage}");

        }
        static bool HasName(string str)
        {
            if (!char.IsUpper(str[0]))
            {
                return false;
            }
            for (int i = 1; i < str.Length; i++)
            {
                if (!char.IsLower(str[i]))
                {
                    return false;
                }
            }
            return true;

        }
    }
   
}
