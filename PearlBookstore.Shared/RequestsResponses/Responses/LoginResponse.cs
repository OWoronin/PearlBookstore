namespace PearlBookstore.Shared.RequestsResponses.Responses
{
    public class LoginResponse
    {
        public string Login { get; set; }
        public int Id { get; set; }
        public int RoleId { get; set; }

        public string RoleName { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }
    }
}
