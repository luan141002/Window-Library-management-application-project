//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Final_1__Library
{
    using System;
    using System.Collections.Generic;
    
    public partial class Borrow_Book
    {
        public int ID_Rd { get; set; }
        public int ID_Book { get; set; }
        public System.DateTime Borrowed_date { get; set; }
        public System.DateTime Estimated_date { get; set; }
        public Nullable<System.DateTime> Returned_date { get; set; }
        public Nullable<int> Extra_fee { get; set; }
        public Nullable<bool> Current_status { get; set; }
        public Nullable<bool> Loss_book { get; set; }
    
        public virtual BOOK BOOK { get; set; }
        public virtual READER READER { get; set; }
    }
}
