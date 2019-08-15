using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace productsAndCategories.Models //change projectName to the name of project
{  

    public class AddCategoryViewModel
    {
        public Category newCategory {get;set;}  // public "ClassName" should match the class name in the file, not the file name itself
        public List<Category> Categories {get;set;} // include all classes and a new instance of the class within this file
    }
}