using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41
{
    class CA:IInfo
    {
        public string Name;
        public int Age;

        public string GetAge()
        {
            return Age.ToString();
        }

        public string GetName()
        {
            return Name;
        }
    }
    class CB:IInfo
    {
        public string First;
        public string Last;
        public double PersonsAge;

        public string GetAge()
        {
            return PersonsAge.ToString();
        }

        public string GetName()
        {
            return First + "" + Last;
        }
    }
    //class Program
    //{
    //    static void PrintInfo(IInfo item)
    //    {
    //        Console.WriteLine("Name:{0},Age{1}", item.GetName(), item.GetAge());
    //    }
    //    static void Main()
    //    {
    //        CA a = new CA() { Name = "John Doe", Age = 35 };
    //        CB b = new CB() { First = "Jane", Last = "Doe", PersonsAge = 33 };
    //        PrintInfo(a);
    //        PrintInfo(b);
    //    }
      
        
    //}
}
