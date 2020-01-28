using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalDbLib
{
    public static class DbSeeder
    {
        public static PersonalContext SeedIfEmpty(this PersonalContext personalDb)
        {
            AssertDatabase(personalDb);
            CompNew(personalDb);
            if (personalDb.Customers.Any()) return personalDb;
            Seed(personalDb);
            personalDb.SaveChanges();
            return personalDb;
        }

        private static void Seed(PersonalContext personalDb)
        {
            var customerA = new Customer { Name = "Franz", Address = "Korneuburg 30", City = "Wien" };
            var customerB = new Customer { Name = "Gerlinde", Address = "Bramsberg 24", City = "Graz" };
            var orderA = new Order { Customer = customerA, Description = "Neue Zähne", OrderDate = new DateTime(2018, 03, 04) };
            var orderDetailA = new OrderDetail { Order = orderA, Amount = 1 };
            personalDb.Customers.Add(customerA);
            //personalDb.Customers.Add(customerB);
            //personalDb.Orders.Add(orderA);
            //personalDb.Order_Details.Add(orderDetailA);
        }

        private static void AssertDatabase(PersonalContext personalDb)
        {
            if (personalDb.Database.Exists())
            {
                if (personalDb.Database.CompatibleWithModel(true)) return;
                personalDb.Database.Delete();
            }
            personalDb.Database.Create();
        }

        private static void CompNew(PersonalContext personalDb)
        {
            personalDb.Database.Delete();
            personalDb.Database.Create();
        }
    }
}
