//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WorkData
{
    using System;
    using System.Collections.Generic;
    
    public partial class presentation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public presentation()
        {
            this.circus_program = new HashSet<circus_program>();
            this.circus_troupe = new HashSet<circus_troupe>();
            this.tour_schedule = new HashSet<tour_schedule>();
        }
    
        public int Id_presentation { get; set; }
        public string Name { get; set; }
        public int Director { get; set; }
        public int Designer { get; set; }
        public int Conductor { get; set; }
        public int author { get; set; }
        public int Genre { get; set; }
        public int Type { get; set; }
    
        public virtual Author Author1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<circus_program> circus_program { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<circus_troupe> circus_troupe { get; set; }
        public virtual Conductor Conductor1 { get; set; }
        public virtual Designer Designer1 { get; set; }
        public virtual Director Director1 { get; set; }
        public virtual Genre Genre1 { get; set; }
        public virtual type type1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tour_schedule> tour_schedule { get; set; }
    }
}
