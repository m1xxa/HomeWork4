namespace HomeWork4.ChainOfResponsibility.Model
{
    public class Request
    {
        public int Id { get; set; }
        public bool IsAuthorized { get; set; }
        public bool IsAuthenticated { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}