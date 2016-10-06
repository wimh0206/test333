using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Common
{
    public class LogingService
    {
        public static void WriteToFile(List<ILogable> changedItem)
        {
            foreach (var item in changedItem)
            {

                Console.WriteLine(item.Log());
            }
        }
    }
}
