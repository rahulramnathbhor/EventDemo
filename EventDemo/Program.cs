using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{






    namespace ClassDemos
    {

        public delegate void MyDelegate();
        public class Stud
        {
            public event MyDelegate Pass; // pass & fail are the events
            public event MyDelegate Fail;
            public void AcceptMarks(int mark)
            {
                if (mark > 75)
                {
                    Pass(); // call to event --> raise an event
                }
                else if (mark < 40)
                {
                    Fail();
                }
                Console.WriteLine($"Your score is {mark}");
            }
        }

        public class Program
        {
            static void Success()
            {
                Console.WriteLine("You got Grade A");
            }
            static void Fail()
            {
                Console.WriteLine("You are Fail");
            }
            static void Main(string[] args)
            {

                Stud s1 = new Stud();
                s1.Pass += new MyDelegate(Success);
                s1.Fail += new MyDelegate(Fail);
                s1.AcceptMarks(85);

            }

        }

    }
}
    





    

