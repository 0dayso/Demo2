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
    
    public partial class vw_InvoicePayments
    {
        public int PatientsInvoicesPaymentId { get; set; }
        public int InvoiceId { get; set; }
        public System.DateTime PaymentDate { get; set; }
        public System.TimeSpan PaymentTime { get; set; }
        public double AdvancePayment { get; set; }
        public double PaymentAmount { get; set; }
    }
}
