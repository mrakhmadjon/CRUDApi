using CRUDApi.Enums;
using CRUDApi.Models.Common;
using CRUDApi.Models.ViewModels;
using CRUDApi.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CRUDApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpPost]
        public Task<StudentModel> Create(StudentViewModel student)
        {
            return _studentService.CreateAsync(student);
        }

        [HttpGet("{id}")]
        public async  Task<IActionResult> Get(long id)
        {
            var res =  await _studentService.GetAsync(p => p.Id == id);

            return Ok(res);
        }

        [HttpGet]

        public  async Task<IActionResult> GetAll()
        {
            return Ok( await _studentService.GetAllAsync());
        }

        [HttpPut]
        public Task<StudentModel> Update(StudentModel student)
        {
            return _studentService.UpdateAsync(student);
        }

        [HttpPatch]
        public Task<StudentModel> UpdateStatus (long id , ItemState state)
        {
            return _studentService.UpdateStatusAsync(id, state);
        }


    }
}
