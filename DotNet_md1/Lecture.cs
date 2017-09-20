using System;
using System.Collections.Generic;

namespace DotNet_md1 {
    public class Lecture
    {
        public DateTime LectureDate { get; set; }

        public Course Course { get; set; }

        public IList<Student> StudentsAttending { get; set; }
    }
}