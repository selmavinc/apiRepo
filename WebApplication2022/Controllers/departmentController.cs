using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2022.Controllers
{
    public class departmentController : Controller
    {
        public static List<Department> dept = new List<Department>();
        [HttpPost]
        [Route("Add Department")]
        public IActionResult addDept([FromBody] Department department)
        {
            try
            {
                dept.Add(department);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Ok("Department Added successfully");
        }

        [HttpGet]
        [Route("View Departments")]
        public IEnumerable<Department> getDept()
        {
            return dept;
        }
        //// GET: departmentController
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //// GET: departmentController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: departmentController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: departmentController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: departmentController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: departmentController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: departmentController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: departmentController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
