using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LYC.StdMgt.Domain
{
   public class Enrollment : BaseEntity
    {
        [Required]
        public DateTime EnrollementDateTime { get; set; }

        public int StudentId { get; set; }
        public int CourseId { get; set; }

        public virtual Student Subject { get; set; }
        public virtual Course Course { get; set; }
    }
}
