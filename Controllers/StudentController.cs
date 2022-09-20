using Microsoft.AspNetCore.Mvc;
using university.Models;

namespace university.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentController : ControllerBase
{
    [HttpGet()]
    public string GetStudents() {
        Student objStudent=new Student();
        string result=objStudent.GetAllStudents();
        Console.WriteLine(result);
        return result;
    }

    [HttpGet("{id}")]
    public IActionResult GetOneStudent(int id) {
        Student objStudent=new Student();
        string result=objStudent.GetOneStudent(id);
        if(result.Length==0){
            result="Student ID not valid";
            return NoContent();
        }
        
        
        return Ok(result);
    }

    [HttpPost()]
    public string AddStudent() {
        return "This will add a new student.";
    }

    [HttpPut("{id}")]
    public string UpdateStudent(int id) {
        return "This will update a student which id=" + id;
    }

    [HttpDelete("{id}")]
    public string DeleteStudent(int id) {
        return "This will delete a student which id=" + id;
    }
}