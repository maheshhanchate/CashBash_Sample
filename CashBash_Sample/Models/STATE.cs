using System;
using System.Collections.Generic;

namespace CashBash_Sample.Models
{
    public partial class STATE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public STATE()
        {
            this.ATTENDEE_ADDRESS = new HashSet<ATTENDEE_ADDRESS>();
        }
    
        public string ST_CD { get; set; }
        public string ST_NM { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ATTENDEE_ADDRESS> ATTENDEE_ADDRESS { get; set; }
    }
}
