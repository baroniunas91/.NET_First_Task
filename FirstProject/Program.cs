    using System;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įrašykite savo vardą");
            string name = Console.ReadLine();
            bool isNumeric = int.TryParse(name, out _);

            while (isNumeric)
            {
                Console.WriteLine("Nevalidus vardas. Įrašykite stringą");
                name = Console.ReadLine();
                isNumeric = int.TryParse(name, out _);
            }

            Console.WriteLine("Įrašykite savo pavardę");
            string surname = Console.ReadLine();
            isNumeric = int.TryParse(surname, out _);

            while (isNumeric)
            {
                Console.WriteLine("Nevalidi pavardė. Įrašykite stringą");
                surname = Console.ReadLine();
                isNumeric = int.TryParse(surname, out _);
            }

            Console.WriteLine("Įrašykite kelintais metais gimėte");
            string year = Console.ReadLine();
            isNumeric = int.TryParse(year, out _);

            while (!isNumeric)
            {
                Console.WriteLine("Blogai. Metai turi būti skaičius");
                year = Console.ReadLine();
                isNumeric = int.TryParse(year, out _);
            }

            int birthdayYear = Int32.Parse(year);

            Console.WriteLine("Įrašykite kelintą mėnesį gimėte");
            string month = Console.ReadLine();
            isNumeric = int.TryParse(month, out _);

            while (!isNumeric)
            {
                Console.WriteLine("Blogai. Mėnesis turi būti skaičius");
                month = Console.ReadLine();
                isNumeric = int.TryParse(month, out _);
            }

            int birthdayMonth = Int32.Parse(month);

            Console.WriteLine("Įrašykite kelintą dieną gimėte");
            string day = Console.ReadLine();
            isNumeric = int.TryParse(day, out _);

            while (!isNumeric)
            {
                Console.WriteLine("Blogai. Diena turi būti skaičius");
                day = Console.ReadLine();
                isNumeric = int.TryParse(day, out _);
            }

            int birthdayDay = Int32.Parse(day);

            var timeSpan = (DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0));
            var now = (long)timeSpan.TotalSeconds;

            var birthdayTimeSpan = (new DateTime(birthdayYear, birthdayMonth, birthdayDay, 0, 0, 0) - new DateTime(1970, 1, 1, 0, 0, 0));
            var birthday = (long)birthdayTimeSpan.TotalSeconds;

            long ageTimeSpan = now - birthday;

            long age = (ageTimeSpan / (60 * 60 * 24)) / 366;

            string result = $"Your name is {name}, your surname is {surname} and you are {age} years old";
            Console.WriteLine(result);
            Console.WriteLine("Programos pabaiga!");
        }
    }
}
