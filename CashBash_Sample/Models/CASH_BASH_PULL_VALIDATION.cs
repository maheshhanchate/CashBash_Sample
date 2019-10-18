using System;
using System.Collections.Generic;

namespace CashBash_Sample.Models
{
    public partial class CASH_BASH_PULL_VALIDATION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CASH_BASH_PULL_VALIDATION()
        {
            this.CASH_BASH_PULL = new HashSet<CASH_BASH_PULL>();
        }
    
        public string PULL_CTRL_ID { get; set; }
        public int EVNT_ID { get; set; }
        public Nullable<int> PULL_AM { get; set; }
        public string IN_USE_IN { get; set; }
        public Nullable<System.DateTime> LST_UPDT_DT { get; set; }
        public string LST_UPDT_USR_ID { get; set; }
        public string PULL_DESC_TX { get; set; }
        public Nullable<int> PULL_TYPE_CD { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CASH_BASH_PULL> CASH_BASH_PULL { get; set; }
        public virtual CASH_BASH_PULL_TYPE CASH_BASH_PULL_TYPE { get; set; }
    }
}
