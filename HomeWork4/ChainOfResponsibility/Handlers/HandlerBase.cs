using System;
using HomeWork4.ChainOfResponsibility.Interfaces;
using HomeWork4.ChainOfResponsibility.Model;

namespace HomeWork4.ChainOfResponsibility.Handlers
{
    public abstract class HandlerBase : IRequestHandler
    {
        private IRequestHandler _nextHandler;

        public virtual object HandleRequest(Request request)
        {
            if (_nextHandler != null) return _nextHandler.HandleRequest(request);
            var isAuthenticated = request.IsAuthenticated ? "authenticated" : "not authenticated";
            var isAuthorized = request.IsAuthorized ? "authorized" : "not authorized";
            Console.WriteLine($"Request #{request.Id} is {isAuthenticated}, and is {isAuthorized}.");
            return null;
        }

        public IRequestHandler SetNext(IRequestHandler handler)
        {
            _nextHandler = handler;
            return handler;
        }
    }
}