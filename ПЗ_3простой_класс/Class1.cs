using pz_2_003;
using System;


namespace ПЗ_3простой_класс
{
    class Prog
    { 
            static void Main(string[] args)
            {
            //    Console.WriteLine("Имя\n");
            //    string Name = Console.ReadLine();
            //    Console.WriteLine("Фамилия\n");
            //    string Fam = Console.ReadLine();
            //    Console.WriteLine("Отчество\n");
            //    string Otch = Console.ReadLine();
            //    Console.WriteLine("Возраст\n");
            //int Age = Convert.ToInt32(Console.Read());
            //Console.WriteLine("Класс\n");
            //int Classroom= Convert.ToInt32(Console.Read());
            //Console.WriteLine("Математика\n");
            //int MathMark = Convert.ToInt32(Console.Read());
            //Console.WriteLine("Физика\n");
            //int PhysMark= Convert.ToInt32(Console.Read());
            //Console.WriteLine("Химия\n");
            //int ChemMark=Convert.ToInt32(Console.Read());
       

        
            
    
                Pupil p = new Pupil();
            p.Name = "Евгения";
            p.Fam = "Зорянкина";
            p.Age = 19;
            p.Otch = "Алексеевна";
            p.classroom = 11;
            p.MathMark = 5;
            p.PhysMark = 5;
            p.ChemMark = 5;
            string pName = p.Name;
            p.GetPupilInfo();
            p.GetMediumMark();
                Pupil p1 = new Pupil();
            p1.Name = " ";
            p1.Fam = "Трайпарс";
            p1.Age = 12;
            p1.Otch = "Иванович";
            p1.classroom = 7;
            p1.MathMark = 4;
            p1.PhysMark = 6;
            p1.ChemMark = 4;
            string p1Name = p1.Name;
            Console.WriteLine(p1Name);
            p1.GetPupilInfo();
            p1.GetMediumMark();
            Pupil p2 = new Pupil();
            p2.Name = "Артур ";
            p2.Fam = "Петров";
            p2.Age = 9;
            p2.Otch = "Иванович";
            p2.classroom = 4;
            p2.MathMark = 3;
            p2.PhysMark = 4;
            p2.ChemMark = 3;
            string p2Name = p2.Name;
            Console.WriteLine(pName);
            p2.GetPupilInfo();
            p2.GetMediumMark();
       
            Pupil p3 = new Pupil();
            p3.Name = " Елизавета";
            p3.Fam = "Попова";
            p3.Age = 16;
            p3.Otch = "Алексеевна";
            p3.classroom = 9;
            p3.MathMark = 5;
            p3.PhysMark = 4;
            p3.ChemMark = 5;
            string p3Name = p3.Name;
            p3.GetPupilInfo();
            p3.GetMediumMark();
       
            Console.ReadLine();
            Pupil p4 = new Pupil();
            p4.Name = " Елизавета";
            p4.Fam = "Попова";
            p4.Age = 16;
            p4.Otch = "Алексеевна";
            p4.classroom = 9;
            p4.MathMark = 5;
            p4.PhysMark = 4;
            p4.ChemMark = 5;
            string p4Name = p4.Name;
            p4.GetPupilInfo();
            p4.GetMediumMark();
            Pupil.GetCounter1();
            Console.WriteLine($"Отличники: {(Pupil.GetCounter())}");
            Console.WriteLine($"Двоечники: {(Pupil.GetCounter1())}");
            Console.ReadLine();
            
            }
        



    }
}
