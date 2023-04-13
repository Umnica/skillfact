namespace kek
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var department = GetCurrentDepartment();
            static Department GetCurrentDepartment()
            {
                // logic
            }
            /*Напишите такой код, который бы 
             * при типе компании, равному типу "Банк", и городе "Санкт-Петербург" 
             * выводил в консоль сообщение "У банка ??? есть отделение в Санкт-Петербурге", 
             * где вместо "???" выводилось бы название компании.

            Если у компании нет названия, вместо него должно быть "Неизвестная компания".*/

            if (department?.Company.Type == "Банк" && department?.City.Name == "Санкт-Петербург")
            {
                string s = "У банка {0} есть отделение в Санкт-Петербурге";
                Console.WriteLine(s, department.Company.Name);
            }
            else
            {
                Console.WriteLine("Неизвестная компания");
            }
            if (department?.Company.Type == "Банк" && department?.City.Name == "Санкт-Петербург")
            {
                string s = "У банка {0} есть отделение в Санкт-Петербурге";
                Console.WriteLine(s, department?.Company?.Name ?? "Неизвестная компания");
            }
        }
        class Company
        {
            public string Type;
            public string Name;
        }

        class Department
        {
            public Company Company;
            public City City;
        }

        class City
        {
            public string Name;
        }

    }
}