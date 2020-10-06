using Boutique.BusinessLogic.Repository;
using Boutique.Models;
using Boutique.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Boutique.BusinessLogic.Managers
{
    public class productManager: Repository<Bill, ApplicationDbContext>
    {
        public productManager(ApplicationDbContext _context) : base(_context)
        {
        }
    }
}