//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServerClient.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AssignInspectionTaskToMobile
    {
        public int Id { get; set; }
        public Nullable<int> ComponentID { get; set; }
        public Nullable<int> LIDComponentID { get; set; }
        public string Frequency { get; set; }
        public string NameInit { get; set; }
        public System.DateTime AssignDate { get; set; }
        public bool IsCompeleted { get; set; }
    
        public virtual LIDInspectionType LIDInspectionType { get; set; }
        public virtual LIDComponent LIDComponent { get; set; }
        public virtual AssignInspectionTaskToMobile AssignInspectionTaskToMobile1 { get; set; }
        public virtual AssignInspectionTaskToMobile AssignInspectionTaskToMobile2 { get; set; }
        public virtual Component Component { get; set; }
    }
}
