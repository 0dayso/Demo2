//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Demo2Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class PatientsInvoiceItem
    {
        public int PatientsInvoiceItemId { get; set; }
        public int InvoiceId { get; set; }
        public int ItemId { get; set; }
        public string ItemCode { get; set; }
        public string ItemDescription { get; set; }
        public Nullable<int> ItemQuantity { get; set; }
        public double ItemPrice { get; set; }
        public byte ServiceOrTP { get; set; }
        public Nullable<double> CompanyShared { get; set; }
        public Nullable<double> PatientShared { get; set; }
    }
}
