using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebApp.Models
{
    public class GradeFormModel
    {
        [Required]
        [Range(0,100,
            ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public sbyte Assignments { get; set; }
        [Required]
        [Range(0, 100)]
        public sbyte Gproject { get; set; }
        [Required]
        [Range(0, 100,
            ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public sbyte Quiz { get; set; }
        [Required]
        [Range(0, 100,
            ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public sbyte Exam { get; set; }
        [Required]
        [Range(0, 100,
            ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public sbyte Intex { get; set; }
    }
}
