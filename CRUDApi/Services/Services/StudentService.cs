using CRUDApi.Data.IRepositories;
using CRUDApi.Enums;
using CRUDApi.Models.Common;
using CRUDApi.Models.ViewModels;
using CRUDApi.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CRUDApi.Services.Services
{
    public class StudentService : IStudentService
    {
        private IStudentRepository _studentRepository;
        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public Task<StudentModel> CreateAsync(StudentViewModel student)
        {
            StudentModel studentModel = new StudentModel()
            {
                FirstName = student.FirstName,
                LastName = student.LastName,
                Age = student.Age
            };

            return _studentRepository.CreateAsync(studentModel);
        }

        public  async Task<IEnumerable<StudentModel>> GetAllAsync(Expression<Func<StudentModel, bool>> expression = null)
        {
            return await _studentRepository.GetAllAsync(expression);
        }

        public Task<StudentModel> GetAsync(Expression<Func<StudentModel, bool>> expression)
        {
            return _studentRepository.GetAsync(expression);
        }

        public async Task<StudentModel> UpdateAsync(StudentModel student)
        {
            return await _studentRepository.UpdateAsync(student);
        }

        public Task<StudentModel> UpdateStatusAsync(long studentId, ItemState state)
        {
            return _studentRepository.UpdateStatusAsync(studentId, state);
        }
    }
}
