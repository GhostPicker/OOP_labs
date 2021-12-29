using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR
{
    public sealed  class Button
    {
        public static string Color;
        public int Height { get; set; }
        public int Width { get; set; }
       
        public Button(string color = "", int height = 0, int width = 0)
        {

            Color = color;
            Height = height;
            Width = width;

        }
        public Button(Button a)
        {

            
            Height = a.Height;
            Width = a.Width;

        }
       

       
          void Squere(int b,int c)
        {
           int s = b * c;
            Console.WriteLine("Squere=" + s);
        } 
        
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Button b = obj as Button;
            if (b == null)
                return false;
            return  this.Width == b.Width && this.Height == b.Height;
        }
        interface IEvent {
            void Click();
        }
        interface IAction { void Click(); }
    }
}
