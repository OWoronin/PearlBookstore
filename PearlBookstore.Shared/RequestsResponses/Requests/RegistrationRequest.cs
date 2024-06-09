namespace PearlBookstore.Shared.RequestsResponses.Requests
{
    public class RegistrationRequest
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }
    }
}
