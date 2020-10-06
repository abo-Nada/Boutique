using Boutique.BusinessLogic.Repository;
using Boutique.Models;
using Boutique.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Boutique.BusinessLogic.Managers
{
    public class categoryManager: Repository<Bill, ApplicationDbContext>
    {
        public categoryManager(ApplicationDbContext _context) : base(_context)
        {
        }
    }
}