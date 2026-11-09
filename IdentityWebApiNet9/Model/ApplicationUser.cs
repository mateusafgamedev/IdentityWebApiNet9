using Microsoft.AspNetCore.Identity;

namespace IdentityWebApiNet9.Model
{
    public class ApplicationUser : IdentityUser
    {
        public string NomeCompleto { get; set; }
    }
}
