using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Amir_Jelodarian_Dotnet.Models
{
    public class Order
    {
        [Required]
        [Key]
        public int Id {get;set;}


        [Required]
        public int productId {get;set;}

        [StringLength(255)]
        public string count {get;set;}

        
    }
}