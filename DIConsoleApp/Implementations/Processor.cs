using DIConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DIConsoleApp.Implementations
{
    public class Processor : IProcessor
    {
        public async Task Waiter()
        {
            await Task.Delay(10000);
        }
    }
}
