
using FirstAppEFCore.Services;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstAppEFCore
{
    class Program
    {
        private readonly IStudentService _studentService;
        public Program(IStudentService studentService)
        {
            _studentService = studentService;
        }
        static void Main(string[] args)
        {                     
            //Read();
            Console.ReadKey();            
        }

        void Insert()
        {
            using (var context = new EFDemoContext())
            {
                var std = new Student()
                {
                    Name = "Isco"
                };
                context.Students.Add(std);
                context.SaveChanges();
            }
        }

        static List<Student> Read()
        {
            using (var context = new EFDemoContext())
            {
                var std = context.Students.Where(x => x.Name == "Isco").ToList();
                Console.WriteLine(std.Select(x => x.Name).FirstOrDefault());
                return std;
            }
        }
    }
}
