using WebApplication2.Dto;
using WebApplication2.Entities;

namespace WebApplication2.Services
{
    public interface IStudentService
    {
        void Add(CreateStudentDto input);
        void Update(int id, UpdateStudentDto student);
        GetStudentDto Get(int id);
        PageResultDto<List<Student>> GetAll();
        void Delete(int id);




    }
}
