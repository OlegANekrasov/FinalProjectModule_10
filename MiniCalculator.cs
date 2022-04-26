using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectModule_10
{
    class MiniCalculator : SumNumbers
    {
        ILogger Logger { get; }

        public MiniCalculator(ILogger logger)
        {
            Logger = logger;
        }

        public void Sum(double v1, double v2)
        {
            double sum = checked(v1 + v2);
            Logger.Event($"Сумма чисел {v1} и {v2} равна {sum}");
        }

        public void Error(string message)
        {
            Logger.Error(message);
        }
    }
}
