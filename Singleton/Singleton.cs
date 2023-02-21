using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    public sealed class Singleton
    {
        private static int counter = 0;
        private static Singleton? Instance = null;
        public static Singleton GetInstance
        {
            get
            {
                if(Instance == null)
                 Instance= new Singleton();
                return Instance;
            }         
        }
        private Singleton() 
        {
            counter ++;
            Console.WriteLine("counter value " + counter.ToString());
        }
        public void PrintDetail(string message)
        {
            Console.WriteLine(message);
        }
    }
}
