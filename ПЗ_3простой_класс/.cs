using System;
using pz_2_003;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace pz_2_003
{
     class Pupil
    {
        public int mathMark;// поля из задания
        public int physMark;
        public int chemMark;
        public int classroom;
        public string name = "ghbd";
        string fam;
        string otch;
        public int age;
        static int Excellent;
        static int Bad_st;

        public string Name
        {
            get { return name; }
            set { if (value == " ")
                { Console.WriteLine("Ошибка. Имя не введенно"); name = "ошибка"; }
                else name = value; }
        }
        public string Fam
        {
            get { return fam; }
            set { if (value == " ") { Console.WriteLine("Ошибка. Фамилия не введенна"); fam = "ошибка"; } else fam = value; }
        }
        public string Otch
        {
            get { return otch; }
            set { if (value == " ") { Console.WriteLine("Ошибка. Отчество не введенно"); otch = "ошибка"; } else otch = value; }
        }
        public int Age
        {
            set
            {
                if (value <= 7 || value >= 18)
                    Console.WriteLine("Ошибка. Возраст должен быть в диапазоне от 7 до 18");
                
                age = value;
            }
            get { return age; }
        }

        public int MathMark
        {
            set
            {
                if (value <= 1 || value >= 6)
                {
                    Console.WriteLine("Оценка должена быть в диапазоне от 2 до 5");
                        mathMark = 0;
                }
                else mathMark = value;

            }
            get { return mathMark; }
        }
        public int PhysMark
        {
            set
            {
                if (value <= 1 || value >= 6)
                {
                    Console.WriteLine("Оценка должена быть в диапазоне от 2 до 5");
                    physMark = 0;

                }
                else physMark = value;


            }
            get { return physMark; }
        }
        public int ChemMark
        {
            set
            {
                if (value <= 1 || value >= 6)
                {
                    Console.WriteLine("Оценка должена быть в диапазоне от 2 до 5");
                    chemMark = 0;

                }
                else chemMark = value;
            }
        }


        public Pupil()
        {
            if (mathMark == 2 || physMark == 2 || chemMark == 2)
            { Bad_st++; }
            if (mathMark == 5 && physMark == 5 && chemMark == 5) Excellent++;
  
        }
        public static int GetCounter()
        { return Excellent; }
        public static int GetCounter1()
        { return Bad_st; }

        public void GetPupilInfo()
        {
            Console.WriteLine($"Имя: {name} Отчество: {otch} Фамилия: {fam} Возраст: {age} \nКласс: {classroom}\nОценки\nМатематика: {mathMark}\nФизика: {physMark}\nХимия: {chemMark}");
        }   
        public void GetMediumMark()
        {
            Console.WriteLine($"Средняя оценка: {(mathMark + physMark + chemMark) / 3}");
        }
        //public override void GetPupilInfo() // переопределяю метод
        //{
        //    base.GetPupilInfo();
        //    Console.Write($" {ReleaseDate}"); // и причину вывожу да вот
        //}

    }
}