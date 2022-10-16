using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitFresh.Clean.Domain
{
    public class Diet
    {
        public int Id { get; set; }
        public int SubscriptionId { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; }
    }
}
