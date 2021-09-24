using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CustomerRegs.Models
{
    public class customerClass
    {
        [Required(ErrorMessage = "Please enter the Name")]
        [Display(Name = "Customer Name")]
        public string c_name { get; set; }
        //[DataType(DataType.int)]
        [Required(ErrorMessage = "please enter the age")]
        [Display(Name = "age")]
        public int c_age { get; set; }
        [Required(ErrorMessage = "please enter the gender ")]
        [Display(Name = "gender")]
        public string c_gender { get; set; }
    }
}