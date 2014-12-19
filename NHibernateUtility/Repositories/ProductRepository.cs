using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernateUtility.Domain;
using NHibernate;
using NHibernate.Criterion;

namespace NHibernateUtility.Repositories
{
    public class ProductRepository:IProductRepository
    {
        public void Add(Product product)
        {
            using(ISession session=NHibernateHelper.OpenSession())
            {
                using(ITransaction transation=session.BeginTransaction())
                {
                    session.Save(product);
                    transation.Commit();
                }
            }
        }

        public void Update(Product product)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transation = session.BeginTransaction())
                {
                    session.Update(product);
                    transation.Commit();
                }
            }
        }

        public void Remove(Product product)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transation = session.BeginTransaction())
                {
                    session.Delete(product);
                    transation.Commit();
                }
            }
        }

        public Product GetById(Guid productId)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                return session.Get<Product>(productId);
            }
        }

        public Product GetByName(string name)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                Product product = session.CreateCriteria(typeof(Product)).Add(Restrictions.Eq("Name", name)).UniqueResult<Product>();
                return product;
            }
        }

        public ICollection<Product> GetByCategory(string category)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var products = session
                    .CreateCriteria(typeof(Product))
                    .Add(Restrictions.Eq("Category", category))
                    .List<Product>();
                return products;
            }
        }
    }
}
