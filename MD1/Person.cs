﻿namespace MD1 {
    public class Person
    {
        private string name;
        private string surname;

        public string Name
        {
            get => name;
            // Šī vietā labāk īpašības atribūts patiktos.
            set
            {
                bool isNewNameEmpty = string.IsNullOrWhiteSpace(value);
                if (!isNewNameEmpty)
                {
                    name = value;
                }
            }
        }

        public string Surname
        {
            get => surname;
            set { surname = value; }
        }

        public Sex Sex { get; set; }

        public string FullName => $"{Name} {Surname}";

        public virtual string Print()
        {
            // Patīk interpolācija
            return $"Full name: {FullName}\nSex: {Sex}";
        }
    }
}
