//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gestion_traiteur
{
    using System;
    using System.Collections.Generic;
    
    public partial class Commande
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Commande()
        {
            this.Reserver = new HashSet<Reserver>();
        }
    
        public int Id_cmd { get; set; }
        public Nullable<int> Repas1 { get; set; }
        public Nullable<int> Repas2 { get; set; }
        public Nullable<int> Repas3 { get; set; }
        public Nullable<int> qtR1 { get; set; }
        public Nullable<int> qtR2 { get; set; }
        public Nullable<int> qtR3 { get; set; }
        public Nullable<System.DateTime> Date_cmd { get; set; }
        public Nullable<System.DateTime> DateD { get; set; }
        public string Lieu_cmd { get; set; }
        public Nullable<decimal> Prix_cmd { get; set; }
        public Nullable<int> Etat { get; set; }
        public string client { get; set; }
        public Nullable<int> evenement { get; set; }
        public string payer { get; set; }
    
        public virtual Client Client1 { get; set; }
        public virtual Etat Etat1 { get; set; }
        public virtual Evenement Evenement1 { get; set; }
        public virtual Repas Repas { get; set; }
        public virtual Repas Repas4 { get; set; }
        public virtual Repas Repas5 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reserver> Reserver { get; set; }
    }
}
