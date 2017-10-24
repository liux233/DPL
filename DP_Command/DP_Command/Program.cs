using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP_Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Receiver r = new Receiver();
            Command c = new ConcreteCommand(r);
            Invoker i = new Invoker();
            i.SetCommand(c);
            i.ExecutedCommand();

            Console.Read();
        }
    }
}
