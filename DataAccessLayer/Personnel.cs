namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Personnel")]
    public partial class Personnel
    {
        public int ID { get; set; }

        [StringLength(20)]
        public string Name { get; set; }

        [StringLength(20)]
        public string Surname { get; set; }

        [StringLength(20)]
        public string City { get; set; }

        [StringLength(20)]
        public string Duty { get; set; }

        public short? Salary { get; set; }
    }
}
