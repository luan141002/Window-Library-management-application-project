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
    
    public partial class PUBLISHER
    {
        public PUBLISHER()
        {
            this.BOOKS = new HashSet<BOOK>();
        }
    
        public int ID_publisher { get; set; }
        public string Name { get; set; }
        public Nullable<int> Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    
        public virtual ICollection<BOOK> BOOKS { get; set; }
    }
}
