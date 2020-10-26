using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Data.Interfaces;
using WebShop.Data.Models;


namespace WebShop.Data.Repository
{
    public class StaffRepository : IAllStaffs
    {
        private readonly AppDBContent appDBContent; 

        public StaffRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Staff> Staffs => appDBContent.Staff.Include(c => c.Category);

        public IEnumerable<Staff> favStaffs => appDBContent.Staff.Where(c => c.isFavourite).Include(c => c.Category);

        public Staff getObjectStaff(int staffId) => appDBContent.Staff.FirstOrDefault(c => c.id == staffId);
    }
}
