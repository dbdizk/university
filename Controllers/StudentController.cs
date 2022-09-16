using Microsoft.AspNetCore.Mvc;

namespace university.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentController : ControllerBase
{
    [HttpGet()]
    public string GetAllStudents() {
        return "This will return all students.";
    }

    [HttpGet("{id}")]
    public string GetOneStudent(int id) {
        return "This will return a student which id=" + id;
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