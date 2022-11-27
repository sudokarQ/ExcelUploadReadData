using ExcelUploadReadDataSaveExampleCore.Models;

namespace ExcelUploadReadDataSaveExampleCore.Service
{
    public interface IStudentService
    {
        List<Student> GetStudents();
        List<Student> SaveStudents(List<Student> students);
    }
}
