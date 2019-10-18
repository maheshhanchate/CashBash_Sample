using System;
using System.Collections.Generic;

namespace CashBash_Sample.Models
{
    public partial class PD_CASH_BASH_ROLE_ASSGN
    {
        public int ROLE_ID { get; set; }
        public string AD_GROUP { get; set; }
    
        public virtual PD_CASH_BASH_ROLES PD_CASH_BASH_ROLES { get; set; }
    }
}
