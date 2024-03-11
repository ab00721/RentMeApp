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
        public string Address1 { get; set; }
        public string Address2 { get; set; }
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
        /// <param name="sex">The sex.</param>
        /// <param name="birthday">The birthday.</param>
        /// <param name="address">The address.</param>
        /// <exception cref="System.ArgumentException">Last Name - Last name cannot be null or empty</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">Member ID - Member ID  has to be > 0</exception>
        public MemberX(int memberID, string firstName, string lastName, string phone)
        {

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
            this.Phone = phone;
        }

        public MemberX() { }
    }
}
