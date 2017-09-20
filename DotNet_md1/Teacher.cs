using System;

namespace DotNet_md1 {
    public class Teacher : Person
    {
        public DateTime ContractDate { get; set; }

        public override string Print()
        {
            string personaInfo = base.Print();
            string readableContractDate = ContractDate.ToString();
            return $"{personaInfo}\nContract date: {readableContractDate}";
        }
    }
}