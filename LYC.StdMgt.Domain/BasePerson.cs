using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LYC.StdMgt.Domain
{
   public abstract class BasePerson : BaseEntity
    {
        [Column(TypeName ="VARCHAR")]
        [StringLength(30)]
        [Required]
        public string FirstName { get; set; }
        [Column(TypeName = "VARCHAR")]
        [Required]
        public string LastName { get; set; }

        [Column(TypeName = "Date")]
        [Required]
        public DateTime DOB { get; set; }
        public Gender Gender { get; set; }
    }
}
