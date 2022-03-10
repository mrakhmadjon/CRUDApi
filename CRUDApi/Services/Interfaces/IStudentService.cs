using CRUDApi.Enums;
using CRUDApi.Models.Common;
using CRUDApi.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CRUDApi.Services.Interfaces
{
    public interface IStudentService
    {
        Task<StudentModel> CreateAsync(StudentViewModel student);

        Task<StudentModel> UpdateAsync(StudentModel student);

        Task<IEnumerable<StudentModel>> GetAllAsync(Expression<Func<StudentModel, bool>> expression = null);

        Task<StudentModel> GetAsync (Expression<Func<StudentModel, bool>> expression);

        Task<StudentModel> UpdateStatusAsync(long studentId, ItemState state);

    }
}
