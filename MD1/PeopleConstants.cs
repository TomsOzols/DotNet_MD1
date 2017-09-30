using System;

namespace MD1 {
    public static class PeopleConstants
    {
        static PeopleConstants()
        {
            John = new Student("John", "Doe", Sex.Male, "JD11018");
            Jane = new Student("Jane", "Doe", Sex.Female, "JD13091");
            Sylvester = new Student("Sylvester", "Stallone", Sex.Male, "JD05052");
        }

        public static readonly Teacher Abigail = new Teacher
        {
            Name = "Abigail",
            Surname = "Ratchford",
            Sex = Sex.Female,
            ContractDate = new DateTime(1979, 5, 22)
        };

        public static readonly Student John;

        public static readonly Student Jane;

        public static readonly Student Sylvester;
    }
}