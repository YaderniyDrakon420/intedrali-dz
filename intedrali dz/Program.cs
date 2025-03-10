namespace integrali
{

    internal class Program
    {
        //delegate void MyDelegate(string message);
        //static void ShowMessage(string message)
        //{
        //    Console.WriteLine(message);
        //}
        //static void ShowMessageUpper(string message)
        //{
        //    Console.WriteLine(message.ToUpper());
        //}

        delegate double operation(double a, double b);

        static double Dodavanya(double a, double b)
        {
            return a + b;
        }

        static double Vidnimanya(double a, double b)
        {
            return a - b;
        }

        static double Mnozhenya(double a, double b)
        {
            return a * b;
        }

        static void Main(string[] args)
        {
            //MyDelegate message1 = ShowMessage;
            //MyDelegate message2 = ShowMessageUpper;
            //message1("Привiт, свiт!");
            //message2("Привiт, свiт!");

            Console.Write("Введіть перше число: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введіть друге число: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Оберіть операцію: ");
            Console.WriteLine("1 - Додавання");
            Console.WriteLine("2 - Віднімання");
            Console.WriteLine("3 - Множення");
            Console.Write("Ваш вибір: ");

            int choice = Convert.ToInt32(Console.ReadLine());
            operation operation = null;

            if (choice == 1)
                operation = Dodavanya;
            else if (choice == 2)
                operation = Vidnimanya;
            else if (choice == 3)
                operation = Mnozhenya;
            else
                Console.WriteLine("Невірний вибір!");

            if (operation != null)
                Console.WriteLine("Результат: " + operation(x, y));
        }


    }
}