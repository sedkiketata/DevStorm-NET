using Data;
using DevStormNet.Data.Infrastructure;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Debut");

            //Context ctx = new Context();
            Product p = new Product { Name = "Vodka", Price = (float)60.000 };
            //ctx.Products.Add(p);
            //ctx.SaveChanges();

            DatabaseFactory DBF = new DatabaseFactory();
            UnitOfWork UOF = new UnitOfWork(DBF);
            //UOF.GetRepository<Product>().Add(p);
            UOF.GetRepository<Product>().Delete(pr=>pr.ProductId==2);
            UOF.Commit();

            System.Console.WriteLine("Fin");
            System.Console.ReadKey();
        }
    }
}
