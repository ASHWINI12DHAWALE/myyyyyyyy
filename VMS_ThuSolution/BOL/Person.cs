using System;
namespace BOL
{
    public class Person
    {
        #region member variables

        protected string firstName;
        protected string lastName;
        protected  DateTime birthDate;

        #endregion

        #region Properties
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }


        public DateTime BirthDate
        {
            set { birthDate =value; }
            get { return birthDate; }
        }
        #endregion

        #region constructors
        public Person() { }
        public Person(string fName, string lName)
        {
            firstName = fName;
            lastName = lName;
        }

        public Person(string fName, string lName,DateTime bdate)
        {
            firstName = fName;
            lastName = lName;
            this.birthDate = bdate;
        }

        #endregion

        #region overridable functions
        public override string ToString()
        {
            return firstName + " " + lastName;
        }

        #endregion
        ~Person()
        {

        }
    }
}
