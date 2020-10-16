using AutoMapper;
using FirstAppEFCore.DTO;
using FirstAppEFCore.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppEFCore.Services
{
    public class LessonService : ILessonService
    {
        private readonly IBaseService<Lesson> _lessonService;
        private readonly IMapper _mapper;
        public LessonService(IBaseService<Lesson> lessonService, IMapper mapper)
        {
            _mapper = mapper;
            _lessonService = lessonService;
        }
        public async Task<bool> AddLesson(VMLesson lesson)
        {
            var les = _mapper.Map<Lesson>(lesson);
            await _lessonService.AddAsync(les);
            return true;
        }

        public async Task<bool> AddLessonList(List<VMLesson> lessonList)
        {
            var les = _mapper.Map<List<Lesson>>(lessonList);            
            await _lessonService.AddRangeAsync(les);
            return true;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
