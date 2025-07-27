namespace SmartSuite.Web.Models
{
    public class SubscriptionPlan
    {
        public int Id { get; set; }

        public string Name { get; set; } // Free, Pro, Enterprise

        public int MonthlyQuota { get; set; } // # of allowed AI calls

        public decimal Price { get; set; } // In your currency

        public string StripePlanId { get; set; } // (Optional) links to Stripe plan
    }
}
