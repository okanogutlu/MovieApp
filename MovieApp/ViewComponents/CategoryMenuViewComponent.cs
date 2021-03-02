using Microsoft.AspNetCore.Mvc;
using MovieApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.ViewComponents
{
    public class CategoryMenuViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(CategoryRepository.Categories);
        }
    }
}
