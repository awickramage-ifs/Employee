using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.Model
{
    public class Emp: IEntity
    {
        public int Id { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        public string Department { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Email { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime BirthDay { get; set; }

        public string Address { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }


    }
}
