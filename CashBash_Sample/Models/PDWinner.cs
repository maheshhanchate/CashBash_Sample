using System;
using System.Collections.Generic;

namespace CashBash_Sample.Models
{
    public partial class PDWinner
    {
        public string AtneID { get; set; }
        public string WinnerType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<int> TitleCd { get; set; }
        public string Title { get; set; }
        public string HomePhone { get; set; }
        public string SocialSecurityNb { get; set; }
        public string MiddleInit { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public int AttendTypeCd { get; set; }
        public string AttendType { get; set; }
        public short PullsAssigned { get; set; }
        public Nullable<short> PULL_QY { get; set; }
        public Nullable<byte> SPLT_PRGE_RT { get; set; }
        public string PullType { get; set; }
        public string RequiredFields { get; set; }
        public string DealerRep { get; set; }
        public int EVNT_ID { get; set; }
        public string FWS_DLR_NB { get; set; }
        public string LAWSON_VENDOR_ID { get; set; }
        public string DISPLAY_DLR_ID { get; set; }
        public string MSTR_FWS_DLR_NB { get; set; }
        public string MSTR_WNR_ID { get; set; }
        public string DLR_NM { get; set; }
        public Nullable<int> PULL_ASSIGNMENT_TYPE { get; set; }
        public Nullable<int> PULL_GROUP_ID { get; set; }
        public string GROUP_NAME { get; set; }
        public string GuestName { get; set; }
        public string TripType { get; set; }
        public string SWITCHTRIP { get; set; }
    }
}
