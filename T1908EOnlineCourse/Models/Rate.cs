namespace T1908EOnlineCourse.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Rate")]
    public partial class Rate
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int? course_id { get; set; }

        [StringLength(255)]
        public string content { get; set; }

        public decimal? star { get; set; }

        public virtual Course Course { get; set; }
    }
}
