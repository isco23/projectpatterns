using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FirstAppEFCore.Services
{
    public class CourseService : ICourseService
    {
        private readonly IBaseService<Course> _courseService;
        public CourseService(IBaseService<Course> courseService)
        {
            _courseService = courseService;
        }
        public async Task<bool> AddCourseAsync(Course newCourse)
        {
            await _courseService.AddAsync(newCourse);
            return true;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
