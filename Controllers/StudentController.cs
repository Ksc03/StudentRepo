using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using StudentApi.Data;

namespace StudentApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly StudentDbContext _context;
        public StudentController(StudentDbContext context) 
        {
            _context = context; 
        }


        [HttpGet]
        public IActionResult GetStudents()
        {
            var students = _context.Students.ToList();

            return Ok(students);

        }

        [HttpGet("{id}")]
        public IActionResult GetStudentById(int id)
        {
            var student = _context.Students.Find(id);

            if(student == null)
            {
                return NotFound();
            }

            return Ok(student);

        }

        [HttpPost]
        public IActionResult CreateStudent([FromBody] Model.Student student)
        {
            

            _context.Students.Add(student); 
            _context.SaveChanges();
            return Ok();

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            var student = _context.Students.Find(id);
            if(student == null)
            {
                return NotFound();
            }
            _context.Students.Remove(student);
            _context.SaveChanges();
            return Ok();

        }

        [HttpPatch("{id}")]
        public IActionResult UpdateStudentAddress(int id, [FromBody] Model.Student student)
        {
            var existingStudent = _context.Students.Find(id);

            if (existingStudent == null)
            {
                return NotFound();
            }

            
            existingStudent.Address = student.Address;

            _context.SaveChanges();
            return Ok();
        }

    }
}
