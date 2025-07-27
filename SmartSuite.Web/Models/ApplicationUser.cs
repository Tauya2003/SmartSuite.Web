using Microsoft.AspNetCore.Identity;

namespace SmartSuite.Web.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Role { get; set; }
        public int MonthlyQuotaUsed { get; set; }
    }
}