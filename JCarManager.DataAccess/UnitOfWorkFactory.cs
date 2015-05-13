using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JCarManager.DataAccess.Common;
using JCarManager.DataAccess.EF;
using JCarManager.DataAccess.nHibernate;

namespace JCarManager.DataAccess
{
    public class UnitOfWorkFactory
    {

        public static IUnitOfWork CreateUnitOfWork(bool useNHibernate = false)
        {
            if(useNHibernate)
                return new NhUnitOfWork();

            return new EfUnitOfWork();
        }
    }
}
