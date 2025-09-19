using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amtelco.Test
{
    public class Class1
    {
        public async Task DoStuff()
        {
            List<Task> pending = new List<Task>();
            Task timeoutTask = Task.Delay(30000);
            Task first = await Task.WhenAny(Task.WhenAll(pending.ToArray()), timeoutTask);
            if(first == timeoutTask)
                throw new TimeoutException("Sending data to Active Insights");
            await first;    // handle any exceptions from pending

        }
        public void BR3()
        {
            Console.WriteLine("BR-3");
        }
    }
}
