using Boutique.BusinessLogic.Repository;
using Boutique.Models;
using Boutique.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Boutique.BusinessLogic.Managers
{
    public class productImgManager: Repository<Bill, ApplicationDbContext>
    {
        public productImgManager(ApplicationDbContext _context) : base(_context)
        {
        }
    }
}