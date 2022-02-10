using System;

namespace pz_2_003
{
    class Pupil
    {
        public int mathMark;// поля из задания
        public int physMark;
        public int chemMark;
        public string name;
        public int age;
        public int classroom;
        public Pupil(int ma, int ph, int ch) { mathMark = ma; physMark = ph; chemMark = ch; }
        public Pupil(string co, int ma, int ph, int ch) { name = co; mathMark = ma; physMark = ph; chemMark = ch; }
        public Pupil(int ho, int fl, int ma, int ph, int ch) { age = ho; classroom = fl; mathMark = ma; physMark = ph; chemMark = ch; }
        public Pupil(string co, int ho, int ma, int ph, int ch) { name = co; age = ho; mathMark = ma; physMark = ph; chemMark = ch; }
        public Pupil(string co, int ho, int fl, int ma, int ph, int ch) { name = co; age = ho; classroom = fl; mathMark = ma; physMark = ph; chemMark = ch; }
        public void GetInfo()
        {
            Console.WriteLine($"Имя: {name}\nВозраст: {age}\nКласс: {classroom}\nОценки\nМатематика: {mathMark}\nФизика: {physMark}\nХимия: {chemMark}");
        }
        public void GetMediumMark()
        {
            Console.WriteLine($"Средняя оценка: {(mathMark + physMark + chemMark) / 3}");
        }
        static void Main(string[] args)// тест конструктора
        {
            Pupil p = new Pupil("Павел", 5, 4, 5);
            p.GetInfo();
            p.GetMediumMark();
            Pupil p1 = new Pupil(8, 2, 4, 5, 5);
            p1.GetInfo();
            p1.GetMediumMark();
            Pupil p2 = new Pupil("Павел", 8, 4, 4, 4);
            p2.GetInfo();
            p2.GetMediumMark();
            Pupil p3 = new Pupil("Павел", 8, 2, 5, 4, 4);
            p3.GetInfo();
            p3.GetMediumMark();
        }
    }
}