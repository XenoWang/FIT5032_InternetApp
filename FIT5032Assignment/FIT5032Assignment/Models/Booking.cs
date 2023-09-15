namespace FIT5032Assignment.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Booking")]
    public partial class Booking
    {
        public int Id { get; set; }

        [Column(TypeName = "date")]
        public DateTime BookingDate { get; set; }

        public TimeSpan BookingTime { get; set; }

        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
