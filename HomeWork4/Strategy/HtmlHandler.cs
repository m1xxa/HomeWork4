using System;

namespace HomeWork4.Strategy
{
    public class HtmlHandler : IStrategyHandle
    {
        public void Proceed()
        {
            Console.WriteLine("Processing handle Html");
        }
    }
}