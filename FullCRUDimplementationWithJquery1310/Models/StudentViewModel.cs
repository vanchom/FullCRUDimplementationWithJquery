using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FullCRUDimplementationWithJquery1310.Models
{
    public class StudentViewModel
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string Email { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public Nullable<int> DepartmentId { get; set; }

        public string DepartmentName { get; set; }
    }
}