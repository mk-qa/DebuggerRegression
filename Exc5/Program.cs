using System;
using ExternalEx5;

namespace Exc5
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: user code
            TestEx.HandlEx();
            TestEx.UnhandlEx();
            
            //TODO: external code
            TrowEx.HandlEx(); 
            TrowEx.UnhandlEx();

            /*
            try
            {
                throw new Exception("This is Exception");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            */
            
            
        }
    }
}