namespace Deliveroo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRODUCT")]
    public partial class PRODUCT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRODUCT()
        {
            LIST_PRODUCTS = new HashSet<LIST_PRODUCTS>();
        }

        public int PRODUCTID { get; set; }

        [Required]
        [StringLength(50)]
        public string PRODUCT_NAME { get; set; }

        [Required]
        [StringLength(100)]
        public string PRODUCT_SUBSCRIBE { get; set; }

        public string URL_PICTURE { get; set; }

        public int? CATEGORYID { get; set; }

        public double? PRICE { get; set; }

        public virtual CATEGORY CATEGORY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LIST_PRODUCTS> LIST_PRODUCTS { get; set; }
    }
}
