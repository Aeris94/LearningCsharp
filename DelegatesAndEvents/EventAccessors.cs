using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public delegate void Calculate(); 

    class Rect
    {
        private event Calculate RectEvent;
        private int a;
        private int b;

        public Rect(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public event Calculate CalculateRectEvent
        {
            add
            {
                Console.WriteLine("Attaching {0} delegate to event", value);
                RectEvent += value;
            }
            remove
            {
                Console.WriteLine("Removing {0} delegate from event.", value);
                RectEvent -= value;
            }
        }

        public void RaiseEvent()
        {
            RectEvent.Invoke();
        }

        public void Dispay()
        {
            Console.WriteLine("The rectangle area is {0}", a * b);
        }

    }

    class Program
    {
       
        static void Main(string[] args)
        {
            Rect r = new Rect(2, 3);
            r.CalculateRectEvent += r.Dispay;
            r.RaiseEvent();
            r.CalculateRectEvent -= r.Dispay;

        }      
    }
}
