using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace AnnotationsDemo
{
    class Employee
    {
        [Required (ErrorMessage = "Employee {0} Is Required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Name Must Be Minimum Of 3 Charachters And Maximum Of 100 Charachters")]
        [DataType(DataType.Text)]
        public string Name { get; set; }


        [Range(18, 99, ErrorMessage = "Age Should Be Between 18 To 99")]
        public int Age { get; set; }


        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string PhoneNumber { get; set; }


        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string emailId { get; set; }
    }
}
