using System;

using NHibernateUtility.Domain;
using NHibernateUtility.Repositories;
using NHibernate;
using NHibernate.Cfg;
//using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void Can_add_new_product()
        {
            var product = new Product { Name = "Apple", Category = "Fruits" };
            IProductRepository repository = new ProductRepository();
            repository.Add(product);

            

            // use session to try to load the product
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var fromDb = session.Get<Product>(product.Id);
                // Test that the product was successfully inserted
                Assert.IsNotNull(fromDb);
                Assert.AreNotSame(product, fromDb);
                Assert.AreEqual(product.Name, fromDb.Name);
                Assert.AreEqual(product.Category, fromDb.Category);
            }
        }
        private readonly Product[] _products = new[]
        {
            new Product {Name = "Melon", Category = "Fruits"},
            new Product {Name = "Pear", Category = "Fruits"},
            new Product {Name = "Milk", Category = "Beverages"},
            new Product {Name = "Coca Cola", Category = "Beverages"},
            new Product {Name = "Pepsi Cola", Category = "Beverages"},
        };
        [TestMethod]
        public void CreateInitialData()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                foreach (var product in _products)
                    session.Save(product);
                transaction.Commit();
            }
        }
        [TestMethod]
        public void Can_update_existing_product()
        {
            var product = _products[0];
            product.Id = new Guid("450DD183-C387-42C9-8491-DF73169FF8F3");
            product.Name = "Yellow Pear";
            IProductRepository repository = new ProductRepository();
            repository.Update(product);

            // use session to try to load the product
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var fromDb = session.Get<Product>(product.Id);
                Assert.AreEqual(product.Name, fromDb.Name);
            }
        }


        [TestMethod]
        public void UpdateTest()
        {
            Guid id = Guid.NewGuid();

            using (ISession session = NHibernateHelper.OpenSession())
            {             
                using (ITransaction tran = session.BeginTransaction())
                {
                    //Transient
                    var product = new Product
                    {
                        Id=id,
                        Name="test",
                        Category = "Fruits"
                    };

                    try
                    {
                        //Persistent
                        session.Save(product);
                        tran.Commit();
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        throw ex;
                    }
                }
            }

            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction tran = session.BeginTransaction())
                {
                    //Detached
                    var product = new Product
                    {
                        Id = id,
                        Name = "ABC456",
                    };

                    try
                    {
                        //Persistent
                        session.Update(product);

                        tran.Commit();
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        throw ex;
                    }
                }
            }
        }
    }
}
