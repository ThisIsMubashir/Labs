using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyControlsLibrary
{
    public class StudentModel
    {
        public StudentModel()
        {

        }

        public string Name { get; set; }
        public string City { get; set; }
        public string Other { get; set; }

        public bool IsMale { get; set; }
    }
}
