using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPthreadCSharp
{
    public class CTest
    {

        public void afficheB()
            {
                while (true)
                {
                    Console.WriteLine($"Thread name: {Thread.CurrentThread.Name}");
                    Thread.Sleep(1000);
                }
            }
        public void afficheC()
        {
          
            Thread thread = Thread.CurrentThread;
            for (int i = 0; i < 101; i++)
            {               
                Console.WriteLine($"Thread name: {Thread.CurrentThread.Name}");
            }
            
        }
    }
}
