using Microsoft.AspNetCore.Mvc;

namespace WebApplication2022.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        //public static List<Department> dept = new List<Department>();
        //public static List<Student> student = new List<Student>();

        //[HttpPost]
        //[Route("Add Department")]
        //public IActionResult addDept([FromBody] Department department)
        //{
        //    try
        //    {
        //        dept.Add(department);
        //    }
        //    catch(Exception ex)
        //    {
        //        throw ex;
        //    }
        //    return Ok("Department Added successfully");
        //}

        //[HttpGet]
        //[Route("View Departments")]
        //public IEnumerable<Department> getDept()
        //{
        //    return dept;
        //}

        //[HttpPost]
        //[Route("Add Student")]
        //public IActionResult addStudent(int id, int deptId,string Name,int age)
        //{
        //    bool isExists = dept.Contains(dept.Find(de => de.deptID == deptId));
        //    if(!isExists)
        //    {
        //        return BadRequest("Department not found");
        //    }
        //    try
        //    {
                
        //            student.Add(new Student
        //            {
        //                studId = id,
        //                deptId = deptId,
        //                studName = Name,
        //                studAge = age
        //            });
        //            return Ok("Student Added successfully");
                
                    
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest("Not exists");
        //    }
            
        //}

        //[HttpGet]
        //[Route("View Students")]
        //public IEnumerable<Student> getstudent()
        //{
        //    return student;
        //}

        //[HttpPut]
        //[Route("Update Student")]
        //public IActionResult updateStudent(int deptId, string Name, int age)
        //{
        //    bool isExists = dept.Contains(dept.Find(de => de.deptID == deptId));
        //    if (!isExists)
        //    {
        //        return BadRequest("Department not found");
        //    }
        //    try
        //    {
                
        //            student.Find(stud => stud.deptId == deptId).studName = Name;
        //            student.Find(stud => stud.deptId == deptId).studAge = age;
        //            return Ok("Modified successfully");
               
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest("Not exists");
        //    }

        //}
        //public static List<Employee> employee = new List<Employee>();

        //[HttpGet]
        //public string GetTime()
        //{
        //    return DateTime.Now.ToString();
        //}

        //[HttpGet()]
        //[Route("AddNumbers")]
        //public string Add(int a, int b)
        //{
        //    return (a + b).ToString();
        //}

        //[HttpGet()]
        //[Route("SubNumbers")]
        //public string Subtract(int a, int b)
        //{
        //    return (a - b).ToString();
        //}

        //[HttpGet()]
        //[Route("MulNumbers")]
        //public string Mul(int a, int b)
        //{
        //    return (a * b).ToString();
        //}

        //[HttpGet()]
        //[Route("DivideNumbers")]
        //public string Divide(int a, int b)
        //{
        //    return (a / b).ToString();
        //}

        //[HttpPost]
        //public IActionResult post(int empNo,string empName)
        //{
        //    employee.Add(new Employee
        //    {
        //        EmpID=empNo,
        //        EmpName=empName
        //    });
        //    return Ok("Added");
        //}

        //[HttpPost]
        //[Route("Add Employee")]
        //public IActionResult post(Employee emp)
        //{
        //    employee.Add(emp);
        //    return Ok("Added");
        //}

        //[HttpPut]
        //public IActionResult put(int empNo, string empName)
        //{
        //    var response="";
        //        if(employee.Contains(employee.Find(emp => emp.EmpID.Equals(empNo))))
        //        {
        //            response = employee.Find(emp => emp.EmpID.Equals(empNo)).EmpName = empName;
        //        }                 
        //        return (response != "") ? Ok("Modified") : Ok("Employee ID not found");

        //}

        //[HttpDelete]
        //public IActionResult delete(int empNo)
        //{
        //    var res = employee.Remove(employee.Find(emp => emp.EmpID.Equals(empNo)));
        //    return (res==true)? Ok("Removed") : Ok("No data found");
        //}

        //[HttpGet]
        //[Route("GetData")]
        //public IEnumerable<Employee> get()
        //{
        //    return employee;
        //}


        //    private static readonly string[] Summaries = new[]
        //    {
        //    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        //};

        //    private readonly ILogger<WeatherForecastController> _logger;

        //    public WeatherForecastController(ILogger<WeatherForecastController> logger)
        //    {
        //        _logger = logger;
        //    }

        //    [HttpGet(Name = "GetWeatherForecast")]
        //    public IEnumerable<WeatherForecast> Get()
        //    {
        //        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //        {
        //            Date = DateTime.Now.AddDays(index),
        //            TemperatureC = Random.Shared.Next(-20, 55),
        //            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //        })
        //        .ToArray();
        //    }
    }
}