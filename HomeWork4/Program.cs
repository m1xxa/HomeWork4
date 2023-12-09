using System;
using HomeWork4.ChainOfResponsibility.Handlers;
using HomeWork4.ChainOfResponsibility.Model;
using HomeWork4.Strategy;

namespace HomeWork4
{
    public abstract class Program
    {
        public static void Main(string[] args)
        {
            var authenticationHandler = new AuthenticationHandler();
            var authorizationHandler = new AuthorizationHandler();
            authenticationHandler.SetNext(authorizationHandler);

            var request1 = new Request
            {
                Id = 1,
                Password = "password",
                UserName = "username"
            };
            
            var request2 = new Request
            {
                Id = 2,
                Password = "",
                UserName = "username"
            };

            authenticationHandler.HandleRequest(request1);
            authenticationHandler.HandleRequest(request2);
            
            
            IStrategyHandle strategyPdf = new PdfHandler();
            IStrategyHandle strategyDoc = new DocHandler();
            IStrategyHandle strategyHtml = new HtmlHandler();

            StrategyContext context = new StrategyContext(strategyPdf);
            context.ExecuteStrategy();
            context.SetStrategy(strategyDoc);
            context.ExecuteStrategy();
            context.SetStrategy(strategyHtml);
            context.ExecuteStrategy();
        }
    }
}