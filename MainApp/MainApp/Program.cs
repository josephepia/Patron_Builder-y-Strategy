using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context;

            // Tres contextos con diferentes estrategias
            context = new Context(new ConcreteStrategyA());
            context.Execute();

            context = new Context(new ConcreteStrategyB());
            context.Execute();

            context = new Context(new ConcreteStrategyC());
            context.Execute();
            Console.ReadKey();
        }
    }
}
