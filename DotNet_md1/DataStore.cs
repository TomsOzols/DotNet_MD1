using System;
using System.Collections.Generic;

namespace DotNet_md1 {
    public static class DataStore
    {
        private static List<Person> People { get; set; }

        private static List<Lecture> Lectures { get; set; }

        public static void CreateTestPeople()
        {
            var testStudents = new List<Student>
            {
                PeopleConstants.John,
                PeopleConstants.Jane,
                PeopleConstants.Sylvester,
            };

            var testTeachers = new List<Teacher>
            {
                new Teacher
                {
                    Name = "Phil",
                    Surname = "Smith",
                    Sex = Sex.Male,
                    ContractDate = new DateTime(1985, 11, 20)
                },
                PeopleConstants.Abigail
            };

            People.AddRange(testStudents);
            People.AddRange(testTeachers);
        }

        public static void CreateTestCourseAndLectures()
        {
            var testCourse = new Course
            {
                Name = "Application development with .NET",
                Teacher = PeopleConstants.Abigail,
            };

            var studentsAttendingFirstLecture = new List<Student>
            {
                PeopleConstants.Sylvester,
                PeopleConstants.Jane,
            };

            var studentsAttendingSecondLecture = new List<Student>
            {
                PeopleConstants.Sylvester,
            };

            var studentsAttendingThirdLecture = new List<Student>
            {
                PeopleConstants.John,
                PeopleConstants.Jane,
                PeopleConstants.Sylvester,
            };

            var testLectures = new List<Lecture>
            {
                new Lecture
                {
                    Course = testCourse,
                    LectureDate = new DateTime(2017, 10, 9),
                    StudentsAttending = studentsAttendingFirstLecture,
                },
                new Lecture
                {
                    Course = testCourse,
                    LectureDate = new DateTime(2017, 10, 16),
                    StudentsAttending = studentsAttendingSecondLecture,
                },
                new Lecture
                {
                    Course = testCourse,
                    LectureDate = new DateTime(2017, 10, 23),
                    StudentsAttending = studentsAttendingThirdLecture,
                },
            };

            Lectures.AddRange(testLectures);
        }

        public static void WriteStoreToFile()
        {
            throw new NotImplementedException();
        }

        public static void ReadFromFile()
        {
            throw new NotImplementedException();
        }
    }
}