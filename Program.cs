using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo {
    class Program {

        public delegate void AddDelegate(int a, int b);
        public delegate string GreetingsDelegate(string name);
        public void Add(int x, int y) {
            Console.WriteLine($"The sum of {x} and {y}, is {x + y}");
        }
        static string Greetings(string name) {
            return "Hello @" + name;
        }
        static void Main(string[] args) {
            Program obj = new Program();
            //The add method is non static so 
            AddDelegate ad = new AddDelegate(obj.Add);
            GreetingsDelegate gd = new GreetingsDelegate(Program.Greetings);

            //calling non static through object
            ad(100,100);

            string greetingMessage = gd("Bismillah");

            Console.WriteLine(greetingMessage);
            Console.ReadKey();
        }
    }
}
