using System;

namespace DisEvalNet5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * TODO: Check manually disabling evaluation
             * 1. Set a breakpoint in Console.WriteLine("Finished!");
             * 2. Run debugging
             * 3. Disable evaluation for an item and click Step Over
             * EXPECTED: Evaluation disabled is displayed only for the item which was disabled
             * 4. Repeate step3 fpr all items
             * 5. Click Refresh
             * EXPECTED: Value is displayed but evaluation remains disabled
             * 6. Enable evaluation for all items in goodc and goods one by one
             * EXPECTED: Values are displayed
             */
            
            var goodc = new GoodClass();
            GoodStruct goods;
            
            /*
             * TODO: Check automatically disabling evaluation
             * 1. Uncomment the lines below
             * 2. Run debugging
             * 3. Every time when debugger crashes rerun debugging
             * 4. Try to view values in badc and bads and rerun debugging until crashes run out
             * EXPECTED: All problematic items were disabled and debugger can run
             * 5. Click Refresh for anu item value
             * 6. When debugger crashes, rerun debugging
             * EXPECTED: Evaluation remains disabled for this item
             */
            
            //var badc = new BadClass();
            //BadStruct bads;
            Console.WriteLine("Finished!");
        }
    }
}