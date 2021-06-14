using System;

namespace Session_24
{
    public class Person
    {
        private int _yearOfBirth;

        public string Name { get; set; }


        public Person()
        {

        }

        public Person(int YearOfBirth)
        {
            this._yearOfBirth = YearOfBirth;
        }

        public string GetName()
        {
            return this.Name;
        }

        private int GetAge()
        {
            return DateTime.Now.Year - this._yearOfBirth;
        }

        public void SetName(string value)
        {
            this.Name = value;
        }

    }
}
