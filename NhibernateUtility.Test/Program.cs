using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using NHibernateUtility.Domain;
using NHibernateUtility.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhibernateUtility.Test
{
    class Program
    {
        private ISessionFactory _sessionFactory;
        private Configuration _configuration;
        static void Main(string[] args)
        {
            //Can_add_new_product();
        }
        public void Can_generate_schema()
        {
            var cfg = new Configuration();
            cfg.Configure();
            cfg.AddAssembly(typeof(Product).Assembly);

            //new SchemaExport(cfg).Execute(false, true, false, false);
            new SchemaExport(cfg).Execute(false, true, false);
        }
        public void TestFixtureSetUp()
        {
            _configuration = new Configuration();
            _configuration.Configure();
            _configuration.AddAssembly(typeof(Product).Assembly);
            _sessionFactory = _configuration.BuildSessionFactory();
        }
        public void SetupContext()
        {
            new SchemaExport(_configuration).Execute(false, true, false);
        }
        public static void Can_add_new_product()
        {
            var product = new Product { Name = "Apple", Category = "Fruits" };
            IProductRepository repository = new ProductRepository();
            repository.Add(product);
        }
    }
}
