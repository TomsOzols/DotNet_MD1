using System;

namespace DotNet_md1 {

    public class Teacher : Persona
    {
        public DateTime ContractDate { get; set; }

        public override string Print()
        {
            string personaInfo = base.Print();
            return $"{personaInfo}\nContract date: {ContractDate}";

        }
    }
}