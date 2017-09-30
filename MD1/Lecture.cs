using System;
using System.Collections.Generic;

namespace MD1 {
    public class Lecture
    {
        public DateTime LectureDate { get; set; }

        public Course Course { get; set; }

        public IList<Student> StudentsAttending { get; set; }
    }
}