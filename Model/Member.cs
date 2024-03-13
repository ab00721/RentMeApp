using System;

namespace RentMeApp.Model
{
    /// <summary>
    /// Member DTO class
    /// </summary>
    public class Member
    {
        public int MemberID { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string Sex { get; }
        public DateTime DateOfBirth { get; }
        public string AddressOne { get; }
        public string AddressTwo { get; }
        public string City { get; }
        public string State { get; }
        public string Zip { get; }

        public string Phone { get; }


        /// <summary>
        /// Initializes a new instance of the <see cref="Member"/> class.
        /// </summary>
        /// <param name="memberID">The member identifier.</param>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="phone">The phone.</param>
        /// <exception cref="System.ArgumentException">
        /// First Name - First name cannot be null or empty
        /// or
        /// Last Name - Last name cannot be null or empty
        /// </exception>
        /// <exception cref="System.ArgumentOutOfRangeException">Member ID - Member ID  has to be > 0</exception>
        public Member(int memberID, string firstName, string lastName, string sex, DateTime dateOfBirth, string addressOne, string addressTwo, string city, string state, string zip, string phone)
        {
            if (string.IsNullOrEmpty(firstName))
            {
                throw new ArgumentException("First Name", "First name cannot be null or empty");
            }

            if (string.IsNullOrEmpty(lastName))
            {
                throw new ArgumentException("Last Name", "Last name cannot be null or empty");
            }

            if (memberID <= 0)
            {
                throw new ArgumentOutOfRangeException("Member ID", "Member ID  has to be > 0");
            }

            this.MemberID = memberID;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Sex = sex;
            this.DateOfBirth = dateOfBirth;
            this.AddressOne = addressOne;
            this.AddressTwo = addressTwo;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.Phone = phone;
        }
    }
}
