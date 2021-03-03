namespace T1908EOnlineCourse.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Result")]
    public partial class Result
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int? test_id { get; set; }

        [StringLength(128)]
        public string user_id { get; set; }

        [StringLength(255)]
        public string link { get; set; }

        public int? status { get; set; }

        public virtual AspNetUser AspNetUser { get; set; }

        public virtual Test Test { get; set; }
    }
}
