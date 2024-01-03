using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Amir_Jelodarian_Dotnet.Models
{
    public class Products
    {
        [Required]
        [Key]
        public int Id {get;set;}


        [Required]
        [StringLength(255)]
        public string picPath {get;set;}

        [NotMapped]
        public IFormFile pic { get; set; }

        [Required]
        [StringLength(255)]
        public string? title {get;set;}


        [StringLength(255)]
        public string? price {get;set;}

        [StringLength(255)]
        public string? offPrice {get;set;}


        [StringLength(255)]
        public string? count {get;set;}



        [StringLength(255)]
        public string? description {get;set;}

        public ICollection<Order> Orders { get; set; }
    }
}