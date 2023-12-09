using System;
using HomeWork4.ChainOfResponsibility.Model;

namespace HomeWork4.ChainOfResponsibility.Handlers
{
    class AuthenticationHandler : HandlerBase
    {
        public override object HandleRequest(Request request)
        {
            if (!String.IsNullOrEmpty(request.UserName) &&
                !String.IsNullOrEmpty(request.Password) &&
                !request.IsAuthenticated) request.IsAuthenticated = true;

            return base.HandleRequest(request);
        }
    }
}