//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Project
    {
        public Project()
        {
            this.Commons = new HashSet<Common>();
        }
    
        public int ID { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string status { get; set; }
    
        public virtual ICollection<Common> Commons { get; set; }
    }
}
