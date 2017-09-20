namespace DotNet_md1
{
    public class Persona
    {
        private string name;
        private string surname;

        public string Name
        {
            get => name;
            set
            {
                bool isNewNameEmpty = string.IsNullOrWhiteSpace(value);
                if (!isNewNameEmpty)
                {
                    name = value;
                }
            }
        }

        public string Surname { get; set; }

        public Sex Sex { get; set; }

        public string FullName => $"{Name} {Surname}";

        public virtual string Print()
        {
            return $"Full name: {FullName}\nSex: {Sex}";
        }
    }
}
