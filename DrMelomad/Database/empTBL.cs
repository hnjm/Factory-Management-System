//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DrMelomad.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class empTBL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public empTBL()
        {
            this.workHoursTBL = new HashSet<workHoursTBL>();
        }
    
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string fullName { get; set; }
        public System.DateTime bDate { get; set; }
        public System.DateTime startDate { get; set; }
        public Nullable<System.DateTime> endDate { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public bool isActive { get; set; }
        public byte[] img { get; set; }
        public string email { get; set; }
        public bool gender { get; set; }
        public string leaveReason { get; set; }
        public string nots { get; set; }
        public int roleID { get; set; }
    
        public virtual roleTBL roleTBL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<workHoursTBL> workHoursTBL { get; set; }
    }
}
