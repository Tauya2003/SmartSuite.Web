using System;

namespace SmartSuite.Web.Models
{
    public class UserQuota
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public int QuotaUsed { get; set; }

        public DateTime Month { get; set; } // Set to 1st of month to track per month

        public ApplicationUser User { get; set; }
    }
}
