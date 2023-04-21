using WebApplication2.Dto;
using WebApplication2.Entities;

namespace WebApplication2.Services.Impl;
public class StudentService : IStudentService
{
    private static List<Student> _students = new List<Student>();
    private static int _id = 0;



    public void Add(CreateStudentDto input)
    {
        _students.Add(new Student
        {
            Id = ++_id,
            Name = input.Name,
            StudentCode = input.StudentCode,
            DateOfBirth = input.DateOfBirth,
        });
    }

    public void Update(int id, UpdateStudentDto student)
    {
        var existingStudent = _students.FirstOrDefault(s => s.Id == id);
        if (existingStudent == null)
        {
            throw new Exception("Khong tim thay sinh vien");
        }
        existingStudent.Name = student.Name;
        existingStudent.StudentCode = student.StudentCode;
        existingStudent.DateOfBirth = student.DateOfBirth;
    }

    public GetStudentDto Get(int id)
    {
        var student = _students.FirstOrDefault(s => s.Id == id);
        if (student == null)
        {
            throw new Exception("Khong tim thay sinh vien");
        }
        return new GetStudentDto
        {
            Id = id,
            Name = student.Name,
            StudentCode = student.StudentCode,
            DateOfBirth = student.DateOfBirth,
        };
    }

    public void Delete(int id)
    {
        var existingStudent = _students.FirstOrDefault(s => s.Id == id);
        if (existingStudent == null)
        {
            throw new Exception("Khong tim thay sinh vien");
        }
        _students.Remove(existingStudent);
    }

    public PageResultDto<List<Student>> GetAll()
    {
        var students = _students;
        int totalItem = students.Count();

        return new PageResultDto<List<Student>>
        {
            Items = students,
            TotalItem = totalItem
        };
    }
}
