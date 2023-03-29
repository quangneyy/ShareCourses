using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShareCourses.Models
{
    public class CommonAbstract
    {
        public string CreateBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedrDate { get; set; }
        public string ModifiedBy{ get; set; }
    }
}