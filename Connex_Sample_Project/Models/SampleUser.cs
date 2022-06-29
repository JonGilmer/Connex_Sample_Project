using System;
using System.Collections.Generic;

namespace Connex_Sample_Project.Models
{
    public partial class SampleUser
    {
        public int UserId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public DateTime? Timestamp { get; set; }
    }
}
