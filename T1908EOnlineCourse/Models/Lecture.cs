namespace T1908EOnlineCourse.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Lecture")]
    public partial class Lecture
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int? type { get; set; }

        public string source { get; set; }

        public int? section_id { get; set; }

        public virtual Section Section { get; set; }

        public enum LectureType
        {
            DOC = 1 , MP4 = 2 , LINK = 3
        }
    }
}
