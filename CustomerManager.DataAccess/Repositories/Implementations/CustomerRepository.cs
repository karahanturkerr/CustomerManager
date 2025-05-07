using CustomerManager.DataAccess.Context;
using CustomerManager.DataAccess.Repositories.Interfaces;
using CustomerManager.Entities.Models;
using Dapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CustomerManager.DataAccess.Repositories.Implementations
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DapperContext _context;

        public CustomerRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            var query = "SELECT * FROM Musteriler";

            using (var connection = _context.CreateConnection())
            {
                var customers = await connection.QueryAsync<Customer>(query);
                return customers;
            }
        }

        public async Task<Customer> GetByIdAsync(int id)
        {
            var query = "SELECT * FROM Musteriler WHERE Id = @Id";

            using (var connection = _context.CreateConnection())
            {
                return await connection.QuerySingleOrDefaultAsync<Customer>(query, new { Id = id });
            }
        }

        public async Task<int> AddAsync(Customer customer)
        {
            var query = @"INSERT INTO Musteriler 
                          (FirstName, LastName, BirthDate, PhoneNumber, Email, CreatedTime, Gender, IsDeleted)
                          VALUES (@FirstName, @LastName, @BirthDate, @PhoneNumber, @Email, @CreatedTime, @Gender, 0);
                          SELECT CAST(SCOPE_IDENTITY() as int);";

            using (var connection = _context.CreateConnection())
            {
                var id = await connection.ExecuteScalarAsync<int>(query, customer);
                return id;
            }
        }

        public async Task<int> UpdateAsync(Customer customer)
        {
            var query = @"UPDATE Musteriler 
                  SET FirstName = @FirstName, LastName = @LastName, BirthDate = @BirthDate,
                      PhoneNumber = @PhoneNumber, Email = @Email, IsDeleted = @IsDeleted, Gender = @Gender
                  WHERE Id = @Id";

            using (var connection = _context.CreateConnection())
            {
                return await connection.ExecuteAsync(query, customer);
            }
        }

        public async Task<int> DeleteAsync(int id)
        {
            var query = "UPDATE Musteriler SET IsDeleted = 1 WHERE Id = @Id";

            using (var connection = _context.CreateConnection())
            {
                return await connection.ExecuteAsync(query, new { Id = id });
            }
        }
    }
}
