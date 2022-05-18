using poco_classes;
using System;
using System.Collections.Generic;

namespace data_helper
{
    public static class PersonData
    {
        public static List<Person> GetPersonList()
        {
            var personList = new List<Person>()
            {
                new Person(){Name="Jack Raymond", Age = 41, Address = new Address() {Zip = 43220, City = "Columbus"}},
                new Person(){Name="Mary Kino", Age = 22, Address = new Address() {Zip = 43240, City = "Columbus"}},
                new Person(){Name="Bill Bond", Age = 58, Address = new Address() {Zip = 40835, City = "Columbus"}},
                new Person(){Name="Henry Rademacher", Age = 66, Address = new Address() {Zip = 80014, City = "Denver"}},
                new Person(){Name="Skylar Forrest", Age = 78, Address = new Address() {Zip = 80123, City = "Denver"}},
                new Person(){Name="Jack Shultz", Age = 54, Address = new Address() {Zip = 80211, City = "Denver"}},
                new Person(){Name="Mary Raymond", Age = 32, Address = new Address() {Zip = 80209, City = "Denver"}},
                new Person(){Name="Mary Martinez", Age = 44, Address = new Address() {Zip = 43313, City = "Atlanta"}},
                new Person(){Name="Paul Rademacher", Age = 61, Address = new Address() {Zip = 30316, City = "Atlanta"}},
                new Person(){Name="Mike Shultz", Age = 25, Address = new Address() {Zip = 75051, City = "Dallas"}},
                new Person(){Name="Dona Bond", Age = 58, Address = new Address() {Zip = 02112, City = "Boston"}},
            };

            

            return personList;
        }
    }
}
