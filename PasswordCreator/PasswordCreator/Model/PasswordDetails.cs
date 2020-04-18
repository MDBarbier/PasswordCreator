using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PasswordCreator.Model
{
    public class PasswordDetails
    {
        public string Password { get; set; }
        public int Length { get; set; }
        public bool IncludeSymbols { get; set; }
    }
}
