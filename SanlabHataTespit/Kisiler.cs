//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SanlabHataTespit
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kisiler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kisiler()
        {
            this.Hata = new HashSet<Hata>();
        }
    
        public int kisiID { get; set; }
        public string kisiAd { get; set; }
        public string kisiSoyad { get; set; }
        public string kisiMail { get; set; }
        public string kisiTel { get; set; }
        public string kisiDepartman { get; set; }
        public string fullName
        {
            get
            {
                return kisiAd + " " + kisiSoyad;
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hata> Hata { get; set; }
    }
}
