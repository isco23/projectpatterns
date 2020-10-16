using FirstAppEFCore.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppEFCore.Services
{
    public interface ILessonService : IDisposable
    {
        Task<bool> AddLesson(VMLesson lesson);
        Task<bool> AddLessonList(List<VMLesson> lessonList);
    }
}
