//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Election_projectFor_me.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ad
    {
        public int AdID { get; set; }
        public string NationalNumber { get; set; }
        public string CandidateName { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string URLPath { get; set; }
        public int PaymentID { get; set; }
        public string StatusOfAds { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public string ListName { get; set; }
        public string Type { get; set; }
        public string AdminComment { get; set; }
    
        public virtual Payment Payment { get; set; }
    }
}
