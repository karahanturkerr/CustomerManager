using CustomerManager.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManager.Business.Interfaces
{
    public interface IUnitOfWork
    {
        ICustomerRepository Customers { get; }
    }
}
