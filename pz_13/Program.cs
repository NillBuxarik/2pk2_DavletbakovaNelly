 using System;

namespace pz_13
{
    class Program
    {
        public enum Estimation
        {
            Verybad = 1,
            Unsatisfactory,
            Satisfactory,
            Good,
            Excellent
        } // Объявление типа "перечисление"

        static void Main()
        {

            Console.WriteLine("введите отметку");

            int number = Convert.ToInt32(Console.ReadLine());

            switch (number) // Обработка значений переменной
            {

                case (int)Estimation.Verybad:
                    Console.WriteLine("характеристика отметки 1: очень плохо");
                    break;
                case (int)Estimation.Unsatisfactory:
                    Console.WriteLine("характеристика отметки 2: неудовлетворительно");
                    break;
                case (int)Estimation.Satisfactory:
                    Console.WriteLine("характеристика отметки 3: удовлетворительно");
                    break;
                case (int)Estimation.Good:
                    Console.WriteLine("характеристика отметки 4: хорошо");
                    break;
                case (int)Estimation.Excellent:
                    Console.WriteLine("характеристика отметки 5: отлично");
                    break;
                default:
                    Console.WriteLine("Неверный выбор оценки. Пожауйста выберите 1, 2, 3, 4 или 5.");
                    break;
            }
        }
    }


}
