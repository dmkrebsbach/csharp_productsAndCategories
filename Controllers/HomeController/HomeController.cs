using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Http; // FOR USE OF SESSIONS
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using productsAndCategories.Models; //change projectName to the name of project

namespace productsAndCategories.Controllers  //change projectName to the name of project
{
    public class HomeController : Controller{
        private MyContext dbContext;

        public HomeController(MyContext context)
        {
            dbContext = context;
        }

        [HttpGet("")]               // GETS Main Registration and Login Page
        public IActionResult Index(){
            return RedirectToAction("Products");
        }

        [HttpGet("products")]  // Renders a list of products on the Products.CSHTML page               
        public IActionResult Products(){
            AddProductViewModel viewModel = new AddProductViewModel();

            viewModel.Products = dbContext.Products
                .ToList();
            return View("Products", viewModel);
        }

        [HttpPost("addProduct")] // ADDS a new product to the List<Product>
        public IActionResult AddProduct(AddProductViewModel viewModel){
            if(ModelState.IsValid)
            {
                Product newProduct = viewModel.newProduct;
                dbContext.Add(newProduct);
                dbContext.SaveChanges();
                return RedirectToAction("Products", new {id = newProduct.ProductId});
            }
            return RedirectToAction("Products");
        }

        [HttpGet("categories")]  // Renders a list of categories on the Categories.CSHTML page                
        public IActionResult Categories(){
            AddCategoryViewModel viewModel = new AddCategoryViewModel();

            viewModel.Categories = dbContext.Categories
                .ToList();
            return View("Categories", viewModel);
        }

        [HttpPost("addCategory")] // ADDS a new category to the List<Category>
        public IActionResult AddCategory(AddCategoryViewModel viewModel){
            if(ModelState.IsValid)
            {
                Category newCategory = viewModel.newCategory;
                dbContext.Add(newCategory);
                dbContext.SaveChanges();
                return RedirectToAction("Categories", new {id = newCategory.CategoryId});
            }
            return RedirectToAction("Products");
        }

        [HttpGet("product/{ProductId}")]  // displays the individual product page, lists categories associated with the product, creates list 
        public IActionResult Product(int ProductId){                //minus already associated categories to ADD to each product
            ProductViewModel viewModel = new ProductViewModel();

            viewModel.thisProduct = dbContext.Products
                .Include(p => p.Associations)
                .ThenInclude(pc => pc.Category)
                .FirstOrDefault(p => p.ProductId == ProductId);

            viewModel.thisCategoryList = dbContext.Categories
                .Include(c => c.Associations)
                .ThenInclude(pc => pc.Product)
                .Where(c => !viewModel.thisProduct.Associations.Select(pc => pc.Category).Contains(c))
                .ToList();

            return View("Product", viewModel);
        }

        [HttpPost("addcategory/{ProductId}")]
        public IActionResult AddIndCategory(ProductViewModel viewModel, int ProductId){
            viewModel.Association.ProductId = ProductId;

            dbContext.Add(viewModel.Association);
            dbContext.SaveChanges();

            return RedirectToAction("Product", new{ProductId = ProductId});
        }

        [HttpGet("category/{CategoryId}")]  // displays the individual category page, lists products associated with the category, creates list 
        public IActionResult Category(int CategoryId){                //minus already associated products to ADD to each category
            CategoryViewModel viewModel = new CategoryViewModel();

            viewModel.thisCategory = dbContext.Categories
                .Include(p => p.Associations)
                .ThenInclude(pc => pc.Product)
                .FirstOrDefault(p => p.CategoryId == CategoryId);

            viewModel.thisProductList = dbContext.Products
                .Include(c => c.Associations)
                .ThenInclude(pc => pc.Category)
                .Where(c => !viewModel.thisCategory.Associations.Select(pc => pc.Product).Contains(c))
                .ToList();

            return View("Category", viewModel);
        }

        [HttpPost("addproduct/{CategoryId}")]
        public IActionResult AddIndProduct(CategoryViewModel viewModel, int CategoryId){
            viewModel.Association.CategoryId = CategoryId;

            dbContext.Add(viewModel.Association);
            dbContext.SaveChanges();

            return RedirectToAction("Category", new{CategoryId = CategoryId});
        }


    }
}