//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bootcamp2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_T_TransactionItems
    {
        public int Id { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<int> TB_M_Items_Id { get; set; }
        public Nullable<int> TB_M_Sell_Id { get; set; }
        public bool IsDelete { get; set; }
    
        public virtual TB_M_Items TB_M_Items { get; set; }
        public virtual TB_M_Sell TB_M_Sell { get; set; }
    }
}
