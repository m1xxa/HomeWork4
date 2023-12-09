using System;

namespace HomeWork4.Strategy
{
    public class DocHandler : IStrategyHandle
    {
        public void Proceed()
        {
            Console.WriteLine("Processing handle DOC");
        }
    }
}