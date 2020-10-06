using Boutique.BusinessLogic.Repository;
using Boutique.Models;
using Boutique.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Boutique.BusinessLogic.Managers
{
    public class billManager : Repository<Bill, ApplicationDbContext>
    {
        public billManager(ApplicationDbContext _context) : base(_context)
        {
        }
    }
}