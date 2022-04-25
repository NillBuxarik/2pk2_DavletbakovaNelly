using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO;

namespace PZ_2_10_events
{
    public struct Train
    {
        string name;
        public int number;
        DateTime date;

        public Train(string name, int number, DateTime date)
        {
            this.name = name;
            this.number = number;
            this.date = date;
        }

        public string CompareTo(object obj)
        {
            Train a = (Train)obj;

            if (this.name.CompareTo(a.name) == -1)
                return a.name;
            if (this.name.CompareTo(a.name) == 0)
                return a.name;
            else return a.name;
        }

        public override string ToString()
        {
            return String.Format("Название пункта назначения " + this.name + " \nНомер поезда " + number + " \nВремя отправления" + date);
        }
    }

}
