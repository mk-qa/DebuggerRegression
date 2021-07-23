using System;
using System.Data;


namespace Exc5
{
    public static class TestEx
    {
        public static void UnhandlEx()
        {
            throw new DataException("This is the unhandled DataException");
        }

        public static void HandlEx()
        {
            try
            {
                throw new ArgumentException("This is handled ArgumentException");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}