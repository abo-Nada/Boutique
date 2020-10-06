using Boutique.BusinessLogic.Repository;
using Boutique.Models;
using Boutique.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Boutique.BusinessLogic.Managers
{
    public class productSizeManager: Repository<Bill, ApplicationDbContext>
    {
        public productSizeManager(ApplicationDbContext _context) : base(_context)
        {
        }
    }
}