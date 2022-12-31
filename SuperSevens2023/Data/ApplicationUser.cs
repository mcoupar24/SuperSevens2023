using Microsoft.AspNetCore.Identity;

namespace SuperSevens2023.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AdditionalEmail { get; set; }
        public bool LiveUser { get; set; }
    }
}
