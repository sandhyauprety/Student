using project3.Services.Interfaces;
using project3.Models;

namespace project3.Services
{
    public class StudentService : IStudentService
    {
        public void Create(StudentDto dto)
        {
            dto.Id = Guid.NewGuid();
            
        }
    }
}
