using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Amir_Jelodarian_Dotnet.Models
{
    public class Users
    {
        [Required]
        [Key]
        public int Id {get;set;}
        [StringLength(255)]
        public string? Name {get;set;}

        [StringLength(255)]
        public string email {get;set;}
        
        [StringLength(255)]
        [Required]
        public string Password {get;set;}


    }
}