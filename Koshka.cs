using System;

namespace Cats
{
    class Cat
    {
        public string Name;
        public DateTime birthday;
        public Cat(string n, DateTime d) { Name = n; birthday = d; }    
        public void MakeNoise()
        {
        Console.WriteLine($"{Name} мяукает ");
        }
        public void GetInfo()
        {
            Console.WriteLine($"{Name} {birthday}");
        }
        public void GetAge()
        {
            Console.WriteLine($"Дата рождения {birthday}");
            Console.WriteLine($"Возраст {(DateTime.Today - birthday).Days/365 }");
        }
        public void GetInfoAboutCat()
        {
            Console.WriteLine($"Кошке по имени {Name} уже {(DateTime.Today - birthday).Days / 365 } лет");
        }
    }
    class Program
    {

        public static void Main(string[] args)
        {
            DateTime date1 = new DateTime(2015, 7, 20);
            Cat pet = new Cat("Кокос",date1);
            pet.GetInfo();
            pet.GetAge();
            pet.MakeNoise();
            pet.GetInfoAboutCat();
        }
    }
}
