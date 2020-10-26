using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using WebShop.Data.Models;

namespace WebShop.Data
{
    public class DBobj
    {
        public static void Initial(AppDBContent content)
        {
           
           

            if (!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }

            if(!content.Staff.Any())
            {
                content.Staff.AddRange(
                     new Staff
                     {
                         name = "Hmmm",
                         shortDesc = "???",
                         longDesc = "????????????",
                         img = "/img/1.png",
                         isFavourite = true,
                         available = true,
                         Category = category["Staff #2"]
                     },
                    new Staff
                    {
                        name = "hMMMMMM",
                        shortDesc = "?*?",
                        longDesc = "????****?????",
                        img = "/img/1.png",
                        isFavourite = true,
                        available = true,
                        Category = category["Staff #1"]
                    },
                    new Staff
                    {
                        name = "#3",
                        shortDesc = "?*?",
                        longDesc = "U can eat it",
                        img = "/img/1.png",
                        isFavourite = true,
                        available = true,
                        Category = category["Staff #2"]
                    },
                    new Staff
                    {
                        name = "#4",
                        shortDesc = "?*?",
                        longDesc = "IDK",
                        img = "/img/1.png",
                        isFavourite = true,
                        available = true,
                        Category = category["Staff #1"]
                    },
                    new Staff
                    {
                        name = "#5",
                        shortDesc = "?*?",
                        longDesc = "just buy it",
                        img = "/img/1.png",
                        isFavourite = true,
                        available = true,
                        Category = category["Staff #2"]
                    },
                     new Staff
                     {
                         name = "#6",
                         shortDesc = "?*?",
                         longDesc = "U can eat it",
                         img = "/img/1.png",
                         isFavourite = true,
                         available = true,
                         Category = category["Staff #1"]
                     }
                    );
            }
            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string,Category> Categories
        {
            get{
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category{ categoryName="Staff #1", desc="Some staff #1"},
                    new Category{categoryName="Staff #2", desc="i dont know what is it"}
                    };
                    category = new Dictionary<string, Category>();
                    foreach(Category element in list)
                    {
                        category.Add(element.categoryName, element);
                    }
                    
                }
                return category;
            }
        }
    }
}
