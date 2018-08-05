using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LYC.StdMgt.Domain
{
   public class Teacher : BasePerson
    {
        [Column(TypeName = "VARCHAR")]
        [StringLength(10)]
        [Required]
        public string Code { get; set; }
        public int YearsOfExperience { get; set; }
        public string Address { get; set; }


    }
}
