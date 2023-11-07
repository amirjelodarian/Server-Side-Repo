using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Amir_Jelodarian_Dotnet.Models
{
    public class Products
    {
        [Key]
        [Required]
        public int Id {get;set;}
        [Required]
        [StringLength(255)]
        public string picPath {get;set;}
        [Required]
        [StringLength(255)]
        public string title {get;set;}
        [StringLength(255)]
        public string price {get;set;}
        [StringLength(255)]
        public string count {get;set;}
        [StringLength(255)]
        public string? description {get;set;}
    }
}