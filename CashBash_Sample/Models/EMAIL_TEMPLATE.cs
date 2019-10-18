using System;
using System.Collections.Generic;

namespace CashBash_Sample.Models
{
    public partial class EMAIL_TEMPLATE
    {
        public int id { get; set; }
        public string name { get; set; }
        public string subject { get; set; }
        public string body { get; set; }
        public string allowed_tokens { get; set; }
    }
}
