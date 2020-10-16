using System;
using System.Collections.Generic;
using System.Text;

namespace FirstAppEFCore.Models
{
    public class Teacher : BaseModel
    {
        public string Name { get; set; }
        public string Age { get; set; }
    }
}
