using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCRUD.Core.DTOs
{
    public class CustomerDTO
    {

        [StringLength(50)]
        public string Name { get; set; }

        [Range(0, 110, ErrorMessage = "Age must be between 1 and 50")]
        public int Age { get; set; }
        [RegularExpression("^[a-zA-Z0-9]+$", ErrorMessage = "PostCode must be alphanumeric.")]
        public string PostCode { get; set; }

        [Range(0, 2.50, ErrorMessage = "Height must be between 0 and 2.50")]
        [RegularExpression(@"^(?:[0-2](?:\.\d{1,2})?|2(?:\.50)?)$", ErrorMessage = "Height must be between 0 and 2.50 with only 2 decimal places.")]
        public double Height { get; set; }
    }
}
