namespace Catalog.DAL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Category Provider
    /// </summary>
    public class CategoryProvider : IProvider<Category>
    {
        public List<Category> GetSubCategories(int? parentCategoryId = null)
        {
            using (var db = new CatalogDataContext())
            {
                return db.Categories.Where(c => c.ParentId == parentCategoryId).ToList();
            }
        }

        public Category Get(int id)
        {
            using (var db = new CatalogDataContext())
            {
                return db.Categories.SingleOrDefault(c => c.Id == id);
            }
        }

        public List<Category> GetAll()
        {
            using (var db = new CatalogDataContext())
            {
                return db.Categories.ToList();
            }
        }

        public void Delete(int id)
        {
            using (var db = new CatalogDataContext())
            {
                var subCategories = db.Categories.Where(c => c.ParentId == id);
                var category = db.Categories.SingleOrDefault(c => c.Id == id);

                if (category == null)
                {
                    throw new Exception(string.Format("Category with id = {0} not found in database", id));
                }

                //todo: if needed add removing products for these categories
                db.Categories.DeleteAllOnSubmit(subCategories);
                db.Categories.DeleteOnSubmit(category);
                db.SubmitChanges();
            }
        }

        public void Add(Category category)
        {
            using (var db = new CatalogDataContext())
            {
                db.Categories.InsertOnSubmit(category);
                db.SubmitChanges();
            }
        }
    }
}
