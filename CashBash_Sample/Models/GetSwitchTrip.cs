using System;
using System.Collections.Generic;

namespace CashBash_Sample.Models
{
    public partial class GetSwitchTrip
    {
        public int ATNE_ID { get; set; }
        public int EVNT_ID { get; set; }
        public string DESTINATION { get; set; }
        public string SWITCHTRIP { get; set; }
    }
}
