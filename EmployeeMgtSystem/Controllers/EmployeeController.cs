using EmployeeMgtSystem.Models;
using EmployeeMgtSystem.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EmployeeMgtSystem.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IGenericRepository<tbl_Employee> repo;
        private const int pageSize = 5;

        public EmployeeController(IGenericRepository<tbl_Employee> repo)
        {
            this.repo = repo;
        }

        public async Task<IActionResult> Index(int page = 1)
        {
            var employees = await repo.GetAllAsync(page, pageSize);
            int totRec = await repo.GetAllCountAsync();
            ViewBag.TotalPages = (int)Math.Ceiling((double)totRec / pageSize);
            ViewBag.CurrentPage = page;
            return View(employees);
        }

        public async Task<IActionResult> Create()
        {
            return PartialView("_EmployeeForm", new tbl_Employee { });
        }

        [HttpPost]
        public async Task<IActionResult> Create(tbl_Employee emp)
        {
            if (ModelState.IsValid)
            {
                await repo.AddAsync(emp);
                return Json(new { success = true, message = "Employee added successfully!" });
            }
            return PartialView("_EmployeeForm", emp);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var emp = await repo.GetByIdAsync(id);
            return emp == null ? NotFound() : PartialView("_EmployeeForm", emp);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(tbl_Employee emp)
        {
            if (ModelState.IsValid)
            {
                await repo.UpdateAsync(emp);
                return Json(new { success = true, message = "Employee Updated successfully!" });
            }
            return PartialView("_EmployeeForm", emp);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var emp = await repo.GetByIdAsync(id);
            return emp == null ? NotFound() : PartialView("_DeleteConfirm", emp);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await repo.DeleteAsync(id);
            return Json(new { success = true, message = "Employee Deleted successfully!" });
        }

    }
}
