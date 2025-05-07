using CustomerManager.Business.Interfaces;
using CustomerManager.DataAccess.Context;
using CustomerManager.DataAccess.Repositories.Implementations;
using CustomerManager.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManager.Business.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DapperContext _context;
        private ICustomerRepository _customerRepository;

        public UnitOfWork(DapperContext context)
        {
            _context = context;
        }

        public ICustomerRepository Customers => _customerRepository ??= new CustomerRepository(_context);
    }
}
