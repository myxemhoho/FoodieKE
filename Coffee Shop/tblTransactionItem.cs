//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Coffee_Shop
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblTransactionItem
    {
        public int TransactionItemID { get; set; }
        public Nullable<int> TransactionID { get; set; }
        public Nullable<int> ProductID { get; set; }
    
        public virtual tblProduct tblProduct { get; set; }
        public virtual tblTransaction tblTransaction { get; set; }
    }
}
