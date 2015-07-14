using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web.Login.DTOs
{
    public class DTO_INFO
    {

        public int ID { get; set; }

        [Required(ErrorMessage = "Please Provide Name")]
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        [Required(ErrorMessage = "Please Provide Contact No")]
        [StringLength(10)]
        public string ContactNo { get; set; }

        public string City { get; set; }
        public string Country { get; set; }
    }
}