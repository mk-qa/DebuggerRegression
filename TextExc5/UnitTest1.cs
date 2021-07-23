using System;
using Xunit;
using Exc5;
using ExternalEx5;

namespace TextExc5
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            TestEx.HandlEx();
            TestEx.UnhandlEx();
            
            TrowEx.HandlEx(); 
            TrowEx.UnhandlEx();
            
        }
    }
}