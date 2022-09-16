using Microsoft.AspNetCore.Mvc;

namespace university.Controllers;

[ApiController]
[Route("[controller]")]
public class TeacherController : ControllerBase
{
    [HttpGet()]
    public string GetAllTeachers() {
        return "This will return all Teachers.";
    }

    [HttpGet("{id}")]
    public string GetOneTeacher(int id) {
        return "This will return a Teacher which id=" + id;
    }

    [HttpPost()]
    public string AddTeacher() {
        return "This will add a new Teacher.";
    }

    [HttpPut("{id}")]
    public string UpdateTeacher(int id) {
        return "This will update a Teacher which id=" + id;
    }

    [HttpDelete("{id}")]
    public string DeleteTeacher(int id) {
        return "This will delete a Teacher which id=" + id;
    }
}