using CustomerManager.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManager.DataAccess.Repositories.Interfaces
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> GetAllAsync();
        Task<Customer> GetByIdAsync(int id);
        Task<int> AddAsync(Customer customer);
        Task<int> UpdateAsync(Customer customer);
        Task<int> DeleteAsync(int id);
    }
}
