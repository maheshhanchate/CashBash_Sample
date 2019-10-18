using System;
using System.Collections.Generic;

namespace CashBash_Sample.Models
{
    public partial class PULL_PURCHASE_CODE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PULL_PURCHASE_CODE()
        {
            this.DEALER_PULL_PURCHASE_ITEM = new HashSet<DEALER_PULL_PURCHASE_ITEM>();
        }
    
        public int PULL_PURS_ID { get; set; }
        public string PULL_PURS_DESC_TX { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DEALER_PULL_PURCHASE_ITEM> DEALER_PULL_PURCHASE_ITEM { get; set; }
    }
}
