//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Judo
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChampionatConfig
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChampionatConfig()
        {
            this.Sorevnovanie = new HashSet<Sorevnovanie>();
            this.UchastChamp = new HashSet<UchastChamp>();
        }
    
        public int id_champ { get; set; }
        public Nullable<int> id_championat { get; set; }
        public Nullable<System.DateTime> DateStart { get; set; }
        public Nullable<System.DateTime> DateEnd { get; set; }
        public Nullable<byte> AgeCategorie { get; set; }
        public string Gender { get; set; }
        public Nullable<int> id_tatami { get; set; }
        public Nullable<byte> WeightCategorie { get; set; }
    
        public virtual Championat Championat { get; set; }
        public virtual Tatami Tatami { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sorevnovanie> Sorevnovanie { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UchastChamp> UchastChamp { get; set; }
    }
}
