using System;
using System.Collections.Generic;

namespace CashBash_Sample.Models
{
    public partial class CASH_BASH_PULL_TYPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CASH_BASH_PULL_TYPE()
        {
            this.CASH_BASH_PULL_VALIDATION = new HashSet<CASH_BASH_PULL_VALIDATION>();
        }
    
        public int PULL_TYPE_CD { get; set; }
        public string PULL_TYPE_DESC { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CASH_BASH_PULL_VALIDATION> CASH_BASH_PULL_VALIDATION { get; set; }
    }
}
