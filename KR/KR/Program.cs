using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR
{
    class Program
    {
        static void Main(string[] args)
        {  //Вариант 17
           //1 задание
           //a
            Console.WriteLine("Max ulong="+ulong.MaxValue);
            //б
            string a = "gfdsfgOhfiuhO";
            int k = a.IndexOf('O');
            Console.WriteLine("Index first O="+k);
            Console.WriteLine("\n");
            //2 задание
            Button b = new Button("Красный",20,12);
            Button c = new Button("Желтый", 13, 21);
            if (b.Equals(c))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
             
            Squere(b.Height,b.Width);
          
        }
    }
}
