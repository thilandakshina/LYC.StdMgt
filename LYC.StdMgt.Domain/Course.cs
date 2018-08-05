using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LYC.StdMgt.Domain
{
  public class Course : BaseEntity
    {
        [Column(TypeName = "VARCHAR")]
        [StringLength(30)]
        [Required]
        public string Code { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(30)]
        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime StartDateTime { get; set; }

        public int SubjectId { get; set; }
        public int TeacherId { get; set; }

        public virtual Subject Subject { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
