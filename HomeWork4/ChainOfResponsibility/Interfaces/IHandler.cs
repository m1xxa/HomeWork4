using HomeWork4.ChainOfResponsibility.Model;

namespace HomeWork4.ChainOfResponsibility.Interfaces
{
    public interface IRequestHandler
    {
        IRequestHandler SetNext(IRequestHandler handler);
        object HandleRequest(Request request);
    }
}