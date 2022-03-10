using CRUDApi.Enums;
using CRUDApi.Models.Common;
using System.Threading.Tasks;

namespace CRUDApi.Data.IRepositories
{
    public interface IStudentRepository : IGenericRepository<StudentModel>
    {
        Task<StudentModel> UpdateStatusAsync(long id, ItemState state);
    }


}
