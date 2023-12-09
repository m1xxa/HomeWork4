using System;

namespace HomeWork4.Strategy
{
    public class PdfHandler : IStrategyHandle
    {
        public void Proceed()
        {
            Console.WriteLine("Processing handle PDF");
        }
    }
}