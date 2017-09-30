using System.Collections.Generic;

namespace MD1
{
    public class DataStoreCollections
    {
        public List<Person> People { get; set; }
        public List<Lecture> Lectures { get; set; }

        public DataStoreCollections() { }
        
        public DataStoreCollections(List<Person> people, List<Lecture> lectures)
        {
            People = people;
            Lectures = lectures;
        }
    }
}