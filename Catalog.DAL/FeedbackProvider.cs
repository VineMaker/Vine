namespace Catalog.DAL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// User Provider
    /// </summary>
    public class UserProvider : IProvider<User>
    {
        public User Get(int id)
        {
            using (var db = new CatalogDataContext())
            {
                return db.Users.SingleOrDefault(c => c.Id == id);
            }
        }

        public List<User> GetAll()
        {
            using (var db = new CatalogDataContext())
            {
                return db.Users.ToList();
            }
        }

        public void Delete(int id)
        {
            using (var db = new CatalogDataContext())
            {
                var user = db.Users.SingleOrDefault(c => c.Id == id);

                if (user == null)
                {
                    throw new Exception(string.Format("User with id = {0} not found in database", id));
                }

                db.Users.DeleteOnSubmit(user);
                db.SubmitChanges();
            }
        }

        public void Add(User user)
        {
            using (var db = new CatalogDataContext())
            {
                db.Users.InsertOnSubmit(user);
                db.SubmitChanges();
            }
        }
    }
}
