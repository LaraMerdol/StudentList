using StudentList1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Student_List.Models
{
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Department { get; set; }
        public string StudentNumber { get; set; }
        public List<Lesson> Transcript { get; set; }

    }
}