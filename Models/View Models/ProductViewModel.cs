using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace productsAndCategories.Models //change projectName to the name of project
{  

    public class ProductViewModel
    {
        public List<Category> thisCategoryList{get;set;}
        public Product thisProduct{get;set;}
        public Association Association{get;set;}
    }
}