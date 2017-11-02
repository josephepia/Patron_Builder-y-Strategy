using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    class ConcreteStrategyC: IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Estrategia concreta C llamada con exito.Execute()");
        }

    }
}
