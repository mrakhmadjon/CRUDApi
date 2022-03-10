using CRUDApi.Data.Contexts;
using CRUDApi.Data.IRepositories;
using CRUDApi.Enums;
using CRUDApi.Models.Common;
using System.Threading.Tasks;


namespace CRUDApi.Data.Repositories
{
    public class StudentRepository : GenericRepository<StudentModel>, IStudentRepository
    {
        public StudentRepository(StudentDbContext studentDb) : base(studentDb)
        {
        }

        public async Task<StudentModel> UpdateStatusAsync(long id, ItemState state)
        {
            var student = await dbSet.FindAsync(id);
             
            student.State = state;
            await _dbContext.SaveChangesAsync();

            return student;
        }
    }
}
