using Newtonsoft.Json;
using Student_List.Models;
using StudentList1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Student_List.Controllers
{

    [EnableCors("*", "*", "*")]
    public class StudentController : ApiController
    {
        public List<Student> GetAll()
        {
            //Change the local pats with the proper file path 
            List<Student> students = new List<Student>();
            var path = @"C:/Users/Lenovo/source/repos/StudentList-Asp.Net-Application/StudentList1/Controllers/students.json";
            var json = File.ReadAllText(path);

            var path1 = @"C:/Users/Lenovo/source/repos/StudentList-Asp.Net-Application/StudentList1/Controllers/201804030201.json";
            var json1 = File.ReadAllText(path1);

            var path2 = @"C:/Users/Lenovo/source/repos/StudentList-Asp.Net-Application/StudentList1/Controllers/201901020304.json";
            var json2 = File.ReadAllText(path2);

            var path3 = @"C:/Users/Lenovo/source/repos/StudentList-Asp.Net-Application/StudentList1/Controllers/201909080706.json";
            var json3 = File.ReadAllText(path3);

            var trs1 = JsonConvert.DeserializeObject<List<Lesson>>(json1);
            var trs2 = JsonConvert.DeserializeObject<List<Lesson>>(json2);
            var trs3 = JsonConvert.DeserializeObject<List<Lesson>>(json3);
            var people = JsonConvert.DeserializeObject<List<Student>>(json);

            people[0].Transcript = trs1;
            people[1].Transcript = trs2;
            people[2].Transcript = trs3;

            return people;




        }
    }
}
