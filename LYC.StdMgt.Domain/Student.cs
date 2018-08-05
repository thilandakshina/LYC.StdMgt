using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LYC.StdMgt.Domain
{
   public class Student : BasePerson
    {
        [Column(TypeName = "VARCHAR")]
        [StringLength(10)]
        [Required]
        public string Code { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        [Required]
        public string ParentName { get; set; }
    }
}
