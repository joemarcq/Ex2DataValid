using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ex2DataValid.Registration
{
    public class Create
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(10)]
        public string Course { get; set; }

        [Required]
        [StringLength(1)]
        public string YearLevel { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-z0-p-]+\.[a-zA-Z0-9-.]+$")]
        public string EmailAddress { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [Range(18, 60)]
        public int Age { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }




    }





   
}
