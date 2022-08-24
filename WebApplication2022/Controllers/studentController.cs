using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2022.Controllers
{
    public class studentController : Controller
    {
        public static List<Department> dept = new List<Department>();
        public static List<Student> student = new List<Student>();
        [HttpPost]
        [Route("Add Student")]
        public IActionResult addStudent(int id, int deptId, string Name, int age)
        {
            bool isExists = dept.Contains(dept.Find(de => de.deptID == deptId));
            if (!isExists)
            {
                return BadRequest("Department not found");
            }
            try
            {

                student.Add(new Student
                {
                    studId = id,
                    deptId = deptId,
                    studName = Name,
                    studAge = age
                });
                return Ok("Student Added successfully");


            }
            catch (Exception ex)
            {
                return BadRequest("Not exists");
            }

        }

        [HttpGet]
        [Route("View Students")]
        public IEnumerable<Student> getstudent()
        {
            return student;
        }

        [HttpPut]
        [Route("Update Student")]
        public IActionResult updateStudent(int deptId, string Name, int age)
        {
            bool isExists = dept.Contains(dept.Find(de => de.deptID == deptId));
            if (!isExists)
            {
                return BadRequest("Department not found");
            }
            try
            {

                student.Find(stud => stud.deptId == deptId).studName = Name;
                student.Find(stud => stud.deptId == deptId).studAge = age;
                return Ok("Modified successfully");

            }
            catch (Exception ex)
            {
                return BadRequest("Not exists");
            }

        }
        //// GET: studentController
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //// GET: studentController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: studentController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: studentController/Create
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

        //// GET: studentController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: studentController/Edit/5
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

        //// GET: studentController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: studentController/Delete/5
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
