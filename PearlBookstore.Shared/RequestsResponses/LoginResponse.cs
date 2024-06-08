using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace PearlBookstore.Shared.RequestsResponses
{
    public class LoginResponse
    {
        public string Login { get; set; }
        public int Id { get; set; }
        public int RoleId { get; set; }
    }
}
