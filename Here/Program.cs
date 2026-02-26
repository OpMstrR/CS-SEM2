// See https://aka.ms/new-console-template for more information


using System.Diagnostics.Metrics;
using System.Xml.Linq;

namespace pr1
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;



            Console.Write(" x= ");
            int x = int.Parse(Console.ReadLine());
            Console.Write(" y= ");
            int y = int.Parse(Console.ReadLine());

            Console.Write(" Обери дію : \n 1=Додавання \n 2=Віднімання \n 3=Множення \n 4=Ділення \n Ваш вибір: ");
            int choice = int.Parse(Console.ReadLine());

            Math.MathOperation operation = Math.Add;


            switch (choice)
            {
                case (1):
                    operation = Math.Add; break;
                case (2):
                    operation = Math.Subtract; break;
                case (3):
                    operation = Math.Multiply; break;
                case (4):
                    operation = Math.Divide; break;
            }




            int result = operation(x, y);
            Console.WriteLine($"Result: {result}");



            //  ЯК Є:     delegate (ВІДДАЄ) OwnFunction(ПРИЙМАЄ, ПРИЙМАЄ...) -->


            // public delegate int MathOperation(int a, int b);    -->      Math.MathOperation operation = Math.Add;     -->   operation(x, y)


            //                                    -->           Func<double, double, double> operation = Math.Add;       -->  operation(a, b)

            // ЯК Є:  func< ПРИЙМАЄ, ПРИЙМАЄ, ПРИЙМАЄ..., ВІДДАЄ>

            Console.Write(" a= ");
            int a = int.Parse(Console.ReadLine());
            Console.Write(" b= ");
            int b = int.Parse(Console.ReadLine());

            Console.Write(" Обери дію : \n 1=Додавання \n 2=Віднімання \n 3=Множення \n 4=Ділення \n Ваш вибір: ");
            int choice2 = int.Parse(Console.ReadLine());


            Func<double, double, double> operation2 = Math2.Add2;
            
            switch (choice2)
            {
                case (1):
                    operation2 = Math2.Add2; break;
                case (2):
                    operation2 = Math2.Subtract2; break;
                case (3):
                    operation2 = Math2.Multiply2; break;
                case (4):
                    operation2 = Math2.Divide2; break;
            }




            double result2 = operation2(a, b);
            Console.WriteLine($"Result: {result2}");


















            /*
            Noti.NotificationHandler nots = Noti.SendSMS;

            Console.WriteLine("Mesage : ");
            string msg = Console.ReadLine();

            string message = nots();

            Console.WriteLine($"Mesage : {nots}");

            */
            Noti.NotificationHandler nots = Noti.Sent;

            string d = "TEST";
            nots(d);
            nots += Noti.SendSMS;
            nots(d);

            //nots -= Noti.SendSMS;
            //nots(d);

            int[] massiv = {1,2,3,4,5,6,7,8,9,10};


            static bool IsEven(int x)
            {
                return x % 2 == 0;
            }

            static bool MoreFive(int x)
            {
                return x > 5;
            }

            Console.WriteLine("Парні числа:");
            Filter.FilterArray(massiv, IsEven);

            Console.WriteLine("Числа більше 5:");
            Filter.FilterArray(massiv, MoreFive);

            Console.WriteLine("Непарні числа (лямбда вираз):");
            Filter.FilterArray(massiv, x => x % 2 != 0);

            Console.WriteLine("Непарні числа (Анонімний метод):");
            Filter.FilterArray
                (
                    massiv, delegate (int x)
                    {
                        return x % 2 != 0;
                    }
                );


            Console.WriteLine("Непарні Числа більше 5 (Анонімний метод):");
            Filter.FilterArray
                (
                    massiv, delegate (int x)
                    {
                        if (x > 5)
                        {
                            return x % 2 != 0;
                        }
                        else return false;
                    }

                );







            List<string> students = new List<string>
            {
                "Влад",
                "Марго",
                "Мирослав",
                "Андрій",
                "Руслан",
                "Олексій"
            };


            Console.Write("На яку літеру будемо шукати Ім'я? - ");
            string Required_Letter = Console.ReadLine();



            Predicate<string> StartsWithLetter;

            StartsWithLetter  = delegate (string name)
            {
                return name.StartsWith(Required_Letter);
            };



            List<string> found = students.FindAll(StartsWithLetter);



            /*List<string> found = students.FindAll
                (
                    name => name.StartsWith(Required_Letter)
                );*/


            Console.WriteLine($"Імена на літеру {Required_Letter}:");
            foreach (string name in found)
            {
                Console.WriteLine(name);
            }


            Console.WriteLine("Напишіть Де потрібен апперкейс? ");
            string LogChanger= Console.ReadLine();
            Logger logger = new Logger();

            logger.LogHandler = message =>
            {
                Console.WriteLine(message);
            };

            
            logger.Log(LogChanger);


            logger.LogHandler = message =>
            {
                Console.WriteLine(message.ToUpper());
            };
            logger.Log(LogChanger);









            Validnost.Validator IsLoginValid = Validnost.GetValidator(3);
            Validnost.Validator IsPasswordValid = Validnost.GetValidator(8);

            Console.Write("Введіть логін: ");
            string login = Console.ReadLine();

            Console.WriteLine
                (
                    IsLoginValid(login)
                        ? "Логін валідний"
                        : "Логін короткий (min. 3)"
                ); 



            Console.Write("Введіть пароль: ");
            string password = Console.ReadLine();

            Console.WriteLine
                (
                    IsPasswordValid(password)
                        ? "Пароль валідний"
                        : "Пароль короткий (min. 8)"
                );

        }
    }

}