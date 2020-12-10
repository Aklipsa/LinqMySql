namespace LinqEntity.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("mydb.ownership")]
    public partial class ownership
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int contract_id { get; set; }

        [StringLength(45)]
        public string adress { get; set; }

        [StringLength(45)]
        public string price { get; set; }
    }
}
