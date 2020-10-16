using System;
using System.Collections.Generic;
using System.Text;

namespace FirstAppEFCore.Helper
{
    public class ApiSettings
    {
        public int Id { get; set; }
        public string ControllerName { get; set; }
        public string Action { get; set; }
        public object Obj { get; set; }
    }
}
