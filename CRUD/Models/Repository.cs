using CRUD.Models;

namespace asp.net__core.Models
{
    public static  class Repository
    {
        private static List<Category> categories = new List<Category>();
        public static List<Category> getCategories()
        {
        return categories; 
        }
        public static void addCategory(Category category)
        {
            categories.Add(category);
        }
    }
}
