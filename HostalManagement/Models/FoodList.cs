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
    
    public partial class FoodList
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FoodList()
        {
            this.Messings = new HashSet<Messing>();
        }
    
        public int FoodListId { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<int> WeekdayId { get; set; }
        public Nullable<int> MealTypeId { get; set; }
    
        public virtual MealType MealType { get; set; }
        public virtual Weekday Weekday { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Messing> Messings { get; set; }
    }
}
