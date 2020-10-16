using AutoMapper;
using FirstAppEFCore.DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppEFCore.Services
{
    public class StudentService : IStudentService
    {
        private readonly IBaseService<Student> _studentService;
        private readonly IMapper _mapper;
        public StudentService(IBaseService<Student> studentService , IMapper mapper)
        {
            _mapper = mapper;
            _studentService = studentService;
        }
        public async Task<bool> AddStudent(VMStudent student)
        {
            var std = _mapper.Map<Student>(student);
            await _studentService.AddAsync(std);
            return true;
        }

        public void Dispose()
        {
            _studentService.Dispose();
        }

        public List<VMStudent> GetByName(VMStudent student)
        {            
            List<Student> stdList = _studentService.GetAll().ToList<Student>();
            var vmList = _mapper.Map<List<VMStudent>>(stdList);
            List<VMStudent> vmStd = vmList.Where(x => x.Name == student.Name && x.Address == student.Address).ToList();
            return vmStd;
        }
    }
}
