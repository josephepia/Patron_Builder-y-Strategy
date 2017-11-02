using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    class ConcreteStrategyB: IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Estrategia concreta B llamada con exito.Execute()");
        }

    }
}
