using System;
using System.Data;
using System.Threading;

namespace DisEvalNet5
{
    public class BadClass: ParentBadClass, IBadInterface
    {
        public string NormalProperty { get; set; } = "Normal value";
        public int StackOverflow => StackOverflow;
        int IBadInterface.StackOverflow => StackOverflow;

        public int EnvironmentExit
        {
            get
            {
                Environment.Exit(0);
                return 1;
            }
        }

        public string TimeoutProperty
        {
            get
            {
                while (true)
                {
                    Thread.Sleep(1000);
                }
            }
        }

        public string ExProperty => throw new DataException("Data Exception");
        
        public override string ToString()
        {
            Environment.Exit(0);
            return "Overridden Bad Class";
        }
    }
    
    public class ParentBadClass
    {
        public int EnvironmentExit
        {
            get
            {
                Environment.Exit(0);
                return 1;
            }
        }
    }
    
    public interface IBadInterface
    {
        public int StackOverflow => StackOverflow;
    }
    
    public struct BadStruct
    {
        public int StackOverflow => StackOverflow;
        
        public int EnvironmentExit
        {
            get
            {
                Environment.Exit(0);
                return 1;
            }
        }
        
        public override string ToString() 
        {
            Environment.Exit(0);
            return "Overridden Bad Struct";
        }
    }
}