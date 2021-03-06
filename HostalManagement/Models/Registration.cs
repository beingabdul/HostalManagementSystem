//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HostalManagement.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Registration
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Registration()
        {
            this.Bills = new HashSet<Bill>();
            this.Messings = new HashSet<Messing>();
        }
    
        public int RegistrationId { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string FatherRank { get; set; }
        public string CNIC { get; set; }
        public string ContactNo { get; set; }
       
        public string Email { get; set; }
        public string Password { get; set; }
        public string FamilyNo { get; set; }
        public string BloodGroup { get; set; }
        public string HomeAddress { get; set; }
        public string Institute { get; set; }
        public string Degree { get; set; }
        public string DegreeSession { get; set; }
        public string Convience { get; set; }
        public string VehicleNo { get; set; }
        public string LicenseNo { get; set; }
        public Nullable<int> Catagory { get; set; }
        public Nullable<int> UserRoleId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bill> Bills { get; set; }
        public virtual Catagory Catagory1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Messing> Messings { get; set; }
        public virtual UserRole UserRole { get; set; }
    }
}
