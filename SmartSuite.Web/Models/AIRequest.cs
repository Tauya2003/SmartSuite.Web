using System;

namespace SmartSuite.Web.Models
{
    public class AIRequest
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public string ToolType { get; set; }  // e.g., "Summarizer", "ContentGenerator"

        public string Input { get; set; }

        public string Output { get; set; }

        public DateTime CreatedAt { get; set; }

        public ApplicationUser User { get; set; }
    }
}
