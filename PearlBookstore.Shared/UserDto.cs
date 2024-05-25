namespace PearlBookstore.Shared
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public RoleDto Role { get; set; }
    }
}
