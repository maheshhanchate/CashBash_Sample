using System;
using System.Collections.Generic;

namespace CashBash_Sample.Models
{
    public partial class PD_CASH_BASH_ROLES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PD_CASH_BASH_ROLES()
        {
            this.PD_CASH_BASH_ROLE_ASSGN = new HashSet<PD_CASH_BASH_ROLE_ASSGN>();
        }
    
        public int ROLE_ID { get; set; }
        public string ROLE_DESC { get; set; }
        public string SEARCH { get; set; }
        public string EDIT { get; set; }
        public string APPROVE { get; set; }
        public Nullable<int> PRECEDENCE { get; set; }
        public string ADMIN { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PD_CASH_BASH_ROLE_ASSGN> PD_CASH_BASH_ROLE_ASSGN { get; set; }
    }
}
