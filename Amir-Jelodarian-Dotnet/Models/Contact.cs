using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Amir_Jelodarian_Dotnet.Models
{
    public class Contact
    {
        [Required]
        [Key]
        public int Id {get;set;}

        [Required]
        [StringLength(255)]
        public string date {get;set;}
        
    }
}