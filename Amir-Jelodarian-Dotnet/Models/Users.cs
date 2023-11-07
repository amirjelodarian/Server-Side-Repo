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
        [StringLength(100)]
        public string? Name {get;set;}
        [StringLength(100)]
        public string Family {get;set;}
        [StringLength(100)]
        public string? NameFather {get;set;}
        [StringLength(100)]
        [Required]
        public string Password {get;set;}
        public DateTime? Birthday {get;set;}
        public bool? Gender {get;set;}
        public bool? Active {get;set;}
        public double? Weight {get;set;}

    }
}