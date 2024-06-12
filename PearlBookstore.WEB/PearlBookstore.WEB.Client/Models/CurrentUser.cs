namespace PearlBookstore.WEB.Client.Models
{
    public class CurrentUser()
    {
        public int ID { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Surname { get; set; } = string.Empty;

        public string Initials { get; set; } = string.Empty;

        public int RoleID { get; set; }

        public string RoleName { get; set; } = string.Empty;
    }

}
