using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyLog.Core
{
    public class Calculator
    {
        private IConsole console;

        public Calculator(IConsole console)
        {            
            this.console = console;
        }
        public int Add(string input)
        {
            if (input.Contains('-'))
                throw new InvalidOperationException();

            var parts = input.Split(new[] {','}, StringSplitOptions.RemoveEmptyEntries);
            var sum = parts.Sum(part => int.Parse(part));

            console.WriteLine(sum);

            return sum;
        }
    }

    public interface IConsole
    {
        void WriteLine(object p);
    }
}
