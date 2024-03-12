//Seeding DB
using ZaunShop.Models.DomainModels;

namespace ZaunShop.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder) {
            using(var ServiceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = ServiceScope.ServiceProvider.GetService<ZaunShopDbContext>();
                context.Database.EnsureCreated();


                if(!context.categories.Any())
                {
                    context.categories.AddRange(new List<Category>()
                    {
                        new Category()
                        {
                            type = "Tops"
                        },
                        new Category()
                        {
                            type = "Bottoms"
                        },
                        new Category()
                        {
                            type = "Shoes"
                        },
                        new Category()
                        {
                            type = "Accessories"
                        }


                    });

                    context.SaveChanges();
                }

                if(!context.products.Any())
                {
                    context.products.AddRange(new List<Product>()
                    {
                        new Product() 
                        {
                            name = "Jacket 1 - Cool",
                            description = "This jacket is very cool! Very very cool!",
                            price = 200,
                            categoryid = 1,
                        },
                        new Product()
                        {
                            name = "Jacket 2 - Blue",
                            description = "This jacket is very Blue! Very very Blue!",
                            price = 200,
                            categoryid = 1,
                        },
                        new Product()
                        {
                            name = "Jacket 3 - Red",
                            description = "This jacket is very Red! Very very Red!",
                            price = 200,
                            categoryid = 1,
                        },
                        new Product()
                        {
                            name = "Jacket 4 - Gray",
                            description = "This jacket is very Gray! Very very Gray!",
                            price = 200,
                            categoryid = 1,
                        },
                        new Product()
                        {
                            name = "Jacket 5 - Green",
                            description = "This jacket is very Green! Very very Green!",
                            price = 200,
                            categoryid = 1,
                        },
                        new Product()
                        {
                            name = "Jacket 6 - Purple",
                            description = "This jacket is very Purple! Very very Purple!",
                            price = 200,
                            categoryid = 1,
                        },
                        new Product()
                        {
                            name = "Jacket 7 - Black",
                            description = "This jacket is very Black! Very very Black!",
                            price = 200,
                            categoryid = 1,
                        },
                        new Product()
                        {
                            name = "Jacket 8 - White",
                            description = "This jacket is very White! Very very White!",
                            price = 200,
                            categoryid = 1,
                        },
                        new Product()
                        {
                            name = "Jacket 9 - Rainbow",
                            description = "This jacket is very Rainbow! Very very Rainbow!",
                            price = 200,
                            categoryid = 1,
                        },
                        new Product()
                        {
                            name = "Jacket 10 - Slick",
                            description = "This jacket is very Slick! Very very Slick!",
                            price = 200,
                            categoryid = 1,
                        },
                        new Product()
                        {
                            name = "Jacket 11 - Rad",
                            description = "This jacket is very Rad! Very very Rad!",
                            price = 100000,
                            categoryid = 1,
                        },
                    });

                    context.SaveChanges();

                }

                if (!context.users.Any())
                {
                    context.users.AddRange(new List<User>()
                    {
                        new User()
                        {
                            firstname = "Billy",
                            lastname = "Bobsen",
                            email = "billybobsen@gmail.com",
                            password = "test",
                            phone = "20 23 24 50"
                        }


                    });

                    context.SaveChanges();
                }
            }
        
        }
    }
}
