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
    
    public partial class Sorevnovanie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sorevnovanie()
        {
            this.Pravila = new HashSet<Pravila>();
        }
    
        public int id_sorevnovanie { get; set; }
        public Nullable<int> Red { get; set; }
        public Nullable<int> White { get; set; }
        public Nullable<double> TimeRound { get; set; }
        public Nullable<int> NumGroup { get; set; }
        public Nullable<byte> Winner { get; set; }
        public Nullable<System.DateTime> Start { get; set; }
        public Nullable<int> id_champ { get; set; }
    
        public virtual ChampionatConfig ChampionatConfig { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pravila> Pravila { get; set; }
        public virtual UchastChamp UchastChamp { get; set; }
        public virtual UchastChamp UchastChamp1 { get; set; }
    }
}
