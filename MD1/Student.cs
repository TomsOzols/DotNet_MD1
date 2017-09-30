namespace MD1 {
    public class Student : Person
    {
        public Student() { }

        public Student(string name, string surname, Sex sex, string studentId)
        {
            Name = name;
            Surname = surname;
            Sex = sex;
            StudentId = studentId;
        }

        public string StudentId { get; }

        public override string Print()
        {
            string personInfo = base.Print();
            return $"{personInfo}\nStudent studentId: {StudentId}";
        }
    }
}