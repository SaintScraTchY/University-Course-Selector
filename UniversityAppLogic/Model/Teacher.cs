//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UniversityAppData.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Teacher
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Teacher()
        {
            this.CoursesTime = new HashSet<CoursesTime>();
        }
    
        public int Teacher_Id { get; set; }
        public string Teacher_FirstName { get; set; }
        public string Teacher_LastName { get; set; }
        public int FK_Teacher_Degree_ID { get; set; }
        public int FK_Teacher_Group_ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CoursesTime> CoursesTime { get; set; }
        public virtual Groups Groups { get; set; }
        public virtual Teacher_Degree Teacher_Degree { get; set; }
    }
}