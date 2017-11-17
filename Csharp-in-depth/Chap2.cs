using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_in_depth
{
    //P29 45的代码
    class Chap2
    {
        #region P29
        delegate void StringProcessor(string input);
        class Person
        {
            private string name;
            public Person(string name)
            {
                this.name = name;
            }

            public void Say(string message)
            {
                Console.WriteLine("{0} says : {1}",name,message);
            }
        }

        class Background
        {
            public static void Note(string note)
            {
                Console.WriteLine("({0})",note);
            }
        }

        public static void Sample()
        {
            Person jon = new Person("jon");
            Person tom = new Person("tom");
            StringProcessor jonsVoice, tomsVoice, background;
            jonsVoice = new StringProcessor(jon.Say);
            tomsVoice = new StringProcessor(tom.Say);
            background = new StringProcessor(Background.Note);
            jonsVoice("Hello,som.");
            tomsVoice.Invoke("Hello,Daddy!");
            background("An airplane files past.");
        }
        #endregion

        #region P45

        //delegate in C#2
        public static void DelagateIn2()
        {
            EventHandler handler;
            handler = new EventHandler(HandleDemoEvent);
            handler(null,EventArgs.Empty);

            handler = HandleDemoEvent;
            handler(null, EventArgs.Empty);

            handler = delegate(object sender, EventArgs e)
            {
                Console.WriteLine("Handled anonymously");
            };
            handler(null,EventArgs.Empty);

            handler = delegate
            {
                Console.WriteLine("Handled anonymously again");
            };
            handler(null, EventArgs.Empty);

            Func<int, int, string> func = (x, y) => (x * y).ToString();
            Console.WriteLine(func(5,20));

        }

        static void HandleDemoEvent(object sender, EventArgs e)
        {
            Console.WriteLine("Handled by HandleDemoEvent");
        }
#endregion

    }
}
