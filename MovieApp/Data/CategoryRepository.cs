using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models
{
    public static class CategoryRepository
    {
        private static List<Category> _categories = null;

        static CategoryRepository()
        {
            _categories = new List<Category>() {
            new Category{Id=1,CategoryName="Macera"},
            new Category{Id=2,CategoryName="Bilim Kurgu"},
            new Category{Id=3,CategoryName="Aksiyon"},
            new Category{Id=4,CategoryName="Romantik"},
            new Category{Id=5,CategoryName="Komedi"},
            };
        }

        public static List<Category> Categories
        {
            get
            {
                return _categories;
            }
        }

        public static void AddCategory(Category entity)
        {
            _categories.Add(entity);
        }
        public static Category GetById(int id)
        {
            return _categories.FirstOrDefault(i => i.Id == id);
        }
    }
}
