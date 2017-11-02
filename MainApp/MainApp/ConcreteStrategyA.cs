using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    // Implementa el algoritmo usando el patron estrategia
    class ConcreteStrategyA : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Estrategia concreta A llamada con exito.Execute()");
        }

    }
}
