using Boutique.BusinessLogic.Managers;
using Boutique.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Boutique.BusinessLogic
{
    public class UnitOfWork
    {
        static UnitOfWork unit;
        private ApplicationDbContext context;
        private UnitOfWork()
        {
            context = new ApplicationDbContext();
        }
        public static UnitOfWork GetInstance()
        {
            if (unit == null)
            {
                unit = new UnitOfWork();
            }
            return unit;
        }

        public billManager billManager
        {
            get
            {
                return new billManager(context);
            }
        }
        public billDetailsManager billDetailsManager
        {
            get
            {
                return new billDetailsManager(context);
            }
        }
        public categoryManager categoryManager
        {
            get
            {
                return new categoryManager(context);
            }
        }
        public productManager productManager
        {
            get
            {
                return new productManager(context);
            }
        }
        public productImgManager productImgManager
        {
            get
            {
                return new productImgManager(context);
            }
        }
        public productSizeManager productSizeManager
        {
            get
            {
                return new productSizeManager(context);
            }
        }
        public typeManager typeManager
        {
            get
            {
                return new typeManager(context);
            }
        }
        
    }
}