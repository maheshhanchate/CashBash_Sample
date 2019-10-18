using System;
using System.Collections.Generic;

namespace CashBash_Sample.Models
{
    public partial class ENTITY_STATUS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ENTITY_STATUS()
        {
            this.CONTEST_ENTITY = new HashSet<CONTEST_ENTITY>();
            this.ENROLLMENT_GROUP = new HashSet<ENROLLMENT_GROUP>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONTEST_ENTITY> CONTEST_ENTITY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ENROLLMENT_GROUP> ENROLLMENT_GROUP { get; set; }
    }
}
