using System;

public delegate void Delegate();

namespace PZ_9_Sobitiya
{
    public class Counter
    {
        public int num;
        public Counter(int x)
        {
            num = x;
        }

        public void Numbers()
        {
            Fishing a = new Fishing();
            for (int i = 1; i < 1001; i++)
            {
                a.ActiveateEvent(i);

                if (i == 800) break;
            }
        }
    }
    public class Fishing
    {
        public event Delegate num;
        public void ActiveateEvent(int now)
        {

            if (now == 200)
            {
                num = Dvesti;
            }
            else if (now == 800)
            {
                num = Vosemsot;
            }
            else num = null;
            if (num!= null) num();
        }
        void Dvesti()
        {
            Console.WriteLine("Мы поймали 200");
        }
        void Vosemsot()
        {
            Console.WriteLine("Мы поймали 800");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Counter b = new Counter(1);
            b.Numbers();
        }
    }
}
