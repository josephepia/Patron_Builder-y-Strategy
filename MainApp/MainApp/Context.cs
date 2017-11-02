using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    // Contiene un objeto ConcreteStrategy y mantiene una referencia a un objeto Strategy
    class Context
    {
        IStrategy strategy;

        // Constructor
        public Context(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void Execute()
        {
            strategy.Execute();

        }
    }
}
