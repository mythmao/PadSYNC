using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using NHibernateUtility.Domain;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhibernateUtility.Test
{
    
    [TestFixture]
    public class GenerateSchema_Fixture
    {
        [Test]
        public void Can_generate_schema()
        {
            var cfg = new Configuration();
            cfg.Configure();
            cfg.AddAssembly(typeof(Product).Assembly);

            //new SchemaExport(cfg).Execute(false, true, false, false);
            new SchemaExport(cfg).Execute(false, true, false);
        }
    }
}
