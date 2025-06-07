using Tyuiu.AntonovVV.Sprint4.Task7.V3.Lib;
namespace Tyuiu.AntonovVV.Sprint4.Task7.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Антонов В.В. | ИCПб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт#4                                                                *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринтуФайл             *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Антонов В.В. | ИCПб-24-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр. Преобразуйте ее в матрицу 4 на 2 и   *");
            Console.WriteLine("* подсчитайте количество нечетных чисел в матрице.                        *");
            Console.WriteLine("*                                                                         *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int n = 4;
            int m = 2;
            string text = "27182818";
            Console.WriteLine("n: " + n);
            Console.WriteLine("m: " + m);
            Console.WriteLine("String: " + text);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(n, m, text);

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}