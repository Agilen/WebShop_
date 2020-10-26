using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Data.Interfaces;
using WebShop.ViewModels;

namespace WebShop.Controllers
{
    public class HomeController:Controller
    {
        private readonly IAllStaffs _staffRep;
        

        public HomeController(IAllStaffs staffRep)
        {
            _staffRep = staffRep;
           
        }

        public ViewResult Index()
        {
            var homeStaffs = new HomeViewModel {
                favStaffs = _staffRep.favStaffs
            };
            return View(homeStaffs);
        }
    }
}
