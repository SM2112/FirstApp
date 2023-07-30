using System.Collections.Specialized;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // КОД ИТОГОВОЙ ПРРОГРАМММЫ ПО МОДУЛЮ 3
            // ЗА ОСНОВУ ВЫВОДА ВЗЯТ ПОСЛЕДНИЙ СКРИН С РАЗДЕЛА 3.7

            //раздел объявления переменных
            byte age;
            bool iscorrect;  // переменная для понимания корректно ли произошло преобразование возрасста
            string name, birthday;

            // раздел сбора и вывода информации о пользователе
            Console.WriteLine("Привет, пользорватель!");
            Console.WriteLine("Я  компютер");
            Console.WriteLine("Я собираю анкету о тебе. Начнем!");
            
            Console.Write("Введите свое имя: ");
            name = Console.ReadLine();
            
            Console.Write("Введите свой возраст: ");
            iscorrect = byte.TryParse(Console.ReadLine(), out age);
            
            Console.WriteLine($"Проверяем! Ваше имя {name} и Ваш возраст {age} лет!");
            Console.WriteLine($"Проверка корректности ввода возраста показала {iscorrect}");

            Console.Write("Ваша дата рождения: ");
            birthday = Console.ReadLine();

            Console.WriteLine("{0}, Ваша дата рождения - {1}", name, birthday);
            Console.ReadKey();

        }
       
    }
}

