using DIConsoleApp.Implementations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace DIConsoleApp.Tests
{
    [TestClass]
    public class ProcessorTests
    {
        [TestMethod]
        public async Task WaiterTests()
        {
            Processor processor = new Processor();
            await processor.Waiter();

            Assert.IsTrue(true);
        }
    }
}
