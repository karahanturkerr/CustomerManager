using CustomerManager.Business.Interfaces;
using CustomerManager.Entities.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using System.Linq;
using CustomerManager.DataAccess.Repositories.Interfaces;

namespace CustomerManager.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CustomerController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var customers = await _unitOfWork.Customers.GetAllAsync();
            return Json(customers);
        }

        [HttpGet]
        public async Task<IActionResult> Get(int id)
        {
            var customer = await _unitOfWork.Customers.GetByIdAsync(id);
            if (customer == null)
                return NotFound();

            return Json(customer);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Customer customer)
        {
            customer.CreatedTime = DateTime.Now;
            await _unitOfWork.Customers.AddAsync(customer);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Update(Customer customer)
        {
            await _unitOfWork.Customers.UpdateAsync(customer);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            await _unitOfWork.Customers.DeleteAsync(id);
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetFilteredCustomers(bool showPassive = false)
        {
            var customers = await _unitOfWork.Customers.GetAllAsync();
            var filtered = showPassive
                ? customers.Where(x => x.IsDeleted).ToList()
                : customers.Where(x => !x.IsDeleted).ToList();

            return PartialView("_customerListPartial", filtered);
        }

    }
}
