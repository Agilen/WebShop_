using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Data.Interfaces;
using WebShop.Data.Models;
using WebShop.ViewModels;

namespace WebShop.Controllers
{
    public class StaffsController : Controller
    {
        private readonly IAllStaffs _allStaffs;
        private readonly IStaffsCategory _staffsCategory;

        public StaffsController(IAllStaffs iAllStaffs, IStaffsCategory iStaffCategory)
        {
            _allStaffs = iAllStaffs;
            _staffsCategory = iStaffCategory;
        }
        [Route("Staff/List")]
        [Route("Staff/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Staff> staffs=null;
            string currCategoty = "";
            if(string.IsNullOrEmpty(category))
            {
                staffs = _allStaffs.Staffs.OrderBy(i => i.id);
            }
            else 
            {
                if (string.Equals("staff1", category, StringComparison.OrdinalIgnoreCase))
                {
                    staffs = _allStaffs.Staffs.Where(i => i.Category.categoryName.Equals("Staff #1")).OrderBy(i => i.id);
                    currCategoty = "Staff type 1";
                }

                else if (string.Equals("staff2", category, StringComparison.OrdinalIgnoreCase))
                {
                    staffs = _allStaffs.Staffs.Where(i => i.Category.categoryName.Equals("Staff #2")).OrderBy(i => i.id);

                    currCategoty = "Staff type 2";
                }
                   ;


                
            }
            var staffObj = new StaffListViewModel
            {
                allStaffs = staffs,
                curStaffCategory = currCategoty

            };

            ViewBag.Title = "Page with Staffs";
          
            return View(staffObj);
        }
    }
}
