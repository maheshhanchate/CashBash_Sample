using System;
using System.Collections.Generic;

namespace CashBash_Sample.Models
{
    public partial class CMS_PAGE
    {
        public int ID { get; set; }
        public string CONTEST_TYPE { get; set; }
        public string NAME { get; set; }
        public string TITLE { get; set; }
        public string HEADER_TEXT { get; set; }
        public string DIRECTIONS { get; set; }
    }
}
