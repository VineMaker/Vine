namespace Catalog.DAL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Feedback Provider
    /// </summary>
    public class FeedbackProvider : IProvider<Feedback>
    {
        public Feedback Get(int id)
        {
            using (var db = new CatalogDataContext())
            {
                return db.Feedbacks.SingleOrDefault(c => c.Id == id);
            }
        }

        public List<Feedback> GetAll()
        {
            using (var db = new CatalogDataContext())
            {
                return db.Feedbacks.ToList();
            }
        }

        public void Delete(int id)
        {
            using (var db = new CatalogDataContext())
            {
                var feedback = db.Feedbacks.SingleOrDefault(c => c.Id == id);

                if (feedback == null)
                {
                    throw new Exception(string.Format("Feedback with id = {0} not found in database", id));
                }

                db.Feedbacks.DeleteOnSubmit(feedback);
                db.SubmitChanges();
            }
        }

        public void Add(Feedback feedback)
        {
            using (var db = new CatalogDataContext())
            {
                db.Feedbacks.InsertOnSubmit(feedback);
                db.SubmitChanges();
            }
        }

        public bool IsExist(string login)
        {
            using (var db = new CatalogDataContext())
            {
                var user = db.Users.SingleOrDefault(u => String.CompareOrdinal(u.Email, login) == 0);
                return user != null;
            }
        }

        //public bool Authenticate(string login, string password, out User user)
        //{
        //    using (var db = new CatalogDataContext())
        //    {
        //        user = db.Users.SingleOrDefault(
        //                u => u.Email == login && u.Password == password.GetHashCode());

        //        return user != null;
        //    }
        //}
    }
}
