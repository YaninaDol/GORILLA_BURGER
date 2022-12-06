namespace GORILLA_BURGER
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("USER")]
    public partial class USER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USER()
        {
            DELIVERY_PERSON = new HashSet<DELIVERY_PERSON>();
            LIST_PRODUCTS = new HashSet<LIST_PRODUCTS>();
        }

        public int USERID { get; set; }

        [StringLength(20)]
        public string USER_LOGIN { get; set; }

        [StringLength(20)]
        public string USER_PASSWORD { get; set; }

        public int? ROLEID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DELIVERY_PERSON> DELIVERY_PERSON { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LIST_PRODUCTS> LIST_PRODUCTS { get; set; }

        public virtual ROLE ROLE { get; set; }
    }
}
