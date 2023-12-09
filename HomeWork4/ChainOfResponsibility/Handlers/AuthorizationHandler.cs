using HomeWork4.ChainOfResponsibility.Model;

namespace HomeWork4.ChainOfResponsibility.Handlers
{
    class AuthorizationHandler : HandlerBase
    {
        public override object HandleRequest(Request request)
        {
            if (request.IsAuthenticated) request.IsAuthorized = true;
            return base.HandleRequest(request);
        }
    }
}