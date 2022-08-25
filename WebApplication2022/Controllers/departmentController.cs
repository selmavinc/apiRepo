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
        public IActionResult updateStudent(int studId, int deptId, string Name, int age)
        {
            bool isdeptExists = dept.Contains(dept.Find(de => de.deptID == deptId));
            bool isStudExists = student.Contains(student.Find(stud => stud.studId == studId));
            bool isExists = student.Contains(student.Find(stud => stud.deptId == deptId && stud.studId == studId));
            if (!isStudExists)
            {
                return BadRequest("Student not found");
            }
            if (!isdeptExists)
            {
                return BadRequest("Department not found");
            }
            if (!isExists)
            {
                return BadRequest("No Data found");
            }

            try
            {
                student.Find(stud => stud.deptId == deptId && stud.studId == studId).deptId = deptId;
                student.Find(stud => stud.studId == studId && stud.deptId == deptId).studName = Name;
                student.Find(stud => stud.studId == studId && stud.deptId == deptId ).studAge = age;
                return Ok("Modified successfully");

            }
            catch (Exception ex)
            {
                return BadRequest("Not exists");
            }

        }

        [HttpDelete]
        [Route("Delete Student")]
        public IActionResult deleteStudent(int studId, int deptId)
        {
            bool isdeptExists = dept.Contains(dept.Find(de => de.deptID == deptId));
            bool isStudExists = student.Contains(student.Find(stud => stud.studId == studId));
            bool isExists = student.Contains(student.Find(stud => stud.deptId == deptId && stud.studId == studId));
            if (!isStudExists)
            {
                return BadRequest("Student not found");
            }
            if (!isdeptExists)
            {
                return BadRequest("Department not found");
            }
            if (!isExists)
            {
                return BadRequest("No Data found");
            }

            try
            {

                student.Remove(student.Find(stud => stud.deptId == deptId && stud.studId == studId));
                return Ok("Removed successfully");

            }
            catch (Exception ex)
            {
                return BadRequest("Not exists");
            }

        }
    }
}
