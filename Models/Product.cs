using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace productsAndCategories.Models //change projectName to the name of project
{  
    
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        public string Name {get; set;}
        public string Description { get; set; }
        public decimal Price {get; set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        public List<Association> Associations {get; set;}

    }

}