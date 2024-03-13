using System;

namespace RentMeApp.Model
{
    /// <summary>
    /// Model class for in-memory Member
    /// </summary>
    public class MemberX
    {
        public int MemberID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public char Sex { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string AddressOne { get; set; }
        public string AddressTwo { get; set; }
        public string City { get; set; }
        public string State {  get; set; }
        public int Zip { get; set; }
        public string Phone { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="MemberX"/> class.
        /// </summary>
        /// <param name="memberID">The member identifier.</param>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="phone">The phone.</param>
        /// <exception cref="System.ArgumentException">Last Name - Last name cannot be null or empty</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">Member ID - Member ID  has to be > 0</exception>
        public MemberX(int memberID, string firstName, string lastName, char sex, DateOnly DateOfBirth, string addressOne, string addressTwo, string city, string state, int zip, string phone)
        {
            this.MemberID = memberID;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Sex = sex;
            this.DateOfBirth = DateOfBirth;
            this.AddressOne = addressOne;
            this.AddressTwo = addressTwo;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.Phone = phone;
        }


        public MemberX() { }
    }
}
