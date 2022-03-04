using System.Data.Entity;

namespace MyApp.Models
{
    public class MyAppDbInitializer : DropCreateDatabaseIfModelChanges<MyAppContext>
    {
        protected override void Seed(MyAppContext context)
        {
            context.Products.Add(new Product { Name = "Яблоко", Description = "Самое вкусное яблоко", Price = 100 });
            context.Products.Add(new Product { Name = "Груша", Description = "Самая вкусная груша", Price = 110 });
            context.Products.Add(new Product { Name = "Персик", Description = "Самый вкусный персик", Price = 150 });
            base.Seed(context);
        }
    }
}