namespace kek
{
    internal class Program
    {
        /*
        Необходимо создать метод, который заполняет данные с клавиатуры по пользователю (возвращает кортеж):
        Имя;
        Фамилия;
        Возраст;
        Наличие питомца;
        Если питомец есть, то запросить количество питомцев;
        Если питомец есть, вызвать метод, принимающий на вход количество питомцев и возвращающий массив их кличек (заполнение с клавиатуры);
        Запросить количество любимых цветов;
        Вызвать метод, который возвращает массив любимых цветов по их количеству (заполнение с клавиатуры);
        Сделать проверку, ввёл ли пользователь корректные числа: возраст, количество питомцев, количество цветов в отдельном методе;
        Требуется проверка корректного ввода значений и повтор ввода, если ввод некорректен;
        Корректный ввод: ввод числа типа int больше 0.
        Метод, который принимает кортеж из предыдущего шага и показывает на экран данные.
        Вызов методов из метода Main.
        */

        static void Main(string[] args)
        {
            var user = createUser();
            printUser(user);
        }
        

        static string[] createPet(int n)
        {
            if (n > 0)
            {
                var arr = new string[n];
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine("Введите кличку {0} питомца", i);
                    arr[i - 1] = Console.ReadLine();
                }
                return arr;
            }
            else
            {
                var arr = new string[] { "питомцев нет" };
                return arr;
            }
        }


        /*var k = createPets(2);
        foreach (var item in k)
            Console.Write(item + " ");
        */

        static string[] createColor(int n)
        {
            var arr = new string[n];
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Введите {0} цвет", i);
                arr[i - 1] = Console.ReadLine();
            }
            return arr;
        }

        static bool test_parametrs(int age, int count_pet, int count_color)
        {
            bool res = age > 0 && count_pet >= 0 && count_color >= 0;
            return res;
        }

        static (int, int, int) input_params()
        {
            int age = 0,
                count_pet = 0,
                count_color = 0;
            bool flag_pet = false;
            Console.WriteLine("Введите ваш возраст");
            age = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Введите *да*, если есть у вас питомец(ы)");
            string s = Console.ReadLine();
            if (s == "да")
            {
                flag_pet = true;
                Console.WriteLine("Введите кол-во питомцев");
                count_pet = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Введите кол-во любимых цветов");
            count_color = Convert.ToInt32(Console.ReadLine());

            if (test_parametrs(age, count_pet, count_color))
                return (age, count_pet, count_color);
            else
                return input_params();

        }

        static (string, string, int, int, string[], int, string[]) createUser()
        {
            string name = "", lastname = "";

            int age = 0,
                count_pet = 0,
                count_color = 0;

            Console.WriteLine("Введите имя, фамилию");
            name = Console.ReadLine();
            lastname = Console.ReadLine();

            (age, count_pet, count_color) = input_params();

            var color = createColor(count_color);
            var pet = createPet(count_pet);

            return (name, lastname, age, count_color, color, count_pet, pet);

        }

        static void printUser((string, string, int, int, string[], int, string[]) user)
        {
            Console.WriteLine("имя: {0}", user.Item1);
            Console.WriteLine("фамилия: {0}", user.Item2);
            Console.WriteLine("возраст: {0}", user.Item3);
            Console.WriteLine();

            Console.WriteLine("кол-во люб. цветов: {0}", user.Item4);
            Console.Write("цвета: ");
            foreach (var item in user.Item5) Console.Write(item + " ");
            Console.WriteLine();

            Console.WriteLine("кол-во питомцев: {0}", user.Item6);
            Console.Write("питомцы: ");
            foreach (var item in user.Item7) Console.Write(item + " ");
        }

       
    }
}