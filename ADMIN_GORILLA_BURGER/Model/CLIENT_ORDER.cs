namespace ADMIN_GORILLA_BURGER.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CLIENT_ORDER
    {
        public DateTime? ORDERTIME { get; set; }

        public int CLIENT_ORDERID { get; set; }

        public int? DELIVERY_PERSONID { get; set; }

        public int? LIST_PRODUCTSID { get; set; }

        [StringLength(20)]
        public string STATUS { get; set; }
    }
}
