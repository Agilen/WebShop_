using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Data.Interfaces;
using WebShop.Data.Models;

namespace WebShop.Data.Mocks
{
    public class MockCategory : IStaffsCategory
    {
        public IEnumerable<Category> AllCategories {
            get {

                return new List<Category> {

                    new Category{ categoryName="Staff #1", desc="Some staff #1"},
                    new Category{categoryName="Staff #2", desc="i dont know what is it"}
                };
            }
        }
    }
}
