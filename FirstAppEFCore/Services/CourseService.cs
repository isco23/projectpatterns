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
        public Task<Course> AddCourseAsync(Course newCourse)
        {
            return _courseService.AddAsync(newCourse);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
