namespace Catalog.DAL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Product Provider
    /// </summary>
    public class ProductProvider : IProvider<Product>
    {
        public Product Get(int id)
        {
            using (var db = new CatalogDataContext())
            {
                return db.Products.SingleOrDefault(c => c.Id == id);
            }
        }

        public List<Product> GetAll()
        {
            using (var db = new CatalogDataContext())
            {
                return db.Products.ToList();
            }
        }

        public void Delete(int id)
        {
            using (var db = new CatalogDataContext())
            {
                var product = db.Products.SingleOrDefault(c => c.Id == id);

                if (product == null)
                {
                    throw new Exception(string.Format("Product with id = {0} not found in database", id));
                }

                db.Products.DeleteOnSubmit(product);
                db.SubmitChanges();
            }
        }

        public void Add(Product product)
        {
            using (var db = new CatalogDataContext())
            {
                db.Products.InsertOnSubmit(product);
                db.SubmitChanges();
            }
        }
    }
}
