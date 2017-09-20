namespace DotNet_md1 {
    public class Student : Person
    {
        public Student() { }

        public Student(string name, string surname, Sex sex, string id)
        {
            Name = name;
            Surname = surname;
            Sex = sex;
            Id = id;
        }

        public string Id { get; }

        public override string Print()
        {
            string personInfo = base.Print();
            return $"{personInfo}\nStudent id: {Id}";
        }
    }
}