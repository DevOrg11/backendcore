using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitFresh.Clean.Domain
{
    public class Subscription
    {
        public int SubscriptionId { get; set; }
        public string? SubscribedDate { get; set; }
        public string? SubscriptionType { get; set; }
        public int CustomerId { get; set; }
    }
}
