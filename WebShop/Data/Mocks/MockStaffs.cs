using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Data.Interfaces;
using WebShop.Data.Models;

namespace WebShop.Data.Mocks
{
    public class MockStaffs : IAllStaffs
    {

        private readonly IStaffsCategory _categoryStaffs = new MockCategory();
       
        public IEnumerable<Staff> Staffs
        {
            get
            {
                return new List<Staff> {

                    new Staff{
                        name="Hmmm", 
                        shortDesc="???", 
                        longDesc="????????????", 
                        img="/img/1.png" , 
                        isFavourite=true, 
                        available=true,
                        Category=_categoryStaffs.AllCategories.First() },
                    new Staff{
                        name="hMMMMMM",
                        shortDesc="?*?",
                        longDesc="????****?????",
                        img="/img/1.png" ,
                        isFavourite=true,
                        available=true,
                        Category=_categoryStaffs.AllCategories.Last() },
                    new Staff{
                        name="#3",
                        shortDesc="?*?",
                        longDesc="U can eat it",
                        img="/img/1.png" ,
                        isFavourite=true,
                        available=true,
                        Category=_categoryStaffs.AllCategories.First () },
                    new Staff{
                        name="#4",
                        shortDesc="?*?",
                        longDesc="IDK",
                        img="/img/1.png" ,
                        isFavourite=true,
                        available=true,
                        Category=_categoryStaffs.AllCategories.Last() },
                    new Staff{
                        name="#5",
                        shortDesc="?*?",
                        longDesc="just buy it",
                        img="/img/1.png" ,
                        isFavourite=true,
                        available=true,
                        Category=_categoryStaffs.AllCategories.Last() },
                     new Staff{
                        name="#6",
                        shortDesc="?*?",
                        longDesc="U can eat it",
                        img="/img/1.png" ,
                        isFavourite=true,
                        available=true,
                        Category=_categoryStaffs.AllCategories.First () }
                };
            }

        }
        public IEnumerable<Staff> favStaffs { get; set ; }

        public Staff getObjectStaff(int staffId)
        {
            throw new NotImplementedException();
        }
    }
}
