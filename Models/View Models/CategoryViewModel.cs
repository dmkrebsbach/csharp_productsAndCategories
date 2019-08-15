using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace productsAndCategories.Models //change projectName to the name of project
{  

    public class CategoryViewModel
    {
        public List<Product> thisProductList{get;set;}
        public Category thisCategory{get;set;}
        public Association Association{get;set;}
    }
}