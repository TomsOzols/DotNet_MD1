using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;

namespace MD1
{
    public static class DataStore
    {
        static DataStore()
        {
            People = new List<Person>();
            Lectures = new List<Lecture>();
        }

        private static List<Person> People { get; set; }

        private static List<Lecture> Lectures { get; set; }

        public static void CreateTestPeople()
        {
            var testStudents = new List<Student>
            {
                PeopleConstants.John,
                PeopleConstants.Jane,
                PeopleConstants.Sylvester
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

            var newPeople = new List<Person>();
            newPeople.AddRange(testStudents);
            newPeople.AddRange(testTeachers);

            People = newPeople;
        }

        public static void CreateTestCourseAndLectures()
        {
            var testCourse = new Course
            {
                Name = "Application development with .NET",
                Teacher = PeopleConstants.Abigail
            };

            var studentsAttendingFirstLecture = new List<Student>
            {
                PeopleConstants.Sylvester,
                PeopleConstants.Jane
            };

            var studentsAttendingSecondLecture = new List<Student>
            {
                PeopleConstants.Sylvester
            };

            var studentsAttendingThirdLecture = new List<Student>
            {
                PeopleConstants.John,
                PeopleConstants.Jane,
                PeopleConstants.Sylvester
            };

            var testLectures = new List<Lecture>
            {
                new Lecture
                {
                    Course = testCourse,
                    LectureDate = new DateTime(2017, 10, 9),
                    StudentsAttending = studentsAttendingFirstLecture
                },
                new Lecture
                {
                    Course = testCourse,
                    LectureDate = new DateTime(2017, 10, 16),
                    StudentsAttending = studentsAttendingSecondLecture
                },
                new Lecture
                {
                    Course = testCourse,
                    LectureDate = new DateTime(2017, 10, 23),
                    StudentsAttending = studentsAttendingThirdLecture
                }
            };

            var newLectures = new List<Lecture>();
            newLectures.AddRange(testLectures);

            Lectures = newLectures;
        }

        public static void WriteStoreToFile(string fileName)
        {
            var serializer = new JavaScriptSerializer();

            var dataStore = new DataStoreCollections(People, Lectures);
            var dataStoreJson = serializer.Serialize(dataStore);

            File.WriteAllText(fileName, dataStoreJson);
        }

        public static void ReadFromFile(string fileName)
        {
            var serializer = new JavaScriptSerializer();

            var dataStoreJson = File.ReadAllText(fileName);
            var deserialized = serializer.Deserialize<DataStoreCollections>(dataStoreJson);

            People = deserialized.People;
            Lectures = deserialized.Lectures;
        }

        private static string GetCourseInfoText(Course course)
        {
            var builder = new StringBuilder();
            builder.AppendLine("Course:");
            builder.AppendLine(course.Name);
            builder.AppendLine("Teacher:");
            builder.AppendLine(course.Teacher.Print());

            return builder.ToString();
        }

        private static string GetLectureInfoText(Lecture lecture)
        {
            var builder = new StringBuilder();
            string courseInfo = GetCourseInfoText(lecture.Course);

            List<string> attendingStudentInfo = lecture.StudentsAttending.Select(student => student.Print()).ToList();
            string studentsAttendingInfo = string.Join("\n", attendingStudentInfo);
            string lectureDate = lecture.LectureDate.ToLongDateString();

            builder.AppendLine(courseInfo);
            builder.AppendLine($"Lecture date: {lectureDate}");
            builder.AppendLine("Students attending lecture:");
            builder.AppendLine(studentsAttendingInfo);

            return builder.ToString();
        }

        public static string GetStoreInfoText()
        {
            var people = People.Select(person => person.Print()).ToList();
            var lectures = Lectures.Select(GetLectureInfoText).ToList();

            var peopleInfo = string.Join("\n", people);
            var lectureInfo = string.Join("\n", lectures);

            return $"People in data store:\n{peopleInfo}\n\nLectures in data store:\n{lectureInfo}";
        }
    }
}